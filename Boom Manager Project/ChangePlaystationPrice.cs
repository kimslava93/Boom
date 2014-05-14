using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Boom_Manager_Project.Controllers;

namespace Boom_Manager_Project
{
    public partial class ChangePlaystationPrice : Form
    {
        private readonly string _timeZoneToFind;
        private readonly List<string> _playstationsToChange;
        public ChangePlaystationPrice(List<string> tablesToChange, string timeZone)
        {
            _timeZoneToFind = timeZone;
            _playstationsToChange = tablesToChange;
            InitializeComponent();
        }

        private void ChangeCost_Load(object sender, EventArgs e)
        {
            WarningTextLoading();
        }

        private void WarningTextLoading()
        {
            lWarning.Text +=
                ChangePlaystationPriceController.ChangePlaystationPriceControllerInstance()
                    .GetWarningText(_playstationsToChange);
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bApply_Click(object sender, EventArgs e)
        {
            
            ChangePlaystationPriceController.ChangePlaystationPriceControllerInstance()
                .ApplyNewPrices(_playstationsToChange, _timeZoneToFind, (int) numUpDPrice.Value);
            Close();
        }

        private void numUpDPrice_ValueChanged(object sender, EventArgs e)
        {
            if (numUpDPrice.Value < 0)
            {
                numUpDPrice.Value = 0;
            }
            else if (numUpDPrice.Value > numUpDPrice.Maximum)
            {
                numUpDPrice.Value = numUpDPrice.Maximum;
                MessageBox.Show("Too big sum for one playstation! Check the input data!");
            }
        }
    }
}
