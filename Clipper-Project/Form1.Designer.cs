namespace Clipper_Project
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_WO = new System.Windows.Forms.ToolStripButton();
            this.btn_Scanning = new System.Windows.Forms.ToolStripButton();
            this.btn_Reports = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dg_Inprocess = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Inprocess)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_WO,
            this.btn_Scanning,
            this.btn_Reports});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(119, 540);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btn_WO
            // 
            this.btn_WO.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_WO.Image = ((System.Drawing.Image)(resources.GetObject("btn_WO.Image")));
            this.btn_WO.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_WO.Name = "btn_WO";
            this.btn_WO.Size = new System.Drawing.Size(116, 25);
            this.btn_WO.Text = "WorkOrder";
            this.btn_WO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_WO.Click += new System.EventHandler(this.btn_WO_Click);
            // 
            // btn_Scanning
            // 
            this.btn_Scanning.AutoSize = false;
            this.btn_Scanning.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Scanning.Image = ((System.Drawing.Image)(resources.GetObject("btn_Scanning.Image")));
            this.btn_Scanning.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Scanning.Name = "btn_Scanning";
            this.btn_Scanning.Size = new System.Drawing.Size(118, 25);
            this.btn_Scanning.Text = "Scaning";
            this.btn_Scanning.ToolTipText = "Scanning display";
            this.btn_Scanning.Click += new System.EventHandler(this.btn_Scanning_Click);
            // 
            // btn_Reports
            // 
            this.btn_Reports.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reports.Image = ((System.Drawing.Image)(resources.GetObject("btn_Reports.Image")));
            this.btn_Reports.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Reports.Name = "btn_Reports";
            this.btn_Reports.Size = new System.Drawing.Size(116, 25);
            this.btn_Reports.Text = "Reports";
            this.btn_Reports.Click += new System.EventHandler(this.btn_Reports_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(865, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dg_Inprocess
            // 
            this.dg_Inprocess.AllowUserToAddRows = false;
            this.dg_Inprocess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Inprocess.Location = new System.Drawing.Point(205, 76);
            this.dg_Inprocess.Name = "dg_Inprocess";
            this.dg_Inprocess.Size = new System.Drawing.Size(552, 372);
            this.dg_Inprocess.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "WorkOrder in process:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 540);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg_Inprocess);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Amazing System Traceability";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Inprocess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_WO;
        private System.Windows.Forms.ToolStripButton btn_Scanning;
        private System.Windows.Forms.ToolStripButton btn_Reports;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dg_Inprocess;
        private System.Windows.Forms.Label label1;
    }
}

