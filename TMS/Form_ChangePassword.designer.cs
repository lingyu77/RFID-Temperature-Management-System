namespace TMS
{
    partial class Form_ChangePassword
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
            this.tB_OldPW = new System.Windows.Forms.TextBox();
            this.tB_NewPW = new System.Windows.Forms.TextBox();
            this.tB_NewRPW = new System.Windows.Forms.TextBox();
            this.bt_Sure = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.OldPW = new System.Windows.Forms.Label();
            this.NewPW = new System.Windows.Forms.Label();
            this.PWstrong = new System.Windows.Forms.Label();
            this.NewRPW = new System.Windows.Forms.Label();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tB_Id = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.p4 = new System.Windows.Forms.PictureBox();
            this.p3 = new System.Windows.Forms.PictureBox();
            this.p2 = new System.Windows.Forms.PictureBox();
            this.p1 = new System.Windows.Forms.PictureBox();
            this.strong = new System.Windows.Forms.Label();
            this.weak = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).BeginInit();
            this.SuspendLayout();
            // 
            // tB_OldPW
            // 
            this.tB_OldPW.Location = new System.Drawing.Point(105, 50);
            this.tB_OldPW.Name = "tB_OldPW";
            this.tB_OldPW.PasswordChar = '*';
            this.tB_OldPW.Size = new System.Drawing.Size(155, 22);
            this.tB_OldPW.TabIndex = 0;
            // 
            // tB_NewPW
            // 
            this.tB_NewPW.Location = new System.Drawing.Point(105, 21);
            this.tB_NewPW.Name = "tB_NewPW";
            this.tB_NewPW.PasswordChar = '*';
            this.tB_NewPW.Size = new System.Drawing.Size(155, 22);
            this.tB_NewPW.TabIndex = 1;
            this.tB_NewPW.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tB_NewPW_KeyDown);
            // 
            // tB_NewRPW
            // 
            this.tB_NewRPW.Location = new System.Drawing.Point(105, 110);
            this.tB_NewRPW.Name = "tB_NewRPW";
            this.tB_NewRPW.PasswordChar = '*';
            this.tB_NewRPW.Size = new System.Drawing.Size(155, 22);
            this.tB_NewRPW.TabIndex = 2;
            // 
            // bt_Sure
            // 
            this.bt_Sure.Location = new System.Drawing.Point(128, 270);
            this.bt_Sure.Name = "bt_Sure";
            this.bt_Sure.Size = new System.Drawing.Size(80, 23);
            this.bt_Sure.TabIndex = 3;
            this.bt_Sure.Text = "儲存";
            this.bt_Sure.UseVisualStyleBackColor = true;
            this.bt_Sure.Click += new System.EventHandler(this.bt_Sure_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "使用者帳號";
            // 
            // OldPW
            // 
            this.OldPW.AutoSize = true;
            this.OldPW.Location = new System.Drawing.Point(21, 60);
            this.OldPW.Name = "OldPW";
            this.OldPW.Size = new System.Drawing.Size(41, 12);
            this.OldPW.TabIndex = 5;
            this.OldPW.Text = "舊密碼";
            // 
            // NewPW
            // 
            this.NewPW.AutoSize = true;
            this.NewPW.Location = new System.Drawing.Point(18, 24);
            this.NewPW.Name = "NewPW";
            this.NewPW.Size = new System.Drawing.Size(65, 12);
            this.NewPW.TabIndex = 6;
            this.NewPW.Text = "輸入新密碼";
            // 
            // PWstrong
            // 
            this.PWstrong.AutoSize = true;
            this.PWstrong.Location = new System.Drawing.Point(6, 72);
            this.PWstrong.Name = "PWstrong";
            this.PWstrong.Size = new System.Drawing.Size(77, 12);
            this.PWstrong.TabIndex = 7;
            this.PWstrong.Text = "密碼安全強度";
            // 
            // NewRPW
            // 
            this.NewRPW.AutoSize = true;
            this.NewRPW.Location = new System.Drawing.Point(6, 113);
            this.NewRPW.Name = "NewRPW";
            this.NewRPW.Size = new System.Drawing.Size(89, 12);
            this.NewRPW.TabIndex = 8;
            this.NewRPW.Text = "重新輸入新密碼";
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.Location = new System.Drawing.Point(228, 270);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(80, 23);
            this.bt_Cancel.TabIndex = 9;
            this.bt_Cancel.Text = "取消";
            this.bt_Cancel.UseVisualStyleBackColor = true;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label6.Location = new System.Drawing.Point(157, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "最少4個字元";
            // 
            // tB_Id
            // 
            this.tB_Id.Location = new System.Drawing.Point(105, 21);
            this.tB_Id.Name = "tB_Id";
            this.tB_Id.Size = new System.Drawing.Size(155, 22);
            this.tB_Id.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tB_Id);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tB_OldPW);
            this.groupBox1.Controls.Add(this.OldPW);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 89);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "使用者資料";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.weak);
            this.groupBox2.Controls.Add(this.strong);
            this.groupBox2.Controls.Add(this.p4);
            this.groupBox2.Controls.Add(this.p3);
            this.groupBox2.Controls.Add(this.p2);
            this.groupBox2.Controls.Add(this.p1);
            this.groupBox2.Controls.Add(this.tB_NewPW);
            this.groupBox2.Controls.Add(this.NewPW);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.NewRPW);
            this.groupBox2.Controls.Add(this.PWstrong);
            this.groupBox2.Controls.Add(this.tB_NewRPW);
            this.groupBox2.Location = new System.Drawing.Point(23, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 148);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "更改資料";
            // 
            // p4
            // 
            this.p4.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.p4.Location = new System.Drawing.Point(212, 72);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(36, 22);
            this.p4.TabIndex = 14;
            this.p4.TabStop = false;
            // 
            // p3
            // 
            this.p3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.p3.Location = new System.Drawing.Point(180, 72);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(36, 22);
            this.p3.TabIndex = 13;
            this.p3.TabStop = false;
            // 
            // p2
            // 
            this.p2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.p2.Location = new System.Drawing.Point(147, 72);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(36, 22);
            this.p2.TabIndex = 12;
            this.p2.TabStop = false;
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.p1.Location = new System.Drawing.Point(113, 72);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(36, 22);
            this.p1.TabIndex = 11;
            this.p1.TabStop = false;
            // 
            // strong
            // 
            this.strong.AutoSize = true;
            this.strong.Location = new System.Drawing.Point(254, 84);
            this.strong.Name = "strong";
            this.strong.Size = new System.Drawing.Size(17, 12);
            this.strong.TabIndex = 15;
            this.strong.Text = "強";
            // 
            // weak
            // 
            this.weak.AutoSize = true;
            this.weak.Location = new System.Drawing.Point(90, 82);
            this.weak.Name = "weak";
            this.weak.Size = new System.Drawing.Size(17, 12);
            this.weak.TabIndex = 16;
            this.weak.Text = "弱";
            // 
            // Form_ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 310);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.bt_Sure);
            this.Name = "Form_ChangePassword";
            this.Text = "密碼變更";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tB_OldPW;
        private System.Windows.Forms.TextBox tB_NewPW;
        private System.Windows.Forms.TextBox tB_NewRPW;
        private System.Windows.Forms.Button bt_Sure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label OldPW;
        private System.Windows.Forms.Label NewPW;
        private System.Windows.Forms.Label PWstrong;
        private System.Windows.Forms.Label NewRPW;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tB_Id;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox p3;
        private System.Windows.Forms.PictureBox p2;
        private System.Windows.Forms.PictureBox p1;
        private System.Windows.Forms.PictureBox p4;
        private System.Windows.Forms.Label weak;
        private System.Windows.Forms.Label strong;
    }
}