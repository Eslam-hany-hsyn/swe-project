using Oracle.DataAccess.Client;
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
        OracleConnection con;
        string ordb = "data source = orcl; user id =hr; password=123;";

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
            con = new OracleConnection(ordb);
            con.Open();

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
            (int id, string role) = Login(txt_Email.Text,txt_Password.Text);
            if (id != -1)
            {
                PersonID = id;
                if(role.ToLower() == "organizer")
                {
                    OrganizerForm user = new OrganizerForm();
                    user.Show();
                }
                else if (role.ToLower() == "admin")
                {
                    AdminForm user = new AdminForm();
                    user.Show();
                }
                else if (role.ToLower() == "attendee")
                {
                    AttendeeForm user = new AttendeeForm();
                    user.Show();
                }
                this.Hide();
            }
            else
              lbl_ErrorMessage.Show();
        }


        
        // this function should return the Person id and role of the user if is exist else return -1
        (int id , string role) Login(string email, string password)
        {
            int personId = -1;
            string userRole = "";

            try
            {
                if (con.State != ConnectionState.Open) con.Open();

                using (OracleCommand cmd = new OracleCommand("Login_Process", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("p_email", OracleDbType.Varchar2).Value = email;
                    cmd.Parameters.Add("p_password", OracleDbType.Varchar2).Value = password;
                    cmd.Parameters.Add("p_personID", OracleDbType.Int32).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("p_role", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();

                    personId = int.Parse(cmd.Parameters["p_personID"].Value.ToString());
                    userRole = cmd.Parameters["p_role"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
            return (personId, userRole);
        }
    }
}
