namespace TMS
{
    partial class Form_setTemp
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
            this.temp_up = new System.Windows.Forms.TextBox();
            this.temp_down = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.up_point = new System.Windows.Forms.TextBox();
            this.down_point = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // temp_up
            // 
            this.temp_up.Location = new System.Drawing.Point(92, 26);
            this.temp_up.Name = "temp_up";
            this.temp_up.Size = new System.Drawing.Size(25, 22);
            this.temp_up.TabIndex = 0;
            this.temp_up.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.temp_KeyPress);
            // 
            // temp_down
            // 
            this.temp_down.Location = new System.Drawing.Point(92, 69);
            this.temp_down.Name = "temp_down";
            this.temp_down.Size = new System.Drawing.Size(25, 22);
            this.temp_down.TabIndex = 1;
            this.temp_down.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.temp_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "體溫上限";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "體溫下限";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "度";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "度";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "確定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(8, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = ".";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(8, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = ".";
            // 
            // up_point
            // 
            this.up_point.Location = new System.Drawing.Point(123, 26);
            this.up_point.Name = "up_point";
            this.up_point.Size = new System.Drawing.Size(13, 22);
            this.up_point.TabIndex = 9;
            this.up_point.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.temp_KeyPress);
            // 
            // down_point
            // 
            this.down_point.Location = new System.Drawing.Point(123, 69);
            this.down_point.Name = "down_point";
            this.down_point.Size = new System.Drawing.Size(13, 22);
            this.down_point.TabIndex = 10;
            this.down_point.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.temp_KeyPress);
            // 
            // Form_setTemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 148);
            this.Controls.Add(this.down_point);
            this.Controls.Add(this.up_point);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.temp_down);
            this.Controls.Add(this.temp_up);
            this.Name = "Form_setTemp";
            this.Text = "設定異常體溫範圍";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox temp_up;
        private System.Windows.Forms.TextBox temp_down;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox up_point;
        private System.Windows.Forms.TextBox down_point;
    }
}