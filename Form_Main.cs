using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CSharp
{
    public partial class Form_Main : Form
    {
        Thread th;
        Decentralization dc = new Decentralization();
        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            if (dc.getisAdmin() == false)
            {
                tvql.Nodes.RemoveAt(1);
                tvql.Nodes.RemoveAt(1);
                tvql.Nodes.RemoveAt(1);
                tvql.Nodes.RemoveAt(1);
                tvql.Nodes.RemoveAt(2);
            }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Text == "Đăng xuất")
            {
                DialogResult res = MessageBox.Show("Bạn chắc chắn muốn đăng xuất chứ","Đăng xuất",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    th = new Thread(Closed);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                    this.Close();
                }
            }
            else if (e.Node.Text == "Quản lý bệnh nhân")
            {
                FormBn bn = new FormBn();
               
                addformtopanel(bn);
            }
            else if(e.Node.Text == "Quản lý bác sĩ")
            {
                FormNhanVien fnv = new FormNhanVien();
                addformtopanel(fnv);
            }
            else if (e.Node.Text == "Quản lý thuốc")
            {
                FormThuoc thuoc  = new FormThuoc();
                addformtopanel(thuoc);
            }
            else if(e.Node.Text == "Quản lý dịch vụ")
            {
                FormDichVu dv = new FormDichVu();
                addformtopanel(dv);
            }
            else if (e.Node.Text == "Quản lý phòng khám")
            {
                FormPhongKham pk  = new FormPhongKham();
                addformtopanel(pk);
            }
            else if(e.Node.Text == "Quản lý hóa đơn")
            {
                FormHoaDon hd = new FormHoaDon();
                addformtopanel(hd);
            }
            else if(e.Node.Text == "Quản lý tài khoản")
            {
                FormTK tk = new FormTK();
                addformtopanel(tk);
            }
            
        }
        void addformtopanel(Form form)
        {
            if(form == null)
            {
                MessageBox.Show("Không có data","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            else
            {
                if(panelForm.Controls.Count != 0)
                {
                    panelForm.Controls.RemoveAt(0);
                }
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                panelForm.Tag = form;
                form.AutoSizeMode = AutoSizeMode.GrowOnly;
                form.BringToFront();
                form.Show();
                panelForm.Controls.Add(form);
            }
        }
        void Closed()
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        
    }
}
