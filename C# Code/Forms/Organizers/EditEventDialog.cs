using System;
using System.Drawing;
using System.Windows.Forms;

namespace Registration_Form.Forms.Organizers
{
    public partial class EditEventDialog : Form
    {
        public string EventTitle { get; private set; }
        public string Description { get; private set; }
        public DateTime EventDate { get; private set; }
        public int Capacity { get; private set; }

        public EditEventDialog(string currentTitle, string currentDesc, string currentDate, string startTime, string endTime, int currentCap)
        {
            InitializeComponent();
            
            // Set Initial Values
            txtTitle.Text = currentTitle;
            txtDesc.Text = currentDesc;
            numCap.Value = currentCap;
            lblTimeValue.Text = DateTime.Parse(startTime).ToString("hh:mm tt") + " - " + DateTime.Parse(endTime).ToString("hh:mm tt");

            DateTime parsedDate;
            if (DateTime.TryParse(currentDate, out parsedDate))
                dtpDate.Value = parsedDate;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            EventTitle = txtTitle.Text;
            Description = txtDesc.Text;
            EventDate = dtpDate.Value;
            Capacity = (int)numCap.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

       
    }
}
