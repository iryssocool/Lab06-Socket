using AsyncSocketTCP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncSocketClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AsyncSocketTCPClient client = new AsyncSocketTCPClient();
            Console.WriteLine("*** Welcome to Async Socket Client ***");
            Console.WriteLine("Enter Server IP Address: ");
            string strIPAddress = Console.ReadLine();
            Console.WriteLine("Enter Port Number (0 - 65535):");
            string strPortInput = Console.ReadLine();
            if (!client.SetServerIPAddress(strIPAddress) || !client.SetPortNumber(strPortInput))
            {
                Console.WriteLine(
                    string.Format(
                        "IP Address or port number invalid- {0} -{1} - Press a key to exit",
                        strIPAddress, strPortInput));
                Console.ReadKey();
                return;
            }
            client.ConnectToServer();
            string strInputUser = null;
            do
            {
                strInputUser = Console.ReadLine();
                if(strInputUser.Trim()!="<EXIT>")
                {
                    client.SendToServer(strInputUser);
                }
                else if(strInputUser.Equals("<EXIT>"))
                {
                    client.CloseAndDisconnect();
                }
            } while (strInputUser!="<EXIT>");
        }
    }
}
