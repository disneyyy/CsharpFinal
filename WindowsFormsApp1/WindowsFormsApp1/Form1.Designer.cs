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
            this.labelTime = new System.Windows.Forms.Label();
            this.pic_cat = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.point_Label = new System.Windows.Forms.Label();
            this.level_Label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.breed_Label = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.Label();
            this.save_btn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.load_btn = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.labelClock = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cat)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGame
            // 
            this.buttonGame.Location = new System.Drawing.Point(899, 37);
            this.buttonGame.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonGame.Name = "buttonGame";
            this.buttonGame.Size = new System.Drawing.Size(292, 194);
            this.buttonGame.TabIndex = 0;
            this.buttonGame.Text = "遊戲";
            this.buttonGame.UseVisualStyleBackColor = true;
            this.buttonGame.Click += new System.EventHandler(this.buttonGame_Click);
            this.buttonGame.MouseHover += new System.EventHandler(this.buttonGame_MouseHover);
            // 
            // buttonSchedule
            // 
            this.buttonSchedule.Location = new System.Drawing.Point(544, 37);
            this.buttonSchedule.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonSchedule.Name = "buttonSchedule";
            this.buttonSchedule.Size = new System.Drawing.Size(292, 194);
            this.buttonSchedule.TabIndex = 0;
            this.buttonSchedule.Text = "讀書計畫表";
            this.buttonSchedule.UseVisualStyleBackColor = true;
            this.buttonSchedule.Click += new System.EventHandler(this.buttonSchedule_Click);
            // 
            // buttonCalculator
            // 
            this.buttonCalculator.Location = new System.Drawing.Point(899, 283);
            this.buttonCalculator.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonCalculator.Name = "buttonCalculator";
            this.buttonCalculator.Size = new System.Drawing.Size(292, 194);
            this.buttonCalculator.TabIndex = 0;
            this.buttonCalculator.Text = "小算盤";
            this.buttonCalculator.UseVisualStyleBackColor = true;
            this.buttonCalculator.Click += new System.EventHandler(this.buttonCalculator_Click);
            // 
            // buttonNote
            // 
            this.buttonNote.Location = new System.Drawing.Point(544, 283);
            this.buttonNote.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonNote.Name = "buttonNote";
            this.buttonNote.Size = new System.Drawing.Size(292, 194);
            this.buttonNote.TabIndex = 0;
            this.buttonNote.Text = "便利貼";
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
            this.comboBox1.Location = new System.Drawing.Point(611, 592);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(194, 32);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "60";
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(864, 586);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(135, 46);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "開始讀書";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("PMingLiU", 20F);
            this.labelTime.Location = new System.Drawing.Point(1048, 574);
            this.labelTime.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(201, 54);
            this.labelTime.TabIndex = 3;
            this.labelTime.Text = "01:00:00";
            // 
            // pic_cat
            // 
            this.pic_cat.Location = new System.Drawing.Point(80, 235);
            this.pic_cat.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pic_cat.Name = "pic_cat";
            this.pic_cat.Size = new System.Drawing.Size(366, 488);
            this.pic_cat.TabIndex = 4;
            this.pic_cat.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "知識:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "等級:";
            // 
            // point_Label
            // 
            this.point_Label.AutoSize = true;
            this.point_Label.Location = new System.Drawing.Point(150, 58);
            this.point_Label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.point_Label.Name = "point_Label";
            this.point_Label.Size = new System.Drawing.Size(21, 24);
            this.point_Label.TabIndex = 7;
            this.point_Label.Text = "0";
            // 
            // level_Label
            // 
            this.level_Label.AutoSize = true;
            this.level_Label.Location = new System.Drawing.Point(150, 102);
            this.level_Label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.level_Label.Name = "level_Label";
            this.level_Label.Size = new System.Drawing.Size(21, 24);
            this.level_Label.TabIndex = 8;
            this.level_Label.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "品種:";
            // 
            // breed_Label
            // 
            this.breed_Label.AutoSize = true;
            this.breed_Label.Location = new System.Drawing.Point(150, 144);
            this.breed_Label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.breed_Label.Name = "breed_Label";
            this.breed_Label.Size = new System.Drawing.Size(106, 24);
            this.breed_Label.TabIndex = 10;
            this.breed_Label.Text = "普通貓貓";
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Font = new System.Drawing.Font("Microsoft JhengHei", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.message.Location = new System.Drawing.Point(31, 235);
            this.message.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(167, 38);
            this.message.TabIndex = 11;
            this.message.Text = "開始讀書ㄅ";
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(68, 179);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(89, 51);
            this.save_btn.TabIndex = 12;
            this.save_btn.Text = "存檔";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // load_btn
            // 
            this.load_btn.Location = new System.Drawing.Point(164, 179);
            this.load_btn.Name = "load_btn";
            this.load_btn.Size = new System.Drawing.Size(89, 51);
            this.load_btn.TabIndex = 13;
            this.load_btn.Text = "讀檔";
            this.load_btn.UseVisualStyleBackColor = true;
            this.load_btn.Click += new System.EventHandler(this.load_btn_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // labelClock
            // 
            this.labelClock.AutoSize = true;
            this.labelClock.Location = new System.Drawing.Point(292, 58);
            this.labelClock.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelClock.Name = "labelClock";
            this.labelClock.Size = new System.Drawing.Size(0, 24);
            this.labelClock.TabIndex = 14;
            // 
            // buttonStop
            // 
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(864, 642);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(135, 46);
            this.buttonStop.TabIndex = 2;
            this.buttonStop.Text = "中斷";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 720);
            this.Controls.Add(this.labelClock);
            this.Controls.Add(this.load_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.message);
            this.Controls.Add(this.breed_Label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.level_Label);
            this.Controls.Add(this.point_Label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_cat);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonNote);
            this.Controls.Add(this.buttonSchedule);
            this.Controls.Add(this.buttonCalculator);
            this.Controls.Add(this.buttonGame);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "貓起來念";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_cat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGame;
        private System.Windows.Forms.Button buttonSchedule;
        private System.Windows.Forms.Button buttonCalculator;
        private System.Windows.Forms.Button buttonNote;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.PictureBox pic_cat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label point_Label;
        private System.Windows.Forms.Label level_Label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label breed_Label;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button load_btn;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label labelClock;
        private System.Windows.Forms.Button buttonStop;
    }
}

