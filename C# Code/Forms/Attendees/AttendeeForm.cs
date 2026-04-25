using Registration_Form.Properties;
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
    public partial class AttendeeForm : Form, AttendeeInterface
    {
        private const string SearchPlaceholder = "🔍  Search events...";
        
        OracleConnection con;
        string ordb = "data source = orcl; user id =hr; password=123;";
        public AttendeeForm() :base()
        {
            InitializeComponent();
        }

        public static List<string> GlobalNotifications = new List<string>();

        private void txt_Search_Enter(object sender, EventArgs e)
        {
            TextBox searchBox = (TextBox )sender;
            BaseForm.PlaceHolder(searchBox, SearchPlaceholder, false);
        }

        private void txt_Search_Leave(object sender, EventArgs e)
        {
            TextBox searchBox = (TextBox)sender;
            BaseForm.PlaceHolder(searchBox, SearchPlaceholder, true);
        }

        private void txt_Search_TextChanged(object sender, EventArgs e) 
        {
            if (txt_Search.Text != SearchPlaceholder || string.IsNullOrEmpty(txt_Search.Text.Trim(' ')))
            {
                string[] results = Filter_Results(txt_Search.Text,LoginForm.userID);
                RefreshEventList(results);
            }
        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            string[] results = Filter_Results_By_Date(dtp_StartDate.Value,LoginForm.userID);
            
            RefreshEventList(results);
        }

        private void btn_Bell_Click(object sender, EventArgs e)
        {
            if (listBox_Notifications.Visible)
            {
                listBox_Notifications.Visible = false;
            }
            else
            {
                listBox_Notifications.Items.Clear();
                if (GlobalNotifications.Count == 0)
                {
                    listBox_Notifications.Items.Add("No new notifications.");
                }
                else
                {
                    foreach (var note in GlobalNotifications)
                    {
                        listBox_Notifications.Items.Add(note);
                    }
                }
                
                listBox_Notifications.BringToFront();
                listBox_Notifications.Visible = true;
            }
        }

        private void btn_FilterStartTime_Click(object sender, EventArgs e)
        {
            if (cmb_Time.SelectedItem == null)
            {
                MessageBox.Show("Please select a time first.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string selectedTimeStr = cmb_Time.SelectedItem.ToString();
            DateTime selectedTime = DateTime.ParseExact(selectedTimeStr, "hh:00 tt", null);

            string[] results = Filter_Results_By_Time(selectedTime, LoginForm.userID);
            RefreshEventList(results);
        }

        private void AttendeeForm_Load_1(object sender, EventArgs e)
        {
            con = new OracleConnection(ordb);
            con.Open();

            string[] approvedEvents = getAllApprovedEvent();
            if (approvedEvents != null && approvedEvents.Length > 0)
            {
                RefreshEventList(approvedEvents);
            }
            PopulateTimeComboBox();
        }

        private void PopulateTimeComboBox()
        {
            cmb_Time.Items.Clear();
            for (int h = 0; h < 24; h++)
            {
                DateTime dt = new DateTime(2000, 1, 1, h, 0, 0);
                cmb_Time.Items.Add(dt.ToString("hh:00 tt"));
            }
        }

        private void RefreshEventList(string[] eventStrings)
        {
            flowLayoutPanel_Cards.Controls.Clear();

            if (eventStrings == null) return;

            foreach (string eventRaw in eventStrings)
            {
                string[] parts = eventRaw.Split(',');
                if (parts.Length >= 7)
                {
                    // "eventID,OrganizerName,title,Description,eventTime,eventDate,actualCapacity,capacity,attendeeStatus"  

                    int id = int.Parse(parts[0]);
                    string organizerName = parts[1];
                    string title = parts[2];
                    string descripation = parts[3];
                    string time = parts[4];
                    string date = parts[5];
                    int actualCapacity = int.Parse(parts[6]);
                    int capacity = int.Parse(parts[7]);
                    string statusAttendee = parts[8];

                    Panel Card = CreateEventCard(id,organizerName ,title, descripation, date, time, actualCapacity, capacity, statusAttendee, Resources.background5);
                    Card.AccessibleDescription = eventRaw;
                    // Default image for now
                    flowLayoutPanel_Cards.Controls.Add(Card);
               
                }
            }
        }
        private Panel CreateEventCard(int eventId,string organizerName, string title,string descripation, string dateInfo, string time,int actualCapacity, int capacity, string statusAttendee, Image eventImage)
        {
            // 1. Create Main Card Panel (Optimized for smaller size, 75% of old 280x305)
            Panel pnlCard = new Panel
            {
                Size = new Size(210, 230),
                BackColor = Color.White,
                Margin = new Padding(5),
            };

            // 2. Image Panel (Top)
            Panel pnlImage = new Panel
            {
                Size = new Size(210, 100),
                Dock = DockStyle.Top,
                BackgroundImage = eventImage,
                BackgroundImageLayout = ImageLayout.Stretch
            };

            // 3. Info Panel (Bottom)
            Panel pnlInfo = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(8)
            };

            // 4. Title Label (scaled to 75%)
            Label lblTitle = new Label
            {
                Text = title,
                Font = new Font("Segoe UI", 8.5F, FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 30, 60),
                Location = new Point(52, 6),
                Size = new Size(148, 20),
                AutoEllipsis = true
            };

            // 5. Date Label (scaled to 75%)
            Label lblDate = new Label
            {
                Text = "📅 " + dateInfo,
                Font = new Font("Segoe UI", 7.5F),
                ForeColor = Color.Gray,
                Location = new Point(60, 24),
                Size = new Size(140, 17)
            };

            Button btnDetails = new Button
            {
                Text = "Details",
                BackColor = Color.FromArgb(70, 130, 220),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 7.5F, FontStyle.Bold),
                Location = new Point(110, 48),
                Size = new Size(90, 26),
                Cursor = Cursors.Hand,
                Tag = eventId,
                AccessibleDescription = (eventId + "," + organizerName + "," + title + "," + descripation + "," + dateInfo + "," + time + "," + actualCapacity + "," + capacity + "," + statusAttendee),
            };
            btnDetails.FlatAppearance.BorderSize = 0;
            btnDetails.Click += BtnDetails_Click;

            bool st = (statusAttendee.ToLower() == "new event");
            // 6. Action Buttons (scaled to 75%)
            Button btnJoin = new Button
            {
                Text = st ? "Join" : "Cancel",
                BackColor = st ? Color.FromArgb(40, 167, 69) : Color.FromArgb(255, 220, 220),
                ForeColor = st ? Color.White: Color.Red,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 7.5F, FontStyle.Bold),
                Location = new Point(10, 48),
                Size = new Size(90, 26),
                Cursor = Cursors.Hand,
                Tag = eventId,
            };
            btnJoin.FlatAppearance.BorderSize = 0;
            btnJoin.Click += BtnJoin_Click;

            string actualStatus = "";

            if (statusAttendee.ToLower() == "new event" && actualCapacity < capacity)
                actualStatus = "Available";
            else if (statusAttendee.ToLower() == "registered")
                actualStatus = "Registered";
            else if (actualCapacity == capacity)
                actualStatus = "Full";

            // 7. Status Badge (scaled to 75%)
            Label lblStatus = new Label
            {
                Text = actualStatus,
                Font = new Font("Segoe UI", 7F, FontStyle.Bold),
                Location = new Point(52, 82),
                Size = new Size(105, 20),
                TextAlign = ContentAlignment.MiddleCenter
            };

            // Re-styling status based on text
            if (actualStatus == ("Registered")) { lblStatus.BackColor = Color.FromArgb(220, 245, 220); lblStatus.ForeColor = Color.Green; }
            else if (actualStatus == ("Full")) { lblStatus.BackColor = Color.FromArgb(255, 220, 220); lblStatus.ForeColor = Color.Red; }
            else { lblStatus.BackColor = Color.RoyalBlue; lblStatus.ForeColor = Color.Snow; }

            // Assemble components
            pnlInfo.Controls.Add(lblTitle);
            pnlInfo.Controls.Add(lblDate);
            pnlInfo.Controls.Add(btnJoin);
            pnlInfo.Controls.Add(btnDetails);
            pnlInfo.Controls.Add(lblStatus);
            pnlCard.Controls.Add(pnlInfo);
            pnlCard.Controls.Add(pnlImage);


            return pnlCard;
        }
        


        private void BtnJoin_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int eventId = (int)btn.Tag;

            if (btn.Text == "Join")
            {
                RegisterOrCancellation(eventId, LoginForm.userID, "join");
                btn.Text = "Cancel";
                btn.BackColor = Color.FromArgb(255, 220, 220);
                btn.ForeColor = Color.Red;
                MessageBox.Show($"Successfully Joined Event {eventId}!", "Registration Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                RegisterOrCancellation(eventId, LoginForm.userID, "cancel");
                btn.Text = "Join";
                btn.BackColor = Color.FromArgb(40, 167, 69);
                btn.ForeColor = Color.White;
                MessageBox.Show($"Successfully Cancelled Event {eventId}.", "Registration Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            // Refresh the event list to update the capacity and statuses
            string[] results = getAllApprovedEvent();
            RefreshEventList(results);
        }

        private void BtnDetails_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int eventId = (int)btn.Tag;

            string[] parts = btn.AccessibleDescription.Split(',');

            //organizer, title, desc, dateInfo, eventTime, Actualcapacity, capacity
            string organizerName = parts[1];
            string title = parts[2];
            string descripation = parts[3];
            string date = parts[4];
            string time = parts[5];
            string Remaining = (int.Parse(parts[7]) - int.Parse(parts[6])).ToString();

            using (Forms.Attendees.EventsDetialsDialog dialog = new Forms.Attendees.EventsDetialsDialog(title, organizerName, date,time, descripation, Remaining))
            {
                dialog.ShowDialog();
            }
        }

        #region AttendeeInterface Implementations

        public string[] Filter_Results(string title, int p_attendeeid)
        {
            List<string> results = new List<string>();

            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();

                using (OracleCommand cmd = new OracleCommand("Filter_Results_Events", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("p_title", OracleDbType.Varchar2).Value =
                        (string.IsNullOrEmpty(title) || title == SearchPlaceholder)
                        ? (object)DBNull.Value
                        : title;

                    cmd.Parameters.Add("p_attendeeid", OracleDbType.Int32).Value = p_attendeeid;

                    cmd.Parameters.Add("p_record", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    OracleDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {

                        string eventID = dr["EVENTID"].ToString();
                        string organizer = dr["ORGANIZERNAME"].ToString();
                        string title1 = dr["TITLE"].ToString();
                        string desc = dr["DESCRIPTION"].ToString();

                        string eventDate = dr["EVENTDATE"].ToString();
                        string eventTime = dr["EVENTTIME"].ToString();

                        string capacity = dr["CAPACITY"].ToString();
                        string statusAttendee = dr["ATTENDEESTATUS"].ToString();

                        int id = int.Parse(eventID);
                        int Actualcapacity = Get_Total_Registered(id);
                        string row = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8}",
                            eventID, organizer, title1, desc, eventTime, eventDate, Actualcapacity, capacity, statusAttendee);

                        results.Add(row);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering results: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }

            return results.ToArray();
        }
        
        public string[] Filter_Results_By_Date(DateTime p_date, int p_attendeeid)
        {

            List<string> results = new List<string>();

            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();

                using (OracleCommand cmd = new OracleCommand("Filter_Results_By_Date", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("p_date", OracleDbType.Date).Value = p_date.Date;

                    cmd.Parameters.Add("p_attendeeid", OracleDbType.Int32).Value = p_attendeeid;

                    cmd.Parameters.Add("p_record", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    OracleDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {

                        string eventID = dr["EVENTID"].ToString();
                        string organizer = dr["ORGANIZERNAME"].ToString();
                        string title1 = dr["TITLE"].ToString();
                        string desc = dr["DESCRIPTION"].ToString();

                        string eventDate = dr["EVENTDATE"].ToString();
                        string eventTime = dr["EVENTTIME"].ToString();

                        string capacity = dr["CAPACITY"].ToString();
                        string statusAttendee = dr["ATTENDEESTATUS"].ToString();
                        int id = int.Parse(eventID);
                        int Actualcapacity = Get_Total_Registered(id);

                        string row = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8}",
                            eventID, organizer, title1, desc, eventTime, eventDate, Actualcapacity, capacity, statusAttendee);

                        results.Add(row);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering results: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }

            return results.ToArray();
        }

        public string[] Filter_Results_By_Time(DateTime p_startTime, int p_attendeeid)
        {
            List<string> results = new List<string>();

            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();

                using (OracleCommand cmd = new OracleCommand("Filter_Results_By_Time", con))
                {

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("p_start_time", OracleDbType.Date).Value = p_startTime;

                    cmd.Parameters.Add("p_attendeeid", OracleDbType.Int32).Value = p_attendeeid;

                    cmd.Parameters.Add("p_record", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    OracleDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {

                        string eventID = dr["EVENTID"].ToString();
                        string organizer = dr["ORGANIZERNAME"].ToString();
                        string title1 = dr["TITLE"].ToString();
                        string desc = dr["DESCRIPTION"].ToString();

                        string eventDate = dr["EVENTDATE"].ToString();
                        string eventTime = dr["EVENTTIME"].ToString();

                        string capacity = dr["CAPACITY"].ToString();
                        string statusAttendee = dr["ATTENDEESTATUS"].ToString();

                        int id = int.Parse(eventID);
                        int Actualcapacity = Get_Total_Registered(id);
                        string row = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8}",
                            eventID, organizer, title1, desc, eventTime, eventDate, Actualcapacity, capacity, statusAttendee);

                        results.Add(row);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering results: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();


            }

            return results.ToArray();
        }
      
        public void RegisterOrCancellation(int eventID, int attendeeID, string action)
        {
            try
            {
                if (con.State != ConnectionState.Open) con.Open();

                using (OracleCommand cmd = new OracleCommand("Register_Or_Cancel_Event", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    
                    cmd.Parameters.Add("p_eventID", OracleDbType.Int32).Value = eventID;
                    cmd.Parameters.Add("p_attendeeID", OracleDbType.Int32).Value = attendeeID;
                    cmd.Parameters.Add("p_action", OracleDbType.Varchar2).Value = action.ToLower();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating registration status: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            { 
                if (con.State == ConnectionState.Open) con.Close();
            }
        }

        public string[] getAllApprovedEvent()
        {
            List<string> results = new List<string>();

            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();

                using (OracleCommand cmd = new OracleCommand("Get_All_Approved_Events", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("p_attendeeid", OracleDbType.Int32).Value = LoginForm.userID;

                    cmd.Parameters.Add("p_record", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    OracleDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {

                        string eventID = dr["EVENTID"].ToString();
                        string organizer = dr["ORGANIZERNAME"].ToString();
                        string title1 = dr["TITLE"].ToString();
                        string desc = dr["DESCRIPTION"].ToString();

                        string eventDate = dr["EVENTDATE"].ToString();
                        string eventTime = dr["EVENTTIME"].ToString();

                        string capacity = dr["CAPACITY"].ToString();
                        string statusAttendee = dr["ATTENDEESTATUS"].ToString();

                        int id = int.Parse(eventID);
                        int Actualcapacity = Get_Total_Registered(id);
                        string row = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8}",
                            eventID, organizer, title1, desc, eventTime, eventDate, Actualcapacity, capacity, statusAttendee);

                        results.Add(row);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading initial events: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }

            return results.ToArray();
        }

        public int Get_Total_Registered(int eventID)
        {
            int total = 0;

            try
            {
                using (OracleConnection localCon = new OracleConnection(ordb))
                {
                    localCon.Open();
                    using (OracleCommand cmd = new OracleCommand("get_total_registered", localCon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // IN parameter
                        cmd.Parameters.Add("event_id", OracleDbType.Int32).Value = eventID;

                        // OUT parameter
                        cmd.Parameters.Add("total_registered", OracleDbType.Int32)
                            .Direction = ParameterDirection.Output;

                        cmd.ExecuteNonQuery();

                        // Read output value
                        if (cmd.Parameters["total_registered"].Value != DBNull.Value)
                            total = int.Parse(cmd.Parameters["total_registered"].Value.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting total registered: " + ex.Message);
            }
            return total;
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


