namespace AppPanels
{
    partial class FormPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPanel));
            this.ContMenu = new System.Windows.Forms.GroupBox();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.btnDateTime = new System.Windows.Forms.Button();
            this.ContApplication = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ContMenu.SuspendLayout();
            this.ContApplication.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ContMenu
            // 
            this.ContMenu.Controls.Add(this.btnCalculator);
            this.ContMenu.Controls.Add(this.btnDateTime);
            this.ContMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.ContMenu.Location = new System.Drawing.Point(0, 0);
            this.ContMenu.Name = "ContMenu";
            this.ContMenu.Size = new System.Drawing.Size(180, 410);
            this.ContMenu.TabIndex = 0;
            this.ContMenu.TabStop = false;
            this.ContMenu.Text = "Menu";
            // 
            // btnCalculator
            // 
            this.btnCalculator.Location = new System.Drawing.Point(35, 170);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(111, 29);
            this.btnCalculator.TabIndex = 1;
            this.btnCalculator.Text = "Calculator";
            this.btnCalculator.UseVisualStyleBackColor = true;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // btnDateTime
            // 
            this.btnDateTime.Location = new System.Drawing.Point(35, 86);
            this.btnDateTime.Name = "btnDateTime";
            this.btnDateTime.Size = new System.Drawing.Size(111, 30);
            this.btnDateTime.TabIndex = 0;
            this.btnDateTime.Text = "Date-Time";
            this.btnDateTime.UseVisualStyleBackColor = true;
            this.btnDateTime.Click += new System.EventHandler(this.btnDateTime_Click);
            // 
            // ContApplication
            // 
            this.ContApplication.Controls.Add(this.pictureBox1);
            this.ContApplication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContApplication.Location = new System.Drawing.Point(180, 0);
            this.ContApplication.Name = "ContApplication";
            this.ContApplication.Size = new System.Drawing.Size(450, 410);
            this.ContApplication.TabIndex = 0;
            this.ContApplication.TabStop = false;
            this.ContApplication.Text = "Application";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(440, 380);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 410);
            this.Controls.Add(this.ContApplication);
            this.Controls.Add(this.ContMenu);
            this.Name = "FormPanel";
            this.Text = "Panel";
            this.Load += new System.EventHandler(this.Panel_Load);
            this.ContMenu.ResumeLayout(false);
            this.ContApplication.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox ContMenu;
        private GroupBox ContApplication;
        private Button btnCalculator;
        private Button btnDateTime;
        private PictureBox pictureBox1;
    }
}