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
    public partial class FormInfoBN : Form
    {
        string str = "Data Source=BING-CHILLING;Initial Catalog=SQLProject;Integrated Security=True";
        Decentralization dc = new Decentralization();
        public FormInfoBN()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormInfoBN_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        public void loaddata()
        {
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from tblBenhNhan where iMaBN = {dc.getmabn()}";
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtmabn.Text = reader.GetValue(0).ToString();
                txtnamebn.Text = reader.GetValue(1).ToString();
                txtsdt.Text = reader.GetValue(2).ToString();
                DateTime date = DateTime.Parse(reader.GetValue(3).ToString());
                txtngsi.Text = date.ToString("dd/MM/yyyy");
                date = DateTime.Parse(reader.GetValue(4).ToString());
                txtngnv.Text = date.ToString("dd/MM/yyyy");
                txtbenhly.Text = reader.GetValue(5).ToString();
                txtsophong.Text = reader.GetValue(6).ToString();
            }
            else
            {
                MessageBox.Show("Không có data","Oops",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            reader.Close();
            cmd.Dispose();
            conn.Close();
        }

        private void btn__info__reset_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            txtmabn.Text =  random.Next(9,1000000).ToString();
            txtnamebn.Text = txtsdt.Text = txtngsi.Text = txtngnv.Text = txtbenhly.Text = txtsophong.Text = "";
        }

        private void btn__info__update_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update tblBenhNhan set sHoTenBN = N'{txtnamebn.Text}',dNgaySinh = '{DateTime.Parse(txtngsi.Text).ToString("yyyy/MM/dd")}',dNgayNhapVien = '{DateTime.Parse(txtngnv.Text).ToString("yyyy/MM/dd")}',sBenh = N'{txtbenhly.Text}',iSoPhong = '{txtsophong.Text}' where iMaBN= {txtmabn.Text}";
            conn.Open();
            var i =cmd.ExecuteNonQuery();
            MessageBox.Show(i.ToString());
            cmd.Dispose();
            conn.Close();
        }
    }
}
