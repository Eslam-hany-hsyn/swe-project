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
        string ordb = "data source = orcl; user id =scott; password=scott;";
        public AttendeeForm() :base()
        {
            InitializeComponent();
        }

        public static List<string> GlobalNotifications = new List<string>();

        List<Button> btnsCards = new List<Button>();
        List<Panel> panelsCards = new List<Panel>();

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
            if (txt_Search.Text != SearchPlaceholder)
            {
                string[] results = Filter_Results(txt_Search.Text, dtp_StartDate.Value, dtp_EndDate.Value);
                RefreshEventList(results);
            }
        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            string title = txt_Search.Text == SearchPlaceholder ? "" : txt_Search.Text;
            string[] results = Filter_Results(title, dtp_StartDate.Value, dtp_EndDate.Value);
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

        private Panel CreateEventCard(int eventId,string title,string descripation, string dateInfo, string time,string capacity, string status, Image eventImage)
        {
            // 1. Create Main Card Panel (Optimized for smaller size, 75% of old 280x305)
            Panel pnlCard = new Panel
            {
                Size = new Size(210, 230),
                BackColor = Color.White,
                Margin = new Padding(5),
                Tag = eventId,
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

            // 6. Action Buttons (scaled to 75%)
            Button btnJoin = new Button
            {
                Text = "Join",
                BackColor = Color.FromArgb(40, 167, 69),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 7.5F, FontStyle.Bold),
                Location = new Point(10, 48),
                Size = new Size(90, 26),
                Cursor = Cursors.Hand,
                Tag = eventId,
            };
            btnJoin.FlatAppearance.BorderSize = 0;
            btnJoin.Click += BtnJoin_Click;

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
                AccessibleDescription = (eventId+","+ title + ","+ descripation + ","+ dateInfo + ","+ time + ","+ capacity+","+ status),
            };
            btnDetails.FlatAppearance.BorderSize = 0;
            btnDetails.Click += BtnDetails_Click;

            // 7. Status Badge (scaled to 75%)
            Label lblStatus = new Label
            {
                Text = "  " + status,
                Font = new Font("Segoe UI", 7F, FontStyle.Bold),
                Location = new Point(52, 82),
                Size = new Size(105, 20),
                TextAlign = ContentAlignment.MiddleCenter
            };

            // Re-styling status based on text
            if (status.Contains("Registered")) { lblStatus.BackColor = Color.FromArgb(220, 245, 220); lblStatus.ForeColor = Color.Green; }
            else if (status.Contains("Full")) { lblStatus.BackColor = Color.FromArgb(255, 220, 220); lblStatus.ForeColor = Color.Red; }
            else { lblStatus.BackColor = Color.RoyalBlue; lblStatus.ForeColor = Color.Snow; }

            // Assemble components
            pnlInfo.Controls.Add(lblTitle);
            pnlInfo.Controls.Add(lblDate);
            pnlInfo.Controls.Add(btnJoin);
            pnlInfo.Controls.Add(btnDetails);
            pnlInfo.Controls.Add(lblStatus);
            pnlCard.Controls.Add(pnlInfo);
            pnlCard.Controls.Add(pnlImage);

            // Add Component to lists
            btnsCards.Add(btnJoin);
            btnsCards.Add(btnDetails);
            panelsCards.Add(pnlCard);
            return pnlCard;
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
           
        }

        private void BtnJoin_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int eventId = (int)btn.Tag;
            string commandStatus = btn.Text == "Join" ? "register" : "cancel";
            
            // Assuming dummy attendee ID 101 for UI mock mapping
            RegisterOrCancellation(eventId, LoginForm.PersonID, commandStatus);

            if (commandStatus == "register")
            {
                btn.Text = "Cancel";
                btn.BackColor = Color.FromArgb(220, 53, 69);
                MessageBox.Show($"Successfully Joined Event {eventId}!", "Registration Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                btn.Text = "Join";
                btn.BackColor = Color.FromArgb(40, 167, 69);
                MessageBox.Show($"Successfully Cancelled Event {eventId}.", "Registration Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnDetails_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int eventId = (int)btn.Tag;

            string[] parts = btn.AccessibleDescription.Split(',');


            string title = parts[1];
            string descripation = parts[2];
            string date = parts[3];
            string time = parts[4];

            using (Forms.Attendees.EventsDetialsDialog dialog = new Forms.Attendees.EventsDetialsDialog(title, date,time, descripation ))
            {
                dialog.ShowDialog();
            }
        }

        private void RefreshEventList(string[] eventStrings)

        {
            flowLayoutPanel_Cards.Controls.Clear();
            btnsCards.Clear();
            panelsCards.Clear();

            if (eventStrings == null) return;

            foreach (string eventRaw in eventStrings)
            {
                string[] parts = eventRaw.Split(',');
                if (parts.Length >= 7)
                {
                    int id = int.Parse(parts[0]);
                    string title = parts[1];
                    string descripation = parts[2];
                    string date = parts[3];
                    string time = parts[4];
                    string capacity = parts[5];
                    string status = parts[6];

                    Panel Card = CreateEventCard(id, title, descripation, date, time, capacity, status, Resources.background5);
                    Card.AccessibleDescription = eventRaw;
                    // Default image for now
                    flowLayoutPanel_Cards.Controls.Add(Card);
               
                }
            }
        }

        #region AttendeeInterface Implementations

        public string[] Filter_Results(string title, DateTime startDate, DateTime endDate)
        {

            // Placeholder: Returning simulated filter results
            List<string> results = new List<string>();

            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();
                using (OracleCommand cmd = new OracleCommand("Filter_Results_Events", con))
                {

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("p_title", OracleDbType.Varchar2).Value =
                    ( string.IsNullOrEmpty(title) || title == SearchPlaceholder ) ? (object)DBNull.Value : title;
                    cmd.Parameters.Add("p_startDate", OracleDbType.Date).Value = startDate.Date;
                    cmd.Parameters.Add("p_endDate", OracleDbType.Date).Value = endDate.Date;
                    cmd.Parameters.Add("p_record", OracleDbType.RefCursor, ParameterDirection.Output);

                    OracleDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        string row = string.Format("{0},{1},{2},{3},{4},{5},{6}",
                            dr["EVENTID"].ToString(),
                            dr["TITLE"].ToString(),
                            dr["DESCRIPTION"].ToString(),
                            Convert.ToDateTime(dr["SLOTDATE"]).ToShortDateString(),
                            dr["STARTTIME"].ToString() + " - " + dr["ENDTIME"].ToString(),
                            dr["CAPACITY"].ToString(),
                            dr["STATUS"].ToString()
                        );
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

        public void RegisterOrCancellation(int eventID, int attendeeID, string status)
        {
            // Placeholder: Insert registration database updating logic here
            try
            {
                if (con.State != ConnectionState.Open) con.Open();

                using (OracleCommand cmd = new OracleCommand("Register_Or_Cancel_Event", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    
                    cmd.Parameters.Add("p_eventID", OracleDbType.Int32).Value = eventID;
                    cmd.Parameters.Add("p_attendeeID", OracleDbType.Int32).Value = attendeeID;
                    cmd.Parameters.Add("p_status", OracleDbType.Varchar2).Value = status.ToLower();
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
            // Placeholder: Retrieve approved events for display
            List<string> results = new List<string>();

            try
            {
                if (con.State != ConnectionState.Open) con.Open();

                using (OracleCommand cmd = new OracleCommand("Get_All_Approved_Events", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("p_record", OracleDbType.RefCursor, ParameterDirection.Output);

                    OracleDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        string row = string.Format("{0},{1},{2},{3},{4},{5},{6}",
                            dr["EVENTID"].ToString(),
                            dr["TITLE"].ToString(),
                            dr["DESCRIPTION"].ToString(),
                            Convert.ToDateTime(dr["SLOTDATE"]).ToShortDateString(),
                            dr["STARTTIME"].ToString() + " - " + dr["ENDTIME"].ToString(),
                            dr["CAPACITY"].ToString(),
                            dr["STATUS"].ToString()
                        );
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
                if (con.State == ConnectionState.Open) con.Close();
            }
            return results.ToArray();
        }

        #endregion
    }
}
