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
    public partial class FormThemPhong : Form
    {
        string str = "Data Source=BING-CHILLING;Initial Catalog=SQLProject;Integrated Security=True";
        ErrorProvider err = new ErrorProvider();
        public int sophongnoi()
        {
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand(str, conn);
            cmd.CommandText = "select max(iSoPhong) from tblPhongKham";
            conn.Open();
            var i = cmd.ExecuteScalar();

            return int.Parse(i.ToString());
        }
        public FormThemPhong()
        {
            InitializeComponent();
            loadata();
            sophong.Text = (sophongnoi() + 1).ToString();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void loadata()
        {
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from tblBacSi";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cboMaBS.DataSource = dt;
            cboMaBS.DisplayMember = "iMaBS";
        }

        private void cboMaBS_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView r = cboMaBS.SelectedItem as DataRowView;    
            if (r != null)
            {
                tenbs.Text = r["sHoTenBS"].ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = $"insert into tblPhongKham values('{sophong.Text}','{cboMaBS.Text}',N'{tenphong.Text}')";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Thêm thành công");
        }
    }
}
