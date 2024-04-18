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
    public partial class FormThemThuoc : Form
    {
        string str = "Data Source=BING-CHILLING;Initial Catalog=SQLProject;Integrated Security=True";
        ErrorProvider err = new ErrorProvider();
        Random random = new Random();
        public delegate void FormThemThuocHandler(string str);
        public FormThemThuocHandler prop;
        public FormThemThuoc()
        {
            InitializeComponent();
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
        private void FormThemThuoc_Load(object sender, EventArgs e)
        {
            txtmath.Text = random.Next(11,100000).ToString();
            //this.reportViewer1.RefreshReport();
        }

        private void btn__reset_Click(object sender, EventArgs e)
        {
            txtmath.Text = random.Next(11, 100000).ToString();
            txtdvt.Text = txtgiaban.Text = txtnamet.Text = txtnsx.Text = txtsl.Text = ""; 
        }

        private void btn__add_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = conn.CreateCommand();
            conn.Open();
            cmd.CommandText = $"insert into tblThuoc values('{txtmath.Text}' , N'{txtnamet.Text}', '{txtnsx.Text}', '{txtgiaban.Text}','{txtsl.Text}',N'{txtdvt.Text}')";
            var i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("Them thanh cong");
                prop("");
            }
            cmd.Dispose();
            conn.Close();
        }

        private void checkvalidate(object sender, MouseEventArgs e)
        {
            if (txtnamet.Text == "" || txtnsx.Text == "" || txtsl.Text == "" || txtgiaban.Text == "" || txtdvt.Text == "")
            {
                btn__add.Enabled = false;
            }
            else
            {
                btn__add.Enabled = true;
            }
        }

        private void checksl(object sender, CancelEventArgs e)
        {
            if(txtsl.Text == "")
            {
                err.SetError(txtsl,"Hãy nhập đúng số lượng");
                txtsl.Focus();
            }
            else if (check(txtsl.Text) == false)
            {
                err.SetError(txtsl,"Hãy nhập đúng dữ liệu");
                txtsl.Focus();
            }
            else
            {
                err.Clear();
            }
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

        private void txtgiaban_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
