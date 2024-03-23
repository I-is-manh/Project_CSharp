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
                tvql.Nodes.RemoveAt(4);
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
            
        }
        void addformtopanel(Form form)
        {
            if(form == null)
            {
                MessageBox.Show("Không có thông tin bảng bệnh nhân","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            else
            {
                if(panelForm.Controls.Count != 0)
                {
                    panelForm.Controls.RemoveAt(0);
                }
                FormBn formBn = new FormBn();
                formBn.TopLevel = false;
                formBn.FormBorderStyle = FormBorderStyle.None;
                panelForm.Tag = formBn;
                formBn.AutoSizeMode = AutoSizeMode.GrowOnly;
                formBn.BringToFront();
                formBn.Show();
                panelForm.Controls.Add(formBn);
            }
        }
        void Closed()
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        
    }
}
