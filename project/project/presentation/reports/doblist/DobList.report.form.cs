using FastReport;
using project.presentation.errors;
using project.presentation.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project.business.usecases.client;
using project.main.factories.business;

namespace project.presentation.reports.doblist
{
    public partial class DobListReportForm : Form
    {
        public DobListReportForm()
        {
            InitializeComponent();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                var dti = tbxDti.Value.ToString("yyyy-MM-dd");
                var dtf = tbxDtf.Value.ToString("yyyy-MM-dd");

                var clients = ClientFactory.handle.getClientsByDob(dti, dtf);

                DataTable dt = new DataTable();
                dt.TableName = "MainReport";

                dt.Columns.Add("clientId");
                dt.Columns.Add("clientName");
                dt.Columns.Add("observation");
                dt.Columns.Add("done");
                dt.Columns.Add("dob");

                foreach (var client in clients)
                {
                    dt.Rows.Add(client.clientId, client.clientName, client.observation, client.done, client.dob);
                }

                Report report = new Report();
                report.Load(Path.Combine(Environment.CurrentDirectory + @"\presentation\reports\doblist\dobList.report.frx"));
                report.SetParameterValue("initialDate", DateTime.Parse(dti).ToString("dd/MM/yyyy"));
                report.SetParameterValue("finalDate", DateTime.Parse(dtf).ToString("dd/MM/yyyy"));
                report.RegisterData(dt, dt.TableName);

                // Enable data source for designer
                report.GetDataSource(dt.TableName).Enabled = true;
                DataBand dataBand2 = (DataBand)report.FindObject("Data2");
                DataBand dataBand3 = (DataBand)report.FindObject("Data3");
                dataBand2.DataSource = report.GetDataSource(dt.TableName);
                dataBand3.DataSource = report.GetDataSource(dt.TableName);

                // Open report in designer
                // report.Design(true);

                report.Show();
            }
            catch (Exception error)
            {
                ThrowCustomException.Throw(error);
            }
        }
    }
}
