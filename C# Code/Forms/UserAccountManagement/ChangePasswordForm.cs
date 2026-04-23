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
        string username = "";
        public ChangePasswordForm() : base()
        {
            InitializeComponent();
            base.inner_header = this.header;
            base.inner_mainPanel = this.mainPanel;
            base.inner_footer = this.footer;
            Inner_InitializeLayout();
        }

        public ChangePasswordForm(string username) : base()
        {
            InitializeComponent();
            base.inner_header = this.header;
            base.inner_mainPanel = this.mainPanel;
            base.inner_footer = this.footer;
            Inner_InitializeLayout();
            this.username = username;
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
            bool change =  changePassword(username,txt_NewPassword.Text);
            if(change)
                MessageBox.Show("Password is changed ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        // return true if it create else false
        bool changePassword(string username, string password)
        {
            return false;
        }
    }
}
