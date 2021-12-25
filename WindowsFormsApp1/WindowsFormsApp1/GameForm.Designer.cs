namespace WindowsFormsApp1
{
    partial class GameForm
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
            this.game1 = new System.Windows.Forms.Button();
            this.game2 = new System.Windows.Forms.Button();
            this.game3 = new System.Windows.Forms.Button();
            this.game4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // game1
            // 
            this.game1.Location = new System.Drawing.Point(159, 109);
            this.game1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.game1.Name = "game1";
            this.game1.Size = new System.Drawing.Size(238, 160);
            this.game1.TabIndex = 0;
            this.game1.Text = "1";
            this.game1.UseVisualStyleBackColor = true;
            // 
            // game2
            // 
            this.game2.Location = new System.Drawing.Point(508, 109);
            this.game2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.game2.Name = "game2";
            this.game2.Size = new System.Drawing.Size(238, 160);
            this.game2.TabIndex = 0;
            this.game2.Text = "2";
            this.game2.UseVisualStyleBackColor = true;
            // 
            // game3
            // 
            this.game3.Location = new System.Drawing.Point(159, 332);
            this.game3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.game3.Name = "game3";
            this.game3.Size = new System.Drawing.Size(238, 160);
            this.game3.TabIndex = 0;
            this.game3.Text = "3";
            this.game3.UseVisualStyleBackColor = true;
            // 
            // game4
            // 
            this.game4.Location = new System.Drawing.Point(508, 332);
            this.game4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.game4.Name = "game4";
            this.game4.Size = new System.Drawing.Size(238, 160);
            this.game4.TabIndex = 0;
            this.game4.Text = "4";
            this.game4.UseVisualStyleBackColor = true;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 540);
            this.Controls.Add(this.game4);
            this.Controls.Add(this.game2);
            this.Controls.Add(this.game3);
            this.Controls.Add(this.game1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button game1;
        private System.Windows.Forms.Button game2;
        private System.Windows.Forms.Button game3;
        private System.Windows.Forms.Button game4;
    }
}