namespace Clipper_Project
{
    partial class IdentificarOrden
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
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.txt_WO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Approval = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(202, 201);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 5;
            this.btn_aceptar.Text = "Submit";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.Btn_aceptar_Click);
            // 
            // txt_WO
            // 
            this.txt_WO.Location = new System.Drawing.Point(101, 62);
            this.txt_WO.Multiline = true;
            this.txt_WO.Name = "txt_WO";
            this.txt_WO.Size = new System.Drawing.Size(322, 117);
            this.txt_WO.TabIndex = 4;
            this.txt_WO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_serial_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Comentario:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_Approval
            // 
            this.txt_Approval.Location = new System.Drawing.Point(101, 21);
            this.txt_Approval.Name = "txt_Approval";
            this.txt_Approval.Size = new System.Drawing.Size(322, 20);
            this.txt_Approval.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Aprobado por:";
            // 
            // IdentificarOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 236);
            this.Controls.Add(this.txt_Approval);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.txt_WO);
            this.Controls.Add(this.label1);
            this.Name = "IdentificarOrden";
            this.Text = "IdentificarOrden";
            this.Load += new System.EventHandler(this.IdentificarOrden_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.TextBox txt_WO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Approval;
        private System.Windows.Forms.Label label2;
    }
}