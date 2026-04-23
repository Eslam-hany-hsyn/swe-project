namespace Registration_Form
{
    partial class AttendeeForm
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
            this.flowLayoutPanel_Cards = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_PageTitle = new System.Windows.Forms.Label();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.dtp_EndDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_StartDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_DateSeparator = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Bell = new System.Windows.Forms.Button();
            this.pnl_Toolbar = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listBox_Notifications = new System.Windows.Forms.ListBox();
            this.pnl_Toolbar.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_Cards
            // 
            this.flowLayoutPanel_Cards.AutoScroll = true;
            this.flowLayoutPanel_Cards.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel_Cards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_Cards.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel_Cards.Location = new System.Drawing.Point(3, 131);
            this.flowLayoutPanel_Cards.Name = "flowLayoutPanel_Cards";
            this.flowLayoutPanel_Cards.Padding = new System.Windows.Forms.Padding(20);
            this.flowLayoutPanel_Cards.Size = new System.Drawing.Size(952, 510);
            this.flowLayoutPanel_Cards.TabIndex = 2;
            // 
            // lbl_PageTitle
            // 
            this.lbl_PageTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.lbl_PageTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_PageTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_PageTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_PageTitle.ForeColor = System.Drawing.Color.White;
            this.lbl_PageTitle.Location = new System.Drawing.Point(0, 64);
            this.lbl_PageTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_PageTitle.Name = "lbl_PageTitle";
            this.lbl_PageTitle.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lbl_PageTitle.Size = new System.Drawing.Size(958, 64);
            this.lbl_PageTitle.TabIndex = 1;
            this.lbl_PageTitle.Text = "Upcoming Events";
            this.lbl_PageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Filter
            // 
            this.btn_Filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(220)))));
            this.btn_Filter.FlatAppearance.BorderSize = 0;
            this.btn_Filter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Filter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Filter.ForeColor = System.Drawing.Color.White;
            this.btn_Filter.Location = new System.Drawing.Point(707, 12);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(74, 28);
            this.btn_Filter.TabIndex = 4;
            this.btn_Filter.Text = "Filter";
            this.btn_Filter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Filter.UseVisualStyleBackColor = true;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            // 
            // dtp_EndDate
            // 
            this.dtp_EndDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtp_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_EndDate.Location = new System.Drawing.Point(540, 12);
            this.dtp_EndDate.Name = "dtp_EndDate";
            this.dtp_EndDate.Size = new System.Drawing.Size(120, 34);
            this.dtp_EndDate.TabIndex = 3;
            // 
            // dtp_StartDate
            // 
            this.dtp_StartDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtp_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_StartDate.Location = new System.Drawing.Point(351, 12);
            this.dtp_StartDate.Name = "dtp_StartDate";
            this.dtp_StartDate.Size = new System.Drawing.Size(120, 34);
            this.dtp_StartDate.TabIndex = 1;
            // 
            // lbl_DateSeparator
            // 
            this.lbl_DateSeparator.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lbl_DateSeparator.ForeColor = System.Drawing.Color.White;
            this.lbl_DateSeparator.Location = new System.Drawing.Point(490, 9);
            this.lbl_DateSeparator.Name = "lbl_DateSeparator";
            this.lbl_DateSeparator.Size = new System.Drawing.Size(30, 31);
            this.lbl_DateSeparator.TabIndex = 2;
            this.lbl_DateSeparator.Text = "📆";
            this.lbl_DateSeparator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Search
            // 
            this.txt_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Search.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(180)))));
            this.txt_Search.Location = new System.Drawing.Point(12, 12);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(306, 34);
            this.txt_Search.TabIndex = 0;
            this.txt_Search.Text = "🔍  Search events...";
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            this.txt_Search.Enter += new System.EventHandler(this.txt_Search_Enter);
            this.txt_Search.Leave += new System.EventHandler(this.txt_Search_Leave);
            // 
            // btn_Bell
            // 
            this.btn_Bell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Bell.AutoSize = true;
            this.btn_Bell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Bell.FlatAppearance.BorderSize = 0;
            this.btn_Bell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Bell.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_Bell.ForeColor = System.Drawing.Color.Gold;
            this.btn_Bell.Location = new System.Drawing.Point(889, 3);
            this.btn_Bell.Name = "btn_Bell";
            this.btn_Bell.Size = new System.Drawing.Size(57, 42);
            this.btn_Bell.TabIndex = 5;
            this.btn_Bell.Text = "🔔";
            this.btn_Bell.Click += new System.EventHandler(this.btn_Bell_Click);
            // 
            // pnl_Toolbar
            // 
            this.pnl_Toolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.pnl_Toolbar.Controls.Add(this.btn_Bell);
            this.pnl_Toolbar.Controls.Add(this.txt_Search);
            this.pnl_Toolbar.Controls.Add(this.lbl_DateSeparator);
            this.pnl_Toolbar.Controls.Add(this.dtp_EndDate);
            this.pnl_Toolbar.Controls.Add(this.btn_Filter);
            this.pnl_Toolbar.Controls.Add(this.dtp_StartDate);
            this.pnl_Toolbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Toolbar.Location = new System.Drawing.Point(0, 0);
            this.pnl_Toolbar.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_Toolbar.Name = "pnl_Toolbar";
            this.pnl_Toolbar.Size = new System.Drawing.Size(958, 64);
            this.pnl_Toolbar.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pnl_Toolbar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel_Cards, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_PageTitle, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(958, 644);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // listBox_Notifications
            // 
            this.listBox_Notifications.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_Notifications.BackColor = System.Drawing.Color.White;
            this.listBox_Notifications.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_Notifications.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.listBox_Notifications.ForeColor = System.Drawing.Color.MidnightBlue;
            this.listBox_Notifications.FormattingEnabled = true;
            this.listBox_Notifications.ItemHeight = 25;
            this.listBox_Notifications.Location = new System.Drawing.Point(645, 60);
            this.listBox_Notifications.Name = "listBox_Notifications";
            this.listBox_Notifications.Size = new System.Drawing.Size(300, 127);
            this.listBox_Notifications.TabIndex = 6;
            this.listBox_Notifications.Visible = false;
            // 
            // AttendeeForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(958, 644);
            this.Controls.Add(this.listBox_Notifications);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MaximumSize = new System.Drawing.Size(980, 700);
            this.MinimumSize = new System.Drawing.Size(980, 700);
            this.Name = "AttendeeForm";
            this.Text = "Attendee Dashboard";
            this.Load += new System.EventHandler(this.AttendeeForm_Load_1);
            this.pnl_Toolbar.ResumeLayout(false);
            this.pnl_Toolbar.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Cards;
        private System.Windows.Forms.Label lbl_PageTitle;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.DateTimePicker dtp_EndDate;
        private System.Windows.Forms.DateTimePicker dtp_StartDate;
        private System.Windows.Forms.Label lbl_DateSeparator;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_Bell;
        private System.Windows.Forms.Panel pnl_Toolbar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox listBox_Notifications;
    }
}