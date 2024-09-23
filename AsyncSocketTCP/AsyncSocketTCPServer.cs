using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace AsyncSocketTCP
{

    public class AsyncSocketTCPServer
    {
        IPAddress mIP;
        int mPort;
        TcpListener mTcpListener;
        List<TcpClient> mClients;
        public bool KeepRunning { get; set; }
        public AsyncSocketTCPServer()
        {
            mClients = new List<TcpClient>();
        }
        public async void StartListeningForIncomingConnection(IPAddress ipaddr = null, int port = 9001)

        {
            if (ipaddr == null)
            {
                ipaddr = IPAddress.Any;
            }
            if (port <= 0)
            {
                port = 9001;
            }
            mIP = ipaddr;
            mPort = port;
            System.Diagnostics.Debug.WriteLine(string.Format("IP Address: {0} -Port: {1}", mIP.ToString(), mPort));
            mTcpListener = new TcpListener(mIP, mPort);
            try
            {
                mTcpListener.Start();
                KeepRunning = true;
                while (KeepRunning)
                {
                    var returnedByAccept = await mTcpListener.AcceptTcpClientAsync();
                    mClients.Add(returnedByAccept);
                    OnClientConnectedEvent(new ClientConnectedEventArgs(returnedByAccept.Client.RemoteEndPoint.ToString()));
                    Debug.WriteLine(string.Format("Client connected succesfully,count: {0} - {1}",
                        mClients.Count, returnedByAccept.Client.RemoteEndPoint));
                    TakeCareOfTCPClient(returnedByAccept);

                }
              

            }
            catch (Exception excp)
            {
                System.Diagnostics.Debug.WriteLine(excp.ToString());
            }
            



        }
        private void RemoveClient(TcpClient paramClient)
        {
            if (mClients.Contains(paramClient))
            {
                mClients.Remove(paramClient);
                Debug.WriteLine(String.Format("Client removed, count:{0}", mClients.Count));
            }



        }
        private async void TakeCareOfTCPClient(TcpClient paramClient)
        {
            NetworkStream stream = null;
            StreamReader reader = null;
            try
            {
                stream = paramClient.GetStream();
                reader = new StreamReader(stream);
                char[] buff = new char[64];
                while (KeepRunning)
                {
                    Debug.WriteLine("*** Ready to read");
                    int nRet = await reader.ReadAsync(buff, 0, buff.Length);
                    System.Diagnostics.Debug.WriteLine("Returned: " + nRet);
                    if (nRet == 0)
                    {
                        RemoveClient(paramClient);
                        System.Diagnostics.Debug.WriteLine("System disconnected");
                        break;
                    }
                    string receivedText = new string(buff);
                    System.Diagnostics.Debug.WriteLine("***RECEIVED" + receivedText);
                    Array.Clear(buff, 0, buff.Length);

                }
            }
            catch (Exception excp)
            {
                RemoveClient(paramClient);
                System.Diagnostics.Debug.WriteLine(excp.ToString());
            }
        }
        public async void SendToAll(string leMeassage)
        {
            if (string.IsNullOrEmpty(leMeassage))
            {
                return;
            }
            try
            {
                byte[] buffMessage = Encoding.ASCII.GetBytes(leMeassage);
                foreach (TcpClient c in mClients)
                {
                    await c.GetStream().WriteAsync(buffMessage, 0, buffMessage.Length);
                }
            }
            catch (Exception excp)
            {
                Debug.WriteLine(excp.ToString());
            }
        }
        public void StopServer()
        {
            try
            {
                if (mTcpListener != null)
                {
                    mTcpListener.Stop();
                }
                foreach (TcpClient c in mClients)
                {
                    c.Close();
                }
            }
            catch (Exception excp)
            {
                Debug.WriteLine(excp.ToString());
            }
        }
        public EventHandler<ClientConnectedEventArgs> ClientConnectedEvent;
        protected virtual void OnClientConnectedEvent(ClientConnectedEventArgs e)
        {
            EventHandler<ClientConnectedEventArgs> handler = ClientConnectedEvent;
            if (handler != null)
            {
                handler(this, e);
            }
        }

    }
}
