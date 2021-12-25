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
            this.input.Font = new System.Drawing.Font("新細明體", 15F);
            this.input.Location = new System.Drawing.Point(163, 40);
            this.input.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(234, 43);
            this.input.TabIndex = 0;
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Font = new System.Drawing.Font("新細明體", 15F);
            this.inputLabel.Location = new System.Drawing.Point(65, 120);
            this.inputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(486, 30);
            this.inputLabel.TabIndex = 1;
            this.inputLabel.Text = "Input your expression and press calculate";
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(217, 194);
            this.calcBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(131, 49);
            this.calcBtn.TabIndex = 2;
            this.calcBtn.Text = "Calc";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // CalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 338);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.input);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CalcForm";
            this.Text = "CalcForm";
            this.Load += new System.EventHandler(this.CalcForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Button calcBtn;
    }
}