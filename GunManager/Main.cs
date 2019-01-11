using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using TagReaderLibrary;


//登记入库 get
//枪支出库 
//枪支归库
//枪支维护
//枪支注销


namespace GunManager
{
    public partial class Main : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        private extern static IntPtr SendMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);
        private const uint WM_CLOSE = 0x0010;
        public OleDbConnection connection = null;
        public OleDbCommand command = null;
        public OleDbDataReader dataReader = null;
        public OleDbDataAdapter adapter = null;
        public List<string> list = null;//list for del
        public Thread thread_Monitor = null;
        public EventWaitHandle waitHandle = null;
        public List<String> allLogs = new List<string>();
        public String main_tag_id = "";
        public String remark;
        public int n = -1;
        public Boolean isReturn = false;
        public DataTable dataTable = null;
        public String[] sql = {
            "SELECT TagId,DocName,AddTime FROM [Gun]",
            "SELECT Time,TagId,Remark,IsReturned FROM [Out]",
            "SELECT Time,TagId,Remark FROM [Repair]",
            "SELECT Time,TagId,Remark FROM [Destroy]"
        };
        public String[] key = {
            "TagId",
            "Time",
            "Time",
            "Time"
        };
        public String[] table =
        {
            "[Gun]",
            "[Out]",
            "[Repair]",
            "[Destroy]"
        };
        public String username = null;
        Boolean IsConnected = false;
        Boolean IsMonitor = false;
        ISO15693Reader reader = new ISO15693Reader();

        public Main()
        {
            InitializeComponent();
        }

        public Main(OleDbConnection connection, String username)
        {
            InitializeComponent();
            this.connection = connection;
            this.username = username;
            main_welcome.Text = "当前用户：" + username;
            main_remain.Text = "串口尚未打开，未连接到设备";
            main_close_com.Enabled = false;
            this.dataGrid.DataSource = null;
            this.dataGrid.AutoGenerateColumns = true;

            main_in_button.Enabled = false;
            main_doc_id.Enabled = false;

            main_out_button.Enabled = false;
            main_out_remark.Enabled = false;

            main_repair_remark.Enabled = false;
            main_repair_button.Enabled = false;

            main_destroy_remark.Enabled = false;
            main_destroy_button.Enabled = false;



            monitor_start.Enabled = false;
            monitor_stop.Enabled = false;
            main_doc_id.Enabled = false;
            list = new List<string>();


        }

        private void readFromDb(int num)
        {
            allLogs.Clear();

            if (num == -1)
            {
                num = main_tab.SelectedIndex;
            }

            dataTable = new DataTable();
            adapter = new OleDbDataAdapter(sql[num], connection);
            try
            {
                adapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    dataGrid.DataSource = dataTable;
                    for (int i = 0; i < dataGrid.ColumnCount; i++)
                    {
                        String headText = dataGrid.Columns[i].HeaderText;
                        if (headText.Contains("Time"))
                        {
                            dataGrid.Columns[i].DefaultCellStyle.Format = "yyyy.MM.dd  HH:mm:ss";
                        }
                    }
                    dataGrid.Columns[key[num]].DisplayIndex = 0;
                    for (int i = 0; i < dataGrid.Rows.Count - 1; i++)
                    {
                        allLogs.Add(dataGrid.Rows[i].Cells[0].Value.ToString());
                    }

                }
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            finally
            {
                adapter.Dispose();
                dataGrid.CurrentCell = dataGrid.Rows[dataGrid.Rows.Count - 1].Cells[0];
            }

        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connection != null)
            {
                connection.Close();
                connection = null;
                command = null;
                reader = null;
            }

            Application.ExitThread();
        }

        private void my_button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            String s = null;
            main_text.Text = "";

            switch (button.Name)
            {
                case "logout_button":
                    this.Dispose();
                    Login.login.Show();
                    break;

                case "exit_button":
                    SendMessage(this.Handle, WM_CLOSE, 0, 0);
                    break;

                case "main_open_com":
                    if (IsConnected == true)
                    {
                        main_remain.Text = "串口已经打开，不能重复打开串口！";
                        return;
                    }
                    if (main_com_box.SelectedIndex < 0)
                    {
                        main_remain.Text = "请选择一个串口";
                        main_com_box.Focus();
                        return;
                    }
                    if (main_rate_box.SelectedIndex < 0)
                    {
                        main_remain.Text = "请选择波特率";
                        main_rate_box.Focus();
                        return;
                    }

                    int open_value = reader.OpenSerialPort(main_com_box.SelectedItem.ToString(), Int32.Parse(main_rate_box.SelectedItem.ToString()));
                    if (open_value == 0)
                    {
                        main_remain.Text = String.Format("串口{0}打开成功！", main_com_box.Text.Trim());
                        main_open_com.Enabled = false;
                        main_close_com.Enabled = true;
                        main_in_button.Enabled = true;
                        main_out_button.Enabled = true;
                        main_repair_button.Enabled = true;
                        main_destroy_button.Enabled = true;
                        monitor_start.Enabled = true;
                        monitor_stop.Enabled = true;

                        IsConnected = true;
                    }
                    else
                    {
                        main_remain.Text = String.Format("串口{0}打开失败！", main_com_box.Text.Trim());
                        IsConnected = false;

                    }
                    break;

                case "main_close_com":
                    if (IsConnected == false)
                    {
                        main_remain.Text = "串口已经关闭！";
                        return;
                    }
                    else
                    {
                        int close_value = 0;
                        if (close_value == 0)
                        {
                            IsConnected = false;
                            main_remain.Text = String.Format("串口{0}成功关闭！", main_com_box.Text.Trim());
                            main_open_com.Enabled = true;
                            main_close_com.Enabled = false;
                            main_in_button.Enabled = false;
                            main_out_button.Enabled = false;
                            monitor_start.Enabled = false;
                            monitor_stop.Enabled = false;

                        }
                        else
                        {
                            main_remain.Text = String.Format("串口{0}关闭失败！", main_com_box.Text.Trim());
                        }

                    }
                    break;

                case "main_refresh":
                    readFromDb(-1);
                    list.Clear();
                    break;

                case "main_save":
                    foreach (string id in list)
                    {
                        if (n == 0)
                        s = String.Format("delete from " + table[n] + " where " + key[n] + " = '{0}'", id);

                        if (n != 0)
                        {
                            //SELECT * from [Out] where FORMAT(Time,'yyyy.MM.dd HH:mm:ss')= '2018.12.16 10:43:55' ;
                            s = String.Format("delete from " + table[n] + " where FORMAT(" + key[n] + ",'yyyy.MM.dd HH:mm:ss') = '{0}'", id);
                        }
                        //"delete from [Gun] where TagId = "+TagId;
                        command = new OleDbCommand(s, connection);
                        int num = command.ExecuteNonQuery();
                        command = null;
                        main_remain.Text = String.Format("您已成功删除 {0} 条记录", num);
                    }
                    break;

                case "main_del":
                    if (this.dataGrid.SelectedRows.Count > 0)
                    {
                        for (int i = 0; i < dataGrid.Rows.Count; i++)
                        {
                            if (true == dataGrid.Rows[i].Selected)
                            {
                                list.Add(dataGrid.Rows[i].Cells[0].Value.ToString());
                                dataGrid.Rows.RemoveAt(i);
                            }
                        }
                    }
                    break;

                case "main_cancel":
                    main_refresh.PerformClick();
                    list.Clear();
                    break;

            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            n = 0;
            readFromDb(-1);
        }

        private void Main_read(object sender, EventArgs e)
        {
            if (IsConnected == false)
            {
                main_remain.Text = "未连接设备";
                return;
            }

            int tagCount = 0;
            String[] tagNumber = new string[0];
            int value = reader.Inventory(ISO15693Reader.ModulateMethod.ASK, ISO15693Reader.InventoryModel.Single, ref tagCount, ref tagNumber);
            
            if (value != 0 && tagNumber.Length > 0)
            {
                main_remain.Text = "读取失败";
                return;
            }
            main_tag_id= tagNumber[0];
            main_remain.Text = "读取成功";
            main_doc_id.Enabled = true;
            main_text_append(main_tag_id);
        }

        private void main_tab_SelectedIndexChanged(object sender, EventArgs e)
        {
            list.Clear();
            main_tag_id = "";
            n = main_tab.SelectedIndex;
            if (dataGrid.DataSource != null)
            {
                dataTable.Rows.Clear();
            }
            dataGrid.DataSource = null;
            if (n == 4)
            {
                n = 0;
            }
            readFromDb(n);

        }

        public void main_text_append(String s) => main_text.AppendText(s + "\r\n");

        public Boolean hasThisGun(String id)
        {
            String s = String.Format("select * from [Gun] where TagId = '{0}'", id.Trim());
            command = new OleDbCommand(s, connection);
            dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                command = null;
                dataReader = null;
                return true;
            }
            else
            {
                command = null;
                dataReader = null;
                return false;
            }
        }

        private void main_in_read__Click(object sender, EventArgs e)
        {
            Main_read(sender, e);
            if (main_tag_id.Equals(""))
                return;

            String s = String.Format("select * from [Gun] where TagId = '{0}'", main_tag_id.Trim());
            command = new OleDbCommand(s, connection);
            dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                main_doc_id.Enabled = false;
                main_in_button.Enabled = false;
                main_doc_id.Text = (String)dataReader["DocName"];
                main_text.Text = String.Format("{0} {1} {2}", dataReader["TagId"], dataReader["DocName"], dataReader["AddTime"]);

                return;
            }

            main_doc_id.Enabled = true;
            main_in_button.Enabled = true;
            command = null;
            dataReader = null;

        }

        private void main_in_button_Click(object sender, EventArgs e)
        {
            String s = "";
            if (main_tag_id.Trim() == "")
            {
                main_remain.Text = "请读取标签";
                return;
            }
            if (main_doc_id.Text.Trim() == "")
            {
                main_remain.Text = "请填写枪支编号";
                return;
            }
            s = String.Format("select * from [Gun] where TagId = '{0}'", main_tag_id.Trim());
            command = new OleDbCommand(s, connection);
            dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                main_remain.Text = String.Format("枪支[{0}]已经使用了该标签，请更换标签后重试！", dataReader["DocName"]);
                command = null;
                dataReader = null;
                return;
            }
            s = String.Format("insert into [Gun] (TagId, DocName,AddTime) values ('{0}','{1}','{2}')", main_tag_id.Trim(), main_doc_id.Text.Trim(), DateTime.Now.ToString());
            command = new OleDbCommand(s, connection);
            if (command.ExecuteNonQuery() == 1)
            {
                main_remain.Text = "添加成功";
                main_doc_id.Text = "";
            }
            else
            {
                main_remain.Text = "添加失败";
            }
            command = null;
            dataReader = null;
            main_doc_id.Text = "";
            main_tag_id = "";
            readFromDb(-1);

        }

        private void main_out_read_Click(object sender, EventArgs e)
        {
            Main_read(sender, e);
            if (main_tag_id.Equals(""))
                return;

            if (!hasThisGun(main_tag_id))
            {
                main_tab.SelectTab(0);
            }
            else
            {
                main_out_remark.Enabled = true;
                main_out_button.Enabled = true;

               if(isReturned())
                {
                    isReturn = true;
                }
                else
                {
                    isReturn = false;
                }
            }
        }

        private bool isReturned()
        {
            //select top 1 * from [Out] where Tagid = '000111000' order by [Time] desc;
            String s = "";
            s = String.Format("select top 1 * from [Out] where TagId = '{0}' order by [Time] desc ", main_tag_id);
            command = new OleDbCommand(s, connection);
            dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                if ((Boolean)dataReader["IsReturned"] == true)
                {

                    command = null;
                    dataReader = null;
                    return true;
                }
                else
                {
                    main_out_button.Text = "归还";
                    main_out_remark.Enabled = false;
                    main_out_remark.Text = (String)dataReader["Remark"];
                    command = null;
                    dataReader = null;
                    return false;
                }
            }
            else
            {
                return true;
            }
            
            
        }

        private void main_out_button_Click(object sender, EventArgs e)
        {
            if (main_tag_id.Trim() == "")
            {
                main_remain.Text = "请读取标签";
                return;
            }
            if (main_out_remark.Text.Trim() == "")
            {
                main_remain.Text = "请填写备注";
                return;
            }


            if (isReturn)
            {
                go_out();
            }
            else
            {
                go_return();
            }
            main_out_remark.Text = "";
            main_tag_id = "";
            readFromDb(n);
        }

        private void go_return()
        {
            //update  [Out] a, (select top 1 * from [Out] where TagId = '000111000' order by [Time] desc ) b set a.IsReturned = true   where a.TagId=b.TagId
            String s = "";
            s = String.Format("update  [Out] a, (select top 1 * from [Out] where TagId = '{0}' order by [Time] desc ) b  set a.IsReturned = true where a.TagId=b.TagId ", main_tag_id.Trim());
            /**/
            command = new OleDbCommand(s, connection);
            if (command.ExecuteNonQuery()>0)
            {
                main_remain.Text = "归还成功";
            }
            else
            {
                main_remain.Text = "归还失败";
            }
            main_out_remark.Enabled = true;
            main_out_button.Text = "出库";
            command = null;
            dataReader = null;
        }

        private void go_out()
        {
            String s = "";
            s = String.Format("insert into [Out] ([Time],TagId,Remark,IsReturned) values ('{0}','{1}','{2}','{3}')", DateTime.Now.ToString(), main_tag_id.Trim(), main_out_remark.Text.Trim(), 0);
            command = new OleDbCommand(s, connection);
            if (command.ExecuteNonQuery() == 1)
            {
                main_remain.Text = "添加成功";
            
            }
            else
            {
                main_remain.Text = "添加失败";
            }
            command = null;
            dataReader = null;
        }

        private void main_repair_read_Click(object sender, EventArgs e)
        {
            Main_read(sender, e);
            if (main_tag_id.Equals(""))
                return;

            if (hasThisGun(main_tag_id))
            {
                main_repair_remark.Enabled = true;
                main_repair_button.Enabled = true;
            }
            else

            {
                main_tab.SelectTab(0);
            }

        }

        private void main_repair_button_Click(object sender, EventArgs e)
        {
            String s = "";
            if (main_tag_id.Trim() == "")
            {
                main_remain.Text = "请读取标签";
                return;
            }
            if (main_repair_remark.Text.Trim() == "")
            {
                main_remain.Text = "请填写备注";
                return;
            }

            s = String.Format("insert into [Repair] ([Time],TagId,Remark) values ('{0}','{1}','{2}')", DateTime.Now.ToString(), main_tag_id.Trim(), main_repair_remark.Text.Trim());
            command = new OleDbCommand(s, connection);
            if (command.ExecuteNonQuery() == 1)
            {
                main_remain.Text = "添加成功";
                main_doc_id.Text = "";
            }
            else
            {
                main_remain.Text = "添加失败";
            }
            command = null;
            dataReader = null;
            main_repair_remark.Text = "";
            main_tag_id = "";
            readFromDb(n);
        }

        private void main_destroy_read_Click(object sender, EventArgs e)
        {
            Main_read(sender, e);
            if (main_tag_id.Equals(""))
                return;

            if (hasThisGun(main_tag_id))
            {
                main_destroy_remark.Enabled = true;
                main_destroy_button.Enabled = true;
            }
            else

            {
                main_tab.SelectTab(0);
            }
        }

        private void main_destroy_button_Click(object sender, EventArgs e)
        {
            String s = "";
            if (main_tag_id.Trim() == "")
            {
                main_remain.Text = "请读取标签";
                return;
            }
            if (main_destroy_remark.Text.Trim() == "")
            {
                main_remain.Text = "请填写备注";
                return;
            }

            s = String.Format("insert into [Destroy] ([Time],TagId,Remark) values ('{0}','{1}','{2}')", DateTime.Now.ToString(), main_tag_id.Trim(), main_destroy_remark.Text.Trim());
            command = new OleDbCommand(s, connection);
            if (command.ExecuteNonQuery() == 1)
            {
                main_remain.Text = "添加成功";
                main_doc_id.Text = "";
            }
            else
            {
                main_remain.Text = "添加失败";
            }
            command = null;
            dataReader = null;
            s = String.Format("delete from [Gun] where  [TagId] = '{0}'", main_tag_id.Trim());
            command = new OleDbCommand(s, connection);
            if (command.ExecuteNonQuery() == 1)
            {
                main_remain.Text = "添加成功";
                main_doc_id.Text = "";
            }
            else
            {
                main_remain.Text = "添加失败";
            }
            command = null;
            dataReader = null;
            main_destroy_remark.Text = "";
            main_tag_id = "";
            readFromDb(0);
            readFromDb(n);
            
        }

        private void monitor_start_Click(object sender, EventArgs e)
        {

          

        }

        private void monitor_stop_Click(object sender, EventArgs e)
        {
          
        }

    }
}
