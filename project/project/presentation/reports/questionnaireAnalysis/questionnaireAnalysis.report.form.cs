using FastReport;
using project.presentation.errors;
using project.presentation.utils;
using System;
using System.IO;
using System.Windows.Forms;

namespace project.presentation.reports.questionnaireAnalysis
{
    public partial class QuestionnaireAnalysisReportForm : Form
    {
        public QuestionnaireAnalysisReportForm()
        {
            InitializeComponent();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                string buildWhereCondition()
                {
                    string initialDate = tbxDti.Value.ToString("yyyy-MM-dd");
                    string finalDate = tbxDtf.Value.ToString("yyyy-MM-dd");
                    string query = $"where created_at between '{initialDate} 00:00:00' and '{finalDate} 23:59:59' ";

                    if (!string.IsNullOrWhiteSpace(tbxIdCompany.Text))
                    {
                        query += $"and id_company = '{tbxIdCompany.Text}' ";
                    }
                    if (!string.IsNullOrWhiteSpace(cbxTypeCrm.Text))
                    {
                        query += $"and pos_sale = '{TextUtils.translatePosSaleData(cbxTypeCrm.Text)}' ";
                    }

                    return query;
                };

                Report report = new Report();
                report.Load(Path.Combine(Environment.CurrentDirectory + @"\presentation\reports\questionnaireAnalysis\questionnaireAnalysis.report.frx"));
                report.SetParameterValue("whereCondition", buildWhereCondition());
                report.Show();
            }
            catch (Exception error)
            {
                ThrowCustomException.Throw(error);
            }
        }

        private void QuestionnaireAnalysisReportForm_Load(object sender, EventArgs e)
        {
            string defaultCompany = Properties.Settings.Default.defaultCompany;
            if (!string.IsNullOrWhiteSpace(defaultCompany))
            {
                tbxIdCompany.Text = defaultCompany;
            }
        }
    }
}
