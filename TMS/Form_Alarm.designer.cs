namespace TMS
{
    partial class Form_Alarm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該公開 Managed 資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改這個方法的內容。
        ///
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tB_sex = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tB_temp = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tB_place = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tB_address = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tB_CTEL = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tB_CWHO = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tB_tTEL = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tB_teacher = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tB_class = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tB_tagId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tB_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tB_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pB_photo = new System.Windows.Forms.PictureBox();
            this.tB_date = new System.Windows.Forms.TextBox();
            this.tB_time = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_photo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.tB_time);
            this.groupBox1.Controls.Add(this.tB_date);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tB_sex);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.tB_temp);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.tB_place);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.tB_address);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tB_CTEL);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tB_CWHO);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tB_tTEL);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tB_teacher);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tB_class);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tB_tagId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tB_name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tB_id);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 424);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "學生基本資料";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 26);
            this.button1.TabIndex = 32;
            this.button1.Text = "處理";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(253, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "more..";
            // 
            // tB_sex
            // 
            this.tB_sex.Location = new System.Drawing.Point(205, 138);
            this.tB_sex.Name = "tB_sex";
            this.tB_sex.ReadOnly = true;
            this.tB_sex.Size = new System.Drawing.Size(40, 22);
            this.tB_sex.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("新細明體", 12F);
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(99, 391);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 16);
            this.label14.TabIndex = 29;
            this.label14.Text = "度C";
            // 
            // tB_temp
            // 
            this.tB_temp.Location = new System.Drawing.Point(53, 388);
            this.tB_temp.Name = "tB_temp";
            this.tB_temp.ReadOnly = true;
            this.tB_temp.Size = new System.Drawing.Size(43, 22);
            this.tB_temp.TabIndex = 28;
            this.tB_temp.Text = "  ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("新細明體", 12F);
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(13, 391);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 16);
            this.label13.TabIndex = 27;
            this.label13.Text = "體溫";
            // 
            // tB_place
            // 
            this.tB_place.Location = new System.Drawing.Point(123, 352);
            this.tB_place.Name = "tB_place";
            this.tB_place.ReadOnly = true;
            this.tB_place.Size = new System.Drawing.Size(227, 22);
            this.tB_place.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("新細明體", 12F);
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(11, 358);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 16);
            this.label12.TabIndex = 25;
            this.label12.Text = "目前所在位置";
            // 
            // tB_address
            // 
            this.tB_address.Location = new System.Drawing.Point(68, 314);
            this.tB_address.Name = "tB_address";
            this.tB_address.ReadOnly = true;
            this.tB_address.Size = new System.Drawing.Size(282, 22);
            this.tB_address.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 319);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 23;
            this.label11.Text = "住址";
            // 
            // tB_CTEL
            // 
            this.tB_CTEL.Location = new System.Drawing.Point(250, 286);
            this.tB_CTEL.Name = "tB_CTEL";
            this.tB_CTEL.ReadOnly = true;
            this.tB_CTEL.Size = new System.Drawing.Size(100, 22);
            this.tB_CTEL.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(174, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 21;
            this.label9.Text = "緊急連絡電話";
            // 
            // tB_CWHO
            // 
            this.tB_CWHO.Location = new System.Drawing.Point(68, 286);
            this.tB_CWHO.Name = "tB_CWHO";
            this.tB_CWHO.ReadOnly = true;
            this.tB_CWHO.Size = new System.Drawing.Size(100, 22);
            this.tB_CWHO.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 290);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 19;
            this.label10.Text = "緊急聯絡人";
            // 
            // tB_tTEL
            // 
            this.tB_tTEL.Location = new System.Drawing.Point(250, 258);
            this.tB_tTEL.Name = "tB_tTEL";
            this.tB_tTEL.ReadOnly = true;
            this.tB_tTEL.Size = new System.Drawing.Size(100, 22);
            this.tB_tTEL.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(195, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "導師手機";
            // 
            // tB_teacher
            // 
            this.tB_teacher.Location = new System.Drawing.Point(68, 258);
            this.tB_teacher.Name = "tB_teacher";
            this.tB_teacher.ReadOnly = true;
            this.tB_teacher.Size = new System.Drawing.Size(100, 22);
            this.tB_teacher.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "導師姓名";
            // 
            // tB_class
            // 
            this.tB_class.Location = new System.Drawing.Point(68, 230);
            this.tB_class.Name = "tB_class";
            this.tB_class.ReadOnly = true;
            this.tB_class.Size = new System.Drawing.Size(100, 22);
            this.tB_class.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "班級";
            // 
            // tB_tagId
            // 
            this.tB_tagId.Location = new System.Drawing.Point(162, 191);
            this.tB_tagId.Name = "tB_tagId";
            this.tB_tagId.ReadOnly = true;
            this.tB_tagId.Size = new System.Drawing.Size(189, 22);
            this.tB_tagId.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(162, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tag ID：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "性別";
            // 
            // tB_name
            // 
            this.tB_name.Location = new System.Drawing.Point(205, 110);
            this.tB_name.Name = "tB_name";
            this.tB_name.ReadOnly = true;
            this.tB_name.Size = new System.Drawing.Size(100, 22);
            this.tB_name.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "姓名";
            // 
            // tB_id
            // 
            this.tB_id.Location = new System.Drawing.Point(205, 82);
            this.tB_id.Name = "tB_id";
            this.tB_id.ReadOnly = true;
            this.tB_id.Size = new System.Drawing.Size(100, 22);
            this.tB_id.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "學號";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pB_photo);
            this.groupBox3.Location = new System.Drawing.Point(6, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(150, 193);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "照片圖像";
            // 
            // pB_photo
            // 
            this.pB_photo.Location = new System.Drawing.Point(6, 21);
            this.pB_photo.Name = "pB_photo";
            this.pB_photo.Size = new System.Drawing.Size(138, 166);
            this.pB_photo.TabIndex = 13;
            this.pB_photo.TabStop = false;
            // 
            // tB_date
            // 
            this.tB_date.BackColor = System.Drawing.SystemColors.Control;
            this.tB_date.Location = new System.Drawing.Point(205, 21);
            this.tB_date.Name = "tB_date";
            this.tB_date.Size = new System.Drawing.Size(100, 22);
            this.tB_date.TabIndex = 33;
            // 
            // tB_time
            // 
            this.tB_time.BackColor = System.Drawing.SystemColors.Control;
            this.tB_time.Location = new System.Drawing.Point(205, 49);
            this.tB_time.Name = "tB_time";
            this.tB_time.Size = new System.Drawing.Size(100, 22);
            this.tB_time.TabIndex = 34;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(162, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 35;
            this.label15.Text = "日期";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(162, 52);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 12);
            this.label16.TabIndex = 36;
            this.label16.Text = "時間";
            // 
            // Form_Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 448);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_Alarm";
            this.Text = "體溫異常警告";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pB_photo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tB_sex;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tB_temp;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tB_place;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tB_address;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tB_CTEL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tB_CWHO;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tB_tTEL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tB_teacher;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tB_class;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tB_tagId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tB_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tB_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pB_photo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tB_time;
        private System.Windows.Forms.TextBox tB_date;
    }
}