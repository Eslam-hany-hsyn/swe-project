using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration_Form
{
    public partial class AdminForm : Form, AdminInterface
    {
        public AdminForm()
        {
            InitializeComponent();
        }
        List<Control> Events = new List<Control>();
        private void AdminForm_Load(object sender, EventArgs e)
        {
            // Adding mock data to visualize the Pending Events board
            string[] pending1 = { "Google Dev Summit", "2026-05-10", "10:00 AM", "Pending" };
            flowLayoutPanel_Events.Controls.Add(CreateAdminDataRow(101, pending1));

            string[] pending2 = { "AI Workshop", "2026-06-15", "02:00 PM", "Pending" };
            flowLayoutPanel_Events.Controls.Add(CreateAdminDataRow(102, pending2));

            // Load Mock Data for Time Slots Table on page 2
            string[] ts1 = { "10:00 AM", "12:00 PM", "Oct 20, 2024", "Free" };
            flowTimeSlots.Controls.Add(CreateTimeSlotDataRow(1, ts1));

            string[] ts2 = { "01:00 PM", "03:00 PM", "Oct 21, 2024", "Booked" };
            flowTimeSlots.Controls.Add(CreateTimeSlotDataRow(2, ts2));

            string[] ts3 = { "04:00 PM", "06:00 PM", "Oct 22, 2024", "Free" };
            flowTimeSlots.Controls.Add(CreateTimeSlotDataRow(3, ts3));
        }

        public Panel CreateTimeSlotDataRow(int slotId, string[] rowData, int width = 450)
        {
            Panel rowPanel = new Panel
            {
                Height = 45,
                Width = width - 25, // scrollbar buffer
                BackColor = Color.White,
                Padding = new Padding(2),
                Margin = new Padding(0, 5, 0, 5),
                BorderStyle = BorderStyle.FixedSingle,
                Tag = slotId
            };

            TableLayoutPanel tableLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                RowCount = 1,
                ColumnCount = 4,
                BackColor = Color.Transparent
            };

            tableLayout.ColumnStyles.Clear();
            tableLayout.RowStyles.Clear();
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

            // Alignments mapping the header columns: Start (25%), End (25%), Date (25%), Status (25%)
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25f));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25f));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25f));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25f));

            // Populate the standard labels (Start Time, End Time, Date)
            for (int i = 0; i < 3; i++)
            {
                Label lblCell = new Label
                {
                    Text = rowData[i],
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Font = new Font("Segoe UI", 9.5F),
                    AutoEllipsis = true,
                    ForeColor = Color.FromArgb(40, 40, 40)
                };
                tableLayout.Controls.Add(lblCell, i, 0);
            }

            // Reserve Status (Booked vs Free Label)
            Panel statusContainer = new Panel { Dock = DockStyle.Fill, Padding = new Padding(5) };
            Label lblBook = new Label
            {
                Text = rowData[3],
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 8.5F, FontStyle.Bold),
                ForeColor = Color.White
            };

            if (rowData[3] == "Booked")
            {
                lblBook.BackColor = Color.Gray; 
            }
            else
            {
                lblBook.BackColor = Color.FromArgb(40, 167, 69); // Green for Free
            }

            statusContainer.Controls.Add(lblBook);
            tableLayout.Controls.Add(statusContainer, 3, 0);

            rowPanel.Controls.Add(tableLayout);
            return rowPanel;
        }

        public Panel CreateAdminDataRow(int eventId, string[] rowData, int width = 912)
        {
            Panel rowPanel = new Panel
            {
                Height = 55,
                Width = width - 25, // Accounting for flow layout scrollbar
                BackColor = Color.White,
                Padding = new Padding(5),
                Margin = new Padding(0, 5, 0, 5),
                BorderStyle = BorderStyle.FixedSingle,
                Tag = eventId
            };

            TableLayoutPanel tableLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                RowCount = 1,
                ColumnCount = 5,
                BackColor = Color.Transparent
            };

            tableLayout.ColumnStyles.Clear();
            tableLayout.RowStyles.Clear();
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

            
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25f));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15f));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15f));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15f));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30f));

            // Create standard text labels for the first 4 columns
            for (int i = 0; i < 4; i++)
            {
                Label lblCell = new Label
                {
                    Text = rowData[i],
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 9.5F),
                    AutoEllipsis = true,
                    ForeColor = Color.FromArgb(40, 40, 40)
                };
                tableLayout.Controls.Add(lblCell, i, 0);
            }

            // 5th Column Action Panel
            Panel actionPanel = new Panel { Dock = DockStyle.Fill };
            
            Button btnApprove = new Button
            {
                Text = "Approve",
                BackColor = Color.FromArgb(40, 167, 69),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 8.5F, FontStyle.Bold),
                Size = new Size(85, 30),
                Location = new Point(10, 5),
                Cursor = Cursors.Hand,
                Tag = eventId
            };
            btnApprove.FlatAppearance.BorderSize = 0;
            btnApprove.Click += BtnApprove_Click;

            Button btnDeny = new Button
            {
                Text = "Deny",
                BackColor = Color.FromArgb(220, 53, 69),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 8.5F, FontStyle.Bold),
                Size = new Size(85, 30),
                Location = new Point(110, 5),
                Cursor = Cursors.Hand,
                Tag = eventId
            };
            btnDeny.FlatAppearance.BorderSize = 0;
            btnDeny.Click += BtnDeny_Click;

            actionPanel.Controls.Add(btnApprove);
            actionPanel.Controls.Add(btnDeny);

            tableLayout.Controls.Add(actionPanel, 4, 0);
            rowPanel.Controls.Add(tableLayout);

            return rowPanel;
        }

        private void BtnApprove_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int eventId = (int)btn.Tag;
            bool isUpdated = updateEventStatus(eventId, "Approved");

            if (!isUpdated)
            {
                MessageBox.Show($"Event {eventId} Failed to Update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Panel actionPanel = (Panel)btn.Parent;
            TableLayoutPanel tableLayout = (TableLayoutPanel)actionPanel.Parent;
            Panel rowPanel = (Panel)tableLayout.Parent;

            // Extract visually presented Data
            string title = tableLayout.GetControlFromPosition(0, 0).Text;
            string date = tableLayout.GetControlFromPosition(1, 0).Text;
            string time = tableLayout.GetControlFromPosition(2, 0).Text;

            // Send notification to attendees
            Registration_Form.AttendeeForm.GlobalNotifications.Add($"NEW EVENT: '{title}' is now registered for {date} at {time}!");

            flowLayoutPanel_Events.Controls.Remove(rowPanel);
            rowPanel.Dispose();

            string[] tsData = { time, "TBD", date, "Booked" };
            flowTimeSlots.Controls.Add(CreateTimeSlotDataRow(eventId, tsData));

            MessageBox.Show($"Event {eventId} Approved and allocated to the Time Slots schedule as Booked!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnDeny_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int eventId = (int)btn.Tag;
            bool isUpdated = updateEventStatus(eventId, "Denied");
            
            if (!isUpdated)
            {
                MessageBox.Show($"Event {eventId} Failed to Update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Reaching the row container visually
            Panel actionPanel = (Panel)btn.Parent;
            TableLayoutPanel tableLayout = (TableLayoutPanel)actionPanel.Parent;
            Panel rowPanel = (Panel)tableLayout.Parent;

            // Extract visually presented Data 
            string title = tableLayout.GetControlFromPosition(0, 0).Text;
            string date = tableLayout.GetControlFromPosition(1, 0).Text;
            string time = tableLayout.GetControlFromPosition(2, 0).Text;

            // Send notification to attendees
            Registration_Form.AttendeeForm.GlobalNotifications.Add($"CANCELLED: '{title}' originally set for {date} was denied.");

            // Visually remove from Pending Events
            flowLayoutPanel_Events.Controls.Remove(rowPanel);
            rowPanel.Dispose();

            // Adds back to pool as Free
            string[] tsData = { time, "TBD", date, "Free" };
            flowTimeSlots.Controls.Add(CreateTimeSlotDataRow(eventId, tsData));

            MessageBox.Show($"Event {eventId} Denied! Flow reverted to Free time slot.", "Action Taken", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_CreateTimeSlot_Click(object sender, EventArgs e)
        {
            bool isCreated = createTimeSlots(LoginForm.userID,dtp_Date.Value, dtp_StartTime.Value.ToString("HH:mm"), dtp_EndTime.Value.ToString("HH:mm"));
            if (isCreated)
                MessageBox.Show("Time Slot successfully requested!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Time Slot rejected request", "Fails", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }


        // You will only Implement these Functions
        #region Tasks Will TODO 

        public bool createTimeSlots(int admminID, DateTime date, string startTime, string endTime)
        {
            // Placeholder: database insertion logic goes here.
            return true;
        }

        public string[] getAllAppendingEvent()
        {
            // Placeholder for FR 8
            return new string[] { };
        }

        public bool updateEventStatus(int eventID, string status)
        {
            // Placeholder for FR 8 (update DB)
            return true;
        }

        public string[] getAllApprovedEventTitles()
        {
            // Placeholder for FR 9
            return new string[] { };
        }

        #endregion
    }
}
