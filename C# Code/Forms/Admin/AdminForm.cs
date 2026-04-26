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

namespace Registration_Form
{
    public partial class AdminForm : Form, AdminInterface
    {
        string connStr = "Data Source=orcl;User Id=scott;Password=123;";
        public AdminForm()
        {
            InitializeComponent();

        }
        List<Control> Events = new List<Control>();
        private int _nextTimeSlotId = 4;

        private void AdminForm_Load(object sender, EventArgs e)
        {


            // Load Mock Data for Time Slots Table on page 2
            string[] ts1 = { "10:00 AM", "12:00 PM", "Oct 20, 2024", "Free" };
            flowTimeSlots.Controls.Add(CreateTimeSlotDataRow(1, ts1));

            string[] ts2 = { "01:00 PM", "03:00 PM", "Oct 21, 2024", "Booked" };
            flowTimeSlots.Controls.Add(CreateTimeSlotDataRow(2, ts2));

            string[] ts3 = { "04:00 PM", "06:00 PM", "Oct 22, 2024", "Free" };
            flowTimeSlots.Controls.Add(CreateTimeSlotDataRow(3, ts3));
            foreach (string raw in getAllAppendingEvent())
            {
                string[] parts = raw.Split(',');
                if (parts.Length >= 5)
                {
                    int id = int.Parse(parts[0]);
                    string[] uiData = { parts[1], parts[2], parts[3], parts[4] };
                    flowLayoutPanel_Events.Controls.Add(CreateAdminDataRow(id, uiData));
                }
            }

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
            bool isCreated = createTimeSlots(1, dtp_Date.Value, dtp_StartTime.Value.ToString("HH:mm"), dtp_EndTime.Value.ToString("HH:mm"));

            if (isCreated)
                MessageBox.Show("Time Slot successfully requested!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Time Slot rejected request", "Fails", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }


        // You will only Implement these Functions
        #region Tasks Will TODO 

        public bool createTimeSlots(int admminID, DateTime date, string startTime, string endTime)
        {
            if (string.IsNullOrWhiteSpace(startTime) || string.IsNullOrWhiteSpace(endTime))
                return false;

            try
            {
                using (OracleConnection con = new OracleConnection(connStr))
                {
                    con.Open();

                    int adminID = 1;



                    string insertSql = @"
    INSERT INTO TimeSlots (AdminID, StartTime, EndTime, SlotDate)
    VALUES (:adminID,
            TO_DATE(TO_CHAR(:slotDate, 'DD/MM/YYYY') || ' ' || :startTime, 'DD/MM/YYYY HH24:MI'),
            TO_DATE(TO_CHAR(:slotDate, 'DD/MM/YYYY') || ' ' || :endTime,   'DD/MM/YYYY HH24:MI'),
            :slotDate)";

                    using (OracleCommand cmd = new OracleCommand(insertSql, con))
                    {
                        cmd.BindByName = true;
                        cmd.Parameters.Add(":adminID", OracleDbType.Int32).Value = adminID;
                        cmd.Parameters.Add(":slotDate", OracleDbType.Date).Value = date.Date;
                        cmd.Parameters.Add(":startTime", OracleDbType.Varchar2).Value = startTime;
                        cmd.Parameters.Add(":endTime", OracleDbType.Varchar2).Value = endTime;

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            string[] rowData = { startTime, endTime, date.ToString("MMM dd, yyyy"), "Free" };
                            flowTimeSlots.Controls.Add(CreateTimeSlotDataRow(_nextTimeSlotId++, rowData));
                            return true;
                        }
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating time slot: " + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public string[] getAllAppendingEvent()
        {
            var results = new List<string>();

            try
            {
                using (OracleConnection con = new OracleConnection(connStr))
                {
                    con.Open();

                    using (OracleCommand cmd = new OracleCommand("sp_GetPendingEvents", con))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.Add("p_cursor", OracleDbType.RefCursor)
                                      .Direction = System.Data.ParameterDirection.Output;

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                string row = string.Join(",",
                                    reader["EVENTID"].ToString(),
                                    reader["TITLE"].ToString(),
                                    reader["SLOTDATE"].ToString(),
                                    reader["STARTTIME"].ToString(),
                                    reader["STATUS"].ToString()
                                );
                                results.Add(row);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading pending events: " + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return results.ToArray();
        }

        public bool updateEventStatus(int eventID, string status)
        {
            if (eventID <= 0 || string.IsNullOrWhiteSpace(status))
                return false;

            try
            {
                using (OracleConnection con = new OracleConnection(connStr))
                {
                    con.Open();

                    int organizerID = -1;
                    string eventTitle = "";

                    using (OracleCommand cmd = new OracleCommand("sp_GetEventOrganizerID", con))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.Add("p_eventID", OracleDbType.Int32).Value = eventID;

                        cmd.Parameters.Add("p_organizerID", OracleDbType.Int32, 0, "p_organizerID")
                                      .Direction = System.Data.ParameterDirection.Output;

                        cmd.Parameters.Add("p_title", OracleDbType.Varchar2, 200, "p_title")
                                      .Direction = System.Data.ParameterDirection.Output;

                        cmd.ExecuteNonQuery();

                        Oracle.DataAccess.Types.OracleDecimal oraVal =
                        (Oracle.DataAccess.Types.OracleDecimal)cmd.Parameters["p_organizerID"].Value;
                        organizerID = (int)oraVal.Value;
                        eventTitle = cmd.Parameters["p_title"].Value.ToString();
                    }

                    if (organizerID == -1) return false;


                    string updateSql = "UPDATE Events SET Status = :status WHERE EventID = :eventID";

                    using (OracleCommand cmd = new OracleCommand(updateSql, con))
                    {
                        cmd.Parameters.Add(":status", OracleDbType.NVarchar2).Value = status;
                        cmd.Parameters.Add(":eventID", OracleDbType.Int32).Value = eventID;
                        cmd.ExecuteNonQuery();
                    }


                    if (status == "Approved")
                    {

                        AttendeeForm.GlobalNotifications.Add(
                            $"NEW EVENT: '{eventTitle}' is now approved and open for registration!");
                    }
                    else if (status == "Denied")
                    {
                        // FR9 — Notify denial
                        AttendeeForm.GlobalNotifications.Add(
                            $"DENIED: '{eventTitle}' was denied by the administrator.");
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating event: " + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public string[] getAllApprovedEventTitles()
        {
            var results = new List<string>();

            try
            {
                using (OracleConnection con = new OracleConnection(connStr))
                {
                    con.Open();

                    // A.1 — SELECT using bind variable :status
                    string sql = @"
                SELECT e.EventID,
                       e.Title,
                       TO_CHAR(ts.SlotDate, 'DD/MM/YYYY') AS SlotDate
                FROM   Events    e
                JOIN   TimeSlots ts ON e.TimeSlotID = ts.TimeSlotID
                WHERE  e.Status = :status
                ORDER  BY ts.SlotDate ASC";

                    using (OracleCommand cmd = new OracleCommand(sql, con))
                    {
                        // Bind variable — passes 'Approved' safely without string concatenation
                        cmd.Parameters.Add(":status", OracleDbType.NVarchar2).Value = "Approved";

                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string row = string.Join(",",
                                    reader["EVENTID"].ToString(),
                                    reader["TITLE"].ToString(),
                                    reader["SLOTDATE"].ToString()
                                );
                                results.Add(row);
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading approved events: " + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return results.ToArray();
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
        #endregion
    }
}
