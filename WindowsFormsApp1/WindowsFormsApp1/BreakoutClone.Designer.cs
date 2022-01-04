namespace WindowsFormsApp1
{
    partial class BreakoutClone
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gameStartBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gameStartBtn
            // 
            this.gameStartBtn.Location = new System.Drawing.Point(72, 208);
            this.gameStartBtn.Name = "gameStartBtn";
            this.gameStartBtn.Size = new System.Drawing.Size(259, 85);
            this.gameStartBtn.TabIndex = 0;
            this.gameStartBtn.Text = "Start Game";
            this.gameStartBtn.UseVisualStyleBackColor = true;
            this.gameStartBtn.Click += new System.EventHandler(this.gameStartBtn_Click);
            // 
            // BreakoutClone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1630, 922);
            this.Controls.Add(this.gameStartBtn);
            this.Name = "BreakoutClone";
            this.Text = "BreakoutClone";
            this.Load += new System.EventHandler(this.BreakoutClone_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BreakoutClone_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button gameStartBtn;
    }
}