
namespace TcpServerClientApp
{
    partial class ClientForm
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
            this.lblClientStatus = new System.Windows.Forms.Label();
            this.btnSendClientMessage = new System.Windows.Forms.Button();
            this.btnDisconnectClient = new System.Windows.Forms.Button();
            this.btnConnectClient = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClientStatus
            // 
            this.lblClientStatus.AutoSize = true;
            this.lblClientStatus.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClientStatus.Location = new System.Drawing.Point(225, 120);
            this.lblClientStatus.Name = "lblClientStatus";
            this.lblClientStatus.Size = new System.Drawing.Size(0, 29);
            this.lblClientStatus.TabIndex = 7;
            // 
            // btnSendClientMessage
            // 
            this.btnSendClientMessage.Location = new System.Drawing.Point(125, 244);
            this.btnSendClientMessage.Name = "btnSendClientMessage";
            this.btnSendClientMessage.Size = new System.Drawing.Size(140, 35);
            this.btnSendClientMessage.TabIndex = 5;
            this.btnSendClientMessage.Text = "Mesaj Gönder";
            this.btnSendClientMessage.UseVisualStyleBackColor = true;
            this.btnSendClientMessage.Click += new System.EventHandler(this.btnSendClientMessage_Click);
            // 
            // btnDisconnectClient
            // 
            this.btnDisconnectClient.Location = new System.Drawing.Point(535, 244);
            this.btnDisconnectClient.Name = "btnDisconnectClient";
            this.btnDisconnectClient.Size = new System.Drawing.Size(140, 35);
            this.btnDisconnectClient.TabIndex = 6;
            this.btnDisconnectClient.Text = "Bağlantıyı Kes";
            this.btnDisconnectClient.UseVisualStyleBackColor = true;
            this.btnDisconnectClient.Click += new System.EventHandler(this.btnDisconnectClient_Click);
            // 
            // btnConnectClient
            // 
            this.btnConnectClient.Location = new System.Drawing.Point(332, 244);
            this.btnConnectClient.Name = "btnConnectClient";
            this.btnConnectClient.Size = new System.Drawing.Size(140, 35);
            this.btnConnectClient.TabIndex = 4;
            this.btnConnectClient.Text = "Bağlan";
            this.btnConnectClient.UseVisualStyleBackColor = true;
            this.btnConnectClient.Click += new System.EventHandler(this.btnConnectClient_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-49, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 67);
            this.panel1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(365, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "CLIENT";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 8;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(778, 444);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblClientStatus);
            this.Controls.Add(this.btnSendClientMessage);
            this.Controls.Add(this.btnDisconnectClient);
            this.Controls.Add(this.btnConnectClient);
            this.Location = new System.Drawing.Point(200, 200);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ClientForm";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClientStatus;
        private System.Windows.Forms.Button btnSendClientMessage;
        private System.Windows.Forms.Button btnDisconnectClient;
        private System.Windows.Forms.Button btnConnectClient;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}