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
    public partial class DobList : Form
    {
        void openDobDetails()
        {
            var props = new DobListDetailsProps()
            {
                client = $"{dgvClients.CurrentRow.Cells["id"].Value.ToString()} - {dgvClients.CurrentRow.Cells["name"].Value.ToString()}",
                dob = dtpDob.Value.ToString(),
                done = Convert.ToBoolean(dgvClients.CurrentRow.Cells["isDone"].Value),
                observations = ""
            };


            new DobListDetails(props).ShowDialog();
        }

        string getDob()
        {
            return dtpDob.Value.ToString("dd/MM");
        }

        void loadGrid()
        {
            DobListFunctions.renderClientsOnGrid(dgvClients, getDob());
        }

        public DobList()
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
