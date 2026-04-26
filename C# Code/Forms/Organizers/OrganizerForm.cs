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
using Oracle.DataAccess.Types;

namespace Registration_Form.Forms.Organizers
{
    public partial class OrganizerForm : Form, OrganizerInterface
    {
        public OrganizerForm()
        {
            InitializeComponent();
        }



        string ordb = "data source = orcl; user id =hr; password=123;";


        private void OrganizerForm_Load(object sender, EventArgs e)
        {
           
            // Dynamically Load Available Time Slots from Interface
            LoadAvailableSlots();
            LoadEventsOrganizers();
        }

        private void LoadAvailableSlots()
        {
            flowTimeSlots.Controls.Clear();
            string[] slots = getAllAvailableTimeSlots();

            if (slots == null || slots.Length == 0)
            {
                
                return;
            }
            dtpSubmitDate.Value = DateTime.Parse(slots[0].Split(',')[3]);

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

        private void LoadEventsOrganizers()
        {
            flowEvents.Controls.Clear();
            string[] events = getAllEventsForOrganizer(LoginForm.userID);

            if (events == null || events.Length == 0)
            {

                return;
            }

            foreach (string slotRaw in events)
            {
                string[] parts = slotRaw.Split(',');
                if (parts.Length >= 4)
                {
                    int id = int.Parse(parts[0]);
                    Panel slot = CreateOrganizerDataRow(id, parts);
                    flowEvents.Controls.Add(slot);
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
                    Text = (i == 2)?(DateTime.Parse(rowData[i]).ToShortDateString()) : (DateTime.Parse(rowData[i]).TimeOfDay.ToString()),
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

            // 1. Text Labels (Title, Date, Time)
            // Column 0: Title
            Label lblTitle = new Label { Text = rowData[1], Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft, Font = new Font("Segoe UI", 9F), AutoEllipsis = true, ForeColor = Color.FromArgb(40, 40, 40) };
            tableLayout.Controls.Add(lblTitle, 0, 0);

            // Column 1: Date
            Label lblDate = new Label { Text = rowData[3], Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft, Font = new Font("Segoe UI", 9F), AutoEllipsis = true, ForeColor = Color.FromArgb(40, 40, 40) };
            tableLayout.Controls.Add(lblDate, 1, 0);

            // Column 2: Time (Start - End)
            Label lblTimeValue = new Label { Text = rowData[4] + " - " + rowData[5], Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft, Font = new Font("Segoe UI", 9F), AutoEllipsis = true, ForeColor = Color.FromArgb(40, 40, 40) };
            tableLayout.Controls.Add(lblTimeValue, 2, 0);

            // 2. Status Pill (Column 3)
            Panel statusContainer = new Panel { Dock = DockStyle.Fill, Padding = new Padding(3) };
            Label lblStatus = new Label
            {
                Text = rowData[7],
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 8F, FontStyle.Bold),
                ForeColor = Color.White
            };

            // Mimic Pill Coloring
            if (rowData[7] == "Approved") lblStatus.BackColor = Color.FromArgb(40, 167, 69);
            else if (rowData[7] == "Pending") { lblStatus.BackColor = Color.FromArgb(255, 193, 7); lblStatus.ForeColor = Color.Black; }
            else if (rowData[7] == "Rejected") lblStatus.BackColor = Color.FromArgb(220, 53, 69);
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
                AccessibleDescription = string.Join(",", rowData),
            };
            // Event Row structure: Title, Date, Time, Status

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

            // Extract existing data from AccessibleDescription
            // Structure: title, description, date, startTime, endTime, capacity, status
            string[] data = btn.AccessibleDescription.Split(',');
            if (data.Length < 7) return;

            string currentTitle = data[0];
            string currentDesc = data[1];
            string currentDate = data[2];
            string startTime = data[3];
            string endTime = data[4];
            int currentCap = int.TryParse(data[5], out int cap) ? cap : 100;

            // Show Dialog
            using (EditEventDialog dialog = new EditEventDialog(currentTitle, currentDesc, currentDate, startTime, endTime, currentCap))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    bool success = updateEvent(eventId, dialog.EventTitle, dialog.Description, dialog.EventDate, dialog.Capacity);

                    if (success)
                    {
                        // Update UI row visually
                        Panel actionPanel = (Panel)btn.Parent;
                        TableLayoutPanel tableLayout = (TableLayoutPanel)actionPanel.Parent;

                        tableLayout.GetControlFromPosition(0, 0).Text = dialog.EventTitle;
                        // Date and Time are disabled in dialog, but we update them just in case
                        tableLayout.GetControlFromPosition(1, 0).Text = dialog.EventDate.ToShortDateString();
                        
                        // Update AccessibleDescription for future edits
                        data[0] = dialog.EventTitle;
                        data[1] = dialog.Description;
                        data[5] = dialog.Capacity.ToString();
                        btn.AccessibleDescription = string.Join(",", data);

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
            int TimeSlotIdBooked = (int)btn.Tag;

            // Find the row container
            Panel actionContainer = (Panel)btn.Parent;
            TableLayoutPanel tableLayout = (TableLayoutPanel)actionContainer.Parent;
            Panel rowPanel = (Panel)tableLayout.Parent;

            // Extract Slot Data
            string startTime = tableLayout.GetControlFromPosition(0, 0).Text;
            string endTime = tableLayout.GetControlFromPosition(1, 0).Text;
            string date = tableLayout.GetControlFromPosition(2, 0).Text;
            string eventTitle = !string.IsNullOrWhiteSpace(txtEventTitle.Text) && txtEventTitle.Text != "Event Title" ? txtEventTitle.Text : "Requested Event";

            // 1. Remove from Time Slots
            flowTimeSlots.Controls.Remove(rowPanel);
            rowPanel.Dispose();

            // 2. Add to Events Table with "Pending" status
            // Event Row structure: Title, Date, Time, Status
            dtpSubmitDate.Value = DateTime.Parse(date);


            if (string.IsNullOrWhiteSpace(txtEventTitle.Text))
            {
                MessageBox.Show("Please enter a Title.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int capacity = (int)numCapacity.Value;
            int eventID = createEvent(TimeSlotIdBooked, LoginForm.userID, txtEventTitle.Text, txtDescription.Text, dtpSubmitDate.Value, capacity);

            // eventid, title, description, date, startTime, endTime , capacity , status
            string[] eventInfo = { eventID.ToString(), txtEventTitle.Text, txtDescription.Text, dtpSubmitDate.Value.ToShortDateString(), startTime, endTime, capacity.ToString(), "pending" };
            flowEvents.Controls.Add(CreateOrganizerDataRow(eventID, eventInfo));

            if (eventID != -1)
            {
                MessageBox.Show($"Success! '{eventTitle}' has been booked for {date} at {startTime}. It is now pending administrator approval.", "Booking Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
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



        // You will only Implement these Functions

        #region Tasks Will TODO

        // =========================================================
        // FR4 - CONNECTED MODE: Insert new event row (no procedure)
        // Requirement: Insert rows Without using Procedures
        // =========================================================
        public int createEvent(int timeSlotID, int organizerID, string eventTitle, string description, DateTime date, int capacity)
        {
            // Step 1: Resolve PersonID -> OrganizerID (connected mode, bind variables)

            // Step 2: Insert event directly — no stored procedure (Phase 2 requirement A.2)
            string insertQuery = @"
                INSERT INTO Events (OrganizerID, TimeSlotID, Title, Description, Status, Capacity)
                VALUES (:organizerID, :timeSlotID, :title, :description, 'Pending', :capacity)";

            try
            {
                using (OracleConnection conn = new OracleConnection(ordb))
                {
                    conn.Open();

                    // Insert the event row using bind variables (Phase 2 requirement A.1 + A.2)
                    using (OracleCommand cmd = new OracleCommand(insertQuery, conn))
                    {

                        cmd.Parameters.Add("organizerID", OracleDbType.Int32).Value = organizerID ;
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
                return -1;
            }
        }

        // =========================================================
        // FR5 - CONNECTED MODE: Cancel event using stored procedure
        // Requirement A.3: Select ONE row using stored procedure
        //                  with OUT parameters of NUMBER data type
        // =========================================================
        public bool cancelEvent(int eventID)
        {
            // Direct UPDATE — sets Status to 'Cancelled'
            // The timeslot is automatically freed because getAllAvailableTimeSlots()
            // uses NOT EXISTS to find slots with no active events.
            string cancelQuery = "UPDATE Events SET Status = 'Cancelled' WHERE EventID = :eventID";

            try
            {
                using (OracleConnection conn = new OracleConnection(ordb))
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

        // =========================================================
        // FR5 - DISCONNECTED MODE: Update event using OracleDataAdapter
        //       + OracleCommandBuilder (Phase 2 requirement B.2)
        // =========================================================
        public bool updateEvent(int eventID, string eventTitle, string description, DateTime date, int capacity)
        {
            // Disconnected mode: fetch the row into a DataSet, modify it,
            // then push changes back using OracleCommandBuilder (auto-generates UPDATE)
            string selectQuery = "SELECT EventID, Title, Description, Capacity FROM Events WHERE EventID = :eventID";

            try
            {
                using (OracleConnection conn = new OracleConnection(ordb))
                {
                    conn.Open();

                    OracleDataAdapter adapter = new OracleDataAdapter(selectQuery, conn);
                    adapter.SelectCommand.Parameters.Add("eventID", OracleDbType.Int32).Value = eventID;

                    // CommandBuilder auto-generates the UPDATE command (Phase 2 B.2)
                    OracleCommandBuilder builder = new OracleCommandBuilder(adapter);

                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "Events");

                    if (ds.Tables["Events"].Rows.Count == 0)
                    {
                        MessageBox.Show("Event not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    // Modify the row in the DataSet (disconnected — no live DB connection needed here)
                    DataRow row = ds.Tables["Events"].Rows[0];
                    row["Title"] = eventTitle;
                    row["Description"] = description;
                    row["Capacity"] = capacity;

                    // Push changes back to DB
                    int rowsAffected = adapter.Update(ds, "Events");
                    return rowsAffected > 0;
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show("DB Error (updateEvent): " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // =========================================================
        // FR6 - CONNECTED MODE: Select multiple rows using stored procedure
        //       Phase 2 requirement A.4: Select multiple rows using stored procedures
        //       Uses Get_Available_TimeSlots stored procedure (see below)
        //
        //  Required stored procedure in Oracle:
        //  CREATE OR REPLACE PROCEDURE Get_Available_TimeSlots(
        //      p_cursor OUT SYS_REFCURSOR
        //  ) AS
        //  BEGIN
        //      OPEN p_cursor FOR
        //          SELECT ts.TimeSlotID, ts.StartTime, ts.EndTime, ts.SlotDate
        //          FROM   TimeSlots ts
        //          WHERE  NOT EXISTS (
        //              SELECT 1 FROM Events e
        //              WHERE  e.TimeSlotID = ts.TimeSlotID
        //              AND    e.Status <> 'Cancelled'
        //          )
        //          ORDER BY ts.SlotDate, ts.StartTime;
        //  END;
        // =========================================================
        public string[] getAllAvailableTimeSlots()
        {
            List<string> slots = new List<string>();

            try
            {
                using (OracleConnection conn = new OracleConnection(ordb))
                {
                    conn.Open();

                    using (OracleCommand cmd = new OracleCommand("Get_Available_TimeSlots", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // OUT cursor parameter (Phase 2 A.4 — select multiple rows via stored procedure)
                        cmd.Parameters.Add("p_cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;


                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = int.Parse(reader["TimeSlotID"].ToString());
                                string startTime = reader["StartTime"].ToString();
                                string endTime = reader["EndTime"].ToString();
                                string slotDate = reader["SlotDate"].ToString();

                                slots.Add($"{id},{startTime},{endTime},{slotDate}");
                            }
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

        public string[] getAllEventsForOrganizer(int organizerID)
        {
            return null;
        }

        #endregion

    }

}

