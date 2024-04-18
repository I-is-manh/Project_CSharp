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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_CSharp
{
    public partial class FormNhanVien : Form
    {
        string str = "Data Source=BING-CHILLING;Initial Catalog=SQLProject;Integrated Security=True;";
        Decentralization dcc = new Decentralization();

        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            loaddata("");
            dcc.setmabs(int.Parse(dgvbs.CurrentRow.Cells["mabs"].Value.ToString()));
           
        }
        public void loaddata(string filter = "")
        {
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select iMaBS,sHoTenBS,sDiaChi,sChuyenNganh,bGioiTinh from tblBacSi";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DataView dv = new DataView(ds.Tables[0]);
            dv.RowFilter = filter;
            dgvbs.DataSource = dv;
            
        }

        private void ininfo(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvbs.Rows[e.RowIndex];
            dcc.setmabs(int.Parse(row.Cells["mabs"].Value.ToString()));
            if (e.ColumnIndex == 0)
            {
                FormSuaBS suabs = new FormSuaBS();
                suabs.ShowDialog();
            }
            
            tmabs.Text = row.Cells["mabs"].Value.ToString();
            tnamebs.Text = row.Cells["tenbs"].Value.ToString();
            tdiachi.Text = row.Cells["dc"].Value.ToString();
            tcnganh.Text = row.Cells["dc"].Value.ToString();
            if(Boolean.Parse(row.Cells["gioitinh"].Value.ToString()) == false)
            {
                tgioitinh.Text = "Nữ";
            }
            else
            {
                tgioitinh.Text = "Nam";
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            FormThemBS themBS = new FormThemBS();
            themBS.load = new FormThemBS.Reload(loaddata);
            themBS.ShowDialog();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            FormSuaBS suaBS = new FormSuaBS();
            suaBS.load = new FormSuaBS.HandleUpdate(loaddata);
            suaBS.ShowDialog();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select count(*) from tblPhongKham where iMaBS = {tmabs.Text}";
            conn.Open();
            var check = cmd.ExecuteScalar();
            if (int.Parse(check.ToString()) == 0)
            {
                cmd.CommandText = $"delete from tblBacSi where iMaBS = {tmabs.Text}";
                cmd.ExecuteNonQuery();
                tmabs.Text = tnamebs.Text = tgioitinh.Text = tdiachi.Text = tcnganh.Text= "";
                loaddata("");
            }
            else
            {
                MessageBox.Show("Khong the xoa","Oops",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string filter = "";
            bool gt;
            if(tgioitinh.Text == "Nam" || tgioitinh.Text == "nam")
            {
                gt = true;
            }
            else
            {
                gt = false;
            }
            filter += string.Format("CONVERT({0}, System.String) like '%{1}%'",
                             "iMaBS", tmabs.Text);
            filter += $" and sHoTenBS like '%{tnamebs.Text}%' and sDiaChi like '%{tdiachi.Text}%' and ";
            filter += string.Format("CONVERT({0}, System.String) like '%{1}%'",
                             "bGioiTinh", gt);
            MessageBox.Show(filter);
            loaddata(filter);   
        }
    }
}
