using Registration_Form.Forms.Organizers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Registration_Form
{
    public partial class LoginForm : BaseForm
    {

        public static int PersonID = -1;
        public LoginForm()
        {
            InitializeComponent();

            base.inner_mainPanel = this.mainPanel;
            base.inner_footer = new Control();
            base.inner_header = this.header;

            base.inner_footer.Hide();
            Inner_InitializeLayout();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_ErrorMessage.Hide();

        }

        private void txt_EmailOrPassword_Leave(object sender, EventArgs e)
        {
            TextBox txtbox = (TextBox)sender;
            PlaceHolder(txtbox, txtbox.Tag.ToString(), true);
        }

        private void txt_EmailOrPassword_Enter(object sender, EventArgs e)
        {
            TextBox txtbox = (TextBox)sender;
            PlaceHolder(txtbox, txtbox.Tag.ToString(), false);
        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {
            TextBox txtbox = (TextBox)sender;

            if (txtbox.Text == txtbox.Tag.ToString() || txtbox.ForeColor == Color.Gray)
                return;

            CheckingFormat(txtbox, @"[\s]+$");
        }

        private void btn_NewAccount_Click(object sender, EventArgs e)
        {
            CreateAccountForm form = new CreateAccountForm();
            form.ShowDialog();
        }

       
        private void btn_ForgotPassword_Click(object sender, EventArgs e)
        {
            ChangePasswordForm form = new ChangePasswordForm();
            form.ShowDialog();
        }

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            (int id, string role) = Login(txt_EmailOrUsername.Text,txt_Password.Text);
            if (id != -1)
            {
                PersonID = id;
                if(role.ToLower() == "organizer")
                {
                    OrganizerForm org = new OrganizerForm();
                    org.Show();

                }
                else if (role.ToLower() == "admin")
                {
                    AdminForm org = new AdminForm();
                    org.Show();
                }
                else
                {
                    AttendeeForm org = new AttendeeForm();
                    org.Show();
                }
                this.Close();
            }
            else
              lbl_ErrorMessage.Show();
        }

        private void txt_EmailOrUsername_TextChanged(object sender, EventArgs e)
        {

        }

        
        // this function should return the Person id and role of the user if is exist else return -1
        (int id , string role) Login(string username, string password)
        {
            return (-1,"");
        }
    
    
    }
}
