﻿namespace WindowsFormsApp1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // game1
            // 
            this.game1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.game1.Font = new System.Drawing.Font("新細明體", 15F);
            this.game1.Location = new System.Drawing.Point(157, 340);
            this.game1.Name = "game1";
            this.game1.Size = new System.Drawing.Size(135, 98);
            this.game1.TabIndex = 0;
            this.game1.Text = "貪食蛇";
            this.game1.UseVisualStyleBackColor = true;
            this.game1.Click += new System.EventHandler(this.game1_Click);
            // 
            // game2
            // 
            this.game2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.game2.Font = new System.Drawing.Font("新細明體", 15F);
            this.game2.Location = new System.Drawing.Point(499, 12);
            this.game2.Name = "game2";
            this.game2.Size = new System.Drawing.Size(144, 107);
            this.game2.TabIndex = 0;
            this.game2.Text = "2";
            this.game2.UseVisualStyleBackColor = true;
            // 
            // game3
            // 
            this.game3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.game3.Font = new System.Drawing.Font("新細明體", 15F);
            this.game3.Location = new System.Drawing.Point(107, 53);
            this.game3.Name = "game3";
            this.game3.Size = new System.Drawing.Size(142, 101);
            this.game3.TabIndex = 0;
            this.game3.Text = "接方塊";
            this.game3.UseVisualStyleBackColor = true;
            this.game3.Click += new System.EventHandler(this.game3_Click);
            // 
            // game4
            // 
            this.game4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.game4.Font = new System.Drawing.Font("新細明體", 15F);
            this.game4.Location = new System.Drawing.Point(555, 335);
            this.game4.Name = "game4";
            this.game4.Size = new System.Drawing.Size(151, 103);
            this.game4.TabIndex = 0;
            this.game4.Text = "4";
            this.game4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(802, 459);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.game4);
            this.Controls.Add(this.game2);
            this.Controls.Add(this.game3);
            this.Controls.Add(this.game1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.GameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button game1;
        private System.Windows.Forms.Button game2;
        private System.Windows.Forms.Button game3;
        private System.Windows.Forms.Button game4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}