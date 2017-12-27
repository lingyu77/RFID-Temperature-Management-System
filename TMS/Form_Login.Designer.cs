namespace TMS
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.bt_Sure = new System.Windows.Forms.Button();
            this.tB_Id = new System.Windows.Forms.TextBox();
            this.tB_Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_Sure
            // 
            this.bt_Sure.BackColor = System.Drawing.SystemColors.Window;
            this.bt_Sure.Location = new System.Drawing.Point(285, 172);
            this.bt_Sure.Name = "bt_Sure";
            this.bt_Sure.Size = new System.Drawing.Size(75, 23);
            this.bt_Sure.TabIndex = 0;
            this.bt_Sure.Text = "確定";
            this.bt_Sure.UseVisualStyleBackColor = false;
            this.bt_Sure.Click += new System.EventHandler(this.bt_Sure_Click);
            // 
            // tB_Id
            // 
            this.tB_Id.BackColor = System.Drawing.SystemColors.Window;
            this.tB_Id.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tB_Id.Location = new System.Drawing.Point(248, 88);
            this.tB_Id.Name = "tB_Id";
            this.tB_Id.Size = new System.Drawing.Size(151, 22);
            this.tB_Id.TabIndex = 1;
            // 
            // tB_Password
            // 
            this.tB_Password.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tB_Password.Location = new System.Drawing.Point(248, 127);
            this.tB_Password.Name = "tB_Password";
            this.tB_Password.PasswordChar = '*';
            this.tB_Password.Size = new System.Drawing.Size(151, 22);
            this.tB_Password.TabIndex = 2;
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(443, 273);
            this.Controls.Add(this.tB_Password);
            this.Controls.Add(this.tB_Id);
            this.Controls.Add(this.bt_Sure);
            this.Name = "Form_Login";
            this.Text = "登入";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Login_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Sure;
        private System.Windows.Forms.TextBox tB_Id;
        private System.Windows.Forms.TextBox tB_Password;
    }
}