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
    public partial class FormAddBn : Form
    {
        string str = "Data Source=BING-CHILLING;Initial Catalog=SQLProject;Integrated Security=True";
        Random random = new Random();
        public FormAddBn()
        {
            InitializeComponent();
        }

        private void FormAddBn_Load(object sender, EventArgs e)
        {
            txtmabn.Text = random.Next(9,1000000).ToString();
        }

        private void btn__info__add_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select count(*) from tblBenhNhan where iMaBN = {txtmabn.Text}";
            conn.Open();
            var check = cmd.ExecuteScalar();
            if (int.Parse(check.ToString()) == 0)
            {
                string ngaysinh = DateTime.Parse(txtngsi.Text).ToString("yyyy-MM-dd");
                string ngaynhapvien = DateTime.Parse(txtngnv.Text).ToString("yyyy-MM-dd");
                SqlCommand cmd2 = conn.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = $"insert into tblBenhNhan values('{txtmabn.Text}',N'{txtnamebn.Text}','{txtsdt.Text}','{ngaysinh}','{ngaynhapvien}',N'{txtbenhly.Text}','{txtsophong.Text}')";

                cmd2.ExecuteNonQuery();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Trùng khóa chính", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn__info__reset_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            txtmabn.Text = random.Next(9, 1000000).ToString();
            txtnamebn.Text = txtsdt.Text = txtngsi.Text = txtngnv.Text = txtbenhly.Text = txtsophong.Text = "";
        }
    }
}
