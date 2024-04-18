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
    public partial class FormChiTietHD : Form
    {
        string str = "Data Source=BING-CHILLING;Initial Catalog=SQLProject;Integrated Security=True";
        ErrorProvider err = new ErrorProvider();
        int imahd;
        bool havedv;
        public int TienThuoc()
        {
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = $"select sum(th.fGiaBan * ct.iSoLuongThuoc) as fThanhTien from tblChiTietHDThuoc ct join tblThuoc th \r\non ct.iMaThuoc = th.iMaThuoc where ct.iMaHD = {imahd} group by ct.iMaHD";
            con.Open();
            var tienthuoc = cmd.ExecuteScalar();
            cmd.Dispose();
            con.Close();
            return int.Parse(tienthuoc.ToString());

        }
        public int TienDichVu()
        {
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = con.CreateCommand ();
            cmd.CommandText = $"select sum(fGiaDV) from tblChiTietHDDV ct join tblDichVu dv\r\non ct.iMaDV = dv.iMaDV where ct.iMaHD = {imahd} group by ct.iMaHD";
            con.Open();
            var tiendv = cmd.ExecuteScalar();
            cmd.Dispose();
            con.Close();
            return int.Parse(tiendv.ToString());
        }
        public FormChiTietHD(int mahd, int mabn, string tenbn, string ngaylap,bool check)
        {
            InitializeComponent();
            this.imahd = mahd;
            tmahd.Text = imahd.ToString();
            tmabn.Text = mabn.ToString();
            ttenbn.Text = tenbn.ToString();
            tngaylap.Text = ngaylap.ToString();
            havedv = check;
            if (havedv == true)
            {
                loadThuoc();
                loadDichVu();
                total.Text = (TienThuoc() + TienDichVu()).ToString("#,## VNĐ");
            }
            else
            {
                loadThuoc();
                total.Text = TienThuoc().ToString("#,## VNĐ");
            }
           
            
        }
        public void loadThuoc()
        {
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = con.CreateCommand ();
            cmd.CommandText = "select count(*) from tblChiTietHDThuoc";
            con.Open();
            var check = cmd.ExecuteScalar();
            if(int.Parse(check.ToString()) == 0)
            {
                dgv1.DataSource = null;
            }
            else{
                SqlConnection conn = new SqlConnection(str);
                SqlCommand cmd2 = conn.CreateCommand();
                cmd2.CommandText = $"select th.iMaThuoc,th.sTenThuoc,ctt.iSoLuongThuoc,th.fGiaBan,th.sDonViTinh,(ctt.iSoLuongThuoc*th.fGiaBan) as fThanhTien from tblChiTietHDThuoc ctt join tblThuoc th\r\non ctt.iMaThuoc = th.iMaThuoc where ctt.iMaHD = {imahd}";
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd2;
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataView dv = new DataView(ds.Tables[0]);
                dgv1.DataSource = dv;
            }
        }
        public void loadDichVu()
        {
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = $"select count(*) from tblChiTietHDDV where iMaHD = {imahd}";
            con.Open();
            var check = cmd.ExecuteScalar();
            if(int.Parse(check.ToString()) == 0)
            {
                dgv2.DataSource = null;
            }
            else
            {
                SqlConnection conn = new SqlConnection(str);
                SqlCommand cmd2 = conn.CreateCommand();
                cmd2.CommandText = $"select ctdv.iMaDV,dv.sTenDV,dv.fGiaDV,dv.fGiaDV as fGiaDV2 from tblHoaDon hd join tblChiTietHDDV ctdv \r\non hd.iMaHD = ctdv.iMaHD join tblDichVu dv on ctdv.iMaDV = dv.iMaDV where ctdv.iMaHD = {imahd}";
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd2;
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataView dv = new DataView(ds.Tables[0]);
                dgv2.DataSource = dv;
            }
        }

        private void click_content_DV(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.RowIndex < dgv2.RowCount - 1)
            {
                DataGridViewRow r = dgv2.Rows[e.RowIndex];
                if(e.ColumnIndex == 0)
                {
                    SqlConnection conn = new SqlConnection(str);
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = $"delete from tblChiTietHDDV where iMaDV = {r.Cells["imadv"].Value.ToString()}";
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    conn.Close();
                    loadDichVu();
                    total.Text = (TienThuoc() + TienDichVu()).ToString("#,## VNĐ");
                }
            }
        }

        private void click_content_Thuoc(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgv1.RowCount - 1)
            {
                DataGridViewRow r = dgv1.Rows[e.RowIndex];
                string mathuoc = r.Cells["imathuoc"].Value.ToString();
                string tenthuoc = r.Cells["namethuoc"].Value.ToString();
                if (e.ColumnIndex == 0)
                {
                    SqlConnection conn = new SqlConnection(str);
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = $"delete from tblChiTietHDThuoc where iMaThuoc = {r.Cells["imathuoc"].Value.ToString()} and iMaHD = {imahd}";
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    conn.Close();
                    loadThuoc();
                    total.Text = (TienThuoc() + TienDichVu()).ToString("#,## VNĐ");
                }
                
            }
        }

        private void edit_Cells(object sender, DataGridViewCellCancelEventArgs e)
        {
            DataGridViewRow r = dgv1.Rows[e.RowIndex];
            if(e.ColumnIndex != 3)
            {
                MessageBox.Show("You cannot update here","Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void end_edit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgv1.Rows[e.RowIndex];
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"update tblChiTietHDThuoc set iSoLuongThuoc = {r.Cells["soluong"].Value.ToString()} where iMaHD = {imahd} and iMaThuoc = {r.Cells["imathuoc"].Value.ToString()}";
            conn.Open();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            loadThuoc();
            total.Text = TienThuoc().ToString("#,## VNĐ");
        }
    }
}
