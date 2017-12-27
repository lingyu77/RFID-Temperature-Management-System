namespace TMS
{
    partial class Form_SearchT
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tB_find = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Search = new System.Windows.Forms.Button();
            this.cB_condition = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tB_meno = new System.Windows.Forms.TextBox();
            this.tB_type = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tB_buy_money = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tB_manager = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tB_buy_date = new System.Windows.Forms.TextBox();
            this.tB_id = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.tB_type);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tB_buy_money);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tB_manager);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tB_buy_date);
            this.groupBox2.Controls.Add(this.tB_id);
            this.groupBox2.Location = new System.Drawing.Point(12, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 224);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "查詢結果";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tB_find);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bt_Search);
            this.groupBox1.Controls.Add(this.cB_condition);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 74);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查詢條件";
            // 
            // tB_find
            // 
            this.tB_find.Location = new System.Drawing.Point(256, 29);
            this.tB_find.Name = "tB_find";
            this.tB_find.Size = new System.Drawing.Size(100, 22);
            this.tB_find.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "硬體編號";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "查詢項目";
            // 
            // bt_Search
            // 
            this.bt_Search.Location = new System.Drawing.Point(368, 21);
            this.bt_Search.Name = "bt_Search";
            this.bt_Search.Size = new System.Drawing.Size(75, 41);
            this.bt_Search.TabIndex = 2;
            this.bt_Search.Text = "查尋";
            this.bt_Search.UseVisualStyleBackColor = true;
            this.bt_Search.Click += new System.EventHandler(this.bt_Search_Click);
            // 
            // cB_condition
            // 
            this.cB_condition.FormattingEnabled = true;
            this.cB_condition.Items.AddRange(new object[] {
            "Reader",
            "Tag"});
            this.cB_condition.Location = new System.Drawing.Point(65, 29);
            this.cB_condition.Name = "cB_condition";
            this.cB_condition.Size = new System.Drawing.Size(109, 20);
            this.cB_condition.TabIndex = 0;
            this.cB_condition.Text = "　---請選擇---";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tB_meno);
            this.groupBox3.Location = new System.Drawing.Point(196, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(251, 191);
            this.groupBox3.TabIndex = 58;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "說明";
            // 
            // tB_meno
            // 
            this.tB_meno.Location = new System.Drawing.Point(18, 21);
            this.tB_meno.Multiline = true;
            this.tB_meno.Name = "tB_meno";
            this.tB_meno.Size = new System.Drawing.Size(218, 163);
            this.tB_meno.TabIndex = 24;
            // 
            // tB_type
            // 
            this.tB_type.Location = new System.Drawing.Point(78, 186);
            this.tB_type.Name = "tB_type";
            this.tB_type.Size = new System.Drawing.Size(100, 22);
            this.tB_type.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 56;
            this.label6.Text = "產品型號";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 55;
            this.label5.Text = "購入金額";
            // 
            // tB_buy_money
            // 
            this.tB_buy_money.Location = new System.Drawing.Point(78, 109);
            this.tB_buy_money.Name = "tB_buy_money";
            this.tB_buy_money.Size = new System.Drawing.Size(100, 22);
            this.tB_buy_money.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 53;
            this.label4.Text = "管理單位";
            // 
            // tB_manager
            // 
            this.tB_manager.Location = new System.Drawing.Point(78, 148);
            this.tB_manager.Name = "tB_manager";
            this.tB_manager.Size = new System.Drawing.Size(100, 22);
            this.tB_manager.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 51;
            this.label3.Text = "購入日期";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 50;
            this.label7.Text = "設備編號";
            // 
            // tB_buy_date
            // 
            this.tB_buy_date.Location = new System.Drawing.Point(78, 67);
            this.tB_buy_date.Name = "tB_buy_date";
            this.tB_buy_date.Size = new System.Drawing.Size(100, 22);
            this.tB_buy_date.TabIndex = 49;
            // 
            // tB_id
            // 
            this.tB_id.Location = new System.Drawing.Point(78, 23);
            this.tB_id.Name = "tB_id";
            this.tB_id.Size = new System.Drawing.Size(100, 22);
            this.tB_id.TabIndex = 48;
            // 
            // Form_SearchT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 344);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_SearchT";
            this.Text = "查詢硬體設備";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Search;
        private System.Windows.Forms.ComboBox cB_condition;
        private System.Windows.Forms.TextBox tB_find;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox tB_meno;
        public System.Windows.Forms.TextBox tB_type;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tB_buy_money;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tB_manager;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox tB_buy_date;
        public System.Windows.Forms.TextBox tB_id;
    }
}