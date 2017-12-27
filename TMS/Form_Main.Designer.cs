namespace TMS
{
    partial class Form_Main
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMI_System = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_ExitSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_ChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Temperature = new System.Windows.Forms.ToolStripMenuItem();
            this.開啟即時監控ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.關閉即時監控ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.設定體溫範圍ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TStMI_Data = new System.Windows.Forms.ToolStripMenuItem();
            this.學生資料ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.學生資料ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.查詢硬體設備ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_S = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.tESTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tSSL_StateTitle = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSSL_State = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSSL_NowTitle = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSSL_Now = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.權限設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增學生資料ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.發送簡訊電子郵件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查詢登入紀錄ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_System,
            this.TSMI_Temperature,
            this.TStMI_Data,
            this.TSMI_S,
            this.TSMI_Help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(721, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSMI_System
            // 
            this.TSMI_System.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_ExitSystem,
            this.toolStripMenuItem1,
            this.TSMI_ChangePassword});
            this.TSMI_System.Name = "TSMI_System";
            this.TSMI_System.Size = new System.Drawing.Size(79, 20);
            this.TSMI_System.Text = "系統功能(&S)";
            // 
            // TSMI_ExitSystem
            // 
            this.TSMI_ExitSystem.Name = "TSMI_ExitSystem";
            this.TSMI_ExitSystem.Size = new System.Drawing.Size(118, 22);
            this.TSMI_ExitSystem.Text = "離開系統";
            this.TSMI_ExitSystem.Click += new System.EventHandler(this.TSMI_ExitSystem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(115, 6);
            // 
            // TSMI_ChangePassword
            // 
            this.TSMI_ChangePassword.Name = "TSMI_ChangePassword";
            this.TSMI_ChangePassword.Size = new System.Drawing.Size(118, 22);
            this.TSMI_ChangePassword.Text = "變更密碼";
            this.TSMI_ChangePassword.Click += new System.EventHandler(this.TSMI_ChangePassword_Click);
            // 
            // TSMI_Temperature
            // 
            this.TSMI_Temperature.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開啟即時監控ToolStripMenuItem,
            this.關閉即時監控ToolStripMenuItem,
            this.toolStripSeparator5,
            this.設定體溫範圍ToolStripMenuItem});
            this.TSMI_Temperature.Name = "TSMI_Temperature";
            this.TSMI_Temperature.Size = new System.Drawing.Size(80, 20);
            this.TSMI_Temperature.Text = "體溫控管(&T)";
            // 
            // 開啟即時監控ToolStripMenuItem
            // 
            this.開啟即時監控ToolStripMenuItem.Name = "開啟即時監控ToolStripMenuItem";
            this.開啟即時監控ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.開啟即時監控ToolStripMenuItem.Text = "開啟即時監控";
            // 
            // 關閉即時監控ToolStripMenuItem
            // 
            this.關閉即時監控ToolStripMenuItem.Name = "關閉即時監控ToolStripMenuItem";
            this.關閉即時監控ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.關閉即時監控ToolStripMenuItem.Text = "關閉即時監控";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(149, 6);
            // 
            // 設定體溫範圍ToolStripMenuItem
            // 
            this.設定體溫範圍ToolStripMenuItem.Name = "設定體溫範圍ToolStripMenuItem";
            this.設定體溫範圍ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.設定體溫範圍ToolStripMenuItem.Text = "設定體溫範圍";
            // 
            // TStMI_Data
            // 
            this.TStMI_Data.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.學生資料ToolStripMenuItem,
            this.查詢硬體設備ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.新增學生資料ToolStripMenuItem});
            this.TStMI_Data.Name = "TStMI_Data";
            this.TStMI_Data.Size = new System.Drawing.Size(81, 20);
            this.TStMI_Data.Text = "資料管理(&D)";
            // 
            // 學生資料ToolStripMenuItem
            // 
            this.學生資料ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.學生資料ToolStripMenuItem1});
            this.學生資料ToolStripMenuItem.Name = "學生資料ToolStripMenuItem";
            this.學生資料ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.學生資料ToolStripMenuItem.Text = "查詢學生資料";
            // 
            // 學生資料ToolStripMenuItem1
            // 
            this.學生資料ToolStripMenuItem1.Name = "學生資料ToolStripMenuItem1";
            this.學生資料ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.學生資料ToolStripMenuItem1.Text = "學生資料";
            // 
            // 查詢硬體設備ToolStripMenuItem
            // 
            this.查詢硬體設備ToolStripMenuItem.Name = "查詢硬體設備ToolStripMenuItem";
            this.查詢硬體設備ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.查詢硬體設備ToolStripMenuItem.Text = "查詢硬體設備";
            this.查詢硬體設備ToolStripMenuItem.Click += new System.EventHandler(this.查詢硬體設備ToolStripMenuItem_Click);
            // 
            // TSMI_S
            // 
            this.TSMI_S.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.權限設定ToolStripMenuItem,
            this.發送簡訊電子郵件ToolStripMenuItem,
            this.查詢登入紀錄ToolStripMenuItem});
            this.TSMI_S.Name = "TSMI_S";
            this.TSMI_S.Size = new System.Drawing.Size(79, 20);
            this.TSMI_S.Text = "功能設定(&F)";
            // 
            // TSMI_Help
            // 
            this.TSMI_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tESTToolStripMenuItem});
            this.TSMI_Help.Name = "TSMI_Help";
            this.TSMI_Help.Size = new System.Drawing.Size(57, 20);
            this.TSMI_Help.Text = "說明(&H)";
            // 
            // tESTToolStripMenuItem
            // 
            this.tESTToolStripMenuItem.Name = "tESTToolStripMenuItem";
            this.tESTToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.tESTToolStripMenuItem.Text = "關於體溫控管系統";
            this.tESTToolStripMenuItem.Click += new System.EventHandler(this.tESTToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSSL_StateTitle,
            this.tSSL_State,
            this.tSSL_NowTitle,
            this.tSSL_Now});
            this.statusStrip1.Location = new System.Drawing.Point(0, 522);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(721, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tSSL_StateTitle
            // 
            this.tSSL_StateTitle.Name = "tSSL_StateTitle";
            this.tSSL_StateTitle.Size = new System.Drawing.Size(56, 17);
            this.tSSL_StateTitle.Text = "偵測狀態:";
            // 
            // tSSL_State
            // 
            this.tSSL_State.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tSSL_State.Name = "tSSL_State";
            this.tSSL_State.Size = new System.Drawing.Size(38, 17);
            this.tSSL_State.Text = "關閉...";
            // 
            // tSSL_NowTitle
            // 
            this.tSSL_NowTitle.Name = "tSSL_NowTitle";
            this.tSSL_NowTitle.Size = new System.Drawing.Size(56, 17);
            this.tSSL_NowTitle.Text = "目前時刻:";
            // 
            // tSSL_Now
            // 
            this.tSSL_Now.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tSSL_Now.Name = "tSSL_Now";
            this.tSSL_Now.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tSSL_Now.Size = new System.Drawing.Size(119, 17);
            this.tSSL_Now.Text = "2009年6月1日12:00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 492);
            this.panel1.TabIndex = 3;
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
            // 
            // 權限設定ToolStripMenuItem
            // 
            this.權限設定ToolStripMenuItem.Name = "權限設定ToolStripMenuItem";
            this.權限設定ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.權限設定ToolStripMenuItem.Text = "權限設定";
            // 
            // 新增學生資料ToolStripMenuItem
            // 
            this.新增學生資料ToolStripMenuItem.Name = "新增學生資料ToolStripMenuItem";
            this.新增學生資料ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.新增學生資料ToolStripMenuItem.Text = "新增學生資料";
            // 
            // 發送簡訊電子郵件ToolStripMenuItem
            // 
            this.發送簡訊電子郵件ToolStripMenuItem.Name = "發送簡訊電子郵件ToolStripMenuItem";
            this.發送簡訊電子郵件ToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.發送簡訊電子郵件ToolStripMenuItem.Text = "發送簡訊/電子郵件";
            // 
            // 查詢登入紀錄ToolStripMenuItem
            // 
            this.查詢登入紀錄ToolStripMenuItem.Name = "查詢登入紀錄ToolStripMenuItem";
            this.查詢登入紀錄ToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.查詢登入紀錄ToolStripMenuItem.Text = "查詢登入紀錄";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 544);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Main";
            this.Text = "體溫控管系統(TMS)  V1.0";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_System;
        private System.Windows.Forms.ToolStripMenuItem TSMI_ExitSystem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Temperature;
        private System.Windows.Forms.ToolStripMenuItem 開啟即時監控ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 關閉即時監控ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem 設定體溫範圍ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TStMI_Data;
        private System.Windows.Forms.ToolStripMenuItem 學生資料ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Help;
        private System.Windows.Forms.ToolStripMenuItem 學生資料ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_S;
        private System.Windows.Forms.ToolStripStatusLabel tSSL_NowTitle;
        private System.Windows.Forms.ToolStripStatusLabel tSSL_Now;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel tSSL_StateTitle;
        private System.Windows.Forms.ToolStripMenuItem tESTToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripMenuItem TSMI_ChangePassword;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ToolStripStatusLabel tSSL_State;
        public System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem 查詢硬體設備ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 權限設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增學生資料ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 發送簡訊電子郵件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查詢登入紀錄ToolStripMenuItem;
    }
}

