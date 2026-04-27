using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Registration_Form
{
    public partial class BaseForm : Form
    {

        private bool _isUpdating = false;
        public Panel inner_mainPanel = null;
        public Control inner_header = null;
        public Control inner_footer = null;
        public Control outer_header = null;

        public BaseForm()
        {
            InitializeComponent();
        }

        protected void Inner_InitializeLayout()
        {
            inner_header.Dock = DockStyle.Fill;
            inner_mainPanel.Dock = DockStyle.Fill;
            inner_footer.Dock = DockStyle.Fill;
            outer_header.Dock = DockStyle.Fill;

            innerTbl.Controls.Add(inner_header, 0, 0);
            innerTbl.Controls.Add(inner_mainPanel, 0, 1);
            innerTbl.Controls.Add(inner_footer, 0, 2);
            outerTbl.Controls.Add(outer_header, 1, 0);

        }

     

        public static void PlaceHolder(Control textBox, string placeHolder, bool appear)
        {
            if (!appear) // Focus Gained (Enter)
            {
                if (textBox.Text == placeHolder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
                else
                {
                    textBox.ForeColor = Color.Black;
                }
            }
            else // Focus Lost (Leave) or Initializing
            {
                if (string.IsNullOrWhiteSpace(textBox.Text) || textBox.Text == placeHolder)
                {
                    textBox.Text = placeHolder;
                    textBox.ForeColor = Color.Gray;
                }
                else
                {
                    textBox.ForeColor = Color.Black;
                }
            }
        }

        public void CheckingFormat(TextBox textBox, string pattern)
        {
            if (_isUpdating) return;

            string currentText = textBox.Text;


            string cleanText = Regex.Replace(currentText, pattern, "");

            if (currentText != cleanText)
            {
                _isUpdating = true;

                int selectionStart = textBox.SelectionStart;

                textBox.Text = cleanText;


                int positionShift = currentText.Length - cleanText.Length;
                textBox.SelectionStart = Math.Max(0, selectionStart - positionShift);

                _isUpdating = false;
            }
        }


    }
}
