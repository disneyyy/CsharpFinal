namespace WindowsFormsApp1
{
    partial class StickyNoteTextForm
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
            this.text = new System.Windows.Forms.RichTextBox();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.moveBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.text.Location = new System.Drawing.Point(0, 0);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(1093, 722);
            this.text.TabIndex = 0;
            this.text.Text = "";
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.closeBtn.Image = global::WindowsFormsApp1.Properties.Resources.x2;
            this.closeBtn.Location = new System.Drawing.Point(1052, 684);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(41, 38);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeBtn.TabIndex = 2;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // moveBtn
            // 
            this.moveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.moveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.moveBtn.Image = global::WindowsFormsApp1.Properties.Resources.move1;
            this.moveBtn.Location = new System.Drawing.Point(1010, 684);
            this.moveBtn.Name = "moveBtn";
            this.moveBtn.Size = new System.Drawing.Size(41, 38);
            this.moveBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moveBtn.TabIndex = 4;
            this.moveBtn.TabStop = false;
            this.moveBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveBtn_MouseDown);
            this.moveBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.moveBtn_MouseMove);
            this.moveBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.moveBtn_MouseUp);
            // 
            // StickyNoteTextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 722);
            this.Controls.Add(this.moveBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.text);
            this.Name = "StickyNoteTextForm";
            this.Text = "StickyNoteTextForm";
            this.Load += new System.EventHandler(this.StickyNoteTextForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox text;
        private System.Windows.Forms.PictureBox closeBtn;
        private System.Windows.Forms.PictureBox moveBtn;
    }
}