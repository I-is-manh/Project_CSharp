using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CSharp
{
    public partial class Form1 : Form
    {
        Decentralization dc = new Decentralization();
        string str = "Data Source=BING-CHILLING;Initial Catalog=SQLProject;Integrated Security=True";
        Thread th;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            SqlConnection conn  =  new SqlConnection(str);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from tblAccount where username = '{txtTK.Text}' and password = '{txtMK.Text}'";
            
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if(dr.GetBoolean(2) == true)
                {
                    dc.setisAdmin(true);
                }
                else
                {
                    dc.setisAdmin(false);

                }
                th = new Thread(Closed);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai thông tin tài khoản hoặc mật khẩu","Đăng nhập thất bại",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        public void Closed()
        {
            Form_Main fm = new Form_Main();
            fm.ShowDialog();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
