namespace Clipper_Project
{
    partial class Scaning
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Scan = new System.Windows.Forms.TextBox();
            this.dg_Scan = new System.Windows.Forms.DataGridView();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.lbl_WO = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Employ = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Records = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Scan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "SCAN CODE:";
            // 
            // txt_Scan
            // 
            this.txt_Scan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Scan.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Scan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Scan.Location = new System.Drawing.Point(321, 103);
            this.txt_Scan.Name = "txt_Scan";
            this.txt_Scan.Size = new System.Drawing.Size(934, 26);
            this.txt_Scan.TabIndex = 1;
            // 
            // dg_Scan
            // 
            this.dg_Scan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_Scan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_Scan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Scan.Location = new System.Drawing.Point(12, 236);
            this.dg_Scan.Name = "dg_Scan";
            this.dg_Scan.Size = new System.Drawing.Size(1751, 553);
            this.dg_Scan.TabIndex = 2;
            this.dg_Scan.TabStop = false;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.Location = new System.Drawing.Point(672, 162);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(121, 44);
            this.btn_Submit.TabIndex = 2;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            this.btn_Submit.Enter += new System.EventHandler(this.btn_Submit_Enter);
            // 
            // lbl_WO
            // 
            this.lbl_WO.AutoSize = true;
            this.lbl_WO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WO.Location = new System.Drawing.Point(150, 25);
            this.lbl_WO.Name = "lbl_WO";
            this.lbl_WO.Size = new System.Drawing.Size(38, 20);
            this.lbl_WO.TabIndex = 4;
            this.lbl_WO.Text = "WO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "WorkOrder:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1234, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Employ #:";
            // 
            // lbl_Employ
            // 
            this.lbl_Employ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Employ.AutoSize = true;
            this.lbl_Employ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employ.Location = new System.Drawing.Point(1327, 25);
            this.lbl_Employ.Name = "lbl_Employ";
            this.lbl_Employ.Size = new System.Drawing.Size(65, 20);
            this.lbl_Employ.TabIndex = 6;
            this.lbl_Employ.Text = "employ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Records:";
            // 
            // lbl_Records
            // 
            this.lbl_Records.AutoSize = true;
            this.lbl_Records.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Records.Location = new System.Drawing.Point(99, 213);
            this.lbl_Records.Name = "lbl_Records";
            this.lbl_Records.Size = new System.Drawing.Size(76, 20);
            this.lbl_Records.TabIndex = 8;
            this.lbl_Records.Text = "Records";
            // 
            // Scaning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1775, 801);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_Records);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Employ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_WO);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.dg_Scan);
            this.Controls.Add(this.txt_Scan);
            this.Controls.Add(this.label1);
            this.Name = "Scaning";
            this.Text = "Scaning";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Scaning_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Scan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Scan;
        private System.Windows.Forms.DataGridView dg_Scan;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label lbl_WO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Employ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Records;
    }
}