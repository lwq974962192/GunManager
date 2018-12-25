namespace GunManager
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.user_text = new System.Windows.Forms.TextBox();
            this.passwd_text = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.out_button = new System.Windows.Forms.Button();
            this.login_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "枪支管理系统";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // user_text
            // 
            this.user_text.Location = new System.Drawing.Point(92, 49);
            this.user_text.MaxLength = 15;
            this.user_text.Name = "user_text";
            this.user_text.Size = new System.Drawing.Size(100, 21);
            this.user_text.TabIndex = 3;
            this.user_text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.my_KeyDown);
            // 
            // passwd_text
            // 
            this.passwd_text.AcceptsReturn = true;
            this.passwd_text.Location = new System.Drawing.Point(92, 87);
            this.passwd_text.MaxLength = 15;
            this.passwd_text.Name = "passwd_text";
            this.passwd_text.PasswordChar = '*';
            this.passwd_text.Size = new System.Drawing.Size(100, 21);
            this.passwd_text.TabIndex = 4;
            this.passwd_text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.my_KeyDown);
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(38, 150);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(75, 23);
            this.login_button.TabIndex = 5;
            this.login_button.Text = "登录";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // out_button
            // 
            this.out_button.Location = new System.Drawing.Point(129, 150);
            this.out_button.Name = "out_button";
            this.out_button.Size = new System.Drawing.Size(75, 23);
            this.out_button.TabIndex = 6;
            this.out_button.Text = "退出";
            this.out_button.UseVisualStyleBackColor = true;
            this.out_button.Click += new System.EventHandler(this.out_button_Click);
            // 
            // login_label
            // 
            this.login_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.login_label.AutoSize = true;
            this.login_label.Location = new System.Drawing.Point(22, 123);
            this.login_label.MaximumSize = new System.Drawing.Size(200, 15);
            this.login_label.MinimumSize = new System.Drawing.Size(200, 15);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(200, 15);
            this.login_label.TabIndex = 7;
            this.login_label.Text = "请登录";
            this.login_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 211);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.out_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.passwd_text);
            this.Controls.Add(this.user_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(250, 250);
            this.MinimumSize = new System.Drawing.Size(250, 250);
            this.Name = "Login";
            this.Text = "登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox user_text;
        private System.Windows.Forms.TextBox passwd_text;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button out_button;
        private System.Windows.Forms.Label login_label;
    }
}