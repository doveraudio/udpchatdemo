namespace UDPChat
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblRemoteHost = new System.Windows.Forms.Label();
            this.tbxRemoteHost = new System.Windows.Forms.TextBox();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tbxMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(216, 75);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Send";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblRemoteHost
            // 
            this.lblRemoteHost.AutoSize = true;
            this.lblRemoteHost.Location = new System.Drawing.Point(11, 16);
            this.lblRemoteHost.Name = "lblRemoteHost";
            this.lblRemoteHost.Size = new System.Drawing.Size(72, 13);
            this.lblRemoteHost.TabIndex = 1;
            this.lblRemoteHost.Text = "Remote Host:";
            // 
            // tbxRemoteHost
            // 
            this.tbxRemoteHost.Location = new System.Drawing.Point(89, 13);
            this.tbxRemoteHost.Name = "tbxRemoteHost";
            this.tbxRemoteHost.Size = new System.Drawing.Size(100, 20);
            this.tbxRemoteHost.TabIndex = 2;
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(89, 39);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(100, 20);
            this.tbxUsername.TabIndex = 3;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(14, 45);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username";
            // 
            // tbxMessage
            // 
            this.tbxMessage.Location = new System.Drawing.Point(12, 104);
            this.tbxMessage.Multiline = true;
            this.tbxMessage.Name = "tbxMessage";
            this.tbxMessage.Size = new System.Drawing.Size(279, 155);
            this.tbxMessage.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Message";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 271);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxMessage);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.tbxRemoteHost);
            this.Controls.Add(this.lblRemoteHost);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblRemoteHost;
        private System.Windows.Forms.TextBox tbxRemoteHost;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox tbxMessage;
        private System.Windows.Forms.Label label1;
    }
}

