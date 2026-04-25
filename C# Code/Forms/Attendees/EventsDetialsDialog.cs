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
        //(title, organizerName, date,time, descripation, Remaining))
        public EventsDetialsDialog(string title,string organizerName,  string date,string time, string description, string remaining)
        {
            InitializeComponent();
            label4.Text = title;
            label5.Text = date;
            label6.Text = description;
            label7.Text = time;
            label10.Text = organizerName;
            label12.Text = remaining;
        }
    }
}
