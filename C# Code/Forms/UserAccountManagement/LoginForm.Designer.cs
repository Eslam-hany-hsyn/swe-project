namespace Registration_Form
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.btn_SignIn = new System.Windows.Forms.Button();
            this.btn_ForgotPassword = new System.Windows.Forms.Button();
            this.btn_NewAccount = new System.Windows.Forms.Button();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.pnlQuickLogin = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_ErrorMessage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.pnlQuickLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Email
            // 
            this.txt_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Email.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txt_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.txt_Email.Location = new System.Drawing.Point(129, 52);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(386, 34);
            this.txt_Email.TabIndex = 11;
            this.txt_Email.Tag = "Email";
            this.txt_Email.Text = "Email";
            this.txt_Email.Enter += new System.EventHandler(this.txt_EmailOrPassword_Enter);
            this.txt_Email.Leave += new System.EventHandler(this.txt_EmailOrPassword_Leave);
            // 
            // btn_SignIn
            // 
            this.btn_SignIn.BackColor = System.Drawing.Color.MediumBlue;
            this.btn_SignIn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_SignIn.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn_SignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SignIn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_SignIn.ForeColor = System.Drawing.Color.White;
            this.btn_SignIn.Location = new System.Drawing.Point(129, 196);
            this.btn_SignIn.Name = "btn_SignIn";
            this.btn_SignIn.Size = new System.Drawing.Size(386, 38);
            this.btn_SignIn.TabIndex = 13;
            this.btn_SignIn.Text = "LOGIN";
            this.btn_SignIn.UseVisualStyleBackColor = false;
            this.btn_SignIn.Click += new System.EventHandler(this.btn_SignIn_Click);
            // 
            // btn_ForgotPassword
            // 
            this.btn_ForgotPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btn_ForgotPassword.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btn_ForgotPassword.FlatAppearance.BorderSize = 0;
            this.btn_ForgotPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ForgotPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_ForgotPassword.ForeColor = System.Drawing.Color.Black;
            this.btn_ForgotPassword.Location = new System.Drawing.Point(129, 240);
            this.btn_ForgotPassword.Name = "btn_ForgotPassword";
            this.btn_ForgotPassword.Size = new System.Drawing.Size(386, 39);
            this.btn_ForgotPassword.TabIndex = 14;
            this.btn_ForgotPassword.Text = "Forgot password?";
            this.btn_ForgotPassword.UseVisualStyleBackColor = false;
            this.btn_ForgotPassword.Click += new System.EventHandler(this.btn_ForgotPassword_Click);
            // 
            // btn_NewAccount
            // 
            this.btn_NewAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btn_NewAccount.FlatAppearance.BorderSize = 0;
            this.btn_NewAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NewAccount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_NewAccount.ForeColor = System.Drawing.Color.Black;
            this.btn_NewAccount.Location = new System.Drawing.Point(129, 311);
            this.btn_NewAccount.Name = "btn_NewAccount";
            this.btn_NewAccount.Size = new System.Drawing.Size(386, 39);
            this.btn_NewAccount.TabIndex = 15;
            this.btn_NewAccount.Text = "Don\'t have an account?";
            this.btn_NewAccount.UseVisualStyleBackColor = false;
            this.btn_NewAccount.Click += new System.EventHandler(this.btn_NewAccount_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Password.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txt_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.txt_Password.Location = new System.Drawing.Point(129, 117);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(386, 34);
            this.txt_Password.TabIndex = 12;
            this.txt_Password.Tag = "Password";
            this.txt_Password.Text = "Password";
            this.txt_Password.UseSystemPasswordChar = true;
            this.txt_Password.Enter += new System.EventHandler(this.txt_EmailOrPassword_Enter);
            this.txt_Password.Leave += new System.EventHandler(this.txt_EmailOrPassword_Leave);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.mainPanel.Controls.Add(this.pnlQuickLogin);
            this.mainPanel.Controls.Add(this.lbl_ErrorMessage);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.label6);
            this.mainPanel.Controls.Add(this.txt_Email);
            this.mainPanel.Controls.Add(this.txt_Password);
            this.mainPanel.Controls.Add(this.btn_SignIn);
            this.mainPanel.Controls.Add(this.btn_NewAccount);
            this.mainPanel.Controls.Add(this.btn_ForgotPassword);
            this.mainPanel.Controls.Add(this.header);
            this.mainPanel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.mainPanel.Location = new System.Drawing.Point(242, 102);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(598, 431);
            this.mainPanel.TabIndex = 17;
            // 
            // pnlQuickLogin
            // 
            this.pnlQuickLogin.BackColor = System.Drawing.Color.White;
            this.pnlQuickLogin.Controls.Add(this.button3);
            this.pnlQuickLogin.Controls.Add(this.button2);
            this.pnlQuickLogin.Controls.Add(this.button1);
            this.pnlQuickLogin.Controls.Add(this.label1);
            this.pnlQuickLogin.Location = new System.Drawing.Point(36, 76);
            this.pnlQuickLogin.Name = "pnlQuickLogin";
            this.pnlQuickLogin.Size = new System.Drawing.Size(704, 56);
            this.pnlQuickLogin.TabIndex = 43;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.Color.RoyalBlue;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(286, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 31);
            this.button3.TabIndex = 3;
            this.button3.Text = "Login as Organizer";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button2_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.ForestGreen;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(443, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "Login as Attendee";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(152, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Login as Admin";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quick login for Test";
            // 
            // lbl_ErrorMessage
            // 
            this.lbl_ErrorMessage.BackColor = System.Drawing.Color.White;
            this.lbl_ErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorMessage.Location = new System.Drawing.Point(130, 153);
            this.lbl_ErrorMessage.Name = "lbl_ErrorMessage";
            this.lbl_ErrorMessage.Size = new System.Drawing.Size(379, 34);
            this.lbl_ErrorMessage.TabIndex = 42;
            this.lbl_ErrorMessage.Text = "Email or password is wrong please Enter correct data.";
            this.lbl_ErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(129, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 27);
            this.label2.TabIndex = 32;
            this.label2.Text = "Email";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(129, 91);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 24);
            this.label6.TabIndex = 31;
            this.label6.Text = "Password";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.header.ForeColor = System.Drawing.Color.Black;
            this.header.Location = new System.Drawing.Point(-204, 187);
            this.header.Margin = new System.Windows.Forms.Padding(0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1006, 57);
            this.header.TabIndex = 41;
            this.header.Text = "LOGIN";
            this.header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Registration_Form.Properties.Resources.background1;
            this.CancelButton = this.btn_SignIn;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "LoginForm";
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Controls.SetChildIndex(this.mainPanel, 0);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.pnlQuickLogin.ResumeLayout(false);
            this.pnlQuickLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Button btn_SignIn;
        private System.Windows.Forms.Button btn_ForgotPassword;
        private System.Windows.Forms.Button btn_NewAccount;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label lbl_ErrorMessage;
        private System.Windows.Forms.Panel pnlQuickLogin;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

