namespace AsyncSocketServer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAcceptIncomingsync = new System.Windows.Forms.Button();
            this.btnSendAll = new System.Windows.Forms.Button();
            this.btnStopServer = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textSendMessage = new System.Windows.Forms.TextBox();
            this.txtClientInfo = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAcceptIncomingsync
            // 
            this.btnAcceptIncomingsync.Location = new System.Drawing.Point(74, 43);
            this.btnAcceptIncomingsync.Name = "btnAcceptIncomingsync";
            this.btnAcceptIncomingsync.Size = new System.Drawing.Size(205, 56);
            this.btnAcceptIncomingsync.TabIndex = 0;
            this.btnAcceptIncomingsync.Text = "Aceept Incoming connection";
            this.btnAcceptIncomingsync.UseVisualStyleBackColor = true;
            this.btnAcceptIncomingsync.Click += new System.EventHandler(this.btnAcceptIncomingsync_Click);
            // 
            // btnSendAll
            // 
            this.btnSendAll.Location = new System.Drawing.Point(630, 155);
            this.btnSendAll.Name = "btnSendAll";
            this.btnSendAll.Size = new System.Drawing.Size(75, 23);
            this.btnSendAll.TabIndex = 2;
            this.btnSendAll.Text = "Send All";
            this.btnSendAll.UseVisualStyleBackColor = true;
            this.btnSendAll.Click += new System.EventHandler(this.btnSendAll_Click);
            // 
            // btnStopServer
            // 
            this.btnStopServer.Location = new System.Drawing.Point(500, 43);
            this.btnStopServer.Name = "btnStopServer";
            this.btnStopServer.Size = new System.Drawing.Size(205, 56);
            this.btnStopServer.TabIndex = 3;
            this.btnStopServer.Text = "Stop Server";
            this.btnStopServer.UseVisualStyleBackColor = true;
            this.btnStopServer.Click += new System.EventHandler(this.btnStopServer_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.AcceptsReturn = true;
            this.txtMessage.Location = new System.Drawing.Point(185, 155);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(389, 20);
            this.txtMessage.TabIndex = 4;
            this.txtMessage.Text = "broadcast messages to all client";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(141, 129);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(85, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Text";
            // 
            // textSendMessage
            // 
            this.textSendMessage.AcceptsReturn = true;
            this.textSendMessage.Location = new System.Drawing.Point(185, 217);
            this.textSendMessage.Multiline = true;
            this.textSendMessage.Name = "textSendMessage";
            this.textSendMessage.Size = new System.Drawing.Size(389, 87);
            this.textSendMessage.TabIndex = 6;
            // 
            // txtClientInfo
            // 
            this.txtClientInfo.AcceptsReturn = true;
            this.txtClientInfo.Location = new System.Drawing.Point(185, 352);
            this.txtClientInfo.Multiline = true;
            this.txtClientInfo.Name = "txtClientInfo";
            this.txtClientInfo.Size = new System.Drawing.Size(389, 86);
            this.txtClientInfo.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(141, 326);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(85, 20);
            this.textBox4.TabIndex = 8;
            this.textBox4.Text = "Text";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(141, 191);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(85, 20);
            this.textBox5.TabIndex = 9;
            this.textBox5.Text = "Text";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtClientInfo);
            this.Controls.Add(this.textSendMessage);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnStopServer);
            this.Controls.Add(this.btnSendAll);
            this.Controls.Add(this.btnAcceptIncomingsync);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAcceptIncomingsync;
        private System.Windows.Forms.Button btnSendAll;
        private System.Windows.Forms.Button btnStopServer;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textSendMessage;
        private System.Windows.Forms.TextBox txtClientInfo;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
    }
}

