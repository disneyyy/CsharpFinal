namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonGame = new System.Windows.Forms.Button();
            this.buttonSchedule = new System.Windows.Forms.Button();
            this.buttonCalculator = new System.Windows.Forms.Button();
            this.buttonNote = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonGame
            // 
            this.buttonGame.Location = new System.Drawing.Point(553, 22);
            this.buttonGame.Name = "buttonGame";
            this.buttonGame.Size = new System.Drawing.Size(180, 121);
            this.buttonGame.TabIndex = 0;
            this.buttonGame.Text = "遊戲";
            this.buttonGame.UseVisualStyleBackColor = true;
            this.buttonGame.Click += new System.EventHandler(this.buttonGame_Click);
            // 
            // buttonSchedule
            // 
            this.buttonSchedule.Location = new System.Drawing.Point(335, 22);
            this.buttonSchedule.Name = "buttonSchedule";
            this.buttonSchedule.Size = new System.Drawing.Size(180, 121);
            this.buttonSchedule.TabIndex = 0;
            this.buttonSchedule.Text = "讀書計畫表";
            this.buttonSchedule.UseVisualStyleBackColor = true;
            this.buttonSchedule.Click += new System.EventHandler(this.buttonSchedule_Click);
            // 
            // buttonCalculator
            // 
            this.buttonCalculator.Location = new System.Drawing.Point(553, 177);
            this.buttonCalculator.Name = "buttonCalculator";
            this.buttonCalculator.Size = new System.Drawing.Size(180, 121);
            this.buttonCalculator.TabIndex = 0;
            this.buttonCalculator.Text = "小算盤";
            this.buttonCalculator.UseVisualStyleBackColor = true;
            this.buttonCalculator.Click += new System.EventHandler(this.buttonCalculator_Click);
            // 
            // buttonNote
            // 
            this.buttonNote.Location = new System.Drawing.Point(335, 177);
            this.buttonNote.Name = "buttonNote";
            this.buttonNote.Size = new System.Drawing.Size(180, 121);
            this.buttonNote.TabIndex = 0;
            this.buttonNote.Text = "日記";
            this.buttonNote.UseVisualStyleBackColor = true;
            this.buttonNote.Click += new System.EventHandler(this.buttonNote_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "30",
            "60",
            "90",
            "120"});
            this.comboBox1.Location = new System.Drawing.Point(376, 370);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "60";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(532, 366);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(83, 29);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "開始讀書";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonNote);
            this.Controls.Add(this.buttonSchedule);
            this.Controls.Add(this.buttonCalculator);
            this.Controls.Add(this.buttonGame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGame;
        private System.Windows.Forms.Button buttonSchedule;
        private System.Windows.Forms.Button buttonCalculator;
        private System.Windows.Forms.Button buttonNote;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Timer timer1;
    }
}

