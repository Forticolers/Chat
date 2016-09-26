namespace ClientMT
{
    partial class Settings
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
            this.tabSettings = new System.Windows.Forms.TabControl();
            this.tabUsersSettings = new System.Windows.Forms.TabPage();
            this.cbxBroadcastMessage = new System.Windows.Forms.CheckBox();
            this.cbxPrivateMessage = new System.Windows.Forms.CheckBox();
            this.lblCurrentIP = new System.Windows.Forms.Label();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tabConnectionSettings = new System.Windows.Forms.TabPage();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.lblServerIpPort = new System.Windows.Forms.Label();
            this.tbxServerIP = new System.Windows.Forms.TextBox();
            this.tbxPort = new System.Windows.Forms.TextBox();
            this.btnAddServer = new System.Windows.Forms.Button();
            this.lstOfServer = new System.Windows.Forms.ListBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tabSettings.SuspendLayout();
            this.tabUsersSettings.SuspendLayout();
            this.tabConnectionSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.tabUsersSettings);
            this.tabSettings.Controls.Add(this.tabConnectionSettings);
            this.tabSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabSettings.Location = new System.Drawing.Point(0, 0);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.SelectedIndex = 0;
            this.tabSettings.Size = new System.Drawing.Size(344, 327);
            this.tabSettings.TabIndex = 0;
            // 
            // tabUsersSettings
            // 
            this.tabUsersSettings.Controls.Add(this.cbxBroadcastMessage);
            this.tabUsersSettings.Controls.Add(this.cbxPrivateMessage);
            this.tabUsersSettings.Controls.Add(this.lblCurrentIP);
            this.tabUsersSettings.Controls.Add(this.tbxUsername);
            this.tabUsersSettings.Controls.Add(this.lblUsername);
            this.tabUsersSettings.Location = new System.Drawing.Point(4, 22);
            this.tabUsersSettings.Name = "tabUsersSettings";
            this.tabUsersSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsersSettings.Size = new System.Drawing.Size(336, 301);
            this.tabUsersSettings.TabIndex = 0;
            this.tabUsersSettings.Text = "Users Settings";
            this.tabUsersSettings.UseVisualStyleBackColor = true;
            // 
            // cbxBroadcastMessage
            // 
            this.cbxBroadcastMessage.AutoSize = true;
            this.cbxBroadcastMessage.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxBroadcastMessage.Checked = true;
            this.cbxBroadcastMessage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxBroadcastMessage.Location = new System.Drawing.Point(12, 71);
            this.cbxBroadcastMessage.Name = "cbxBroadcastMessage";
            this.cbxBroadcastMessage.Size = new System.Drawing.Size(170, 17);
            this.cbxBroadcastMessage.TabIndex = 8;
            this.cbxBroadcastMessage.Text = "Receive broadcast message ?";
            this.cbxBroadcastMessage.UseVisualStyleBackColor = true;
            // 
            // cbxPrivateMessage
            // 
            this.cbxPrivateMessage.AutoSize = true;
            this.cbxPrivateMessage.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxPrivateMessage.Checked = true;
            this.cbxPrivateMessage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxPrivateMessage.Location = new System.Drawing.Point(12, 48);
            this.cbxPrivateMessage.Name = "cbxPrivateMessage";
            this.cbxPrivateMessage.Size = new System.Drawing.Size(155, 17);
            this.cbxPrivateMessage.TabIndex = 7;
            this.cbxPrivateMessage.Text = "Receive private message ?";
            this.cbxPrivateMessage.UseVisualStyleBackColor = true;
            // 
            // lblCurrentIP
            // 
            this.lblCurrentIP.AutoSize = true;
            this.lblCurrentIP.Location = new System.Drawing.Point(12, 234);
            this.lblCurrentIP.Name = "lblCurrentIP";
            this.lblCurrentIP.Size = new System.Drawing.Size(135, 13);
            this.lblCurrentIP.TabIndex = 2;
            this.lblCurrentIP.Text = "Your current IP Adresse is :";
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(83, 22);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(110, 20);
            this.tbxUsername.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(12, 26);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(61, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username :";
            // 
            // tabConnectionSettings
            // 
            this.tabConnectionSettings.Controls.Add(this.btnDelete);
            this.tabConnectionSettings.Controls.Add(this.btnModify);
            this.tabConnectionSettings.Controls.Add(this.btnSelect);
            this.tabConnectionSettings.Controls.Add(this.lstOfServer);
            this.tabConnectionSettings.Controls.Add(this.btnAddServer);
            this.tabConnectionSettings.Controls.Add(this.tbxPort);
            this.tabConnectionSettings.Controls.Add(this.tbxServerIP);
            this.tabConnectionSettings.Controls.Add(this.lblServerIpPort);
            this.tabConnectionSettings.Location = new System.Drawing.Point(4, 22);
            this.tabConnectionSettings.Name = "tabConnectionSettings";
            this.tabConnectionSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabConnectionSettings.Size = new System.Drawing.Size(336, 301);
            this.tabConnectionSettings.TabIndex = 1;
            this.tabConnectionSettings.Text = "Connection Settings";
            this.tabConnectionSettings.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(113, 333);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(265, 333);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(189, 333);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 5;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // lblServerIpPort
            // 
            this.lblServerIpPort.AutoSize = true;
            this.lblServerIpPort.Location = new System.Drawing.Point(8, 25);
            this.lblServerIpPort.Name = "lblServerIpPort";
            this.lblServerIpPort.Size = new System.Drawing.Size(88, 13);
            this.lblServerIpPort.TabIndex = 0;
            this.lblServerIpPort.Text = "Server IP + Port :";
            // 
            // tbxServerIP
            // 
            this.tbxServerIP.Location = new System.Drawing.Point(103, 21);
            this.tbxServerIP.Name = "tbxServerIP";
            this.tbxServerIP.Size = new System.Drawing.Size(100, 20);
            this.tbxServerIP.TabIndex = 1;
            // 
            // tbxPort
            // 
            this.tbxPort.Location = new System.Drawing.Point(209, 21);
            this.tbxPort.Name = "tbxPort";
            this.tbxPort.Size = new System.Drawing.Size(35, 20);
            this.tbxPort.TabIndex = 2;
            // 
            // btnAddServer
            // 
            this.btnAddServer.Enabled = false;
            this.btnAddServer.Location = new System.Drawing.Point(250, 20);
            this.btnAddServer.Name = "btnAddServer";
            this.btnAddServer.Size = new System.Drawing.Size(75, 23);
            this.btnAddServer.TabIndex = 3;
            this.btnAddServer.Text = "New server";
            this.btnAddServer.UseVisualStyleBackColor = true;
            this.btnAddServer.Visible = false;
            // 
            // lstOfServer
            // 
            this.lstOfServer.Enabled = false;
            this.lstOfServer.FormattingEnabled = true;
            this.lstOfServer.Location = new System.Drawing.Point(11, 69);
            this.lstOfServer.Name = "lstOfServer";
            this.lstOfServer.Size = new System.Drawing.Size(233, 186);
            this.lstOfServer.TabIndex = 4;
            this.lstOfServer.Visible = false;
            // 
            // btnSelect
            // 
            this.btnSelect.Enabled = false;
            this.btnSelect.Location = new System.Drawing.Point(251, 231);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 5;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Visible = false;
            // 
            // btnModify
            // 
            this.btnModify.Enabled = false;
            this.btnModify.Location = new System.Drawing.Point(250, 202);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 6;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(250, 173);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 368);
            this.Controls.Add(this.tabSettings);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Name = "Settings";
            this.Text = "Settings";
            this.tabSettings.ResumeLayout(false);
            this.tabUsersSettings.ResumeLayout(false);
            this.tabUsersSettings.PerformLayout();
            this.tabConnectionSettings.ResumeLayout(false);
            this.tabConnectionSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabSettings;
        private System.Windows.Forms.TabPage tabUsersSettings;
        private System.Windows.Forms.TabPage tabConnectionSettings;
        private System.Windows.Forms.Label lblCurrentIP;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.CheckBox cbxBroadcastMessage;
        private System.Windows.Forms.CheckBox cbxPrivateMessage;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ListBox lstOfServer;
        private System.Windows.Forms.Button btnAddServer;
        private System.Windows.Forms.TextBox tbxPort;
        private System.Windows.Forms.TextBox tbxServerIP;
        private System.Windows.Forms.Label lblServerIpPort;
    }
}