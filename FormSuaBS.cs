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
    public partial class FormSuaBS : Form
    {
        Decentralization dc =  new Decentralization();
        public delegate void HandleUpdate(string str);
        public HandleUpdate load;
        string str = "Data Source=BING-CHILLING;Initial Catalog=SQLProject;Integrated Security=True";
        ErrorProvider err =  new ErrorProvider();
        public FormSuaBS()
        {
            InitializeComponent();
            loadData();
        }
        public bool check(string str)
        {
            foreach (char ch in str)
            {
                if (ch >= 48 && ch <=57)
                {
                    return true;
                }
            }
            return false;
        }
        public void loadData()
        {
            SqlConnection conn =  new SqlConnection(str);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from tblBacSi where iMaBS = {dc.getmabs()}";
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read()) { 
                txtmabs.Text = reader.GetValue(0).ToString();
                txtnamebs.Text = reader.GetValue(1).ToString();
                txtcccd.Text = reader.GetValue(2).ToString();
                txtdc.Text = reader.GetValue(3).ToString();
                txtcn.Text = reader.GetValue(4).ToString();
                txtlcb.Text = reader.GetValue(5).ToString();
                txtpc.Text = reader.GetValue(6).ToString();
                if(Boolean.Parse(reader.GetValue(7).ToString()) == true) {
                    rdNam.Checked = true;
                }
                else
                {
                    rdNu.Checked = true;
                }
                txtsdt.Text = reader.GetValue(8).ToString();
                DateTime date = DateTime.Parse(reader.GetValue(9).ToString());
                string day = date.ToString("dd/MM/yyyy");
                txtngsi.Text = day;
            }
        }

        private void txtmabs_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn__bs__sua_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            bool gt;
            if(rdNam.Checked == true)
            {
                gt = true;
            }
            else
            {
                gt = false;
            }
            string day = DateTime.Parse(txtngsi.Text).ToString("yyyy/MM/dd");
            cmd.CommandText = $"update tblBacSi set sHoTenBS = N'{txtnamebs.Text}',sCCCD = '{txtcccd.Text}',sDiaChi = N'{txtdc.Text}', sChuyenNganh = N'{txtcn.Text}', fLuongCoBan = {txtlcb.Text}, fPhuCap = {txtpc.Text}, bGioiTinh = '{gt}', sSoDienThoai = '{txtsdt.Text}',dNgaySinh = '{day}' where iMaBS = {txtmabs.Text}";
            conn.Open();
            var check = cmd.ExecuteNonQuery();
            if(int.Parse(check.ToString()) != 0)
            {
                MessageBox.Show("Sua thanh cong");
                load("");
            }
            else
            {
                MessageBox.Show("Sua that bai");
            }
            cmd.Dispose();
            conn.Close();
        }

        private void checknamebs(object sender, CancelEventArgs e)
        {
            if(txtnamebs.Text == "")
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
            else if (check(txtcccd.Text) == false || txtcccd.Text.Length < 12 || txtcccd.Text.Length > 12)
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
            else if (check(txtsdt.Text) == false || txtsdt.Text.Length < 10 || txtsdt.Text.Length > 10)
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
