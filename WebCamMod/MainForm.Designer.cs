namespace WebCamMod
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbInitVideoFilePath = new System.Windows.Forms.TextBox();
            this.btnInitVideoFilePathOpen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAudioFilePath = new System.Windows.Forms.TextBox();
            this.btnAudioFilePathOpen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.chkbxChangeNextFilter = new System.Windows.Forms.CheckBox();
            this.nudFilterInterval = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.cmbFilter1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbFilter2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbFilter3 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbFilter4 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbFilter5 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbFilter6 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbFilter7 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbFilter8 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudFilterInterval)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Горячие клавиши";
            // 
            // tbInitVideoFilePath
            // 
            this.tbInitVideoFilePath.Location = new System.Drawing.Point(15, 48);
            this.tbInitVideoFilePath.Name = "tbInitVideoFilePath";
            this.tbInitVideoFilePath.Size = new System.Drawing.Size(467, 20);
            this.tbInitVideoFilePath.TabIndex = 1;
            // 
            // btnInitVideoFilePathOpen
            // 
            this.btnInitVideoFilePathOpen.Location = new System.Drawing.Point(488, 46);
            this.btnInitVideoFilePathOpen.Name = "btnInitVideoFilePathOpen";
            this.btnInitVideoFilePathOpen.Size = new System.Drawing.Size(75, 23);
            this.btnInitVideoFilePathOpen.TabIndex = 2;
            this.btnInitVideoFilePathOpen.Text = "...";
            this.btnInitVideoFilePathOpen.UseVisualStyleBackColor = true;
            this.btnInitVideoFilePathOpen.Click += new System.EventHandler(this.btnInitVideoFilePathOpen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Путь к начальному видеофайлу";
            // 
            // tbAudioFilePath
            // 
            this.tbAudioFilePath.Location = new System.Drawing.Point(15, 101);
            this.tbAudioFilePath.Name = "tbAudioFilePath";
            this.tbAudioFilePath.Size = new System.Drawing.Size(467, 20);
            this.tbAudioFilePath.TabIndex = 4;
            // 
            // btnAudioFilePathOpen
            // 
            this.btnAudioFilePathOpen.Location = new System.Drawing.Point(488, 99);
            this.btnAudioFilePathOpen.Name = "btnAudioFilePathOpen";
            this.btnAudioFilePathOpen.Size = new System.Drawing.Size(75, 23);
            this.btnAudioFilePathOpen.TabIndex = 5;
            this.btnAudioFilePathOpen.Text = "...";
            this.btnAudioFilePathOpen.UseVisualStyleBackColor = true;
            this.btnAudioFilePathOpen.Click += new System.EventHandler(this.btnAudioFilePathOpen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Путь к аудиофайлу";
            // 
            // chkbxChangeNextFilter
            // 
            this.chkbxChangeNextFilter.AutoSize = true;
            this.chkbxChangeNextFilter.Checked = true;
            this.chkbxChangeNextFilter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbxChangeNextFilter.Location = new System.Drawing.Point(267, 143);
            this.chkbxChangeNextFilter.Name = "chkbxChangeNextFilter";
            this.chkbxChangeNextFilter.Size = new System.Drawing.Size(306, 17);
            this.chkbxChangeNextFilter.TabIndex = 7;
            this.chkbxChangeNextFilter.Text = "Заменять фильтр (иначе накладывать на предыдущий)";
            this.chkbxChangeNextFilter.UseVisualStyleBackColor = true;
            // 
            // nudFilterInterval
            // 
            this.nudFilterInterval.Location = new System.Drawing.Point(212, 142);
            this.nudFilterInterval.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudFilterInterval.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudFilterInterval.Name = "nudFilterInterval";
            this.nudFilterInterval.Size = new System.Drawing.Size(46, 20);
            this.nudFilterInterval.TabIndex = 8;
            this.nudFilterInterval.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Время работы одного фильтра (сек.)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbFilter8);
            this.groupBox1.Controls.Add(this.cmbFilter7);
            this.groupBox1.Controls.Add(this.cmbFilter6);
            this.groupBox1.Controls.Add(this.cmbFilter5);
            this.groupBox1.Controls.Add(this.cmbFilter4);
            this.groupBox1.Controls.Add(this.cmbFilter3);
            this.groupBox1.Controls.Add(this.cmbFilter2);
            this.groupBox1.Controls.Add(this.cmbFilter1);
            this.groupBox1.Location = new System.Drawing.Point(15, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 224);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтры";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(15, 424);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(548, 41);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cmbFilter1
            // 
            this.cmbFilter1.FormattingEnabled = true;
            this.cmbFilter1.Location = new System.Drawing.Point(23, 29);
            this.cmbFilter1.Name = "cmbFilter1";
            this.cmbFilter1.Size = new System.Drawing.Size(220, 21);
            this.cmbFilter1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "1)";
            // 
            // cmbFilter2
            // 
            this.cmbFilter2.FormattingEnabled = true;
            this.cmbFilter2.Location = new System.Drawing.Point(23, 73);
            this.cmbFilter2.Name = "cmbFilter2";
            this.cmbFilter2.Size = new System.Drawing.Size(220, 21);
            this.cmbFilter2.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "2)";
            // 
            // cmbFilter3
            // 
            this.cmbFilter3.FormattingEnabled = true;
            this.cmbFilter3.Location = new System.Drawing.Point(23, 120);
            this.cmbFilter3.Name = "cmbFilter3";
            this.cmbFilter3.Size = new System.Drawing.Size(220, 21);
            this.cmbFilter3.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "3)";
            // 
            // cmbFilter4
            // 
            this.cmbFilter4.FormattingEnabled = true;
            this.cmbFilter4.Location = new System.Drawing.Point(23, 166);
            this.cmbFilter4.Name = "cmbFilter4";
            this.cmbFilter4.Size = new System.Drawing.Size(220, 21);
            this.cmbFilter4.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "4)";
            // 
            // cmbFilter5
            // 
            this.cmbFilter5.FormattingEnabled = true;
            this.cmbFilter5.Location = new System.Drawing.Point(296, 29);
            this.cmbFilter5.Name = "cmbFilter5";
            this.cmbFilter5.Size = new System.Drawing.Size(220, 21);
            this.cmbFilter5.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(279, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "5)";
            // 
            // cmbFilter6
            // 
            this.cmbFilter6.FormattingEnabled = true;
            this.cmbFilter6.Location = new System.Drawing.Point(296, 73);
            this.cmbFilter6.Name = "cmbFilter6";
            this.cmbFilter6.Size = new System.Drawing.Size(220, 21);
            this.cmbFilter6.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(279, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "6)";
            // 
            // cmbFilter7
            // 
            this.cmbFilter7.FormattingEnabled = true;
            this.cmbFilter7.Location = new System.Drawing.Point(296, 120);
            this.cmbFilter7.Name = "cmbFilter7";
            this.cmbFilter7.Size = new System.Drawing.Size(220, 21);
            this.cmbFilter7.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(279, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "7)";
            // 
            // cmbFilter8
            // 
            this.cmbFilter8.FormattingEnabled = true;
            this.cmbFilter8.Location = new System.Drawing.Point(296, 166);
            this.cmbFilter8.Name = "cmbFilter8";
            this.cmbFilter8.Size = new System.Drawing.Size(220, 21);
            this.cmbFilter8.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(279, 169);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "8)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 477);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudFilterInterval);
            this.Controls.Add(this.chkbxChangeNextFilter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAudioFilePathOpen);
            this.Controls.Add(this.tbAudioFilePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnInitVideoFilePathOpen);
            this.Controls.Add(this.tbInitVideoFilePath);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WebCam modificator";
            ((System.ComponentModel.ISupportInitialize)(this.nudFilterInterval)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbInitVideoFilePath;
        private System.Windows.Forms.Button btnInitVideoFilePathOpen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAudioFilePath;
        private System.Windows.Forms.Button btnAudioFilePathOpen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkbxChangeNextFilter;
        private System.Windows.Forms.NumericUpDown nudFilterInterval;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbFilter8;
        private System.Windows.Forms.ComboBox cmbFilter7;
        private System.Windows.Forms.ComboBox cmbFilter6;
        private System.Windows.Forms.ComboBox cmbFilter5;
        private System.Windows.Forms.ComboBox cmbFilter4;
        private System.Windows.Forms.ComboBox cmbFilter3;
        private System.Windows.Forms.ComboBox cmbFilter2;
        private System.Windows.Forms.ComboBox cmbFilter1;
        private System.Windows.Forms.Button btnStart;
    }
}

