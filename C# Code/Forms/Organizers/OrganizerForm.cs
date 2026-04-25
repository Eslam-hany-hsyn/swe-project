using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration_Form.Forms.Organizers
{
    public partial class OrganizerForm : Form, Registration_Form.OrganizerInterface
    {
        public OrganizerForm()
        {
            InitializeComponent();
        }

        int TimeSlotIdBooked = -1;

        private void OrganizerForm_Load(object sender, EventArgs e)
        {
           
            // Dynamically Load Available Time Slots from Interface
            LoadAvailableSlots();
        }

        private void LoadAvailableSlots()
        {
            flowTimeSlots.Controls.Clear();
            string[] slots = getAllAvailableTimeSlots();

            if (slots == null || slots.Length == 0)
            {
                
                return;
            }

            foreach (string slotRaw in slots)
            {
                string[] parts = slotRaw.Split(',');
                if (parts.Length >= 4)
                {
                    int id = int.Parse(parts[0]);
                    // Mapping "TimeSlotID,startTime,endtime,date" -> UI "startTime, endtime, date, Status"
                    string[] uiData = { parts[1], parts[2], parts[3], "Free" };
                    Panel slot = CreateTimeSlotDataRow(id, uiData);
                    flowTimeSlots.Controls.Add(slot);
                }
            }
        }

        public Panel CreateTimeSlotDataRow(int slotId, string[] rowData, int width = 530)
        {
            Panel rowPanel = new Panel
            {
                Height = 45,
                Width = width,
                BackColor = Color.White,
                Padding = new Padding(2),
                Margin = new Padding(0, 5, 0, 5),
                BorderStyle = BorderStyle.FixedSingle,
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

            // Reserve Action (Booked vs Free)
            Panel actionContainer = new Panel { Dock = DockStyle.Fill, Padding = new Padding(2) };
            Button btnBook = new Button
            {
                Text = "Book",
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(40, 167, 69), // Green
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 8.5F, FontStyle.Bold),
                Cursor = Cursors.Hand,
                Tag = slotId
            };
            btnBook.FlatAppearance.BorderSize = 0;

            if (rowData[3] == "Booked")
            {
                btnBook.Text = "Booked";
                btnBook.BackColor = Color.LightGray;
                btnBook.ForeColor = Color.DarkGray;
                btnBook.Enabled = false;
            }
            else
            {
                btnBook.Click += BtnBook_Click;
            }

            actionContainer.Controls.Add(btnBook);
            tableLayout.Controls.Add(actionContainer, 3, 0);

            rowPanel.Controls.Add(tableLayout);
            return rowPanel;
        }

        public Panel CreateOrganizerDataRow(int eventId, string[] rowData, int width = 920)
        {

            Panel rowPanel = new Panel
            {
                Height = 42,
                Width = width,
                BackColor = Color.White,
                Padding = new Padding(3),
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

            // Alignments: Title (25%), Date (15%), Time (15%), Status (15%), Actions (30%)
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30f)); // Tweaked internal ratios to match mock left panel size
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15f));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15f));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15f));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25f));

            // 1. Text Labels
            for (int i = 0; i < 3; i++)
            {
                Label lblCell = new Label
                {
                    Text = rowData[i],
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Font = new Font("Segoe UI", 9F),
                    AutoEllipsis = true,
                    ForeColor = Color.FromArgb(40, 40, 40)
                };
                tableLayout.Controls.Add(lblCell, i, 0);
            }

            // 2. Status Pill (Column 3)
            Panel statusContainer = new Panel { Dock = DockStyle.Fill, Padding = new Padding(3) };
            Label lblStatus = new Label
            {
                Text = rowData[3],
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 8F, FontStyle.Bold),
                ForeColor = Color.White
            };

            // Mimic Pill Coloring
            if (rowData[3] == "Approved") lblStatus.BackColor = Color.FromArgb(40, 167, 69);
            else if (rowData[3] == "Pending") { lblStatus.BackColor = Color.FromArgb(255, 193, 7); lblStatus.ForeColor = Color.Black; }
            else if (rowData[3] == "Rejected") lblStatus.BackColor = Color.FromArgb(220, 53, 69);
            else lblStatus.BackColor = Color.Gray;

            statusContainer.Controls.Add(lblStatus);
            tableLayout.Controls.Add(statusContainer, 3, 0);

            // 3. Actions Panel (Column 4)
            Panel actionPanel = new Panel { Dock = DockStyle.Fill };

            Button btnEdit = new Button
            {
                Text = "Edit",
                BackColor = Color.FromArgb(70, 130, 220),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 8F, FontStyle.Bold),
                Size = new Size(55, 26),
                Location = new Point(60, 3),
                Cursor = Cursors.Hand,
                Tag = eventId,
                AccessibleDescription = (rowData[0]+","+ rowData[1] + "," + rowData[2] + "," + rowData[3] + "," + rowData[4] + "," + rowData[5]),
            };
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.Click += BtnEdit_Click;

            Button btnCancel = new Button
            {
                Text = "Cancel",
                BackColor = Color.LightGray,
                ForeColor = Color.Black,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 8F, FontStyle.Bold),
                Size = new Size(55, 26),
                Location = new Point(120, 3),
                Cursor = Cursors.Hand,
                Tag = eventId
            };
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.Click += BtnCancel_Click;

            actionPanel.Controls.Add(btnEdit);
            actionPanel.Controls.Add(btnCancel);

            tableLayout.Controls.Add(actionPanel, 4, 0);
            rowPanel.Controls.Add(tableLayout);

            return rowPanel;
        }


        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int eventId = (int)btn.Tag;

            // Extract existing data from the row UI
            Panel actionPanel = (Panel)btn.Parent;
            TableLayoutPanel tableLayout = (TableLayoutPanel)actionPanel.Parent;
            
            string currentTitle = tableLayout.GetControlFromPosition(0, 0).Text;
            string currentDate = tableLayout.GetControlFromPosition(1, 0).Text;

            // Show Dialog
            using (EditEventDialog dialog = new EditEventDialog(currentTitle, "Enter description here...", currentDate, 100))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    bool success = updateEvent(eventId, dialog.EventTitle, dialog.Description, dialog.EventDate, dialog.Capacity);

                    if (success)
                    {
                        // Update UI row visually
                        tableLayout.GetControlFromPosition(0, 0).Text = dialog.EventTitle;
                        tableLayout.GetControlFromPosition(1, 0).Text = dialog.EventDate.ToShortDateString();
                        
                        MessageBox.Show($"Event ID {eventId} has been successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int eventId = (int)btn.Tag;

            var result = MessageBox.Show($"Are you sure you want to cancel event {eventId}?", "Confirm Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                cancelEvent(eventId);
                MessageBox.Show($"Event {eventId} cancelled.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnBook_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            TimeSlotIdBooked = (int)btn.Tag;

            // Find the row container
            Panel actionContainer = (Panel)btn.Parent;
            TableLayoutPanel tableLayout = (TableLayoutPanel)actionContainer.Parent;
            Panel rowPanel = (Panel)tableLayout.Parent;

            // Extract Slot Data
            string startTime = tableLayout.GetControlFromPosition(0, 0).Text;
            string date = tableLayout.GetControlFromPosition(2, 0).Text;
            string eventTitle = !string.IsNullOrWhiteSpace(txtEventTitle.Text) && txtEventTitle.Text != "Event Title" ? txtEventTitle.Text : "Requested Event";

            // 1. Remove from Time Slots
            flowTimeSlots.Controls.Remove(rowPanel);
            rowPanel.Dispose();

            // 2. Add to Events Table with "Pending" status
            // Event Row structure: Title, Date, Time, Status
            string[] eventData = { eventTitle, date, startTime, "Pending" };
            flowEvents.Controls.Add(CreateOrganizerDataRow(TimeSlotIdBooked, eventData));

            MessageBox.Show($"Success! '{eventTitle}' has been booked for {date} at {startTime}. It is now pending administrator approval.", "Booking Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEventTitle.Text))
            {
                MessageBox.Show("Please enter a Title.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (TimeSlotIdBooked == -1)
            {
                MessageBox.Show("Please choose a Time Slot.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool updated = updateTimeSlotStatus(TimeSlotIdBooked, "booked");
            int capacity = (int)numCapacity.Value;
            bool success = createEvent(TimeSlotIdBooked, LoginForm.userID, txtEventTitle.Text, txtDescription.Text, dtpSubmitDate.Value, capacity);
            TimeSlotIdBooked = -1;

            if (success)
            {
                MessageBox.Show("Event submitted for review successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtDescription_Enter(object sender, EventArgs e)
        {
            Control targetBox = (Control)sender;
            if (targetBox.Tag != null)
                BaseForm.PlaceHolder(targetBox, targetBox.Tag.ToString(), false);
        }

        private void txtDescription_Leave(object sender, EventArgs e)
        {
            Control targetBox = (Control)sender;
            if (targetBox.Tag != null)
                BaseForm.PlaceHolder(targetBox, targetBox.Tag.ToString(), true);
        }


        // You will only Implement these Functions
        #region Tasks Will TODO 


        public bool createEvent(int timeSlotID, int organizerID,string eventTitle, string description, DateTime date, int capacity)
        {
            // Placeholder: Database Integration Logic
            return true;
        }

        public bool cancelEvent(int eventID)
        {
            // Placeholder: Marking event as cancelled in Database
            return true;
        }

        public bool updateEvent(int eventID, string eventTitle, string description, DateTime date, int capacity)
        {
            // Placeholder: DB Update Logic
            return true;
        }

        public string[] getAllAvailableTimeSlots()
        {
            // Placeholder for FR 6: Returning list of slots to populate comboboxes
            return new string[] { };
        }

        public bool updateTimeSlotStatus(int timeSlotID, string status)
        {
            return false;
        }


        #endregion
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            LoginForm.userID = -1;
            this.Close();
            foreach (Form f in Application.OpenForms)
            {
                if (f is LoginForm)
                {
                    f.Show();
                    return;
                }
            }
            new LoginForm().Show();
        }
    }
}
