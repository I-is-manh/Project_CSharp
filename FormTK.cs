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
    public partial class FormTK : Form
    {
        string str = "Data Source=BING-CHILLING;Initial Catalog=SQLProject;Integrated Security=True";
        public FormTK()
        {
            InitializeComponent();
            load();
        }
        public void load()
        {
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from tblAccount";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dgvTK.DataSource = ds.Tables[0];
        }

        private void click_content(object sender, DataGridViewCellEventArgs e)
        {
            
            if(e.RowIndex >= 0 && e.RowIndex < dgvTK.RowCount - 1)
            {
                DataGridViewRow r = dgvTK.Rows[e.RowIndex];
                ttk.Text = r.Cells["tk"].Value.ToString();
                tmk.Text = r.Cells["mk"].Value.ToString();
                if (Boolean.Parse(r.Cells["state"].Value.ToString()) == false) 
                {
                    tcv.Text = "Nhân viên";
                }
                else
                {
                    tcv.Text = "Quản lý";
                }
                if (e.ColumnIndex == 0)
                {
                    SqlConnection conn = new SqlConnection(str);
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = $"delete from tblAccount where username = N'{ttk.Text}'";
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    conn.Close();
                    MessageBox.Show("Xóa thành công");
                    load();
                    ttk.Text = tmk.Text = tcv.Text = null;
                }
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            FormThemTK tk = new FormThemTK();
            tk.reload = new FormThemTK.MyReload(load);
            tk.Show();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if(ttk.Text != "" && tmk.Text != "" && tcv.Text != "")
            {
                SqlConnection conn = new SqlConnection(str);
                SqlCommand cmd = conn.CreateCommand();
                conn.Open();
                if (tcv.Text.ToLower() == "quản lý")  
                {
                    cmd.CommandText = $"update tblAccount set state = {1} where username = N'{ttk.Text}'";
                }
                else
                {
                    cmd.CommandText = $"update tblAccount set state = {0} where username = N'{ttk.Text}'";
                }
                cmd.ExecuteNonQuery ();
                cmd.Dispose();
                conn.Close();
                MessageBox.Show("Sửa thành công");
                load();
                ttk.Text = tmk.Text = tcv.Text = null;
            }
        }
    }
}
