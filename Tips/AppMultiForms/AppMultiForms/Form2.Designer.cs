namespace AppMultiForms
{
    partial class Access
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
            this.mesAccess = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.txtMessageReturn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mesAccess
            // 
            this.mesAccess.AutoSize = true;
            this.mesAccess.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mesAccess.Location = new System.Drawing.Point(22, 32);
            this.mesAccess.Name = "mesAccess";
            this.mesAccess.Size = new System.Drawing.Size(0, 30);
            this.mesAccess.TabIndex = 2;
            this.mesAccess.Click += new System.EventHandler(this.label1_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Teal;
            this.close.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.close.ForeColor = System.Drawing.SystemColors.Control;
            this.close.Location = new System.Drawing.Point(165, 131);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(112, 52);
            this.close.TabIndex = 1;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // txtMessageReturn
            // 
            this.txtMessageReturn.Location = new System.Drawing.Point(12, 71);
            this.txtMessageReturn.Multiline = true;
            this.txtMessageReturn.Name = "txtMessageReturn";
            this.txtMessageReturn.Size = new System.Drawing.Size(420, 54);
            this.txtMessageReturn.TabIndex = 3;
            // 
            // Access
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(444, 203);
            this.Controls.Add(this.txtMessageReturn);
            this.Controls.Add(this.close);
            this.Controls.Add(this.mesAccess);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Access";
            this.Text = "Access";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label mesAccess;
        private Button close;
        private TextBox txtMessageReturn;
    }
}