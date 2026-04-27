namespace Registration_Form.Forms.Organizers
{
    partial class EditEventDialog
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.numCap = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCap = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblTimeValue = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.numCap)).BeginInit();
            this.SuspendLayout();

            // ================= TEXTBOX: TITLE =================
            this.txtTitle.Location = new System.Drawing.Point(20, 45);
            this.txtTitle.Size = new System.Drawing.Size(390, 27);
            this.txtTitle.ForeColor = System.Drawing.Color.Black;

            // ================= LABEL: TITLE =================
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Size = new System.Drawing.Size(100, 20);
            this.lblTitle.Text = "Event Title:";

            // ================= TEXTBOX: DESCRIPTION =================
            this.txtDesc.Location = new System.Drawing.Point(20, 110);
            this.txtDesc.Size = new System.Drawing.Size(390, 80);
            this.txtDesc.Multiline = true;

            // ================= LABEL: DESCRIPTION =================
            this.lblDesc.Location = new System.Drawing.Point(20, 85);
            this.lblDesc.Size = new System.Drawing.Size(100, 20);
            this.lblDesc.Text = "Description:";

            // ================= DATE PICKER =================
            this.dtpDate.Location = new System.Drawing.Point(20, 230);
            this.dtpDate.Size = new System.Drawing.Size(180, 27);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Enabled = false;

            // ================= LABEL: DATE =================
            this.lblDate.Location = new System.Drawing.Point(20, 205);
            this.lblDate.Size = new System.Drawing.Size(100, 20);
            this.lblDate.Text = "Date:";

            // ================= NUMERIC: CAPACITY =================
            this.numCap.Location = new System.Drawing.Point(230, 230);
            this.numCap.Size = new System.Drawing.Size(100, 27);
            this.numCap.Maximum = 10000;

            // ================= LABEL: CAPACITY =================
            this.lblCap.Location = new System.Drawing.Point(230, 205);
            this.lblCap.Size = new System.Drawing.Size(100, 20);
            this.lblCap.Text = "Capacity:";

            // ================= TIME LABEL =================
            this.lblTime.Location = new System.Drawing.Point(20, 270);
            this.lblTime.Size = new System.Drawing.Size(100, 20);
            this.lblTime.Text = "Time:";

            this.lblTimeValue.Location = new System.Drawing.Point(130, 270);
            this.lblTimeValue.Size = new System.Drawing.Size(200, 20);
            this.lblTimeValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTimeValue.Text = "00:00 - 00:00";
            this.lblTimeValue.Enabled = false;

            // ================= BUTTON: SAVE =================
            this.btnSave.Location = new System.Drawing.Point(110, 310);
            this.btnSave.Size = new System.Drawing.Size(110, 35);
            this.btnSave.Text = "Save";
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // ================= BUTTON: CANCEL =================
            this.btnCancel.Location = new System.Drawing.Point(230, 310);
            this.btnCancel.Size = new System.Drawing.Size(110, 35);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.BackColor = System.Drawing.Color.LightGray;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // ================= FORM =================
            this.ClientSize = new System.Drawing.Size(440, 370);
            this.BackColor = System.Drawing.Color.White;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Event Details";

            // ================= ADD CONTROLS =================
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblCap);
            this.Controls.Add(this.numCap);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblTimeValue);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);

            ((System.ComponentModel.ISupportInitialize)(this.numCap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.NumericUpDown numCap;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCap;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblTimeValue;
    }
}
