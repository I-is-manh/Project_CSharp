using CrystalDecisions.CrystalReports.Engine;
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
    public partial class FormReport : Form
    {
        string str = "Data Source=BING-CHILLING;Initial Catalog=SQLProject;Integrated Security=True";
        public FormReport(string store,string path,string option,string parameter)
        {
            InitializeComponent();
            Show(store,path,option,parameter);
        }
        public void Show(string store,string path,string option,string parameter)
        {
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = store;
            if (option != null)
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@imahd", option);
            }
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DataView dv = new DataView(ds.Tables[0]);
            
            ReportDocument report  = new ReportDocument();
            string path2 = string.Format("{0}\\{1}", Application.StartupPath, path);
            report.Load(path2);
            report.SetDataSource(dv);
            report.SetParameterValue("tongtien",parameter);
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();

        }
    }
}
