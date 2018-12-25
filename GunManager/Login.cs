using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GunManager
{
    public partial class Login : Form
    {
        Boolean IsLogined = false;
        Boolean IsConnected = false;
        Boolean IsChecked = false;
        Boolean IsMonitor = false;
        public static Login login = null;
        public OleDbConnection connection = null;
        public OleDbCommand command = null;
        public OleDbDataReader reader = null;

        public Login()
        {
            InitializeComponent();
            login = this;
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if (user_text.Text.Trim() == "")
            {
                login_label.Text = "请填写用户名!";
                return;
            }
            if (passwd_text.Text.Trim() == "")
            {
                login_label.Text = "请填写密码!";
                return;
            }
            connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\db.mdb;Persist Security Info=True";
            connection.Open();
            String sql = String.Format("SELECT password FROM [User] WHERE username='{0}'", user_text.Text.Trim());
            command = new OleDbCommand(sql, connection);
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                if (((String)reader["password"]).Trim() == passwd_text.Text.Trim())
                {
                    IsLogined = true;
                    login_label.Text = "登陆成功";
                    this.Hide();
                    Main main = new Main(connection, user_text.Text.Trim());
                    main.Show();
                }
                else
                {
                    login_label.Text = "密码错误";
                    passwd_text.Clear();
                    passwd_text.Focus();

                }
            }
            else
            {
                login_label.Text = "用户不存在，请重新填写";
                user_text.Clear();
                passwd_text.Clear();
                user_text.Focus();
            }
            reader.Close();
        }

        private void out_button_Click(object sender, EventArgs e)
        {
            if (connection != null)
            {
                connection.Close();
                connection = null;
                command = null;
                reader = null;
            }
            Application.Exit();
        }

        private void my_KeyDown(object sender, KeyEventArgs e)
        {
            if ((TextBox)sender == passwd_text)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    login_button.PerformClick();
                }
                return;
            }

            if ((TextBox)sender == user_text)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (user_text.Text.Trim().Length > 0)
                    {
                        passwd_text.Focus();
                        login_label.Text = "请登录";
                    }
                    else
                    {
                        login_label.Text = "请填写用户名!";
                        return;
                    }

                }
            }




        }


    }
}
