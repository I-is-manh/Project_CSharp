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
    public partial class FormThemDV : Form
    {
        string str = "Data Source=BING-CHILLING;Initial Catalog=SQLProject;Integrated Security=True";
        public delegate void HandleAdd(string str);
        public HandleAdd prop;
        public int getMaDV()
        {
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select max(iMaDV) from tblDichVu";
            conn.Open();
            var ma = cmd.ExecuteScalar();
            int maDV = int.Parse(ma.ToString());
            return maDV;
        }
        public FormThemDV()
        {
            InitializeComponent();
            Random random = new Random();
            ma_dv.Text = (getMaDV()+1).ToString();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Select count(*) from tblDichVu where iMaDV = '"+ma_dv.Text+"'";
            conn.Open();
            var check = cmd.ExecuteScalar();
            if(int.Parse(check.ToString()) == 0)
            {
                cmd.CommandText = $"insert into tblDichVu values('{ma_dv.Text}',N'{name_dv.Text}','{dg_dv.Text}')";
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                MessageBox.Show("Thêm thành công");
                prop("");
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại");
                ma_dv.Text = (getMaDV() + 1).ToString();
                name_dv.Text = "";
                dg_dv.Text = "";

            }
        }

        private void btn_rs_Click(object sender, EventArgs e)
        {
            ma_dv.Text = (getMaDV() + 1).ToString();
            name_dv.Text = "";
            dg_dv.Text = "";
        }
    }
}
