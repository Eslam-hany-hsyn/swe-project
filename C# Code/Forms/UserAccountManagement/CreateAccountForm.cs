using Oracle.DataAccess.Client;
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
    public partial class CreateAccountForm : BaseForm
    {
        OracleConnection con;
        string ordb = "data source = orcl; user id =scott; password=scott;";
        public CreateAccountForm() : base()
        {
            InitializeComponent();   // creates header, mainPanel, footer
            base.inner_header = this.header;
            base.inner_mainPanel = this.mainPanel;
            base.inner_footer = this.footer;
            Inner_InitializeLayout();      // now safe to add them to innerTbl
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(ordb);
            con.Open();

        }

        private void txt_CheckingFormat(object sender, EventArgs e)
        {
            TextBox txtbox = (TextBox)sender;

            if (txtbox.ForeColor == Color.Gray)
                return;

            CheckingFormat(txtbox, txtbox.Tag.ToString());

            if (txtbox.AccessibleDescription == "Age")
            {
                txtbox.Text = txtbox.Text.TrimStart('0');
            }

        }

        private void txt_PlaceHolder_Leave(object sender, EventArgs e)
        {
            TextBox txtbox = (TextBox)sender;
            PlaceHolder(txtbox, txtbox.AccessibleDescription, true);
        }

        private void txt_PlaceHolder_Enter(object sender, EventArgs e)
        {
            TextBox txtbox = (TextBox)sender;
            PlaceHolder(txtbox, txtbox.AccessibleDescription.ToString(), false);
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            bool added = addNewAccount(txt_Email.Text,txt_Password.Text,txt_Name.Text,txt_Phone.Text,cmbx_Gender.SelectedItem.ToString(),Convert.ToInt32(txt_age.Value), cmbx_Gender.SelectedItem.ToString());
            if (added)
                MessageBox.Show("Account is created ", "Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }


        // return true if it create else false
        bool addNewAccount(string Email, string password, string fullName, string phoneNumber, string gender, int age, string role)
        {
            try
            {
                if (con.State != ConnectionState.Open) con.Open();

                using (OracleCommand cmd = new OracleCommand("Add_New_Attendee_Account", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("p_email", OracleDbType.Varchar2).Value = Email;
                    cmd.Parameters.Add("p_password", OracleDbType.Varchar2).Value = password;
                    cmd.Parameters.Add("p_fullName", OracleDbType.Varchar2).Value = fullName;
                    cmd.Parameters.Add("p_phoneNumber", OracleDbType.Varchar2).Value = phoneNumber;
                    cmd.Parameters.Add("p_gender", OracleDbType.Varchar2).Value = gender;
                    cmd.Parameters.Add("p_age", OracleDbType.Int32).Value = age;
                    cmd.Parameters.Add("p_role", OracleDbType.Varchar2).Value = role;

                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registration failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
        }
    }
}
