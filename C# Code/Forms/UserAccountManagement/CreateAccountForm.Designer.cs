namespace Registration_Form
{
    partial class CreateAccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccountForm));
            this.btn_SignUp = new System.Windows.Forms.Button();
            this.header = new System.Windows.Forms.Label();
            this.footer = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_age = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbx_Role = new System.Windows.Forms.ComboBox();
            this.cmbx_Gender = new System.Windows.Forms.ComboBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.footer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_age)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.BackColor = System.Drawing.Color.MediumBlue;
            this.btn_SignUp.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_SignUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_SignUp.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_SignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SignUp.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_SignUp.ForeColor = System.Drawing.Color.White;
            this.btn_SignUp.Location = new System.Drawing.Point(196, 4);
            this.btn_SignUp.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(190, 53);
            this.btn_SignUp.TabIndex = 37;
            this.btn_SignUp.Text = "Sign Up";
            this.btn_SignUp.UseVisualStyleBackColor = false;
            this.btn_SignUp.Click += new System.EventHandler(this.btn_SignUp_Click);
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.header.ForeColor = System.Drawing.Color.Black;
            this.header.Location = new System.Drawing.Point(35, 9);
            this.header.Margin = new System.Windows.Forms.Padding(0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1006, 57);
            this.header.TabIndex = 40;
            this.header.Text = "Create Account";
            this.header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // footer
            // 
            this.footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.footer.ColumnCount = 3;
            this.footer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.footer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.footer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.footer.Controls.Add(this.btn_SignUp, 1, 0);
            this.footer.Location = new System.Drawing.Point(337, 580);
            this.footer.Margin = new System.Windows.Forms.Padding(0);
            this.footer.Name = "footer";
            this.footer.RowCount = 1;
            this.footer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.footer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.footer.Size = new System.Drawing.Size(584, 61);
            this.footer.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(410, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 21);
            this.label7.TabIndex = 32;
            this.label7.Text = "Confirm pasword";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(410, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 21);
            this.label6.TabIndex = 30;
            this.label6.Text = "Password";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_ConfirmPassword
            // 
            this.txt_ConfirmPassword.AccessibleDescription = "Confirm Password";
            this.txt_ConfirmPassword.BackColor = System.Drawing.Color.White;
            this.txt_ConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.txt_ConfirmPassword.Location = new System.Drawing.Point(410, 218);
            this.txt_ConfirmPassword.Name = "txt_ConfirmPassword";
            this.txt_ConfirmPassword.Size = new System.Drawing.Size(241, 25);
            this.txt_ConfirmPassword.TabIndex = 31;
            this.txt_ConfirmPassword.Tag = "[\\s]+$";
            this.txt_ConfirmPassword.Text = "Confirm Password";
            this.txt_ConfirmPassword.TextChanged += new System.EventHandler(this.txt_CheckingFormat);
            this.txt_ConfirmPassword.Enter += new System.EventHandler(this.txt_PlaceHolder_Enter);
            this.txt_ConfirmPassword.Leave += new System.EventHandler(this.txt_PlaceHolder_Leave);
            // 
            // txt_Name
            // 
            this.txt_Name.AccessibleDescription = "Full Name";
            this.txt_Name.BackColor = System.Drawing.Color.White;
            this.txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Name.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.txt_Name.Location = new System.Drawing.Point(30, 52);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(241, 25);
            this.txt_Name.TabIndex = 41;
            this.txt_Name.Text = "Full Name";
            this.txt_Name.Enter += new System.EventHandler(this.txt_PlaceHolder_Enter);
            this.txt_Name.Leave += new System.EventHandler(this.txt_PlaceHolder_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(410, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 21);
            this.label5.TabIndex = 28;
            this.label5.Text = "Email";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Phone
            // 
            this.txt_Phone.AccessibleDescription = "Phone Number";
            this.txt_Phone.BackColor = System.Drawing.Color.White;
            this.txt_Phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Phone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.txt_Phone.Location = new System.Drawing.Point(30, 135);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(241, 25);
            this.txt_Phone.TabIndex = 42;
            this.txt_Phone.Tag = "[\\D]";
            this.txt_Phone.Text = "Phone Number";
            this.txt_Phone.Enter += new System.EventHandler(this.txt_PlaceHolder_Enter);
            this.txt_Phone.Leave += new System.EventHandler(this.txt_PlaceHolder_Leave);
            // 
            // txt_Password
            // 
            this.txt_Password.AccessibleDescription = "Password";
            this.txt_Password.BackColor = System.Drawing.Color.White;
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Password.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.txt_Password.Location = new System.Drawing.Point(410, 135);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(241, 25);
            this.txt_Password.TabIndex = 29;
            this.txt_Password.Tag = "[\\s]+$";
            this.txt_Password.Text = "Password";
            this.txt_Password.TextChanged += new System.EventHandler(this.txt_CheckingFormat);
            this.txt_Password.Enter += new System.EventHandler(this.txt_PlaceHolder_Enter);
            this.txt_Password.Leave += new System.EventHandler(this.txt_PlaceHolder_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(30, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 21);
            this.label2.TabIndex = 44;
            this.label2.Text = "Phone Number";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(30, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 21);
            this.label4.TabIndex = 46;
            this.label4.Text = "Age";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Email
            // 
            this.txt_Email.AccessibleDescription = "Email";
            this.txt_Email.BackColor = System.Drawing.Color.White;
            this.txt_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Email.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.txt_Email.Location = new System.Drawing.Point(410, 52);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(241, 25);
            this.txt_Email.TabIndex = 27;
            this.txt_Email.Text = "Email";
            this.txt_Email.Enter += new System.EventHandler(this.txt_PlaceHolder_Enter);
            this.txt_Email.Leave += new System.EventHandler(this.txt_PlaceHolder_Leave);
            // 
            // txt_age
            // 
            this.txt_age.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_age.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_age.Location = new System.Drawing.Point(30, 218);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(241, 25);
            this.txt_age.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(30, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 21);
            this.label3.TabIndex = 45;
            this.label3.Text = "Gender";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(410, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 21);
            this.label8.TabIndex = 34;
            this.label8.Text = "Role";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(30, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 43;
            this.label1.Text = "Full Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbx_Role
            // 
            this.cmbx_Role.BackColor = System.Drawing.Color.Snow;
            this.cmbx_Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_Role.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_Role.FormattingEnabled = true;
            this.cmbx_Role.Items.AddRange(new object[] {
            "Organizer",
            "Attendee"});
            this.cmbx_Role.Location = new System.Drawing.Point(495, 278);
            this.cmbx_Role.Name = "cmbx_Role";
            this.cmbx_Role.Size = new System.Drawing.Size(156, 25);
            this.cmbx_Role.TabIndex = 36;
            // 
            // cmbx_Gender
            // 
            this.cmbx_Gender.BackColor = System.Drawing.Color.Snow;
            this.cmbx_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_Gender.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_Gender.FormattingEnabled = true;
            this.cmbx_Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbx_Gender.Location = new System.Drawing.Point(127, 278);
            this.cmbx_Gender.Name = "cmbx_Gender";
            this.cmbx_Gender.Size = new System.Drawing.Size(144, 25);
            this.cmbx_Gender.TabIndex = 47;
            // 
            // mainPanel
            // 
            this.mainPanel.AutoSize = true;
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.mainPanel.Controls.Add(this.cmbx_Gender);
            this.mainPanel.Controls.Add(this.cmbx_Role);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.label8);
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.txt_age);
            this.mainPanel.Controls.Add(this.txt_Email);
            this.mainPanel.Controls.Add(this.label4);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.txt_Password);
            this.mainPanel.Controls.Add(this.txt_Phone);
            this.mainPanel.Controls.Add(this.label5);
            this.mainPanel.Controls.Add(this.txt_Name);
            this.mainPanel.Controls.Add(this.txt_ConfirmPassword);
            this.mainPanel.Controls.Add(this.label6);
            this.mainPanel.Controls.Add(this.label7);
            this.mainPanel.Location = new System.Drawing.Point(42, 105);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainPanel.MinimumSize = new System.Drawing.Size(685, 340);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(685, 340);
            this.mainPanel.TabIndex = 42;
            // 
            // CreateAccountForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Registration_Form.Properties.Resources.background1;
            this.CancelButton = this.btn_SignUp;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.header);
            this.Controls.Add(this.mainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "CreateAccountForm";
            this.Text = "Create Account Form";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.Controls.SetChildIndex(this.mainPanel, 0);
            this.Controls.SetChildIndex(this.header, 0);
            this.Controls.SetChildIndex(this.footer, 0);
            this.footer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_age)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_SignUp;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.TableLayoutPanel footer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ConfirmPassword;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.NumericUpDown txt_age;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbx_Role;
        private System.Windows.Forms.ComboBox cmbx_Gender;
        private System.Windows.Forms.Panel mainPanel;
    }
}