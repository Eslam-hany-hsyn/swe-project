namespace Registration_Form.Forms.Organizers
{
    partial class OrganizerForm
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageEvents = new System.Windows.Forms.TabPage();
            this.flowEvents = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.lbl_H_Title = new System.Windows.Forms.Label();
            this.lbl_H_Date = new System.Windows.Forms.Label();
            this.lbl_H_Time = new System.Windows.Forms.Label();
            this.lbl_H_Status = new System.Windows.Forms.Label();
            this.lbl_H_Actions = new System.Windows.Forms.Label();
            this.lblEventsTitle = new System.Windows.Forms.Label();
            this.tabPageCreateAndSlots = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlTSHeader = new System.Windows.Forms.Panel();
            this.lblTSColStart = new System.Windows.Forms.Label();
            this.lblTSColEnd = new System.Windows.Forms.Label();
            this.lblTSColDate = new System.Windows.Forms.Label();
            this.lblTSColStatus = new System.Windows.Forms.Label();
            this.flowTimeSlots = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSubmitEvent = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSubmitHeader = new System.Windows.Forms.Label();
            this.txtEventTitle = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.dtpSubmitDate = new System.Windows.Forms.DateTimePicker();
            this.numCapacity = new System.Windows.Forms.NumericUpDown();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabControlMain.SuspendLayout();
            this.tabPageEvents.SuspendLayout();
            this.pnl_Header.SuspendLayout();
            this.tabPageCreateAndSlots.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlTSHeader.SuspendLayout();
            this.pnlSubmitEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageEvents);
            this.tabControlMain.Controls.Add(this.tabPageCreateAndSlots);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(968, 594);
            this.tabControlMain.TabIndex = 0;
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.Crimson;
            this.btn_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Logout.FlatAppearance.BorderSize = 0;
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.btn_Logout.ForeColor = System.Drawing.Color.White;
            this.btn_Logout.Location = new System.Drawing.Point(880, 5);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(55, 22);
            this.btn_Logout.TabIndex = 8;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // tabPageEvents
            // 
            this.tabPageEvents.BackColor = System.Drawing.Color.White;
            this.tabPageEvents.Controls.Add(this.flowEvents);
            this.tabPageEvents.Controls.Add(this.pnl_Header);
            this.tabPageEvents.Controls.Add(this.lblEventsTitle);
            this.tabPageEvents.Location = new System.Drawing.Point(4, 37);
            this.tabPageEvents.Name = "tabPageEvents";
            this.tabPageEvents.Padding = new System.Windows.Forms.Padding(20);
            this.tabPageEvents.Size = new System.Drawing.Size(960, 553);
            this.tabPageEvents.TabIndex = 0;
            this.tabPageEvents.Text = "Events Table";
            // 
            // flowEvents
            // 
            this.flowEvents.AutoScroll = true;
            this.flowEvents.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowEvents.Location = new System.Drawing.Point(20, 132);
            this.flowEvents.Name = "flowEvents";
            this.flowEvents.Size = new System.Drawing.Size(920, 401);
            this.flowEvents.TabIndex = 5;
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
            this.pnl_Header.Location = new System.Drawing.Point(20, 87);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(920, 45);
            this.pnl_Header.TabIndex = 4;
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
            // lblEventsTitle
            // 
            this.lblEventsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEventsTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblEventsTitle.Location = new System.Drawing.Point(20, 20);
            this.lblEventsTitle.Name = "lblEventsTitle";
            this.lblEventsTitle.Padding = new System.Windows.Forms.Padding(0, 15, 0, 5);
            this.lblEventsTitle.Size = new System.Drawing.Size(920, 67);
            this.lblEventsTitle.TabIndex = 3;
            this.lblEventsTitle.Text = "Events Table";
            // 
            // tabPageCreateAndSlots
            // 
            this.tabPageCreateAndSlots.Controls.Add(this.panel1);
            this.tabPageCreateAndSlots.Controls.Add(this.pnlSubmitEvent);
            this.tabPageCreateAndSlots.Location = new System.Drawing.Point(4, 37);
            this.tabPageCreateAndSlots.Name = "tabPageCreateAndSlots";
            this.tabPageCreateAndSlots.Size = new System.Drawing.Size(960, 553);
            this.tabPageCreateAndSlots.TabIndex = 1;
            this.tabPageCreateAndSlots.Text = "Create Event & Time Slots";
            this.tabPageCreateAndSlots.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlTSHeader);
            this.panel1.Controls.Add(this.flowTimeSlots);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(437, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 553);
            this.panel1.TabIndex = 12;
            // 
            // pnlTSHeader
            // 
            this.pnlTSHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(75)))));
            this.pnlTSHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTSHeader.Controls.Add(this.lblTSColStart);
            this.pnlTSHeader.Controls.Add(this.lblTSColEnd);
            this.pnlTSHeader.Controls.Add(this.lblTSColDate);
            this.pnlTSHeader.Controls.Add(this.lblTSColStatus);
            this.pnlTSHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTSHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlTSHeader.Name = "pnlTSHeader";
            this.pnlTSHeader.Size = new System.Drawing.Size(523, 30);
            this.pnlTSHeader.TabIndex = 11;
            // 
            // lblTSColStart
            // 
            this.lblTSColStart.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTSColStart.ForeColor = System.Drawing.Color.White;
            this.lblTSColStart.Location = new System.Drawing.Point(10, 5);
            this.lblTSColStart.Name = "lblTSColStart";
            this.lblTSColStart.Size = new System.Drawing.Size(120, 20);
            this.lblTSColStart.TabIndex = 0;
            this.lblTSColStart.Text = "Start Time";
            // 
            // lblTSColEnd
            // 
            this.lblTSColEnd.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTSColEnd.ForeColor = System.Drawing.Color.White;
            this.lblTSColEnd.Location = new System.Drawing.Point(140, 5);
            this.lblTSColEnd.Name = "lblTSColEnd";
            this.lblTSColEnd.Size = new System.Drawing.Size(120, 20);
            this.lblTSColEnd.TabIndex = 1;
            this.lblTSColEnd.Text = "End Time";
            // 
            // lblTSColDate
            // 
            this.lblTSColDate.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTSColDate.ForeColor = System.Drawing.Color.White;
            this.lblTSColDate.Location = new System.Drawing.Point(270, 5);
            this.lblTSColDate.Name = "lblTSColDate";
            this.lblTSColDate.Size = new System.Drawing.Size(120, 20);
            this.lblTSColDate.TabIndex = 2;
            this.lblTSColDate.Text = "Date";
            // 
            // lblTSColStatus
            // 
            this.lblTSColStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTSColStatus.ForeColor = System.Drawing.Color.White;
            this.lblTSColStatus.Location = new System.Drawing.Point(400, 5);
            this.lblTSColStatus.Name = "lblTSColStatus";
            this.lblTSColStatus.Size = new System.Drawing.Size(120, 20);
            this.lblTSColStatus.TabIndex = 3;
            this.lblTSColStatus.Text = "Status";
            // 
            // flowTimeSlots
            // 
            this.flowTimeSlots.AutoScroll = true;
            this.flowTimeSlots.BackColor = System.Drawing.Color.White;
            this.flowTimeSlots.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowTimeSlots.Location = new System.Drawing.Point(0, 29);
            this.flowTimeSlots.Name = "flowTimeSlots";
            this.flowTimeSlots.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.flowTimeSlots.Size = new System.Drawing.Size(523, 524);
            this.flowTimeSlots.TabIndex = 10;
            // 
            // pnlSubmitEvent
            // 
            this.pnlSubmitEvent.Controls.Add(this.label2);
            this.pnlSubmitEvent.Controls.Add(this.label1);
            this.pnlSubmitEvent.Controls.Add(this.lblSubmitHeader);
            this.pnlSubmitEvent.Controls.Add(this.txtEventTitle);
            this.pnlSubmitEvent.Controls.Add(this.txtDescription);
            this.pnlSubmitEvent.Controls.Add(this.dtpSubmitDate);
            this.pnlSubmitEvent.Controls.Add(this.numCapacity);
            this.pnlSubmitEvent.Controls.Add(this.btnSubmit);
            this.pnlSubmitEvent.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSubmitEvent.Location = new System.Drawing.Point(0, 0);
            this.pnlSubmitEvent.Name = "pnlSubmitEvent";
            this.pnlSubmitEvent.Size = new System.Drawing.Size(442, 553);
            this.pnlSubmitEvent.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "Event Capacity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Event Date";
            // 
            // lblSubmitHeader
            // 
            this.lblSubmitHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSubmitHeader.Location = new System.Drawing.Point(20, 20);
            this.lblSubmitHeader.Name = "lblSubmitHeader";
            this.lblSubmitHeader.Size = new System.Drawing.Size(200, 30);
            this.lblSubmitHeader.TabIndex = 0;
            this.lblSubmitHeader.Text = "Create New Event";
            // 
            // txtEventTitle
            // 
            this.txtEventTitle.BackColor = System.Drawing.SystemColors.Window;
            this.txtEventTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEventTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEventTitle.ForeColor = System.Drawing.Color.Gray;
            this.txtEventTitle.Location = new System.Drawing.Point(20, 60);
            this.txtEventTitle.Name = "txtEventTitle";
            this.txtEventTitle.Size = new System.Drawing.Size(400, 34);
            this.txtEventTitle.TabIndex = 1;
            this.txtEventTitle.Tag = "Event Title";
            this.txtEventTitle.Text = "Event Title";
            this.txtEventTitle.Enter += new System.EventHandler(this.txtDescription_Enter);
            this.txtEventTitle.Leave += new System.EventHandler(this.txtDescription_Leave);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescription.ForeColor = System.Drawing.Color.Gray;
            this.txtDescription.Location = new System.Drawing.Point(20, 110);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(400, 100);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.Tag = "Event Description...";
            this.txtDescription.Text = "Event Description...";
            this.txtDescription.Enter += new System.EventHandler(this.txtDescription_Enter);
            this.txtDescription.Leave += new System.EventHandler(this.txtDescription_Leave);
            // 
            // dtpSubmitDate
            // 
            this.dtpSubmitDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpSubmitDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSubmitDate.Location = new System.Drawing.Point(20, 273);
            this.dtpSubmitDate.Name = "dtpSubmitDate";
            this.dtpSubmitDate.Size = new System.Drawing.Size(180, 34);
            this.dtpSubmitDate.TabIndex = 3;
            // 
            // numCapacity
            // 
            this.numCapacity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numCapacity.Location = new System.Drawing.Point(20, 381);
            this.numCapacity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numCapacity.Name = "numCapacity";
            this.numCapacity.Size = new System.Drawing.Size(120, 34);
            this.numCapacity.TabIndex = 4;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(104, 454);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(200, 40);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit Event";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(20, 252);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 26);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Event Date";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(20, 342);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(107, 26);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Capacity";
            // 
            // OrganizerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 594);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.tabControlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.MaximumSize = new System.Drawing.Size(990, 650);
            this.MinimumSize = new System.Drawing.Size(990, 650);
            this.Name = "OrganizerForm";
            this.Text = "Organizer Dashboard";
            this.Load += new System.EventHandler(this.OrganizerForm_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageEvents.ResumeLayout(false);
            this.pnl_Header.ResumeLayout(false);
            this.tabPageCreateAndSlots.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlTSHeader.ResumeLayout(false);
            this.pnlSubmitEvent.ResumeLayout(false);
            this.pnlSubmitEvent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageEvents;
        private System.Windows.Forms.TabPage tabPageCreateAndSlots;
        private System.Windows.Forms.Label lblEventsTitle;
        private System.Windows.Forms.Label lblSubmitHeader;
        private System.Windows.Forms.TextBox txtEventTitle;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.DateTimePicker dtpSubmitDate;
        private System.Windows.Forms.NumericUpDown numCapacity;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FlowLayoutPanel flowEvents;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Label lbl_H_Title;
        private System.Windows.Forms.Label lbl_H_Date;
        private System.Windows.Forms.Label lbl_H_Time;
        private System.Windows.Forms.Label lbl_H_Status;
        private System.Windows.Forms.Label lbl_H_Actions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlSubmitEvent;
        private System.Windows.Forms.FlowLayoutPanel flowTimeSlots;
        private System.Windows.Forms.Panel pnlTSHeader;
        private System.Windows.Forms.Label lblTSColStart;
        private System.Windows.Forms.Label lblTSColEnd;
        private System.Windows.Forms.Label lblTSColDate;
        private System.Windows.Forms.Label lblTSColStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Logout;
    }
}