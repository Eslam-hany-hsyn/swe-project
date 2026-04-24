namespace Registration_Form
{
    partial class ChangePasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.lbl_CurrentPassword = new System.Windows.Forms.Label();
            this.txt_CurrentPassword = new System.Windows.Forms.TextBox();
            this.lbl_NewPassword = new System.Windows.Forms.Label();
            this.txt_NewPassword = new System.Windows.Forms.TextBox();
            this.lbl_ConfirmNewPassword = new System.Windows.Forms.Label();
            this.txt_ConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.header = new System.Windows.Forms.Label();
            this.footer = new System.Windows.Forms.TableLayoutPanel();
            this.btn_ChangePassword = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.mainPanel.Controls.Add(this.lbl_CurrentPassword);
            this.mainPanel.Controls.Add(this.txt_CurrentPassword);
            this.mainPanel.Controls.Add(this.lbl_NewPassword);
            this.mainPanel.Controls.Add(this.txt_NewPassword);
            this.mainPanel.Controls.Add(this.lbl_ConfirmNewPassword);
            this.mainPanel.Controls.Add(this.txt_ConfirmNewPassword);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 51);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(622, 360);
            this.mainPanel.TabIndex = 7;
            // 
            // lbl_CurrentPassword
            // 
            this.lbl_CurrentPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CurrentPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_CurrentPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurrentPassword.ForeColor = System.Drawing.Color.Black;
            this.lbl_CurrentPassword.Location = new System.Drawing.Point(130, 20);
            this.lbl_CurrentPassword.Name = "lbl_CurrentPassword";
            this.lbl_CurrentPassword.Size = new System.Drawing.Size(210, 30);
            this.lbl_CurrentPassword.TabIndex = 1;
            this.lbl_CurrentPassword.Text = "Current Password";
            this.lbl_CurrentPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_CurrentPassword
            // 
            this.txt_CurrentPassword.AccessibleDescription = "Current Password";
            this.txt_CurrentPassword.BackColor = System.Drawing.Color.White;
            this.txt_CurrentPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CurrentPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CurrentPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.txt_CurrentPassword.Location = new System.Drawing.Point(130, 55);
            this.txt_CurrentPassword.Name = "txt_CurrentPassword";
            this.txt_CurrentPassword.Size = new System.Drawing.Size(340, 25);
            this.txt_CurrentPassword.TabIndex = 2;
            this.txt_CurrentPassword.Tag = "[\\s]+$";
            this.txt_CurrentPassword.Text = "Current Password";
            this.txt_CurrentPassword.TextChanged += new System.EventHandler(this.txt_CheckingFormat);
            this.txt_CurrentPassword.Enter += new System.EventHandler(this.txt_PlaceHolder_Enter);
            this.txt_CurrentPassword.Leave += new System.EventHandler(this.txt_PlaceHolder_Leave);
            // 
            // lbl_NewPassword
            // 
            this.lbl_NewPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_NewPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NewPassword.ForeColor = System.Drawing.Color.Black;
            this.lbl_NewPassword.Location = new System.Drawing.Point(130, 110);
            this.lbl_NewPassword.Name = "lbl_NewPassword";
            this.lbl_NewPassword.Size = new System.Drawing.Size(210, 30);
            this.lbl_NewPassword.TabIndex = 3;
            this.lbl_NewPassword.Text = "New Password";
            this.lbl_NewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_NewPassword
            // 
            this.txt_NewPassword.AccessibleDescription = "New Password";
            this.txt_NewPassword.BackColor = System.Drawing.Color.White;
            this.txt_NewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NewPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.txt_NewPassword.Location = new System.Drawing.Point(130, 145);
            this.txt_NewPassword.Name = "txt_NewPassword";
            this.txt_NewPassword.Size = new System.Drawing.Size(340, 25);
            this.txt_NewPassword.TabIndex = 4;
            this.txt_NewPassword.Tag = "[\\s]+$";
            this.txt_NewPassword.Text = "New Password";
            this.txt_NewPassword.TextChanged += new System.EventHandler(this.txt_CheckingFormat);
            this.txt_NewPassword.Enter += new System.EventHandler(this.txt_PlaceHolder_Enter);
            this.txt_NewPassword.Leave += new System.EventHandler(this.txt_PlaceHolder_Leave);
            // 
            // lbl_ConfirmNewPassword
            // 
            this.lbl_ConfirmNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ConfirmNewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_ConfirmNewPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ConfirmNewPassword.ForeColor = System.Drawing.Color.Black;
            this.lbl_ConfirmNewPassword.Location = new System.Drawing.Point(130, 200);
            this.lbl_ConfirmNewPassword.Name = "lbl_ConfirmNewPassword";
            this.lbl_ConfirmNewPassword.Size = new System.Drawing.Size(250, 30);
            this.lbl_ConfirmNewPassword.TabIndex = 5;
            this.lbl_ConfirmNewPassword.Text = "Confirm New Password";
            this.lbl_ConfirmNewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_ConfirmNewPassword
            // 
            this.txt_ConfirmNewPassword.AccessibleDescription = "Confirm New Password";
            this.txt_ConfirmNewPassword.BackColor = System.Drawing.Color.White;
            this.txt_ConfirmNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ConfirmNewPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ConfirmNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.txt_ConfirmNewPassword.Location = new System.Drawing.Point(130, 235);
            this.txt_ConfirmNewPassword.Name = "txt_ConfirmNewPassword";
            this.txt_ConfirmNewPassword.Size = new System.Drawing.Size(340, 25);
            this.txt_ConfirmNewPassword.TabIndex = 6;
            this.txt_ConfirmNewPassword.Tag = "[\\s]+$";
            this.txt_ConfirmNewPassword.Text = "Confirm New Password";
            this.txt_ConfirmNewPassword.TextChanged += new System.EventHandler(this.txt_CheckingFormat);
            this.txt_ConfirmNewPassword.Enter += new System.EventHandler(this.txt_PlaceHolder_Enter);
            this.txt_ConfirmNewPassword.Leave += new System.EventHandler(this.txt_PlaceHolder_Leave);
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.header.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.header.ForeColor = System.Drawing.Color.Black;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(622, 51);
            this.header.TabIndex = 0;
            this.header.Text = "Change Password";
            this.header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // footer
            // 
            this.footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.footer.ColumnCount = 3;
            this.footer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.footer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.footer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.footer.Controls.Add(this.btn_ChangePassword, 1, 0);
            this.footer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.footer.Location = new System.Drawing.Point(0, 411);
            this.footer.Margin = new System.Windows.Forms.Padding(0);
            this.footer.Name = "footer";
            this.footer.RowCount = 1;
            this.footer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.footer.Size = new System.Drawing.Size(622, 51);
            this.footer.TabIndex = 9;
            // 
            // btn_ChangePassword
            // 
            this.btn_ChangePassword.BackColor = System.Drawing.Color.MediumBlue;
            this.btn_ChangePassword.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_ChangePassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ChangePassword.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_ChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChangePassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_ChangePassword.ForeColor = System.Drawing.Color.White;
            this.btn_ChangePassword.Location = new System.Drawing.Point(208, 3);
            this.btn_ChangePassword.Name = "btn_ChangePassword";
            this.btn_ChangePassword.Size = new System.Drawing.Size(205, 45);
            this.btn_ChangePassword.TabIndex = 8;
            this.btn_ChangePassword.Text = "Change Password";
            this.btn_ChangePassword.UseVisualStyleBackColor = false;
            this.btn_ChangePassword.Click += new System.EventHandler(this.btn_ChangePassword_Click);
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Registration_Form.Properties.Resources.background1;
            this.CancelButton = this.btn_ChangePassword;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "ChangePasswordForm";
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.ChangePasswordForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.footer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.TableLayoutPanel footer;
        private System.Windows.Forms.Label lbl_CurrentPassword;
        private System.Windows.Forms.TextBox txt_CurrentPassword;
        private System.Windows.Forms.Label lbl_NewPassword;
        private System.Windows.Forms.TextBox txt_NewPassword;
        private System.Windows.Forms.Label lbl_ConfirmNewPassword;
        private System.Windows.Forms.TextBox txt_ConfirmNewPassword;
        private System.Windows.Forms.Button btn_ChangePassword;
    }
}
