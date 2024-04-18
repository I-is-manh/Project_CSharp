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
    public partial class FormHoaDon : Form
    {
        string str = "Data Source=BING-CHILLING;Initial Catalog=SQLProject;Integrated Security=True";
        ErrorProvider err = new ErrorProvider();
        public FormHoaDon()
        {
            InitializeComponent();
            loaddata();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public void loaddata()
        {
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select hd.iMaHD,hd.iMaBN,bn.sHoTenBN,hd.dNgayLap from tblHoaDon hd join tblBenhNhan bn \r\non hd.iMaBN = bn.iMaBN";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DataView dv = new DataView(ds.Tables[0]);
            dgv.DataSource = dv;
        }

        private void click_content(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >=0 && e.RowIndex < dgv.RowCount-1)
            {
                DataGridViewRow r = dgv.Rows[e.RowIndex];
                tmahd.Text = r.Cells["mahd"].Value.ToString();
                tmabn.Text = r.Cells["mabn"].Value.ToString();
                ttenbn.Text = r.Cells["stenbn"].Value.ToString();
                tngaylap.Text = r.Cells["dngaylap"].Value.ToString();
                tngaylap.Text = DateTime.Parse(tngaylap.Text).ToString("dd/MM/yyyy");
                //MessageBox.Show(e.ColumnIndex.ToString());
                if(e.ColumnIndex == 0)
                {
                    SqlConnection conn = new SqlConnection(str);
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = $"select count(*) from tblChiTietHDDV where iMaHD = {tmahd.Text}";
                    conn.Open();
                    var check = cmd.ExecuteScalar();
                    cmd.CommandText = $"select count (*) from tblChiTietHDThuoc where iMaHD = {tmahd.Text}";
                    var check2 = cmd.ExecuteScalar();
                    if(int.Parse(check.ToString())==0 && int.Parse(check2.ToString()) == 0)
                    {
                        MessageBox.Show("Hóa đơn này không có chi tiết hóa đơn bạn có thể xóa nó","Không có dòng hóa đơn",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                        return;
                    }
                    if(int.Parse(check.ToString()) == 0)
                    {
                        FormChiTietHD hd = new FormChiTietHD(int.Parse(tmahd.Text), int.Parse(tmabn.Text), ttenbn.Text, tngaylap.Text,false);
                        
                        hd.ShowDialog();
                    }
                    else
                    {
                        FormChiTietHD hd = new FormChiTietHD(int.Parse(tmahd.Text), int.Parse(tmabn.Text), ttenbn.Text, tngaylap.Text, true);
                        hd.ShowDialog();
                    }
                    cmd.Dispose();
                    conn.Close();
                    //MessageBox.Show($"{tmahd.Text} , {tmabn.Text}, {ttenbn.Text}");
                }
                else if(e.ColumnIndex == 1)
                {
                    SqlConnection conn = new SqlConnection(str);
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = $"select count(*) from tblChiTietHDDV where iMaHD = {tmahd.Text}";
                    conn.Open();
                    var check1 = cmd.ExecuteScalar();
                    cmd.CommandText = $"select count(*) from tblChiTietHDThuoc where iMaHD = {tmahd.Text}";
                    var check2 = cmd.ExecuteScalar();
                    if(int.Parse(check1.ToString()) == 0 && int.Parse(check2.ToString()) == 0)
                    {
                        cmd.CommandText = $"delete from tblHoaDon where iMaHD = {tmahd.Text}";
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        conn.Close();
                        MessageBox.Show("Xóa thành công");
                        loaddata();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa vì ràng buộc khóa ngoại");
                    }
                }
            }
        }
    }
}
