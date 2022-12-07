using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.presentation.forms.main
{
    internal class MainFunctions
    {
        GroupBox getActiveGroupBox()
        {
            Control.ControlCollection controls = Form.ActiveForm.Controls;

            GroupBox gpxSales = (GroupBox)controls.Find("gpxSales", true)[0];
            GroupBox gpxOrder = (GroupBox)controls.Find("gpxOrder", true)[0];

            GroupBox activeGroupBox = gpxOrder.Visible ? gpxOrder : gpxSales;

            return activeGroupBox;
        }

        public void getAnswersFromForm()
        {
           GroupBox activeGroupBox = getActiveGroupBox();

        }
    }
}
