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

        public DobListDetails(DobListDetailsProps props)
        {
            InitializeComponent();
            this.props = props;
        }

        private void dtpDob_ValueChanged(object sender, EventArgs e)
        {
        }

        private void DobList_Load(object sender, EventArgs e)
        {
            tbxClientName.Text = props.client;
            tbxDob.Text = props.dob;
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

        }
    }

    public class DobListDetailsProps
    {
        public string client { get; set; }
        public string dob { get; set; }
        public bool done { get; set; }
        public string observations { get; set; }
    }
}
