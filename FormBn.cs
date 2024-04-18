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
using System.Xml.Linq;

namespace Project_CSharp
{
    public partial class FormBn : Form
    {
        string str = "Data Source=BING-CHILLING;Initial Catalog=SQLProject;Integrated Security=True";
        Decentralization dc = new Decentralization();
        public FormBn()
        {
            InitializeComponent();
        }

        private void FormBn_Load(object sender, EventArgs e)
        {
            loadData();
            dc.setmabn(int.Parse(dgvbn.CurrentRow.Cells["mabn"].Value.ToString()));
        }
        void loadData(string filter = "")
        {
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select iMaBN,sHoTenBN,dNgayNhapVien,sBenh,iSoPhong from tblBenhNhan";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DataView dv = new DataView(ds.Tables[0]);
            dv.RowFilter = filter;
            dgvbn.DataSource = dv;
            dgvbn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            foreach (DataGridViewColumn column in dgvbn.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void dgvbn_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvbn.Rows[e.RowIndex];
            dc.setmabn(int.Parse(row.Cells["mabn"].Value.ToString()));
            tmabn.Text = row.Cells["mabn"].Value.ToString();
            tnamebn.Text = row.Cells["namebn"].Value.ToString();
            DateTime date = DateTime.Parse(row.Cells["dngaynv"].Value.ToString());
            string day = date.ToString("dd/MM/yyyy");
            tdaynv.Text = day;
            tbenhly.Text = row.Cells["benhly"].Value.ToString();
            tsophong.Text = row.Cells["sophong"].Value.ToString();
            if (e.ColumnIndex == 0)
            {
                FormInfoBN bn = new FormInfoBN();
                bn.ShowDialog();
            }
            else if (e.ColumnIndex == 1)
            {
                FormLapHoaDon lhd = new FormLapHoaDon(tmabn.Text,tnamebn.Text,tdaynv.Text,tbenhly.Text,tsophong.Text);
                lhd.ShowDialog();
            }
           
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            FormAddBn addbn = new FormAddBn();
            addbn.prop = new FormAddBn.HandleDelegate(loadData);
            addbn.ShowDialog();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            FormInfoBN bn = new FormInfoBN();
            bn.prop = new FormInfoBN.HandleUpdate(loadData);
            bn.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select count(*) from tblHoaDon where iMaBN = {tmabn.Text}";
            conn.Open();
            var check  = cmd.ExecuteScalar();
            if (int.Parse(check.ToString()) == 0)
            {
                SqlCommand cmd2 = conn.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = $"delete from tblBenhNhan where iMaBN = {tmabn.Text}";
                cmd2.ExecuteNonQuery();
                cmd2.Dispose();
                conn.Close();
                MessageBox.Show("Xoá thành công","Success");
            }
            else
            {
                MessageBox.Show("Bạn không thể xóa vì có liên quan tới khóa ngoại","Oops",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        public bool check (string str)
        {

            return false;
        }
        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string filter = "iMaBN IS NOT NULL and ";
            filter += string.Format("CONVERT({0}, System.String) like '%{1}%'",
                             "iMaBN", tmabn.Text);
            string daynv = tdaynv.Text.Replace("-", "/");

            filter += $" and sHoTenBN like \'%{tnamebn.Text.Trim()}%\' and ";
            filter += string.Format("CONVERT({0}, System.String) like '%{1}%'",
                              "dNgayNhapVien", daynv);
            filter += $" and sBenh like \'%{tbenhly.Text.Trim()}%\' and ";
            filter += string.Format("CONVERT({0}, System.String) like '%{1}%'",
                             "iSoPhong", tsophong.Text);
            loadData(filter);
        }
    }
}
