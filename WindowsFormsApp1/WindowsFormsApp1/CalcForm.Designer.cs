namespace WindowsFormsApp1
{
    partial class CalcForm
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
            if (disposing && (components != null)) {
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
            this.input = new System.Windows.Forms.TextBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.calcBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Font = new System.Drawing.Font("PMingLiU", 15F);
            this.input.Location = new System.Drawing.Point(236, 54);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(336, 55);
            this.input.TabIndex = 0;
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Font = new System.Drawing.Font("PMingLiU", 15F);
            this.inputLabel.Location = new System.Drawing.Point(94, 160);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(648, 40);
            this.inputLabel.TabIndex = 1;
            this.inputLabel.Text = "Input your expression and press calculate";
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(314, 258);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(189, 65);
            this.calcBtn.TabIndex = 2;
            this.calcBtn.Text = "Calc";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // CalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.input);
            this.Name = "CalcForm";
            this.Text = "CalcForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Button calcBtn;
    }
}