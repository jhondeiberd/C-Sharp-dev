namespace AppCalculator
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
            this.Number1 = new System.Windows.Forms.TextBox();
            this.Number2 = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Add = new System.Windows.Forms.RadioButton();
            this.Sub = new System.Windows.Forms.RadioButton();
            this.Mult = new System.Windows.Forms.RadioButton();
            this.Div = new System.Windows.Forms.RadioButton();
            this.Result = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Number1
            // 
            this.Number1.BackColor = System.Drawing.Color.Navy;
            this.Number1.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.Number1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Number1.ForeColor = System.Drawing.SystemColors.Info;
            this.Number1.Location = new System.Drawing.Point(177, 143);
            this.Number1.Name = "Number1";
            this.Number1.Size = new System.Drawing.Size(242, 39);
            this.Number1.TabIndex = 0;
            this.Number1.Text = "0";
            this.Number1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Number1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Number2
            // 
            this.Number2.BackColor = System.Drawing.Color.Navy;
            this.Number2.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.Number2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Number2.ForeColor = System.Drawing.SystemColors.Info;
            this.Number2.Location = new System.Drawing.Point(177, 213);
            this.Number2.Name = "Number2";
            this.Number2.Size = new System.Drawing.Size(242, 39);
            this.Number2.TabIndex = 1;
            this.Number2.Text = "0";
            this.Number2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Calculate
            // 
            this.Calculate.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Calculate.Location = new System.Drawing.Point(177, 284);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(242, 94);
            this.Calculate.TabIndex = 2;
            this.Calculate.Text = "=";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Div);
            this.groupBox1.Controls.Add(this.Mult);
            this.groupBox1.Controls.Add(this.Sub);
            this.groupBox1.Controls.Add(this.Add);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(13, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 266);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operations";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Add
            // 
            this.Add.AutoSize = true;
            this.Add.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Add.Location = new System.Drawing.Point(26, 24);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(80, 69);
            this.Add.TabIndex = 0;
            this.Add.TabStop = true;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.CheckedChanged += new System.EventHandler(this.Add_CheckedChanged);
            // 
            // Sub
            // 
            this.Sub.AutoSize = true;
            this.Sub.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Sub.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Sub.Location = new System.Drawing.Point(26, 79);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(65, 69);
            this.Sub.TabIndex = 1;
            this.Sub.TabStop = true;
            this.Sub.Text = "-";
            this.Sub.UseVisualStyleBackColor = true;
            this.Sub.CheckedChanged += new System.EventHandler(this.Sub_CheckedChanged);
            // 
            // Mult
            // 
            this.Mult.AutoSize = true;
            this.Mult.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Mult.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Mult.Location = new System.Drawing.Point(26, 132);
            this.Mult.Name = "Mult";
            this.Mult.Size = new System.Drawing.Size(73, 69);
            this.Mult.TabIndex = 2;
            this.Mult.TabStop = true;
            this.Mult.Text = "x";
            this.Mult.UseVisualStyleBackColor = true;
            this.Mult.CheckedChanged += new System.EventHandler(this.Mult_CheckedChanged);
            // 
            // Div
            // 
            this.Div.AutoSize = true;
            this.Div.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Div.Location = new System.Drawing.Point(26, 192);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(67, 69);
            this.Div.TabIndex = 3;
            this.Div.TabStop = true;
            this.Div.Text = "/";
            this.Div.UseVisualStyleBackColor = true;
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Result.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.Result.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Result.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Result.Location = new System.Drawing.Point(12, 15);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(407, 91);
            this.Result.TabIndex = 4;
            this.Result.Text = "0";
            this.Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(431, 390);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.Number2);
            this.Controls.Add(this.Number1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Number1;
        private TextBox Number2;
        private Button Calculate;
        private GroupBox groupBox1;
        private RadioButton Div;
        private RadioButton Mult;
        private RadioButton Sub;
        private RadioButton Add;
        private TextBox Result;
    }
}