using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CSharp
{
    public partial class FormThuoc : Form
    {
        string str = "Data Source=BING-CHILLING;Initial Catalog=SQLProject;Integrated Security=True";
        ErrorProvider err = new ErrorProvider();
        public FormThuoc()
        {
            InitializeComponent();
            loadData("");
        }
        public bool check(string str)
        {
            foreach (char ch in str)
            {
                if (ch >= 48 && ch <= 57)
                {
                    return true;
                }
            }
            return false;
        }
        public void loadData(string filter = "")
        {
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tblThuoc";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DataView dv = new DataView(ds.Tables[0]);
            dv.RowFilter = filter;
            dgvt.DataSource = dv;
        }
        private void dgvt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvt.Rows[e.RowIndex];
            txtmath.Text = row.Cells["ma"].Value.ToString();
            txtnamet.Text = row.Cells["ten"].Value.ToString();
            txtnsx.Text = row.Cells["nsx"].Value.ToString();
            txtgiaban.Text = row.Cells["giaban"].Value.ToString();
            double number = Double.Parse(txtgiaban.Text);
            CultureInfo culture = new CultureInfo("vi-VN");
            txtgiaban.Text = string.Format(culture, "{0:C}", number);
            txtsl.Text = row.Cells["soluong"].Value.ToString();
            txtdvt.Text = row.Cells["dvt"].Value.ToString();
        }
        private void btn_tim_Click(object sender, EventArgs e)
        {
            string filter = "";
            filter += string.Format("CONVERT({0},System.String) like '%{1}%'", "iMaThuoc", txtmath.Text);
            filter += $"and sTenThuoc like '%{txtnamet.Text}%'";
            filter += $" and sNhaSanXuat like '%{txtnsx.Text}%' and ";
            filter += string.Format("CONVERT({0},System.String) like '%{1}%' and ", "fGiaBan", txtgiaban.Text);
            filter += string.Format("CONVERT({0},System.String) like '%{1}%' and ", "iSLThuocCon", txtsl.Text);
            filter += $" sDonViTinh like '%{txtdvt.Text}%'";
            MessageBox.Show(filter);
            loadData(filter);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = conn.CreateCommand();  
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select count(*) from tblChiTietHDThuoc where iMaThuoc = {txtmath.Text}";
            conn.Open();
            var check = cmd.ExecuteScalar();
            if (int.Parse(check.ToString()) == 0)
            {
                cmd.CommandText = $"delete from tblThuoc where iMaThuoc = {txtmath.Text}";
                var i = cmd.ExecuteNonQuery();
                if(i == 0) {
                    MessageBox.Show("Khong the xoa");
                    
                }
                else
                {
                    MessageBox.Show("Xoa thanh cong");
                    loadData("");
                }
            }
            else
            {
            }
            cmd.Dispose();
            conn.Close();
        }

        private void checkvalidate(object sender, MouseEventArgs e)
        {
            if(txtnamet.Text == "" || txtnsx.Text == "" || txtsl.Text == "" || txtgiaban.Text == "" || txtdvt.Text == "")
            {
                btn_sua.Enabled = false;
            }
            else
            {
                btn_sua.Enabled = true;
            }
        }

        private void checkgb(object sender, CancelEventArgs e)
        {
            if (check(txtgiaban.Text) == false)
            {
                err.SetError(txtgiaban, "Hãy nhập đúng dữ liệu");
                txtgiaban.Focus();
            }
            else
            {
                err.Clear();
            }
        }

        private void checksl(object sender, CancelEventArgs e)
        {
            if (check(txtsl.Text) == false)
            {
                err.SetError(txtsl, "Hãy nhập đúng dữ liệu");
                txtsl.Focus();
            }
            else
            {
                err.Clear();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            FormThemThuoc ftt = new FormThemThuoc();
            ftt.prop = new FormThemThuoc.FormThemThuocHandler(loadData);
            ftt.ShowDialog();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string str2 = "";
            str2 = txtgiaban.Text;
            str2 = str2.Remove(str2.IndexOf(","),1);
            str2 = str2.Remove(str2.IndexOf("."), 1);
            str2 = str2.Remove(str2.Length-1, 1);
            str2 = str2.Trim();
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update tblThuoc set sTenThuoc = N'{txtnamet.Text}', sNhaSanXuat = N'{txtnsx.Text}' , fGiaBan = '{str2}' , iSLThuocCon = '{txtsl.Text}' ,sDonViTinh = N'{txtdvt.Text}' where iMaThuoc = '{txtmath.Text}'";
            conn.Open();
            var i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("Sửa thành công");
                loadData("");
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
            cmd.Dispose();
            conn.Close();
        }

        private void checkdvt(object sender, CancelEventArgs e)
        {
            if (txtdvt.Text == "")
            {
                err.SetError(txtdvt, "Hãy nhập dữ liệu");
                txtdvt.Focus();
            }
            
            else
            {
                err.Clear();
            }
        }

        private void checktt(object sender, CancelEventArgs e)
        {
            if (txtnamet.Text == "")
            {
                err.SetError(txtnamet, "Hãy nhập dữ liệu");
                txtnamet.Focus();
            }

            else
            {
                err.Clear();
            }
        }

        private void check(object sender, CancelEventArgs e)
        {
            if (txtnsx.Text == "")
            {
                err.SetError(txtnsx, "Hãy nhập dữ liệu");
                txtnsx.Focus();
            }

            else
            {
                err.Clear();
            }
        }

        private void FormThuoc_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
        }

        private void btn_rpt_Click(object sender, EventArgs e)
        {
            FormReport re = new FormReport("sp_thuoc", "dsthuoc.rpt", null,null);
            re.ShowDialog();
        }
    }
}
