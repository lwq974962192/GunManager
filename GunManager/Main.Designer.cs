namespace GunManager
{
    partial class Main
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
            if (disposing && (components != null))
            {
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
            this.main_welcome = new System.Windows.Forms.Label();
            this.logout_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.main_com_box = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.main_rate_box = new System.Windows.Forms.ComboBox();
            this.main_remain = new System.Windows.Forms.Label();
            this.main_open_com = new System.Windows.Forms.Button();
            this.main_close_com = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.main_del = new System.Windows.Forms.Button();
            this.main_refresh = new System.Windows.Forms.Button();
            this.main_save = new System.Windows.Forms.Button();
            this.main_cancel = new System.Windows.Forms.Button();
            this.main_text = new System.Windows.Forms.TextBox();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.main_in_read = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.main_destroy_read = new System.Windows.Forms.Button();
            this.main_destroy_remark = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.main_destroy_button = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.main_repair_read = new System.Windows.Forms.Button();
            this.main_repair_remark = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.main_repair_button = new System.Windows.Forms.Button();
            this.main_page2 = new System.Windows.Forms.TabPage();
            this.monitor_start = new System.Windows.Forms.Button();
            this.monitor_stop = new System.Windows.Forms.Button();
            this.main_page1 = new System.Windows.Forms.TabPage();
            this.main_doc_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.main_in_button = new System.Windows.Forms.Button();
            this.main_tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.main_out_remark = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.main_out_button = new System.Windows.Forms.Button();
            this.main_out_read = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.main_page2.SuspendLayout();
            this.main_page1.SuspendLayout();
            this.main_tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_welcome
            // 
            this.main_welcome.AutoSize = true;
            this.main_welcome.Location = new System.Drawing.Point(13, 8);
            this.main_welcome.MaximumSize = new System.Drawing.Size(150, 15);
            this.main_welcome.MinimumSize = new System.Drawing.Size(150, 15);
            this.main_welcome.Name = "main_welcome";
            this.main_welcome.Size = new System.Drawing.Size(150, 15);
            this.main_welcome.TabIndex = 0;
            this.main_welcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // logout_button
            // 
            this.logout_button.Location = new System.Drawing.Point(566, 4);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(75, 23);
            this.logout_button.TabIndex = 1;
            this.logout_button.Text = "注销";
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.my_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(647, 4);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(75, 23);
            this.exit_button.TabIndex = 2;
            this.exit_button.Text = "退出";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.my_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "串口号：";
            // 
            // main_com_box
            // 
            this.main_com_box.FormattingEnabled = true;
            this.main_com_box.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5"});
            this.main_com_box.Location = new System.Drawing.Point(94, 36);
            this.main_com_box.Name = "main_com_box";
            this.main_com_box.Size = new System.Drawing.Size(121, 20);
            this.main_com_box.TabIndex = 4;
            this.main_com_box.Text = "请选择串口";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "波特率：";
            // 
            // main_rate_box
            // 
            this.main_rate_box.FormattingEnabled = true;
            this.main_rate_box.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.main_rate_box.Location = new System.Drawing.Point(94, 62);
            this.main_rate_box.Name = "main_rate_box";
            this.main_rate_box.Size = new System.Drawing.Size(121, 20);
            this.main_rate_box.TabIndex = 6;
            this.main_rate_box.Text = "请选择波特率";
            // 
            // main_remain
            // 
            this.main_remain.AutoSize = true;
            this.main_remain.Location = new System.Drawing.Point(305, 9);
            this.main_remain.MaximumSize = new System.Drawing.Size(200, 15);
            this.main_remain.MinimumSize = new System.Drawing.Size(200, 15);
            this.main_remain.Name = "main_remain";
            this.main_remain.Size = new System.Drawing.Size(200, 15);
            this.main_remain.TabIndex = 7;
            // 
            // main_open_com
            // 
            this.main_open_com.Location = new System.Drawing.Point(15, 90);
            this.main_open_com.Name = "main_open_com";
            this.main_open_com.Size = new System.Drawing.Size(90, 23);
            this.main_open_com.TabIndex = 8;
            this.main_open_com.Text = "打开串口";
            this.main_open_com.UseVisualStyleBackColor = true;
            this.main_open_com.Click += new System.EventHandler(this.my_button_Click);
            // 
            // main_close_com
            // 
            this.main_close_com.Location = new System.Drawing.Point(125, 90);
            this.main_close_com.Name = "main_close_com";
            this.main_close_com.Size = new System.Drawing.Size(90, 23);
            this.main_close_com.TabIndex = 9;
            this.main_close_com.Text = "关闭串口";
            this.main_close_com.UseVisualStyleBackColor = true;
            this.main_close_com.Click += new System.EventHandler(this.my_button_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGrid.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(221, 122);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowTemplate.Height = 23;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(500, 177);
            this.dataGrid.TabIndex = 11;
            // 
            // main_del
            // 
            this.main_del.Location = new System.Drawing.Point(353, 309);
            this.main_del.Name = "main_del";
            this.main_del.Size = new System.Drawing.Size(100, 23);
            this.main_del.TabIndex = 12;
            this.main_del.Text = "删除";
            this.main_del.UseVisualStyleBackColor = true;
            this.main_del.Click += new System.EventHandler(this.my_button_Click);
            // 
            // main_refresh
            // 
            this.main_refresh.Location = new System.Drawing.Point(491, 309);
            this.main_refresh.Name = "main_refresh";
            this.main_refresh.Size = new System.Drawing.Size(100, 23);
            this.main_refresh.TabIndex = 12;
            this.main_refresh.Text = "刷新";
            this.main_refresh.UseVisualStyleBackColor = true;
            this.main_refresh.Click += new System.EventHandler(this.my_button_Click);
            // 
            // main_save
            // 
            this.main_save.Location = new System.Drawing.Point(221, 309);
            this.main_save.Name = "main_save";
            this.main_save.Size = new System.Drawing.Size(100, 23);
            this.main_save.TabIndex = 12;
            this.main_save.Text = "保存";
            this.main_save.UseVisualStyleBackColor = true;
            this.main_save.Click += new System.EventHandler(this.my_button_Click);
            // 
            // main_cancel
            // 
            this.main_cancel.Location = new System.Drawing.Point(622, 309);
            this.main_cancel.Name = "main_cancel";
            this.main_cancel.Size = new System.Drawing.Size(100, 23);
            this.main_cancel.TabIndex = 12;
            this.main_cancel.Text = "取消";
            this.main_cancel.UseVisualStyleBackColor = true;
            this.main_cancel.Click += new System.EventHandler(this.my_button_Click);
            // 
            // main_text
            // 
            this.main_text.Location = new System.Drawing.Point(221, 36);
            this.main_text.Multiline = true;
            this.main_text.Name = "main_text";
            this.main_text.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.main_text.Size = new System.Drawing.Size(500, 77);
            this.main_text.TabIndex = 13;
            // 
            // main_in_read
            // 
            this.main_in_read.Location = new System.Drawing.Point(8, 6);
            this.main_in_read.Name = "main_in_read";
            this.main_in_read.Size = new System.Drawing.Size(184, 23);
            this.main_in_read.TabIndex = 11;
            this.main_in_read.Text = "读取标签";
            this.main_in_read.UseVisualStyleBackColor = true;
            this.main_in_read.Click += new System.EventHandler(this.main_in_read__Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.main_destroy_read);
            this.tabPage3.Controls.Add(this.main_destroy_remark);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.main_destroy_button);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(198, 184);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "销毁";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // main_destroy_read
            // 
            this.main_destroy_read.Location = new System.Drawing.Point(8, 6);
            this.main_destroy_read.Name = "main_destroy_read";
            this.main_destroy_read.Size = new System.Drawing.Size(184, 23);
            this.main_destroy_read.TabIndex = 26;
            this.main_destroy_read.Text = "读取标签";
            this.main_destroy_read.UseVisualStyleBackColor = true;
            this.main_destroy_read.Click += new System.EventHandler(this.main_destroy_read_Click);
            // 
            // main_destroy_remark
            // 
            this.main_destroy_remark.Location = new System.Drawing.Point(52, 35);
            this.main_destroy_remark.Name = "main_destroy_remark";
            this.main_destroy_remark.Size = new System.Drawing.Size(140, 21);
            this.main_destroy_remark.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 24;
            this.label4.Text = "备注：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // main_destroy_button
            // 
            this.main_destroy_button.Location = new System.Drawing.Point(8, 62);
            this.main_destroy_button.Name = "main_destroy_button";
            this.main_destroy_button.Size = new System.Drawing.Size(184, 116);
            this.main_destroy_button.TabIndex = 0;
            this.main_destroy_button.Text = "销毁";
            this.main_destroy_button.UseVisualStyleBackColor = true;
            this.main_destroy_button.Click += new System.EventHandler(this.main_destroy_button_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.main_repair_read);
            this.tabPage2.Controls.Add(this.main_repair_remark);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.main_repair_button);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(198, 184);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "维修";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // main_repair_read
            // 
            this.main_repair_read.Location = new System.Drawing.Point(8, 6);
            this.main_repair_read.Name = "main_repair_read";
            this.main_repair_read.Size = new System.Drawing.Size(184, 23);
            this.main_repair_read.TabIndex = 25;
            this.main_repair_read.Text = "读取标签";
            this.main_repair_read.UseVisualStyleBackColor = true;
            this.main_repair_read.Click += new System.EventHandler(this.main_repair_read_Click);
            // 
            // main_repair_remark
            // 
            this.main_repair_remark.Location = new System.Drawing.Point(52, 35);
            this.main_repair_remark.Name = "main_repair_remark";
            this.main_repair_remark.Size = new System.Drawing.Size(140, 21);
            this.main_repair_remark.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 23;
            this.label3.Text = "备注：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // main_repair_button
            // 
            this.main_repair_button.Location = new System.Drawing.Point(8, 62);
            this.main_repair_button.Name = "main_repair_button";
            this.main_repair_button.Size = new System.Drawing.Size(184, 116);
            this.main_repair_button.TabIndex = 0;
            this.main_repair_button.Text = "维修";
            this.main_repair_button.UseVisualStyleBackColor = true;
            this.main_repair_button.Click += new System.EventHandler(this.main_repair_button_Click);
            // 
            // main_page2
            // 
            this.main_page2.Controls.Add(this.monitor_start);
            this.main_page2.Controls.Add(this.monitor_stop);
            this.main_page2.Location = new System.Drawing.Point(4, 22);
            this.main_page2.Name = "main_page2";
            this.main_page2.Padding = new System.Windows.Forms.Padding(3);
            this.main_page2.Size = new System.Drawing.Size(198, 184);
            this.main_page2.TabIndex = 1;
            this.main_page2.Text = "监控";
            this.main_page2.UseVisualStyleBackColor = true;
            // 
            // monitor_start
            // 
            this.monitor_start.Location = new System.Drawing.Point(11, 6);
            this.monitor_start.Name = "monitor_start";
            this.monitor_start.Size = new System.Drawing.Size(180, 78);
            this.monitor_start.TabIndex = 16;
            this.monitor_start.Text = "开始监视";
            this.monitor_start.UseVisualStyleBackColor = true;
            this.monitor_start.Click += new System.EventHandler(this.monitor_start_Click);
            // 
            // monitor_stop
            // 
            this.monitor_stop.Location = new System.Drawing.Point(11, 90);
            this.monitor_stop.Name = "monitor_stop";
            this.monitor_stop.Size = new System.Drawing.Size(180, 88);
            this.monitor_stop.TabIndex = 16;
            this.monitor_stop.Text = "停止监视";
            this.monitor_stop.UseVisualStyleBackColor = true;
            this.monitor_stop.Click += new System.EventHandler(this.monitor_stop_Click);
            // 
            // main_page1
            // 
            this.main_page1.Controls.Add(this.main_doc_id);
            this.main_page1.Controls.Add(this.label5);
            this.main_page1.Controls.Add(this.main_in_button);
            this.main_page1.Controls.Add(this.main_in_read);
            this.main_page1.Location = new System.Drawing.Point(4, 22);
            this.main_page1.Name = "main_page1";
            this.main_page1.Padding = new System.Windows.Forms.Padding(3);
            this.main_page1.Size = new System.Drawing.Size(198, 184);
            this.main_page1.TabIndex = 0;
            this.main_page1.Text = "入库";
            this.main_page1.UseVisualStyleBackColor = true;
            // 
            // main_doc_id
            // 
            this.main_doc_id.Location = new System.Drawing.Point(52, 35);
            this.main_doc_id.Name = "main_doc_id";
            this.main_doc_id.Size = new System.Drawing.Size(140, 21);
            this.main_doc_id.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 22;
            this.label5.Text = "编号：";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // main_in_button
            // 
            this.main_in_button.Location = new System.Drawing.Point(8, 62);
            this.main_in_button.Name = "main_in_button";
            this.main_in_button.Size = new System.Drawing.Size(184, 116);
            this.main_in_button.TabIndex = 16;
            this.main_in_button.Text = "入库";
            this.main_in_button.UseVisualStyleBackColor = true;
            this.main_in_button.Click += new System.EventHandler(this.main_in_button_Click);
            // 
            // main_tab
            // 
            this.main_tab.Controls.Add(this.main_page1);
            this.main_tab.Controls.Add(this.tabPage1);
            this.main_tab.Controls.Add(this.tabPage2);
            this.main_tab.Controls.Add(this.tabPage3);
            this.main_tab.Controls.Add(this.main_page2);
            this.main_tab.Location = new System.Drawing.Point(9, 122);
            this.main_tab.Name = "main_tab";
            this.main_tab.SelectedIndex = 0;
            this.main_tab.Size = new System.Drawing.Size(206, 210);
            this.main_tab.TabIndex = 17;
            this.main_tab.SelectedIndexChanged += new System.EventHandler(this.main_tab_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.main_out_remark);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.main_out_button);
            this.tabPage1.Controls.Add(this.main_out_read);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(198, 184);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "出库归还";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // main_out_remark
            // 
            this.main_out_remark.Location = new System.Drawing.Point(52, 35);
            this.main_out_remark.Name = "main_out_remark";
            this.main_out_remark.Size = new System.Drawing.Size(140, 21);
            this.main_out_remark.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 25;
            this.label6.Text = "备注：";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // main_out_button
            // 
            this.main_out_button.Location = new System.Drawing.Point(7, 62);
            this.main_out_button.Name = "main_out_button";
            this.main_out_button.Size = new System.Drawing.Size(184, 116);
            this.main_out_button.TabIndex = 18;
            this.main_out_button.Text = "出库";
            this.main_out_button.UseVisualStyleBackColor = true;
            this.main_out_button.Click += new System.EventHandler(this.main_out_button_Click);
            // 
            // main_out_read
            // 
            this.main_out_read.Location = new System.Drawing.Point(8, 6);
            this.main_out_read.Name = "main_out_read";
            this.main_out_read.Size = new System.Drawing.Size(184, 23);
            this.main_out_read.TabIndex = 12;
            this.main_out_read.Text = "读取标签";
            this.main_out_read.UseVisualStyleBackColor = true;
            this.main_out_read.Click += new System.EventHandler(this.main_out_read_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 341);
            this.Controls.Add(this.main_tab);
            this.Controls.Add(this.main_text);
            this.Controls.Add(this.main_cancel);
            this.Controls.Add(this.main_save);
            this.Controls.Add(this.main_refresh);
            this.Controls.Add(this.main_del);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.main_close_com);
            this.Controls.Add(this.main_open_com);
            this.Controls.Add(this.main_remain);
            this.Controls.Add(this.main_rate_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.main_com_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.main_welcome);
            this.MaximumSize = new System.Drawing.Size(750, 380);
            this.MinimumSize = new System.Drawing.Size(750, 380);
            this.Name = "Main";
            this.Text = "枪支管理系统  ©第七组";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.main_page2.ResumeLayout(false);
            this.main_page1.ResumeLayout(false);
            this.main_page1.PerformLayout();
            this.main_tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label main_welcome;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox main_com_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox main_rate_box;
        private System.Windows.Forms.Label main_remain;
        private System.Windows.Forms.Button main_open_com;
        private System.Windows.Forms.Button main_close_com;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button main_del;
        private System.Windows.Forms.Button main_refresh;
        private System.Windows.Forms.Button main_save;
        private System.Windows.Forms.Button main_cancel;
        private System.Windows.Forms.TextBox main_text;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.Button main_in_read;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button main_destroy_button;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button main_repair_button;
        private System.Windows.Forms.TabPage main_page2;
        private System.Windows.Forms.Button monitor_start;
        private System.Windows.Forms.Button monitor_stop;
        private System.Windows.Forms.TabPage main_page1;
        private System.Windows.Forms.TextBox main_doc_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button main_in_button;
        private System.Windows.Forms.TabControl main_tab;
        private System.Windows.Forms.TextBox main_destroy_remark;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox main_repair_remark;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button main_destroy_read;
        private System.Windows.Forms.Button main_repair_read;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox main_out_remark;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button main_out_button;
        private System.Windows.Forms.Button main_out_read;
    }
}