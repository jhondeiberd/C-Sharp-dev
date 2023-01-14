namespace AppPanels
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ContMenu = new System.Windows.Forms.GroupBox();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.btnDateTime = new System.Windows.Forms.Button();
            this.panelForm = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ContMenu.SuspendLayout();
            this.panelForm.SuspendLayout();
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
            this.ContMenu.Size = new System.Drawing.Size(192, 356);
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
            // panelForm
            // 
            this.panelForm.Controls.Add(this.pictureBox1);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(192, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(355, 356);
            this.panelForm.TabIndex = 1;
            this.panelForm.TabStop = false;
            this.panelForm.Text = "Application";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 296);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 356);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.ContMenu);
            this.Name = "Form1";
            this.Text = "Panel";
            this.Load += new System.EventHandler(this.Panel_Load);
            this.ContMenu.ResumeLayout(false);
            this.panelForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox ContMenu;
        private Button btnCalculator;
        private Button btnDateTime;
        private GroupBox panelForm;
        private PictureBox pictureBox1;
    }
}