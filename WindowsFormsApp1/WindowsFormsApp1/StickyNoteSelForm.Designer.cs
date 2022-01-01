namespace WindowsFormsApp1
{
    partial class StickyNoteSelForm
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
            this.addTextBtn = new System.Windows.Forms.Button();
            this.addDrawBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addTextBtn
            // 
            this.addTextBtn.Location = new System.Drawing.Point(185, 28);
            this.addTextBtn.Name = "addTextBtn";
            this.addTextBtn.Size = new System.Drawing.Size(235, 67);
            this.addTextBtn.TabIndex = 0;
            this.addTextBtn.Text = "新增文字便利貼";
            this.addTextBtn.UseVisualStyleBackColor = true;
            this.addTextBtn.Click += new System.EventHandler(this.addTextBtn_Click);
            // 
            // addDrawBtn
            // 
            this.addDrawBtn.Location = new System.Drawing.Point(185, 119);
            this.addDrawBtn.Name = "addDrawBtn";
            this.addDrawBtn.Size = new System.Drawing.Size(235, 67);
            this.addDrawBtn.TabIndex = 1;
            this.addDrawBtn.Text = "新增手寫便利貼";
            this.addDrawBtn.UseVisualStyleBackColor = true;
            this.addDrawBtn.Click += new System.EventHandler(this.addDrawBtn_Click);
            // 
            // StickyNoteSelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 232);
            this.Controls.Add(this.addDrawBtn);
            this.Controls.Add(this.addTextBtn);
            this.Name = "StickyNoteSelForm";
            this.Text = "StickyNoteSelForm";
            this.Load += new System.EventHandler(this.StickyNoteSelForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addTextBtn;
        private System.Windows.Forms.Button addDrawBtn;
    }
}