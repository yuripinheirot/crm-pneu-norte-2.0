using project.presentation.errors;
using project.presentation.protocols;
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
    public partial class DobListDetails : Form
    {
        DobListDetailsProps props;
        DobListForm form;

        public DobListDetails(DobListDetailsProps props, DobListForm form)
        {
            InitializeComponent();
            this.props = props;
            this.form = form;
        }

        private void dtpDob_ValueChanged(object sender, EventArgs e)
        {
        }

        private void DobList_Load(object sender, EventArgs e)
        {
            tbxClientName.Text = props.client;
            dtpDob.Value = props.dob;
            cbxDone.Checked = props.done;
            tbxObservations.Text = props.observations;
        }

        private void dgvClients_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var dto = new DobListDTO()
            {
                done = cbxDone.Checked,
                observations = tbxObservations.Text,
                idClient = tbxClientName.Text.Split('-')[0],
                dob = $"{props.dob.Day}/{props.dob.Month}"
            };

            try
            {
                DobListFunctions.saveDob(dto);
                MessageBox.Show("Alterações salvas com sucesso!", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                form.loadGrid();
                Close();
            }
            catch (Exception error)
            {
                ThrowCustomException.Throw(error);
            }

        }
    }

    public class DobListDetailsProps
    {
        public string client { get; set; }
        public DateTime dob { get; set; }
        public bool done { get; set; }
        public string observations { get; set; }
    }
}
