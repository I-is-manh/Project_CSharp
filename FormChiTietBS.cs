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
    public partial class FormThemBS : Form
    {
        public delegate void Reload(string str);
        public Reload load;
        Random random = new Random();
        string str = "Data Source=BING-CHILLING;Initial Catalog=SQLProject;Integrated Security=True";
        ErrorProvider err = new ErrorProvider();    
        public FormThemBS()
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
        private void FormChiTietBS_Load(object sender, EventArgs e)
        {
            txtmabs.Text = random.Next(9,1000000).ToString();
        }

        private void btn__info__reset_Click(object sender, EventArgs e)
        {
            txtmabs.Text = random.Next(9, 1000000).ToString();
            txtnamebs.Text = "";
            txtsdt.Text = txtcccd.Text = txtdc.Text = txtlcb.Text = txtpc.Text = txtcn.Text = "";
            rdNam.Checked = rdNu.Checked = false;
            txtngsi.Text = "";
        }

        private void btn__bs__add_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select count(*) from tblBacSi where iMaBS = {txtmabs.Text}";
            conn.Open();
            var check = cmd.ExecuteScalar();
            if (int.Parse(check.ToString()) == 0)
            {
                SqlCommand cmd2 = conn.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                bool gt;
                if (rdNam.Checked == true)
                {
                    gt = true;
                }
                else
                {
                    gt = false;
                }
                
                if (txtmabs.Text != "" && txtnamebs.Text != "" && txtdc.Text != "" && txtcccd.Text != "" && txtcn.Text != "" && txtngsi.Text != "" && txtpc.Text != "" && txtsdt.Text != "" && txtlcb.Text != "" && rdNam.Checked != false || rdNu.Checked != false)
                {
                    DateTime date = DateTime.Parse(txtngsi.Text);
                    string ngsi = date.ToString("yyyy/MM/dd");
                    cmd2.CommandText = $"insert into tblBacSi values('{txtmabs.Text}',N'{txtnamebs.Text}','{txtcccd.Text}',N'{txtdc.Text}',N'{txtcn.Text}','{txtlcb.Text}','{txtpc.Text}','{gt}','{txtsdt.Text}','{ngsi}')";
                    MessageBox.Show("sdafds");
                    var i = cmd2.ExecuteNonQuery();
                    if (int.Parse(i.ToString()) != 0)
                    {
                        MessageBox.Show("Thêm thành công");
                        load("");
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Hay nhập đày đủ dữ liệu");
                }
                
            }
            else
            {
                MessageBox.Show("Bị trùng khóa chình", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void checknamebs(object sender, CancelEventArgs e)
        {
            if (txtnamebs.Text == "")
            {
                err.SetError(txtnamebs, "Hãy nhập tên bác sĩ");
                txtnamebs.Focus();

            }
            else
            {
                err.Clear();
            }
        }

        private void checkdc(object sender, CancelEventArgs e)
        {
            if (txtdc.Text == "")
            {
                err.SetError(txtdc, "Hãy nhập địa chỉ");
                txtdc.Focus();
            }
            else
            {
                err.Clear();
            }
        }

        private void checkcn(object sender, CancelEventArgs e)
        {
            if (txtcn.Text == "")
            {
                err.SetError(txtcn, "Hãy nhập chuyên ngành");
                txtcn.Focus();
            }
            else
            {
                err.Clear();
            }
        }

        private void checkcccd(object sender, CancelEventArgs e)
        {
            if (txtcccd.Text == "")
            {
                err.SetError(txtcccd, "Hãy nhập căn cước công dân");
                txtcccd.Focus();
            }
            else if (check(txtcccd.Text) == false)
            {
                err.SetError(txtcccd, "Hãy đúng dữ liệu");
                txtcccd.Focus();
            }
            else
            {
                err.Clear();
            }
        }

        private void checksdt(object sender, CancelEventArgs e)
        {
            if (txtsdt.Text == "")
            {
                err.SetError(txtsdt, "Hãy nhập số điện thoại");
                txtsdt.Focus();
            }
            else if (check(txtsdt.Text) == false)
            {
                err.SetError(txtsdt, "Hãy nhập đúng điện thoại");
                txtsdt.Focus();
            }
            else
            {
                err.Clear();
            }
        }

        private void checkluong(object sender, CancelEventArgs e)
        {
            if (txtlcb.Text == "")
            {
                err.SetError(txtlcb, "Hãy nhập lương cơ bản");
                txtlcb.Focus();
            }
            else if (check(txtlcb.Text) == false)
            {
                err.SetError(txtlcb, "Hãy nhập đúng lương cơ bản");
                txtlcb.Focus();
            }
            else
            {
                err.Clear();
            }
        }

        private void checkpc(object sender, CancelEventArgs e)
        {
            if (txtpc.Text == "")
            {
                err.SetError(txtpc, "Hãy nhập phụ cấp");
                txtpc.Focus();
            }
            else if (check(txtpc.Text) == false)
            {
                err.SetError(txtpc, "Hãy nhập đúng phụ cấp");
                txtpc.Focus();
            }
            else
            {
                err.Clear();
            }
        }




        private void checkday(object sender, CancelEventArgs e)
        {
            if (txtngsi.Text[0] == ' ')
            {
                err.SetError(txtngsi, "Hãy nhập ngày sinh");
                txtngsi.Focus();
            }
            else
            {
                err.Clear();
            }
        }
    }
}
