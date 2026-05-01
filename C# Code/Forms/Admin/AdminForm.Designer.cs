namespace Registration_Form
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlAdmin = new System.Windows.Forms.TabControl();
            this.tabPendingEvents = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel_Events = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.lbl_H_Title = new System.Windows.Forms.Label();
            this.lbl_H_Date = new System.Windows.Forms.Label();
            this.lbl_H_Time = new System.Windows.Forms.Label();
            this.lbl_H_Status = new System.Windows.Forms.Label();
            this.lbl_H_Actions = new System.Windows.Forms.Label();
            this.tabTimeSlots = new System.Windows.Forms.TabPage();
            this.lbl_TS_Instruct = new System.Windows.Forms.Label();
            this.lbl_TS_Date = new System.Windows.Forms.Label();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_TS_Start = new System.Windows.Forms.Label();
            this.dtp_StartTime = new System.Windows.Forms.DateTimePicker();
            this.lbl_TS_End = new System.Windows.Forms.Label();
            this.dtp_EndTime = new System.Windows.Forms.DateTimePicker();
            this.btn_CreateTimeSlot = new System.Windows.Forms.Button();
            this.pnl_TSHeader = new System.Windows.Forms.Panel();
            this.lbl_TSColStart = new System.Windows.Forms.Label();
            this.lbl_TSColEnd = new System.Windows.Forms.Label();
            this.lbl_TSColDate = new System.Windows.Forms.Label();
            this.lbl_TSColStatus = new System.Windows.Forms.Label();
            this.flowTimeSlots = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbxStatus = new System.Windows.Forms.ComboBox();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbxEventTitle = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.crrepoAttendee = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crrepoOrg = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbxDate = new System.Windows.Forms.ComboBox();
            this.tabControlAdmin.SuspendLayout();
            this.tabPendingEvents.SuspendLayout();
            this.pnl_Header.SuspendLayout();
            this.tabTimeSlots.SuspendLayout();
            this.pnl_TSHeader.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAdmin
            // 
            this.tabControlAdmin.Controls.Add(this.tabPendingEvents);
            this.tabControlAdmin.Controls.Add(this.tabTimeSlots);
            this.tabControlAdmin.Controls.Add(this.tabPage1);
            this.tabControlAdmin.Controls.Add(this.tabPage2);
            this.tabControlAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdmin.Location = new System.Drawing.Point(0, 0);
            this.tabControlAdmin.Name = "tabControlAdmin";
            this.tabControlAdmin.SelectedIndex = 0;
            this.tabControlAdmin.Size = new System.Drawing.Size(921, 594);
            this.tabControlAdmin.TabIndex = 0;
            // 
            // tabPendingEvents
            // 
            this.tabPendingEvents.Controls.Add(this.flowLayoutPanel_Events);
            this.tabPendingEvents.Controls.Add(this.pnl_Header);
            this.tabPendingEvents.Location = new System.Drawing.Point(4, 37);
            this.tabPendingEvents.Name = "tabPendingEvents";
            this.tabPendingEvents.Padding = new System.Windows.Forms.Padding(15);
            this.tabPendingEvents.Size = new System.Drawing.Size(913, 553);
            this.tabPendingEvents.TabIndex = 0;
            this.tabPendingEvents.Text = "Pending Events";
            this.tabPendingEvents.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel_Events
            // 
            this.flowLayoutPanel_Events.AutoScroll = true;
            this.flowLayoutPanel_Events.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel_Events.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_Events.Location = new System.Drawing.Point(15, 60);
            this.flowLayoutPanel_Events.Name = "flowLayoutPanel_Events";
            this.flowLayoutPanel_Events.Size = new System.Drawing.Size(883, 478);
            this.flowLayoutPanel_Events.TabIndex = 1;
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(75)))));
            this.pnl_Header.Controls.Add(this.lbl_H_Title);
            this.pnl_Header.Controls.Add(this.lbl_H_Date);
            this.pnl_Header.Controls.Add(this.lbl_H_Time);
            this.pnl_Header.Controls.Add(this.lbl_H_Status);
            this.pnl_Header.Controls.Add(this.lbl_H_Actions);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(15, 15);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(883, 45);
            this.pnl_Header.TabIndex = 0;
            // 
            // lbl_H_Title
            // 
            this.lbl_H_Title.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_H_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_H_Title.Location = new System.Drawing.Point(0, 0);
            this.lbl_H_Title.Name = "lbl_H_Title";
            this.lbl_H_Title.Size = new System.Drawing.Size(228, 45);
            this.lbl_H_Title.TabIndex = 0;
            this.lbl_H_Title.Text = "Event Title";
            this.lbl_H_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_H_Date
            // 
            this.lbl_H_Date.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_H_Date.ForeColor = System.Drawing.Color.White;
            this.lbl_H_Date.Location = new System.Drawing.Point(228, 0);
            this.lbl_H_Date.Name = "lbl_H_Date";
            this.lbl_H_Date.Size = new System.Drawing.Size(137, 45);
            this.lbl_H_Date.TabIndex = 1;
            this.lbl_H_Date.Text = "Date";
            this.lbl_H_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_H_Time
            // 
            this.lbl_H_Time.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_H_Time.ForeColor = System.Drawing.Color.White;
            this.lbl_H_Time.Location = new System.Drawing.Point(365, 0);
            this.lbl_H_Time.Name = "lbl_H_Time";
            this.lbl_H_Time.Size = new System.Drawing.Size(137, 45);
            this.lbl_H_Time.TabIndex = 2;
            this.lbl_H_Time.Text = "Time";
            this.lbl_H_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_H_Status
            // 
            this.lbl_H_Status.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_H_Status.ForeColor = System.Drawing.Color.White;
            this.lbl_H_Status.Location = new System.Drawing.Point(502, 0);
            this.lbl_H_Status.Name = "lbl_H_Status";
            this.lbl_H_Status.Size = new System.Drawing.Size(137, 45);
            this.lbl_H_Status.TabIndex = 3;
            this.lbl_H_Status.Text = "Status";
            this.lbl_H_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_H_Actions
            // 
            this.lbl_H_Actions.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_H_Actions.ForeColor = System.Drawing.Color.White;
            this.lbl_H_Actions.Location = new System.Drawing.Point(639, 0);
            this.lbl_H_Actions.Name = "lbl_H_Actions";
            this.lbl_H_Actions.Size = new System.Drawing.Size(273, 45);
            this.lbl_H_Actions.TabIndex = 4;
            this.lbl_H_Actions.Text = "Actions";
            this.lbl_H_Actions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabTimeSlots
            // 
            this.tabTimeSlots.BackColor = System.Drawing.Color.White;
            this.tabTimeSlots.Controls.Add(this.lbl_TS_Instruct);
            this.tabTimeSlots.Controls.Add(this.lbl_TS_Date);
            this.tabTimeSlots.Controls.Add(this.dtp_Date);
            this.tabTimeSlots.Controls.Add(this.lbl_TS_Start);
            this.tabTimeSlots.Controls.Add(this.dtp_StartTime);
            this.tabTimeSlots.Controls.Add(this.lbl_TS_End);
            this.tabTimeSlots.Controls.Add(this.dtp_EndTime);
            this.tabTimeSlots.Controls.Add(this.btn_CreateTimeSlot);
            this.tabTimeSlots.Controls.Add(this.pnl_TSHeader);
            this.tabTimeSlots.Controls.Add(this.flowTimeSlots);
            this.tabTimeSlots.Location = new System.Drawing.Point(4, 37);
            this.tabTimeSlots.Name = "tabTimeSlots";
            this.tabTimeSlots.Padding = new System.Windows.Forms.Padding(15);
            this.tabTimeSlots.Size = new System.Drawing.Size(913, 553);
            this.tabTimeSlots.TabIndex = 1;
            this.tabTimeSlots.Text = "Manage Time Slots";
            // 
            // lbl_TS_Instruct
            // 
            this.lbl_TS_Instruct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_TS_Instruct.Location = new System.Drawing.Point(40, 38);
            this.lbl_TS_Instruct.Name = "lbl_TS_Instruct";
            this.lbl_TS_Instruct.Size = new System.Drawing.Size(374, 30);
            this.lbl_TS_Instruct.TabIndex = 0;
            this.lbl_TS_Instruct.Text = "Create a New System Time Slot";
            // 
            // lbl_TS_Date
            // 
            this.lbl_TS_Date.Location = new System.Drawing.Point(40, 100);
            this.lbl_TS_Date.Name = "lbl_TS_Date";
            this.lbl_TS_Date.Size = new System.Drawing.Size(120, 25);
            this.lbl_TS_Date.TabIndex = 1;
            this.lbl_TS_Date.Text = "Target Date:";
            // 
            // dtp_Date
            // 
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Date.Location = new System.Drawing.Point(180, 95);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(200, 33);
            this.dtp_Date.TabIndex = 2;
            // 
            // lbl_TS_Start
            // 
            this.lbl_TS_Start.Location = new System.Drawing.Point(40, 160);
            this.lbl_TS_Start.Name = "lbl_TS_Start";
            this.lbl_TS_Start.Size = new System.Drawing.Size(120, 25);
            this.lbl_TS_Start.TabIndex = 3;
            this.lbl_TS_Start.Text = "Start Time:";
            // 
            // dtp_StartTime
            // 
            this.dtp_StartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_StartTime.Location = new System.Drawing.Point(180, 155);
            this.dtp_StartTime.Name = "dtp_StartTime";
            this.dtp_StartTime.ShowUpDown = true;
            this.dtp_StartTime.Size = new System.Drawing.Size(200, 33);
            this.dtp_StartTime.TabIndex = 4;
            // 
            // lbl_TS_End
            // 
            this.lbl_TS_End.Location = new System.Drawing.Point(40, 220);
            this.lbl_TS_End.Name = "lbl_TS_End";
            this.lbl_TS_End.Size = new System.Drawing.Size(120, 25);
            this.lbl_TS_End.TabIndex = 5;
            this.lbl_TS_End.Text = "End Time:";
            // 
            // dtp_EndTime
            // 
            this.dtp_EndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_EndTime.Location = new System.Drawing.Point(180, 215);
            this.dtp_EndTime.Name = "dtp_EndTime";
            this.dtp_EndTime.ShowUpDown = true;
            this.dtp_EndTime.Size = new System.Drawing.Size(200, 33);
            this.dtp_EndTime.TabIndex = 6;
            // 
            // btn_CreateTimeSlot
            // 
            this.btn_CreateTimeSlot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btn_CreateTimeSlot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CreateTimeSlot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CreateTimeSlot.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_CreateTimeSlot.ForeColor = System.Drawing.Color.White;
            this.btn_CreateTimeSlot.Location = new System.Drawing.Point(99, 295);
            this.btn_CreateTimeSlot.Name = "btn_CreateTimeSlot";
            this.btn_CreateTimeSlot.Size = new System.Drawing.Size(200, 40);
            this.btn_CreateTimeSlot.TabIndex = 7;
            this.btn_CreateTimeSlot.Text = "Create Time Slot";
            this.btn_CreateTimeSlot.UseVisualStyleBackColor = false;
            this.btn_CreateTimeSlot.Click += new System.EventHandler(this.btn_CreateTimeSlot_Click);
            // 
            // pnl_TSHeader
            // 
            this.pnl_TSHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(75)))));
            this.pnl_TSHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_TSHeader.Controls.Add(this.lbl_TSColStart);
            this.pnl_TSHeader.Controls.Add(this.lbl_TSColEnd);
            this.pnl_TSHeader.Controls.Add(this.lbl_TSColDate);
            this.pnl_TSHeader.Controls.Add(this.lbl_TSColStatus);
            this.pnl_TSHeader.Location = new System.Drawing.Point(444, 18);
            this.pnl_TSHeader.Name = "pnl_TSHeader";
            this.pnl_TSHeader.Padding = new System.Windows.Forms.Padding(5);
            this.pnl_TSHeader.Size = new System.Drawing.Size(451, 30);
            this.pnl_TSHeader.TabIndex = 8;
            // 
            // lbl_TSColStart
            // 
            this.lbl_TSColStart.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lbl_TSColStart.ForeColor = System.Drawing.Color.White;
            this.lbl_TSColStart.Location = new System.Drawing.Point(10, 5);
            this.lbl_TSColStart.Name = "lbl_TSColStart";
            this.lbl_TSColStart.Size = new System.Drawing.Size(110, 20);
            this.lbl_TSColStart.TabIndex = 0;
            this.lbl_TSColStart.Text = "Start Time";
            // 
            // lbl_TSColEnd
            // 
            this.lbl_TSColEnd.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lbl_TSColEnd.ForeColor = System.Drawing.Color.White;
            this.lbl_TSColEnd.Location = new System.Drawing.Point(120, 5);
            this.lbl_TSColEnd.Name = "lbl_TSColEnd";
            this.lbl_TSColEnd.Size = new System.Drawing.Size(110, 20);
            this.lbl_TSColEnd.TabIndex = 1;
            this.lbl_TSColEnd.Text = "End Time";
            // 
            // lbl_TSColDate
            // 
            this.lbl_TSColDate.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lbl_TSColDate.ForeColor = System.Drawing.Color.White;
            this.lbl_TSColDate.Location = new System.Drawing.Point(230, 5);
            this.lbl_TSColDate.Name = "lbl_TSColDate";
            this.lbl_TSColDate.Size = new System.Drawing.Size(110, 20);
            this.lbl_TSColDate.TabIndex = 2;
            this.lbl_TSColDate.Text = "Date";
            // 
            // lbl_TSColStatus
            // 
            this.lbl_TSColStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lbl_TSColStatus.ForeColor = System.Drawing.Color.White;
            this.lbl_TSColStatus.Location = new System.Drawing.Point(340, 5);
            this.lbl_TSColStatus.Name = "lbl_TSColStatus";
            this.lbl_TSColStatus.Size = new System.Drawing.Size(110, 20);
            this.lbl_TSColStatus.TabIndex = 3;
            this.lbl_TSColStatus.Text = "Status";
            // 
            // flowTimeSlots
            // 
            this.flowTimeSlots.AutoScroll = true;
            this.flowTimeSlots.BackColor = System.Drawing.Color.White;
            this.flowTimeSlots.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowTimeSlots.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowTimeSlots.Location = new System.Drawing.Point(444, 48);
            this.flowTimeSlots.Name = "flowTimeSlots";
            this.flowTimeSlots.Padding = new System.Windows.Forms.Padding(10);
            this.flowTimeSlots.Size = new System.Drawing.Size(451, 480);
            this.flowTimeSlots.TabIndex = 9;
            this.flowTimeSlots.WrapContents = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(913, 553);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Reporting about Organizers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.crrepoOrg, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(907, 547);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbxDate);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbxStatus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 59);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(651, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(33, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Event Status";
            // 
            // cmbxStatus
            // 
            this.cmbxStatus.FormattingEnabled = true;
            this.cmbxStatus.Location = new System.Drawing.Point(175, 9);
            this.cmbxStatus.Name = "cmbxStatus";
            this.cmbxStatus.Size = new System.Drawing.Size(138, 36);
            this.cmbxStatus.TabIndex = 2;
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.Crimson;
            this.btn_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Logout.FlatAppearance.BorderSize = 0;
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.btn_Logout.ForeColor = System.Drawing.Color.White;
            this.btn_Logout.Location = new System.Drawing.Point(850, 5);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(55, 22);
            this.btn_Logout.TabIndex = 8;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(913, 553);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Reporting about Attendees";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Event Title";
            // 
            // cmbxEventTitle
            // 
            this.cmbxEventTitle.FormattingEnabled = true;
            this.cmbxEventTitle.Location = new System.Drawing.Point(311, 22);
            this.cmbxEventTitle.Name = "cmbxEventTitle";
            this.cmbxEventTitle.Size = new System.Drawing.Size(121, 36);
            this.cmbxEventTitle.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(474, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 39);
            this.button2.TabIndex = 4;
            this.button2.Text = "Generate Report";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // crrepoAttendee
            // 
            this.crrepoAttendee.ActiveViewIndex = -1;
            this.crrepoAttendee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crrepoAttendee.Cursor = System.Windows.Forms.Cursors.Default;
            this.crrepoAttendee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crrepoAttendee.Location = new System.Drawing.Point(3, 85);
            this.crrepoAttendee.Name = "crrepoAttendee";
            this.crrepoAttendee.Size = new System.Drawing.Size(901, 459);
            this.crrepoAttendee.TabIndex = 5;
            // 
            // crrepoOrg
            // 
            this.crrepoOrg.ActiveViewIndex = -1;
            this.crrepoOrg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crrepoOrg.Cursor = System.Windows.Forms.Cursors.Default;
            this.crrepoOrg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crrepoOrg.Location = new System.Drawing.Point(3, 68);
            this.crrepoOrg.Name = "crrepoOrg";
            this.crrepoOrg.Size = new System.Drawing.Size(901, 476);
            this.crrepoOrg.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.crrepoAttendee, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(907, 547);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cmbxEventTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(901, 76);
            this.panel2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(319, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Event Date";
            // 
            // cmbxDate
            // 
            this.cmbxDate.FormattingEnabled = true;
            this.cmbxDate.Location = new System.Drawing.Point(461, 11);
            this.cmbxDate.Name = "cmbxDate";
            this.cmbxDate.Size = new System.Drawing.Size(145, 36);
            this.cmbxDate.TabIndex = 4;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(921, 594);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.tabControlAdmin);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(943, 650);
            this.MinimumSize = new System.Drawing.Size(943, 650);
            this.Name = "AdminForm";
            this.Text = "Admin Dashboard";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.tabControlAdmin.ResumeLayout(false);
            this.tabPendingEvents.ResumeLayout(false);
            this.pnl_Header.ResumeLayout(false);
            this.tabTimeSlots.ResumeLayout(false);
            this.pnl_TSHeader.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.TabControl tabControlAdmin;
        private System.Windows.Forms.TabPage tabPendingEvents;
        private System.Windows.Forms.TabPage tabTimeSlots;
        
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Label lbl_H_Title;
        private System.Windows.Forms.Label lbl_H_Date;
        private System.Windows.Forms.Label lbl_H_Time;
        private System.Windows.Forms.Label lbl_H_Status;
        private System.Windows.Forms.Label lbl_H_Actions;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Events;

        private System.Windows.Forms.Label lbl_TS_Instruct;
        private System.Windows.Forms.Label lbl_TS_Date;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Label lbl_TS_Start;
        private System.Windows.Forms.DateTimePicker dtp_StartTime;
        private System.Windows.Forms.Label lbl_TS_End;
        private System.Windows.Forms.DateTimePicker dtp_EndTime;
        private System.Windows.Forms.Button btn_CreateTimeSlot;

        private System.Windows.Forms.Panel pnl_TSHeader;
        private System.Windows.Forms.Label lbl_TSColStart;
        private System.Windows.Forms.Label lbl_TSColEnd;
        private System.Windows.Forms.Label lbl_TSColDate;
        private System.Windows.Forms.Label lbl_TSColStatus;
        private System.Windows.Forms.FlowLayoutPanel flowTimeSlots;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbxStatus;
        private System.Windows.Forms.TabPage tabPage2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crrepoAttendee;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbxEventTitle;
        private System.Windows.Forms.Label label2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crrepoOrg;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbxDate;
    }
}