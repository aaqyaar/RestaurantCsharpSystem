namespace RestaurantCsharpSystem
{
    partial class frmSearchPayrollByID
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
            this.btnGeneralRpt = new System.Windows.Forms.Button();
            this.txtPayrollID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGeneralRpt
            // 
            this.btnGeneralRpt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.btnGeneralRpt.Font = new System.Drawing.Font("Inter", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneralRpt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.btnGeneralRpt.Location = new System.Drawing.Point(333, 147);
            this.btnGeneralRpt.Name = "btnGeneralRpt";
            this.btnGeneralRpt.Size = new System.Drawing.Size(146, 46);
            this.btnGeneralRpt.TabIndex = 38;
            this.btnGeneralRpt.Text = "Show Report";
            this.btnGeneralRpt.UseVisualStyleBackColor = false;
            this.btnGeneralRpt.Click += new System.EventHandler(this.btnGeneralRpt_Click);
            // 
            // txtPayrollID
            // 
            this.txtPayrollID.BackColor = System.Drawing.Color.White;
            this.txtPayrollID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPayrollID.Font = new System.Drawing.Font("Inter", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayrollID.ForeColor = System.Drawing.Color.Black;
            this.txtPayrollID.Location = new System.Drawing.Point(76, 86);
            this.txtPayrollID.Name = "txtPayrollID";
            this.txtPayrollID.Size = new System.Drawing.Size(403, 38);
            this.txtPayrollID.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 24);
            this.label6.TabIndex = 37;
            this.label6.Text = "Payroll. ID";
            // 
            // frmSearchPayrollByID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 232);
            this.Controls.Add(this.btnGeneralRpt);
            this.Controls.Add(this.txtPayrollID);
            this.Controls.Add(this.label6);
            this.Name = "frmSearchPayrollByID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSearchPayrollByID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGeneralRpt;
        private System.Windows.Forms.TextBox txtPayrollID;
        private System.Windows.Forms.Label label6;
    }
}