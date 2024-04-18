using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CSharp
{
    public partial class FormDichVu : Form
    {
        string str = "Data Source=BING-CHILLING;Initial Catalog=SQLProject;Integrated Security=True";
        ErrorProvider err = new ErrorProvider();
        public bool checknumber(string str)
        {
            foreach (char ch in str)
            {
                if (ch >= 65 && ch <= 90 || ch >= 97 && ch <= 122)
                {
                    return false;
                }
            }
            return true;
        }
        public FormDichVu()
        {
            InitializeComponent();
            loaddata("");
        }
        public void loaddata(string filter = "")
        {
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT iMaDV,sTenDV,fGiaDV FROM tblDichVu;";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataSet ds = new DataSet(); 
            adapter.Fill(ds);
            DataView dv = new DataView(ds.Tables[0]);
            dv.RowFilter = filter;
            dgv_dv.DataSource = dv;
        }

        private void cell_click(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgv_dv.Rows[e.RowIndex];
            madivu.Text = r.Cells["madv"].Value.ToString();
            namedivu.Text = r.Cells["namedv"].Value.ToString();
            giadivu.Text = int.Parse(r.Cells["dongia"].Value.ToString()).ToString("#,## VNĐ");
        }

        private void to_TextChanged(object sender, EventArgs e)
        {

        }

        private void from_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkfrom(object sender, CancelEventArgs e)
        {
            if (checknumber(from.Text) != true)
            {
                err.SetError(from, "Chi nhập số");
                from.Focus();
            }
            else
            {
                err.Clear();
            }
        }

        private void checkto(object sender, CancelEventArgs e)
        {
            if (checknumber(to.Text) != true)
            {
                err.SetError(to, "Chi nhập số");
                to.Focus();
            }
            else
            {
                err.Clear();
            }
        }

        private void btn_tk_Click(object sender, EventArgs e)
        {
            string filter = "iMaDV is not null and ";
            if (namedivu.Text != "")
            {
                filter += $"sTenDV like '%{namedivu.Text}%'  ";
            }
            if(from.Text != "" || to.Text != "")
            {
               filter += " and ";
                if (from.Text != "" && to.Text != "")
                {
                    filter += string.Format("CONVERT({0},System.String) >= {1} and CONVERT({0},System.String) <= {2}", "fGiaDV", from.Text, to.Text);
                    loaddata(filter);
                }
                else if (to.Text == "" && from.Text != "")
                {
                    filter += string.Format("CONVERT({0},System.String) >= {1}", "fGiaDV", from.Text);
                    loaddata(filter);
                }
                else if (from.Text == "" && to.Text != "")
                {
                    filter += string.Format("CONVERT({0},System.String) <= {1} ", "fGiaDV", to.Text);
                    loaddata(filter);
                }
                else
                {
                    MessageBox.Show("Hãy nhập khoảng giá trị muốn tìm");
                }
            }
            else
            {
                loaddata(filter);
            }

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if(namedivu.Text == "")
            {
                err.SetError(namedivu, "Bạn để trống tên dịch vụ kìa");
                namedivu.Focus();
                return;
            }
            else if (giadivu.Text == "")
            {
                err.SetError(giadivu, "Bạn để trống đơn giá dịch vụ");
                giadivu.Focus();
                return;
            }
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update tblDichVu set sTenDV = N'{namedivu.Text}',fGiaDV = {giadivu.Text} where iMaDV = {madivu.Text}";
            conn.Open();
            var i = cmd.ExecuteNonQuery();
            if(int.Parse(i.ToString()) == 0)
            {
                MessageBox.Show("Sửa thất bại");
            }
            else
            {
                MessageBox.Show("Sửa thành công");
                loaddata("");
            }
            cmd.Dispose();
            conn.Close();
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select count(*) from tblDichVu dv join tblChiTietHDDV ct on dv.iMaDV = ct.iMaDV where ct.iMaDV = {madivu.Text}";
            con.Open();
            var check = cmd.ExecuteScalar();
            if (int.Parse(check.ToString()) == 0)
            {
                cmd.CommandText = $"delete from tblDichVu where iMaDV = {madivu.Text}";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công");
                loaddata("");
                cmd.Dispose();
                con.Close();
            }
            else
            {
                MessageBox.Show("Không thể xóa vì liên quan khóa ngoại");
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            FormThemDV dv = new FormThemDV();
            dv.prop = new FormThemDV.HandleAdd(loaddata);
            dv.ShowDialog();
        }
    }
    
}
