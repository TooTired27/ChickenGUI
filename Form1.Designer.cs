namespace GUIPrac1
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblChicken1 = new System.Windows.Forms.Label();
            this.lblChicken2 = new System.Windows.Forms.Label();
            this.lblChicken3 = new System.Windows.Forms.Label();
            this.lblChicken4 = new System.Windows.Forms.Label();
            this.lblChicken5 = new System.Windows.Forms.Label();
            this.txtChicken1 = new System.Windows.Forms.TextBox();
            this.txtChicken2 = new System.Windows.Forms.TextBox();
            this.txtChicken3 = new System.Windows.Forms.TextBox();
            this.txtChicken4 = new System.Windows.Forms.TextBox();
            this.txtChicken5 = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTitle.Location = new System.Drawing.Point(369, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(103, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "CALCULATE EGGS";
            // 
            // lblChicken1
            // 
            this.lblChicken1.AutoSize = true;
            this.lblChicken1.Location = new System.Drawing.Point(52, 85);
            this.lblChicken1.Name = "lblChicken1";
            this.lblChicken1.Size = new System.Drawing.Size(52, 13);
            this.lblChicken1.TabIndex = 1;
            this.lblChicken1.Text = "Chicken1";
            // 
            // lblChicken2
            // 
            this.lblChicken2.AutoSize = true;
            this.lblChicken2.Location = new System.Drawing.Point(52, 115);
            this.lblChicken2.Name = "lblChicken2";
            this.lblChicken2.Size = new System.Drawing.Size(52, 13);
            this.lblChicken2.TabIndex = 2;
            this.lblChicken2.Text = "Chicken2";
            // 
            // lblChicken3
            // 
            this.lblChicken3.AutoSize = true;
            this.lblChicken3.Location = new System.Drawing.Point(52, 146);
            this.lblChicken3.Name = "lblChicken3";
            this.lblChicken3.Size = new System.Drawing.Size(52, 13);
            this.lblChicken3.TabIndex = 3;
            this.lblChicken3.Text = "Chicken3";
            // 
            // lblChicken4
            // 
            this.lblChicken4.AutoSize = true;
            this.lblChicken4.Location = new System.Drawing.Point(52, 178);
            this.lblChicken4.Name = "lblChicken4";
            this.lblChicken4.Size = new System.Drawing.Size(52, 13);
            this.lblChicken4.TabIndex = 4;
            this.lblChicken4.Text = "Chicken4";
            // 
            // lblChicken5
            // 
            this.lblChicken5.AutoSize = true;
            this.lblChicken5.Location = new System.Drawing.Point(52, 208);
            this.lblChicken5.Name = "lblChicken5";
            this.lblChicken5.Size = new System.Drawing.Size(52, 13);
            this.lblChicken5.TabIndex = 5;
            this.lblChicken5.Text = "Chicken5";
            // 
            // txtChicken1
            // 
            this.txtChicken1.Location = new System.Drawing.Point(210, 78);
            this.txtChicken1.Name = "txtChicken1";
            this.txtChicken1.Size = new System.Drawing.Size(100, 20);
            this.txtChicken1.TabIndex = 6;
            // 
            // txtChicken2
            // 
            this.txtChicken2.Location = new System.Drawing.Point(210, 108);
            this.txtChicken2.Name = "txtChicken2";
            this.txtChicken2.Size = new System.Drawing.Size(100, 20);
            this.txtChicken2.TabIndex = 7;
            // 
            // txtChicken3
            // 
            this.txtChicken3.Location = new System.Drawing.Point(210, 139);
            this.txtChicken3.Name = "txtChicken3";
            this.txtChicken3.Size = new System.Drawing.Size(100, 20);
            this.txtChicken3.TabIndex = 8;
            // 
            // txtChicken4
            // 
            this.txtChicken4.Location = new System.Drawing.Point(210, 171);
            this.txtChicken4.Name = "txtChicken4";
            this.txtChicken4.Size = new System.Drawing.Size(100, 20);
            this.txtChicken4.TabIndex = 9;
            // 
            // txtChicken5
            // 
            this.txtChicken5.Location = new System.Drawing.Point(210, 201);
            this.txtChicken5.Name = "txtChicken5";
            this.txtChicken5.Size = new System.Drawing.Size(100, 20);
            this.txtChicken5.TabIndex = 10;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(52, 279);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 13);
            this.lblOutput.TabIndex = 11;
            // 
            // btnCalculate
            // 
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCalculate.Location = new System.Drawing.Point(386, 228);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtChicken5);
            this.Controls.Add(this.txtChicken4);
            this.Controls.Add(this.txtChicken3);
            this.Controls.Add(this.txtChicken2);
            this.Controls.Add(this.txtChicken1);
            this.Controls.Add(this.lblChicken5);
            this.Controls.Add(this.lblChicken4);
            this.Controls.Add(this.lblChicken3);
            this.Controls.Add(this.lblChicken2);
            this.Controls.Add(this.lblChicken1);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblChicken1;
        private System.Windows.Forms.Label lblChicken2;
        private System.Windows.Forms.Label lblChicken3;
        private System.Windows.Forms.Label lblChicken4;
        private System.Windows.Forms.Label lblChicken5;
        private System.Windows.Forms.TextBox txtChicken1;
        private System.Windows.Forms.TextBox txtChicken2;
        private System.Windows.Forms.TextBox txtChicken3;
        private System.Windows.Forms.TextBox txtChicken4;
        private System.Windows.Forms.TextBox txtChicken5;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnCalculate;
    }
}

