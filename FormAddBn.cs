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
        ErrorProvider err = new ErrorProvider();
        string str = "Data Source=BING-CHILLING;Initial Catalog=SQLProject;Integrated Security=True";
        public delegate void HandleDelegate(string str);
        public HandleDelegate prop;
        Random random = new Random();
        public FormAddBn()
        {
            InitializeComponent();
        }

        private void FormAddBn_Load(object sender, EventArgs e)
        {
            txtmabn.Text = random.Next(9,1000000).ToString();
            loadtocombobox();
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
                prop("");
                conn.Close();
            }
            else
            {
                MessageBox.Show("Trùng khóa chính", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void loadtocombobox()
        {
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select iSoPhong from tblPhongKham";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            txtsophong.DataSource = ds.Tables[0];
            txtsophong.DisplayMember = "iSoPhong";
        }
        private void btn__info__reset_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            txtmabn.Text = random.Next(9, 1000000).ToString();
            txtnamebn.Text = txtsdt.Text = txtngsi.Text = txtngnv.Text = txtbenhly.Text = txtsophong.Text = "";
        }

        private void checkname(object sender, CancelEventArgs e)
        {
            
        }

        private void checkvalidate(object sender, MouseEventArgs e)
        {
            if(txtnamebn.Text == "" || txtngsi.Text == "" || txtngnv.Text == "" || txtsdt.Text == "" || txtbenhly.Text == "" || txtsophong.Text == "")
            {
                btn__info__add.Enabled = false;
            }
            else
            {
                btn__info__add.Enabled = true;
            }
        }
    }
}
