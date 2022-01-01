namespace WindowsFormsApp1
{
    partial class StickyNoteDrawForm
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
            this.canvas = new System.Windows.Forms.Panel();
            this.colorSelPanel = new System.Windows.Forms.Panel();
            this.penSizeSel = new System.Windows.Forms.TrackBar();
            this.moveBtn = new System.Windows.Forms.PictureBox();
            this.openPalleteBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closePalleteBtn = new System.Windows.Forms.PictureBox();
            this.eraserBtn = new System.Windows.Forms.PictureBox();
            this.RedSel = new System.Windows.Forms.PictureBox();
            this.blueSel = new System.Windows.Forms.PictureBox();
            this.blackSel = new System.Windows.Forms.PictureBox();
            this.canvas.SuspendLayout();
            this.colorSelPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.penSizeSel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openPalleteBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePalleteBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eraserBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedSel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueSel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackSel)).BeginInit();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.AutoSize = true;
            this.canvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.canvas.Controls.Add(this.moveBtn);
            this.canvas.Controls.Add(this.openPalleteBtn);
            this.canvas.Controls.Add(this.pictureBox1);
            this.canvas.Controls.Add(this.colorSelPanel);
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 0);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(1305, 778);
            this.canvas.TabIndex = 0;
            this.canvas.SizeChanged += new System.EventHandler(this.canvas_SizeChanged);
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // colorSelPanel
            // 
            this.colorSelPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorSelPanel.BackColor = System.Drawing.Color.Gray;
            this.colorSelPanel.Controls.Add(this.penSizeSel);
            this.colorSelPanel.Controls.Add(this.closePalleteBtn);
            this.colorSelPanel.Controls.Add(this.eraserBtn);
            this.colorSelPanel.Controls.Add(this.RedSel);
            this.colorSelPanel.Controls.Add(this.blueSel);
            this.colorSelPanel.Controls.Add(this.blackSel);
            this.colorSelPanel.Location = new System.Drawing.Point(1011, 3);
            this.colorSelPanel.Name = "colorSelPanel";
            this.colorSelPanel.Size = new System.Drawing.Size(291, 136);
            this.colorSelPanel.TabIndex = 0;
            // 
            // penSizeSel
            // 
            this.penSizeSel.LargeChange = 3;
            this.penSizeSel.Location = new System.Drawing.Point(15, 63);
            this.penSizeSel.Minimum = 2;
            this.penSizeSel.Name = "penSizeSel";
            this.penSizeSel.Size = new System.Drawing.Size(266, 90);
            this.penSizeSel.TabIndex = 5;
            this.penSizeSel.Value = 5;
            this.penSizeSel.Scroll += new System.EventHandler(this.penSizeSel_Scroll);
            // 
            // moveBtn
            // 
            this.moveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.moveBtn.Image = global::WindowsFormsApp1.Properties.Resources.move1;
            this.moveBtn.Location = new System.Drawing.Point(47, 0);
            this.moveBtn.Name = "moveBtn";
            this.moveBtn.Size = new System.Drawing.Size(41, 38);
            this.moveBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moveBtn.TabIndex = 3;
            this.moveBtn.TabStop = false;
            this.moveBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveBtn_MouseDown);
            this.moveBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.moveBtn_MouseMove);
            this.moveBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.moveBtn_MouseUp);
            // 
            // openPalleteBtn
            // 
            this.openPalleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openPalleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.openPalleteBtn.Image = global::WindowsFormsApp1.Properties.Resources.penIcon;
            this.openPalleteBtn.Location = new System.Drawing.Point(1218, 0);
            this.openPalleteBtn.Name = "openPalleteBtn";
            this.openPalleteBtn.Size = new System.Drawing.Size(84, 79);
            this.openPalleteBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.openPalleteBtn.TabIndex = 2;
            this.openPalleteBtn.TabStop = false;
            this.openPalleteBtn.Click += new System.EventHandler(this.openPalleteBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.x2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // closePalleteBtn
            // 
            this.closePalleteBtn.Image = global::WindowsFormsApp1.Properties.Resources.x2;
            this.closePalleteBtn.Location = new System.Drawing.Point(238, 8);
            this.closePalleteBtn.Name = "closePalleteBtn";
            this.closePalleteBtn.Size = new System.Drawing.Size(50, 49);
            this.closePalleteBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closePalleteBtn.TabIndex = 4;
            this.closePalleteBtn.TabStop = false;
            this.closePalleteBtn.Click += new System.EventHandler(this.closePalleteBtn_Click);
            // 
            // eraserBtn
            // 
            this.eraserBtn.BackColor = System.Drawing.Color.White;
            this.eraserBtn.Location = new System.Drawing.Point(187, 9);
            this.eraserBtn.Name = "eraserBtn";
            this.eraserBtn.Size = new System.Drawing.Size(45, 44);
            this.eraserBtn.TabIndex = 3;
            this.eraserBtn.TabStop = false;
            this.eraserBtn.Click += new System.EventHandler(this.eraserBtn_Click);
            // 
            // RedSel
            // 
            this.RedSel.BackColor = System.Drawing.Color.Red;
            this.RedSel.Location = new System.Drawing.Point(132, 8);
            this.RedSel.Name = "RedSel";
            this.RedSel.Size = new System.Drawing.Size(45, 44);
            this.RedSel.TabIndex = 2;
            this.RedSel.TabStop = false;
            this.RedSel.Click += new System.EventHandler(this.RedSel_Click);
            // 
            // blueSel
            // 
            this.blueSel.BackColor = System.Drawing.Color.Blue;
            this.blueSel.Location = new System.Drawing.Point(75, 9);
            this.blueSel.Name = "blueSel";
            this.blueSel.Size = new System.Drawing.Size(45, 44);
            this.blueSel.TabIndex = 1;
            this.blueSel.TabStop = false;
            this.blueSel.Click += new System.EventHandler(this.blueSel_Click);
            // 
            // blackSel
            // 
            this.blackSel.BackColor = System.Drawing.Color.Black;
            this.blackSel.Location = new System.Drawing.Point(15, 9);
            this.blackSel.Name = "blackSel";
            this.blackSel.Size = new System.Drawing.Size(45, 44);
            this.blackSel.TabIndex = 0;
            this.blackSel.TabStop = false;
            this.blackSel.Click += new System.EventHandler(this.blackSel_Click);
            // 
            // StickyNoteDrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 778);
            this.Controls.Add(this.canvas);
            this.Name = "StickyNoteDrawForm";
            this.Text = "StickyNoteDrawForm";
            this.Load += new System.EventHandler(this.StickyNoteDrawForm_Load);
            this.canvas.ResumeLayout(false);
            this.colorSelPanel.ResumeLayout(false);
            this.colorSelPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.penSizeSel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openPalleteBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePalleteBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eraserBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedSel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueSel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackSel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.Panel colorSelPanel;
        private System.Windows.Forms.PictureBox eraserBtn;
        private System.Windows.Forms.PictureBox RedSel;
        private System.Windows.Forms.PictureBox blueSel;
        private System.Windows.Forms.PictureBox blackSel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox closePalleteBtn;
        private System.Windows.Forms.PictureBox openPalleteBtn;
        private System.Windows.Forms.TrackBar penSizeSel;
        private System.Windows.Forms.PictureBox moveBtn;
    }
}