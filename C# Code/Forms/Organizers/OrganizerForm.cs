using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

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

            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25f));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25f));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25f));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25f));

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

            Panel actionContainer = new Panel { Dock = DockStyle.Fill, Padding = new Padding(2) };
            Button btnBook = new Button
            {
                Text = "Book",
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(40, 167, 69),
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

            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30f));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15f));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15f));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15f));
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25f));

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

            Panel statusContainer = new Panel { Dock = DockStyle.Fill, Padding = new Padding(3) };
            Label lblStatus = new Label
            {
                Text = rowData[3],
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 8F, FontStyle.Bold),
                ForeColor = Color.White
            };

            if (rowData[3] == "Approved") lblStatus.BackColor = Color.FromArgb(40, 167, 69);
            else if (rowData[3] == "Pending") { lblStatus.BackColor = Color.FromArgb(255, 193, 7); lblStatus.ForeColor = Color.Black; }
            else if (rowData[3] == "Rejected") lblStatus.BackColor = Color.FromArgb(220, 53, 69);
            else lblStatus.BackColor = Color.Gray;

            statusContainer.Controls.Add(lblStatus);
            tableLayout.Controls.Add(statusContainer, 3, 0);

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
                AccessibleDescription = (rowData[0] + "," + rowData[1] + "," + rowData[2] + "," + rowData[3] + "," + rowData[4] + "," + rowData[5]),
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

            Panel actionPanel = (Panel)btn.Parent;
            TableLayoutPanel tableLayout = (TableLayoutPanel)actionPanel.Parent;

            string currentTitle = tableLayout.GetControlFromPosition(0, 0).Text;
            string currentDate = tableLayout.GetControlFromPosition(1, 0).Text;

            using (EditEventDialog dialog = new EditEventDialog(currentTitle, "Enter description here...", currentDate, 100))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    bool success = updateEvent(eventId, dialog.EventTitle, dialog.Description, dialog.EventDate, dialog.Capacity);

                    if (success)
                    {
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

            Panel actionContainer = (Panel)btn.Parent;
            TableLayoutPanel tableLayout = (TableLayoutPanel)actionContainer.Parent;
            Panel rowPanel = (Panel)tableLayout.Parent;

            string startTime = tableLayout.GetControlFromPosition(0, 0).Text;
            string date = tableLayout.GetControlFromPosition(2, 0).Text;
            string eventTitle = !string.IsNullOrWhiteSpace(txtEventTitle.Text) && txtEventTitle.Text != "Event Title"
                                ? txtEventTitle.Text : "Requested Event";

            flowTimeSlots.Controls.Remove(rowPanel);
            rowPanel.Dispose();

            string[] eventData = { eventTitle, date, startTime, "Pending" };
            flowEvents.Controls.Add(CreateOrganizerDataRow(TimeSlotIdBooked, eventData));

            MessageBox.Show($"Success! '{eventTitle}' has been booked for {date} at {startTime}. It is now pending administrator approval.",
                            "Booking Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            int capacity = (int)numCapacity.Value;
            bool success = createEvent(TimeSlotIdBooked, LoginForm.PersonID, txtEventTitle.Text, txtDescription.Text, dtpSubmitDate.Value, capacity);
            TimeSlotIdBooked = -1;

            if (success)
            {
                MessageBox.Show("Event submitted for review successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAvailableSlots(); // Refresh slots after booking
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


        #region Tasks Will TODO

        /// <summary>
        /// FR4 - Creates a new event with 'Pending' status.
        /// Looks up OrganizerID from Organizers table using PersonID.
        /// </summary>
        public bool createEvent(int timeSlotID, int personID, string eventTitle, string description, DateTime date, int capacity)
        {
            string getOrganizerQuery = "SELECT OrganizerID FROM Organizers WHERE PersonID = :personID";

            string insertEventQuery = @"
                INSERT INTO Events (OrganizerID, TimeSlotID, Title, Description, Status, Capacity)
                VALUES (:organizerID, :timeSlotID, :title, :description, 'Pending', :capacity)";

            try
            {
                using (OracleConnection conn = new OracleConnection(DBHelper.ConnectionString))
                {
                    conn.Open();

                    // Step 1: Resolve PersonID -> OrganizerID
                    int organizerID;
                    using (OracleCommand cmd = new OracleCommand(getOrganizerQuery, conn))
                    {
                        cmd.Parameters.Add("personID", OracleDbType.Int32).Value = personID;
                        object result = cmd.ExecuteScalar();
                        if (result == null)
                        {
                            MessageBox.Show("Organizer record not found for this account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                        organizerID = Convert.ToInt32(result);
                    }

                    // Step 2: Insert the Event
                    using (OracleCommand cmd = new OracleCommand(insertEventQuery, conn))
                    {
                        cmd.Parameters.Add("organizerID", OracleDbType.Int32).Value = organizerID;
                        cmd.Parameters.Add("timeSlotID", OracleDbType.Int32).Value = timeSlotID;
                        cmd.Parameters.Add("title", OracleDbType.NVarchar2).Value = eventTitle;
                        cmd.Parameters.Add("description", OracleDbType.Clob).Value = description;
                        cmd.Parameters.Add("capacity", OracleDbType.Int32).Value = capacity;

                        int rows = cmd.ExecuteNonQuery();
                        return rows > 0;
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show("DB Error (createEvent): " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// FR5 - Cancels an event by setting its Status to 'Cancelled'.
        /// The timeslot automatically becomes available again because
        /// getAllAvailableTimeSlots() excludes only slots with non-cancelled events.
        /// </summary>
        public bool cancelEvent(int eventID)
        {
            string cancelQuery = "UPDATE Events SET Status = 'Cancelled' WHERE EventID = :eventID";

            try
            {
                using (OracleConnection conn = new OracleConnection(DBHelper.ConnectionString))
                {
                    conn.Open();
                    using (OracleTransaction tx = conn.BeginTransaction())
                    {
                        try
                        {
                            using (OracleCommand cmd = new OracleCommand(cancelQuery, conn))
                            {
                                cmd.Transaction = tx;
                                cmd.Parameters.Add("eventID", OracleDbType.Int32).Value = eventID;
                                cmd.ExecuteNonQuery();
                            }

                            tx.Commit();
                            return true;
                        }
                        catch
                        {
                            tx.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show("DB Error (cancelEvent): " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// FR5 - Updates event Title, Description, and Capacity.
        /// Note: Event date lives in the linked TimeSlot row, not in Events,
        /// so date edits require changing the TimeSlotID which is out of scope here.
        /// </summary>
        public bool updateEvent(int eventID, string eventTitle, string description, DateTime date, int capacity)
        {
            string query = @"UPDATE Events
                             SET Title       = :title,
                                 Description = :description,
                                 Capacity    = :capacity
                             WHERE EventID = :eventID";

            try
            {
                using (OracleConnection conn = new OracleConnection(DBHelper.ConnectionString))
                {
                    conn.Open();
                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add("title", OracleDbType.NVarchar2).Value = eventTitle;
                        cmd.Parameters.Add("description", OracleDbType.Clob).Value = description;
                        cmd.Parameters.Add("capacity", OracleDbType.Int32).Value = capacity;
                        cmd.Parameters.Add("eventID", OracleDbType.Int32).Value = eventID;

                        int rows = cmd.ExecuteNonQuery();
                        return rows > 0;
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show("DB Error (updateEvent): " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// FR6 - Returns all time slots with no active (non-cancelled) event linked to them.
        /// Format per entry: "TimeSlotID,StartTime,EndTime,SlotDate"
        /// </summary>
        public string[] getAllAvailableTimeSlots()
        {
            // A slot is available if it has no event, or only cancelled events
            string query = @"
                SELECT ts.TimeSlotID,
                       ts.StartTime,
                       ts.EndTime,
                       ts.SlotDate
                FROM   TimeSlots ts
                WHERE  NOT EXISTS (
                           SELECT 1
                           FROM   Events e
                           WHERE  e.TimeSlotID = ts.TimeSlotID
                           AND    e.Status     <> 'Cancelled'
                       )
                ORDER BY ts.SlotDate, ts.StartTime";

            List<string> slots = new List<string>();

            try
            {
                using (OracleConnection conn = new OracleConnection(DBHelper.ConnectionString))
                {
                    conn.Open();
                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string startTime = reader.GetDateTime(1).ToString("hh:mm tt");
                            string endTime = reader.GetDateTime(2).ToString("hh:mm tt");
                            string date = reader.GetDateTime(3).ToString("MMM dd, yyyy");

                            slots.Add($"{id},{startTime},{endTime},{date}");
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show("DB Error (getAllAvailableTimeSlots): " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return slots.ToArray();
        }

        /// <summary>
        /// TimeSlots table has no Status column in this schema.
        /// Slot availability is derived automatically via getAllAvailableTimeSlots().
        /// Kept to satisfy the interface contract.
        /// </summary>
        public bool updateTimeSlotStatus(int timeSlotID, string status)
        {
            return true;
        }

        #endregion
    }
}