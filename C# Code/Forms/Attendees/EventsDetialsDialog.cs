using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration_Form.Forms.Attendees
{
    public partial class EventsDetialsDialog : Form
    {
        public EventsDetialsDialog(string title, string date,string time, string description)
        {
            InitializeComponent();
            label4.Text = title;
            label5.Text = date;
            label6.Text = description;
            label7.Text = time;
        }
    }
}
