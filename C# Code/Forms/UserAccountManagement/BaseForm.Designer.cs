namespace Registration_Form
{
    partial class BaseForm
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
            this.innerTbl = new System.Windows.Forms.TableLayoutPanel();
            this.outerTbl = new System.Windows.Forms.TableLayoutPanel();
            this.outerTbl.SuspendLayout();
            this.SuspendLayout();
            // 
            // innerTbl
            // 
            this.innerTbl.ColumnCount = 1;
            this.innerTbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.innerTbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.innerTbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.innerTbl.Location = new System.Drawing.Point(74, 64);
            this.innerTbl.Margin = new System.Windows.Forms.Padding(0);
            this.innerTbl.Name = "innerTbl";
            this.innerTbl.RowCount = 3;
            this.innerTbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.innerTbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.innerTbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.innerTbl.Size = new System.Drawing.Size(629, 547);
            this.innerTbl.TabIndex = 41;
            // 
            // outerTbl
            // 
            this.outerTbl.BackColor = System.Drawing.Color.Transparent;
            this.outerTbl.ColumnCount = 3;
            this.outerTbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.523809F));
            this.outerTbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.95238F));
            this.outerTbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.523809F));
            this.outerTbl.Controls.Add(this.innerTbl, 1, 1);
            this.outerTbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outerTbl.Location = new System.Drawing.Point(0, 0);
            this.outerTbl.Margin = new System.Windows.Forms.Padding(2);
            this.outerTbl.Name = "outerTbl";
            this.outerTbl.RowCount = 3;
            this.outerTbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.outerTbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.outerTbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.outerTbl.Size = new System.Drawing.Size(778, 644);
            this.outerTbl.TabIndex = 42;
            // 
            // BaseForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(778, 644);
            this.Controls.Add(this.outerTbl);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Snow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BaseForm";
            this.Text = "Base Form";
            this.outerTbl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel innerTbl;
        private System.Windows.Forms.TableLayoutPanel outerTbl;
    }
}