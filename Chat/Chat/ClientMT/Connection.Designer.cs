namespace ClientMT
{
    partial class Connection
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCurrentServerInSettings = new System.Windows.Forms.Label();
            this.btnConnectDisconnect = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(13, 13);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(169, 13);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "You are not connected to a server";
            // 
            // lblCurrentServerInSettings
            // 
            this.lblCurrentServerInSettings.AutoSize = true;
            this.lblCurrentServerInSettings.Location = new System.Drawing.Point(16, 67);
            this.lblCurrentServerInSettings.Name = "lblCurrentServerInSettings";
            this.lblCurrentServerInSettings.Size = new System.Drawing.Size(137, 13);
            this.lblCurrentServerInSettings.TabIndex = 1;
            this.lblCurrentServerInSettings.Text = "The server in the setting is :";
            // 
            // btnConnectDisconnect
            // 
            this.btnConnectDisconnect.Location = new System.Drawing.Point(131, 130);
            this.btnConnectDisconnect.Name = "btnConnectDisconnect";
            this.btnConnectDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnectDisconnect.TabIndex = 2;
            this.btnConnectDisconnect.Text = "Connect";
            this.btnConnectDisconnect.UseVisualStyleBackColor = true;
            this.btnConnectDisconnect.Click += new System.EventHandler(this.btnConnectDisconnect_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(13, 114);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(193, 13);
            this.lblQuestion.TabIndex = 3;
            this.lblQuestion.Text = "Do you want to connect to this server ?";
            // 
            // Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 325);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnConnectDisconnect);
            this.Controls.Add(this.lblCurrentServerInSettings);
            this.Controls.Add(this.lblStatus);
            this.Name = "Connection";
            this.Text = "Connection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCurrentServerInSettings;
        private System.Windows.Forms.Button btnConnectDisconnect;
        private System.Windows.Forms.Label lblQuestion;
    }
}