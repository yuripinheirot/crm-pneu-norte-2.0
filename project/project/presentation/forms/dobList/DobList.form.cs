using project.domain.model.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.presentation.forms.dobList
{
    public partial class DobListForm : Form
    {
        void openDobDetails()
        {

            var observationsValue = dgvClients.CurrentRow.Cells["observations"].Value;
            string observations = observationsValue != null ? observationsValue.ToString() : string.Empty;

            var props = new DobListDetailsProps()
            {
                client = $"{dgvClients.CurrentRow.Cells["id"].Value}-{dgvClients.CurrentRow.Cells["name"].Value}",
                dob = Convert.ToDateTime(dgvClients.CurrentRow.Cells["dob"].Value),
                done = Convert.ToBoolean(dgvClients.CurrentRow.Cells["isDone"].Value),
                observations = observations
            };


            new DobListDetails(props, this).ShowDialog();
        }

        string getDob()
        {
            return dtpDob.Value.ToString("dd/MM");
        }

        public void loadGrid()
        {
            string dob = $"{dtpDob.Value.Day}/{dtpDob.Value.Month}";
            int currentYear = DateTime.Now.Year;

            DobListFunctions.renderClientsOnGrid(dgvClients, getDob());
            var doblist = DobListFunctions.getDoblist(dob, currentYear);

            var doblistDict = doblist.ToDictionary(dobModel => dobModel.idClient, dobModel => dobModel);

            if (dgvClients.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvClients.Rows)
                {
                    if (row.Cells["id"].Value is string idClient && doblistDict.TryGetValue(idClient, out DobListModel doblistModel))
                    {
                        row.Cells["isDone"].Value = doblistModel.done;
                        row.Cells["observations"].Value = doblistModel.observations;
                    }
                }
            }
        }

        public DobListForm()
        {
            InitializeComponent();
        }

        private void dtpDob_ValueChanged(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void DobList_Load(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void dgvClients_KeyDown(object sender, KeyEventArgs e)
        {



        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            openDobDetails();
        }
    }
}
