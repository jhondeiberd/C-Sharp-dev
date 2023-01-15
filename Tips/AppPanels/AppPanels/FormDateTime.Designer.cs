namespace AppDateTime
{
    partial class FormDateTime
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTime.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTime.Location = new System.Drawing.Point(156, 57);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(273, 106);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "label1";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDate.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblDate.Location = new System.Drawing.Point(97, 177);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(205, 81);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormDateTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(512, 305);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTime);
            this.Name = "FormDateTime";
            this.Text = "Date-Time";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTime;
        private Label lblDate;
        private System.Windows.Forms.Timer timer1;
    }
}