using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CSharp
{
    public partial class FormThemTK : Form
    {
        string str = "Data Source=BING-CHILLING;Initial Catalog=SQLProject;Integrated Security=True";
        ErrorProvider err = new ErrorProvider();
        public delegate void MyReload();
        public MyReload reload;
        public FormThemTK()
        {
            InitializeComponent();
        }

        

        private void btn_con_Click(object sender, EventArgs e)
        {
            ttk.Text = tmk.Text = trmk.Text = tcv.Text = null;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (ttk.Text != "" && tmk.Text != "" && trmk.Text != "" && tcv.Text != "")
            {
                if (tmk.Text == trmk.Text)
                {
                    SqlConnection conn = new SqlConnection(str);
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = $"select count(*) from tblAccount where username = N'{ttk.Text}' or password = N'{tmk.Text}'";
                    conn.Open();
                    var check = cmd.ExecuteScalar();
                    if (int.Parse(check.ToString()) == 0)
                    {
                        if (tcv.Text.ToLower() == "quản lý")
                        {

                            cmd.CommandText = $"insert into tblAccount values('{ttk.Text}','{tmk.Text}','{1}')";
                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            cmd.CommandText = $"insert into tblAccount values('{ttk.Text}','{tmk.Text}','{0}')";
                            cmd.ExecuteNonQuery();
                        }
                        cmd.Dispose();
                        conn.Close();
                        MessageBox.Show("Thêm thành công");
                        reload();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản đã tồn tại");
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu không khớp");
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập đủ thông tin");
            }
        }

        private void checktk(object sender, CancelEventArgs e)
        {
            if (ttk.Text == "") 
            {
                err.SetError(ttk, "Hãy nhập tên tài khoản");
                ttk.Focus();
            }
            else
            {
                err.Clear();
            }

        }
    }
}
