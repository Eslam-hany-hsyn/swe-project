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
    public partial class ChangePasswordForm : BaseForm
    {

        OracleConnection con;
        string ordb = "data source = orcl; user id =hr; password=123;";
        public ChangePasswordForm()
        {
            InitializeComponent();
            base.inner_header = this.header;
            base.inner_mainPanel = this.mainPanel;
            base.inner_footer = this.footer;
            Inner_InitializeLayout();
        }


        private void txt_CheckingFormat(object sender, EventArgs e)
        {
            TextBox txtbox = (TextBox)sender;

            if (txtbox.ForeColor == Color.Gray)
                return;

            CheckingFormat(txtbox, txtbox.Tag.ToString());
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

        private void btn_ChangePassword_Click(object sender, EventArgs e)
        {
            bool change =  changePassword(txt_Email.Text,txt_NewPassword.Text);
            if(change)
                MessageBox.Show("Password is changed ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        // return true if it create else false
        bool changePassword(string email, string password)
        {
            int rowsAffected = 0;
            try
            {
                if (con.State != ConnectionState.Open) con.Open();

                using (OracleCommand cmd = new OracleCommand("Change_User_Password", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("p_email", OracleDbType.Varchar2).Value = email;
                    cmd.Parameters.Add("p_newPassword", OracleDbType.Varchar2).Value = password;

                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating password: " + ex.Message);
                return false;
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
            return rowsAffected > 0;
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(ordb);
            con.Open();
        }
    }
}
