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
    public partial class FormPhongKham : Form
    {
        string str = "Data Source=BING-CHILLING;Initial Catalog=SQLProject;Integrated Security=True";
        ErrorProvider err = new ErrorProvider();
        public FormPhongKham()
        {
            InitializeComponent();
            loaddata();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormPhongKham_Load(object sender, EventArgs e)
        {

        }
        public void loaddata()
        {
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_select_BSPK";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgv.DataSource = dt;
        }
        public void loadcombobox()
        {
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tblBacSi";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            mabs.DataSource = dt;
            mabs.DisplayMember = "iMaBS";
           
        }
        private void clickrow(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.RowIndex < dgv.RowCount-1)
            {
                loadcombobox();
                DataGridViewRow r = dgv.Rows[e.RowIndex];
                sophong.Text = r.Cells["iphong"].Value.ToString();
                tenphong.Text = r.Cells["namephong"].Value.ToString();
                mabs.Text = r.Cells["mabasi"].Value.ToString();
                namebs.Text = r.Cells["namebasi"].Value.ToString();
                
            }
            else
            {
                sophong.Text = tenphong.Text = mabs.Text = namebs.Text = null;
                mabs.DataSource = null;
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (sophong.Text == "")
            {
                err.SetError(sophong, "Số phòng bỏ trống");
                sophong.Focus();
            }
            else if(tenphong.Text == "")
            {
                err.SetError(tenphong,"Tên phòng bị trống");
                tenphong.Focus();
            }
            else if(mabs.Text == "")
            {
                err.SetError(mabs,"Mã bác sĩ bỏ trống");
                mabs.Focus();
            }
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update tblPhongKham set iSoPhong = {sophong.Text},sTenPhong = N'{tenphong.Text}',iMaBS = {mabs.Text} where iSoPhong = {sophong.Text}";
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Sửa thành công");
        }

        private void mabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView r = mabs.SelectedItem as DataRowView;
            if (r != null)
            {
                namebs.Text = r["sHoTenBS"].ToString();
            }
        }
        private void btn_remove_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select count(*) from tblBenhNhan where iSoPhong = {sophong.Text}";
            conn.Open();
            var check = cmd.ExecuteScalar();
            if (int.Parse(check.ToString()) == 0)
            {
                cmd.CommandText = $"delete from tblPhongKham where iSoPhong = {sophong.Text}";
                cmd.ExecuteNonQuery ();
                cmd.Dispose ();
                conn.Close();
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Không thể xóa vì ràng buộc khóa ngoại");
            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            FormThemPhong p = new FormThemPhong();
            p.ShowDialog();
        }
    }
}
