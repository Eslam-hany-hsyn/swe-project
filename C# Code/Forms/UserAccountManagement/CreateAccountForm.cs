using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Registration_Form
{
    public partial class CreateAccountForm : BaseForm
    {
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
            bool added = addNewAccount(txt_Email.Text,txt_Password.Text,txt_Name.Text,txt_Phone.Text,cmbx_Gender.SelectedText,Convert.ToInt32(txt_age.Value),cmbx_Gender.SelectedText);
            if (added)
                MessageBox.Show("Account is created ", "Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }


        // return true if it create else false
        bool addNewAccount(string Email, string password, string fullName, string phoneNumber, string gender, int age, string role)
        {
            return false;
        }

    }
}
