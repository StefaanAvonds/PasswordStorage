namespace PasswordStorage
{
    partial class Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.groupItem = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtExtra = new System.Windows.Forms.TextBox();
            this.lblExtra = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.lblURL = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupList = new System.Windows.Forms.GroupBox();
            this.lstPasswords = new System.Windows.Forms.ListBox();
            this.btnCopyUrl = new System.Windows.Forms.Button();
            this.btnCopyPassword = new System.Windows.Forms.Button();
            this.btnCopyUsername = new System.Windows.Forms.Button();
            this.groupItem.SuspendLayout();
            this.groupList.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupItem
            // 
            this.groupItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupItem.Controls.Add(this.btnCopyUrl);
            this.groupItem.Controls.Add(this.btnCopyPassword);
            this.groupItem.Controls.Add(this.btnCopyUsername);
            this.groupItem.Controls.Add(this.btnAdd);
            this.groupItem.Controls.Add(this.btnUpdate);
            this.groupItem.Controls.Add(this.btnDelete);
            this.groupItem.Controls.Add(this.txtExtra);
            this.groupItem.Controls.Add(this.lblExtra);
            this.groupItem.Controls.Add(this.txtURL);
            this.groupItem.Controls.Add(this.lblURL);
            this.groupItem.Controls.Add(this.txtPassword);
            this.groupItem.Controls.Add(this.lblPassword);
            this.groupItem.Controls.Add(this.txtUsername);
            this.groupItem.Controls.Add(this.lblUsername);
            this.groupItem.Controls.Add(this.txtTitle);
            this.groupItem.Controls.Add(this.lblTitle);
            this.groupItem.Location = new System.Drawing.Point(12, 12);
            this.groupItem.Name = "groupItem";
            this.groupItem.Size = new System.Drawing.Size(769, 298);
            this.groupItem.TabIndex = 0;
            this.groupItem.TabStop = false;
            this.groupItem.Text = "Item";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(496, 259);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 33);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(587, 259);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 33);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(678, 259);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 33);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtExtra
            // 
            this.txtExtra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExtra.Location = new System.Drawing.Point(130, 133);
            this.txtExtra.Multiline = true;
            this.txtExtra.Name = "txtExtra";
            this.txtExtra.Size = new System.Drawing.Size(633, 120);
            this.txtExtra.TabIndex = 7;
            // 
            // lblExtra
            // 
            this.lblExtra.AutoSize = true;
            this.lblExtra.Location = new System.Drawing.Point(6, 136);
            this.lblExtra.Name = "lblExtra";
            this.lblExtra.Size = new System.Drawing.Size(44, 17);
            this.lblExtra.TabIndex = 15;
            this.lblExtra.Text = "Extra:";
            // 
            // txtURL
            // 
            this.txtURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtURL.Location = new System.Drawing.Point(130, 105);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(600, 22);
            this.txtURL.TabIndex = 5;
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(6, 108);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(40, 17);
            this.lblURL.TabIndex = 14;
            this.lblURL.Text = "URL:";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(130, 77);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(600, 22);
            this.txtPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(6, 80);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 17);
            this.lblPassword.TabIndex = 13;
            this.lblPassword.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Location = new System.Drawing.Point(130, 49);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(600, 22);
            this.txtUsername.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(6, 52);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(77, 17);
            this.lblUsername.TabIndex = 12;
            this.lblUsername.Text = "Username:";
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.Location = new System.Drawing.Point(130, 21);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(633, 22);
            this.txtTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(6, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(39, 17);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Title:";
            // 
            // groupList
            // 
            this.groupList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupList.Controls.Add(this.lstPasswords);
            this.groupList.Location = new System.Drawing.Point(12, 316);
            this.groupList.Name = "groupList";
            this.groupList.Size = new System.Drawing.Size(769, 280);
            this.groupList.TabIndex = 1;
            this.groupList.TabStop = false;
            this.groupList.Text = "Passwords";
            // 
            // lstPasswords
            // 
            this.lstPasswords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPasswords.FormattingEnabled = true;
            this.lstPasswords.ItemHeight = 16;
            this.lstPasswords.Location = new System.Drawing.Point(3, 18);
            this.lstPasswords.Name = "lstPasswords";
            this.lstPasswords.Size = new System.Drawing.Size(763, 259);
            this.lstPasswords.TabIndex = 0;
            this.lstPasswords.SelectedIndexChanged += new System.EventHandler(this.lstPasswords_SelectedIndexChanged);
            // 
            // btnCopyUrl
            // 
            this.btnCopyUrl.Image = global::PasswordStorage.Properties.Resources.copy;
            this.btnCopyUrl.Location = new System.Drawing.Point(736, 105);
            this.btnCopyUrl.Name = "btnCopyUrl";
            this.btnCopyUrl.Size = new System.Drawing.Size(27, 22);
            this.btnCopyUrl.TabIndex = 6;
            this.btnCopyUrl.UseVisualStyleBackColor = true;
            this.btnCopyUrl.Click += new System.EventHandler(this.btnCopyUrl_Click);
            // 
            // btnCopyPassword
            // 
            this.btnCopyPassword.Image = global::PasswordStorage.Properties.Resources.copy;
            this.btnCopyPassword.Location = new System.Drawing.Point(736, 77);
            this.btnCopyPassword.Name = "btnCopyPassword";
            this.btnCopyPassword.Size = new System.Drawing.Size(27, 22);
            this.btnCopyPassword.TabIndex = 4;
            this.btnCopyPassword.UseVisualStyleBackColor = true;
            this.btnCopyPassword.Click += new System.EventHandler(this.btnCopyPassword_Click);
            // 
            // btnCopyUsername
            // 
            this.btnCopyUsername.Image = global::PasswordStorage.Properties.Resources.copy;
            this.btnCopyUsername.Location = new System.Drawing.Point(736, 49);
            this.btnCopyUsername.Name = "btnCopyUsername";
            this.btnCopyUsername.Size = new System.Drawing.Size(27, 22);
            this.btnCopyUsername.TabIndex = 2;
            this.btnCopyUsername.UseVisualStyleBackColor = true;
            this.btnCopyUsername.Click += new System.EventHandler(this.btnCopyUsername_Click);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 608);
            this.Controls.Add(this.groupList);
            this.Controls.Add(this.groupItem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(811, 655);
            this.MinimumSize = new System.Drawing.Size(811, 655);
            this.Name = "Homepage";
            this.Text = "Passwords";
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.groupItem.ResumeLayout(false);
            this.groupItem.PerformLayout();
            this.groupList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupItem;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtExtra;
        private System.Windows.Forms.Label lblExtra;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupList;
        private System.Windows.Forms.ListBox lstPasswords;
        private System.Windows.Forms.Button btnCopyUsername;
        private System.Windows.Forms.Button btnCopyUrl;
        private System.Windows.Forms.Button btnCopyPassword;
    }
}

