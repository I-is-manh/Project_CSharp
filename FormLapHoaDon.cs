using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace Project_CSharp
{
    public partial class FormLapHoaDon : Form
    {
        string str = "Data Source=BING-CHILLING;Initial Catalog=SQLProject;Integrated Security=True";
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        int tienThuoc = 0;
        public int getID()
        {
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select max(iMaHD) from tblHoaDon";
            conn.Open();
            var get = cmd.ExecuteScalar();
            cmd.Dispose();
            conn.Close();
            return int.Parse(get.ToString());
        }
        public string gettenphong(string sophong)
        {
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = $"select sTenPhong from tblPhongKham where iSoPhong = {sophong}";
            con.Open();
            var namep = cmd.ExecuteScalar();
            cmd.Dispose();
            con.Close();
            return namep.ToString();
        }
        public FormLapHoaDon(string mabn,string tenbn,string ngaynhap,string benhly,string sophong)
        {
            InitializeComponent();
            panelThuoc.Visible = true;
            panelAll.Controls.Add(panelThuoc);
            panelThuoc.Dock = DockStyle.Fill;
            adColumnThuoc();
            addColumnDV();
            loaddataCBODV();
            tmahd.Text = (getID() + 1).ToString();
            tmabn.Text = mabn;
            ttenbn.Text = tenbn;
            tsophong.Text = sophong;
            ttenphong.Text = gettenphong(sophong);
            tbenhly.Text = benhly;
            tngaynhap.Text = ngaynhap;
            tngaylap.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        private void rdThuoc_CheckedChanged(object sender, EventArgs e)
        {
            panelAll.Controls.Clear();
            panelThuoc.Visible = true;
            panelAll.Controls.Add(panelThuoc);
            panelThuoc.Dock = DockStyle.Fill;
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand(str, conn);
            cmd.CommandText = "select * from tblThuoc";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            cboThuoc.DataSource = ds.Tables[0];
            cboThuoc.DisplayMember = "sTenThuoc";
        }
        private void rdDV_CheckedChanged(object sender, EventArgs e)
        {
            panelAll.Controls.Clear();
            panelDV.Visible = true;
            panelAll.Controls.Add(panelDV);
            panelDV.Dock = DockStyle.Fill;
        }
        public void loaddataCBODV()
        {
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand(str, conn);
            cmd.CommandText = "select sTenDV from tblDichVu";
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                while (dr.Read())
                {
                    cboDV.Items.Add(dr.GetString(0));
                }
            }
            dr.Close();
            cmd.Dispose();
            conn.Close();
        }
        public void adColumnThuoc()
        {
            dt1.Columns.Add("iMaThuoc");
            dt1.Columns.Add("sTenThuoc");
            dt1.Columns.Add("iSoLuongThuoc");
            dt1.Columns.Add("fGiaBan");
            dt1.Columns.Add("sDonViTinh");
            dt1.Columns.Add("fThanhTien");
            dgvThuoc.DataSource = dt1;
        }
        public void addColumnDV()
        {
            dt2.Columns.Add("iMaDV");
            dt2.Columns.Add("sTenDV");
            dt2.Columns.Add("fGiaDV");
            dt2.Columns.Add("fGiaDV2");
            dgvDV.DataSource = dt2;
        }
        public string repairString(string str)
        {
            if (str.IndexOf('.') >= 0)
            {
                while(str.IndexOf('.') >= 0)
                {
                    str = str.Remove(str.IndexOf('.'), 1);
                }
                str = str.Remove(str.IndexOf('V'), 3);
            }
            else
            {
                str = str.Remove(str.IndexOf('V'), 3);
            }
            str = str.Trim();
            return str;
        }
        public bool checkExistenceThuoc(string tenThuoc)
        {
            for(int i = 0; i < dt1.Rows.Count; i++)
            {
                if(dt1.Rows[i]["sTenThuoc"].ToString() == tenThuoc)
                {
                    return true;
                }
            }
            return false;
        }
        public bool checkExistenceDV(string tenDV)
        {
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                if (dt2.Rows[i]["sTenDV"].ToString() == tenDV)
                {
                    return true;
                }
            }
            return false;
        }
        private void enter_number(object sender, KeyEventArgs e)
        {
            DataRowView r = cboThuoc.SelectedItem as DataRowView;
            if(e.KeyCode == Keys.Enter && checkExistenceThuoc(r["sTenThuoc"].ToString()) == false)
            {
                dt1.Rows.Add(r["iMaThuoc"], r["sTenThuoc"], tsoluong.Text, int.Parse(r["fGiaBan"].ToString()).ToString("#,## VNĐ"), r["sDonViTinh"],(int.Parse(r["fGiaBan"].ToString()) * int.Parse(tsoluong.Text)).ToString("#,## VNĐ"));
                string str = ttotal.Text;
                string thanhtien = (int.Parse(r["fGiaBan"].ToString()) * int.Parse(tsoluong.Text)).ToString();
                int parseInt = int.Parse(thanhtien);
                ttotal.Text = (int.Parse(repairString(str)) + parseInt).ToString("#,## VNĐ");
                tienThuoc += parseInt;
            }
            btn_In.Visible = true;
        }
        private void cboDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDV.SelectedIndex != -1 && checkExistenceDV(cboDV.SelectedItem.ToString()) == false)
            {
                SqlConnection conn = new SqlConnection(str);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"select * from tblDichVu where sTenDV = N'{cboDV.SelectedItem.ToString()}'";
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dt2.Rows.Add(dr.GetInt32(0).ToString(), cboDV.SelectedItem.ToString(), int.Parse(dr.GetValue(2).ToString()).ToString("#,## VNĐ"), int.Parse(dr.GetValue(2).ToString()).ToString("#,## VNĐ"));
                }
                dr.Close();
                cmd.Dispose();
                conn.Close();
                string total = ttotal.Text;
                
                if (dt2.Rows.Count <= 0)
                {
                    ttotal.Text = ttotal.Text;
                }
                else
                {
                    string thanhtien = dt2.Rows[dt2.Rows.Count - 1]["fGiaDV2"].ToString();
                    ttotal.Text = (int.Parse(repairString(total)) + int.Parse(repairString(thanhtien))).ToString("#,## VNĐ");
                }

            }
            btn_divu.Visible = true;
        }

        private void change_Value(object sender, EventArgs e)
        {
        }
       
        

        private void cboThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            tsoluong.Text = "1";
        }

        private void btn_Chon_Click(object sender, EventArgs e)
        {
            DataRowView r = cboThuoc.SelectedItem as DataRowView;
            if(checkExistenceThuoc(r["sTenThuoc"].ToString()) == false)
            {
                dt1.Rows.Add(r["iMaThuoc"], r["sTenThuoc"], tsoluong.Text, int.Parse(r["fGiaBan"].ToString()).ToString("#,## VNĐ"), r["sDonViTinh"], (int.Parse(r["fGiaBan"].ToString()) * int.Parse(tsoluong.Text)).ToString("#,## VNĐ"));
                string str = ttotal.Text;
                str = str.Trim();
                string thanhtien = (int.Parse(r["fGiaBan"].ToString()) * int.Parse(tsoluong.Text)).ToString();
                int parseInt = int.Parse(thanhtien);
                tienThuoc += parseInt;
                ttotal.Text = (int.Parse(repairString(str)) + parseInt).ToString("#,## VNĐ");
            }
            btn_In.Visible = true;
        }
        
        private void click_content(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgvDV.Rows[e.RowIndex];
            
            if(e.RowIndex >= 0 && e.RowIndex < dgvDV.RowCount - 1)
            {
                if(e.ColumnIndex == 0)
                {
                    string thanhtien = dt2.Rows[e.RowIndex]["fGiaDV2"].ToString();
                    dt2.Rows.Remove(dt2.Rows[e.RowIndex]);
                    if ((int.Parse(repairString(ttotal.Text)) - int.Parse(repairString(thanhtien))) == 0)
                    {
                        ttotal.Text = "0 VNĐ";
                    }
                    else ttotal.Text = (int.Parse(repairString(ttotal.Text)) - int.Parse(repairString(thanhtien))).ToString("#,## VNĐ");
                    if (dt2.Rows.Count == 0)
                    {
                        btn_divu.Visible = false;
                    }
                }
            }
        }
        private void click_contentThuoc(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgvThuoc.Rows[e.RowIndex];
            if (e.RowIndex >= 0 && e.RowIndex < dgvThuoc.RowCount - 1)
            {
                if (e.ColumnIndex == 0)
                {
                    string thanhtien = dt1.Rows[e.RowIndex]["fThanhTien"].ToString();
                    dt1.Rows.Remove(dt1.Rows[e.RowIndex]);
                    if((int.Parse(repairString(ttotal.Text)) - int.Parse(repairString(thanhtien))) == 0)
                    {
                        ttotal.Text = "0 VNĐ";
                        tienThuoc = 0;
                    }
                    else
                    {
                        ttotal.Text = (int.Parse(repairString(ttotal.Text)) - int.Parse(repairString(thanhtien))).ToString("#,## VNĐ");
                        tienThuoc -= int.Parse(repairString(thanhtien));
                    };
                    if(dt1.Rows.Count == 0)
                    {
                        btn_In.Visible = false;
                    }
                }
            }
        }
        private void btn_In_Click(object sender, EventArgs e)
        {
          
           
                string date = DateTime.Parse(tngaylap.Text).ToString("yyyy/MM/dd HH:mm:ss");
                SqlConnection conn = new SqlConnection(str);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"select count(*) from tblHoaDon where iMaHD = {tmahd.Text}";
                conn.Open();
                var check = cmd.ExecuteScalar();
                if (int.Parse(check.ToString()) == 0)
                {
                    SqlConnection conn2 = new SqlConnection(str);
                    SqlCommand cmd2 = conn2.CreateCommand();
                    cmd2.CommandText = $"insert into tblHoaDon values('{tmahd.Text}','{tmabn.Text}','{date}')";
                    conn2.Open();
                    cmd2.ExecuteNonQuery();
                    cmd2.Dispose();
                    conn2.Close();

                    SqlConnection conn3 = new SqlConnection(str);
                    SqlCommand cmd3 = conn3.CreateCommand();
                    cmd3.CommandText = $"insert into tblChiTietHDThuoc \r\nvalues";
                    conn3.Open();
                    if (dt1.Rows.Count > 1)
                    {
                        for (int i = 0; i < dt1.Rows.Count; i++)
                        {
                            cmd3.CommandText += $" ({int.Parse(tmahd.Text)},{int.Parse(dt1.Rows[i]["iMaThuoc"].ToString())},{int.Parse(dt1.Rows[i]["iSoLuongThuoc"].ToString())}) ,";
                        }
                        cmd3.CommandText = cmd3.CommandText.Remove(cmd3.CommandText.Length - 1, 1);
                    }
                    else
                    {
                        cmd3.CommandText += $" ('{tmahd.Text}','{dt1.Rows[0]["iMaThuoc"]}','{dt1.Rows[0]["iSoLuongThuoc"]}')";
                    }
                    cmd3.ExecuteNonQuery();
                    cmd3.Dispose();
                    conn3.Close();
                    FormReport report = new FormReport("sp_HDThuoc", "HoaDonThuoc.rpt", tmahd.Text, ttotal.Text);
                    report.ShowDialog();
                }
                else
                {
                    SqlConnection hehe = new SqlConnection (str);
                    SqlCommand hcmd = hehe.CreateCommand();
                    hcmd.CommandText = $"select count (*) from tblChiTietHDThuoc where iMaHD = {tmahd.Text}";
                    hehe.Open();
                    var ktthuoc = hcmd.ExecuteScalar();
                    if(int.Parse(ktthuoc.ToString()) == 0 && dt1.Rows.Count != 0)
                    {
                        SqlConnection conn3 = new SqlConnection(str);
                        SqlCommand cmd3 = conn3.CreateCommand();
                        cmd3.CommandText = $"insert into tblChiTietHDThuoc \r\nvalues";
                        conn3.Open();
                        if (dt1.Rows.Count > 1)
                        {
                            for (int i = 0; i < dt1.Rows.Count; i++)
                            {
                                cmd3.CommandText += $" ({int.Parse(tmahd.Text)},{int.Parse(dt1.Rows[i]["iMaThuoc"].ToString())},{int.Parse(dt1.Rows[i]["iSoLuongThuoc"].ToString())}) ,";
                            }
                            cmd3.CommandText = cmd3.CommandText.Remove(cmd3.CommandText.Length - 1, 1);
                        }
                        else
                        {
                            cmd3.CommandText += $" ('{tmahd.Text}','{dt1.Rows[0]["iMaThuoc"]}','{dt1.Rows[0]["iSoLuongThuoc"]}')";
                        }
                        cmd3.ExecuteNonQuery();
                        cmd3.Dispose();
                        conn3.Close();
                        FormReport report = new FormReport("sp_HDThuoc", "HoaDonThuoc.rpt", tmahd.Text, tienThuoc.ToString("#,## VNĐ"));
                        report.ShowDialog();
                    }
                    hcmd.Dispose();
                    hehe.Close();
                }
        }

        private void btn_divu_Click(object sender, EventArgs e)
        {
            string date = DateTime.Parse(tngaylap.Text).ToString("yyyy/MM/dd HH:mm:ss");
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"select count(*) from tblHoaDon where iMaHD = {tmahd.Text}";
            conn.Open();
            var check = cmd.ExecuteScalar();
            if (int.Parse(check.ToString()) == 0) 
            {
                cmd.CommandText = $"insert into tblHoaDon values ('{tmahd.Text}','{tmabn.Text}','{date}')";
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Close();
                SqlConnection con2 = new SqlConnection(str);
                SqlCommand cmd2 = con2.CreateCommand();
                con2.Open();
                cmd2.CommandText = $"insert into tblChiTietHDDV\r\n values ";
                if(dt2.Rows.Count > 1)
                {
                    for(int i=0 ; i < dt2.Rows.Count; i++)
                    {
                        cmd2.CommandText += $"  ('{tmahd.Text}','{dt2.Rows[i]["iMaDV"]}') ,";
                    }
                    cmd2.CommandText = cmd2.CommandText.Remove(cmd2.CommandText.Length - 1,1);
                }
                else
                {
                    cmd2.CommandText += $" ('{tmahd.Text}','{dt2.Rows[0]["iMaDV"]}') ";
                }
                cmd2.ExecuteNonQuery();
                cmd2.Dispose();
                con2.Close();
            }
            else
            {
                SqlConnection test = new SqlConnection(str);
                SqlCommand tcmd = test.CreateCommand();
                tcmd.CommandText = $"select count (*) from tblChiTietHDDV where iMaHD = {tmahd.Text}";
                test.Open();
                var checktcmd = tcmd.ExecuteScalar();
                if (int.Parse(checktcmd.ToString()) == 0 && dt2.Rows.Count != 0)
                {
                    SqlConnection conn3 = new SqlConnection(str);
                    SqlCommand cmd3 = conn3.CreateCommand();
                    cmd3.CommandText = $"insert into tblChiTietHDDV \r\nvalues";
                    conn3.Open();
                    if (dt2.Rows.Count > 1)
                    {
                        for (int i = 0; i < dt2.Rows.Count; i++)
                        {
                            cmd3.CommandText += $" ({int.Parse(tmahd.Text)},'{dt2.Rows[i]["iMaDV"]}') ,";
                        }
                        cmd3.CommandText = cmd3.CommandText.Remove(cmd3.CommandText.Length - 1, 1);
                    }
                    else
                    {
                        cmd3.CommandText += $" ('{tmahd.Text}','{dt2.Rows[dt2.Rows.Count - 1]["iMaDV"]}')";
                    }
                    cmd3.ExecuteNonQuery();
                    cmd3.Dispose();
                    conn3.Close();
                }
                
            }
            if(tienThuoc == 0)
            {
                FormReport report = new FormReport("sp_HDDV", "DichVu__report.rpt", tmahd.Text, ttotal.Text);
                report.ShowDialog();
            }
            else
            {
                int tiendv;
                int tong = int.Parse(repairString(ttotal.Text));
                tiendv = tong - tienThuoc;
                FormReport report = new FormReport("sp_HDDV", "DichVu__report.rpt", tmahd.Text, tiendv.ToString("#,## VNĐ"));
                report.ShowDialog();
            }
        }

    }
}

