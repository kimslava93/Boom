using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Boom_Manager_Project.Controllers;

namespace Boom_Manager_Project
{
    public partial class ChangePlaystationPrice : Form
    {
        private readonly string _timeZoneToFind;
        private readonly List<string> _playstationsToChange;
        private Point? _old;
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

        private void ChangePlaystationPrice_MouseDown(object sender, MouseEventArgs e)
        {
            _old = Cursor.Position;
        }

        private void ChangePlaystationPrice_MouseMove(object sender, MouseEventArgs e)
        {
            if (_old.HasValue && _old.Value != Cursor.Position)
            {
                Left += Cursor.Position.X - _old.Value.X;
                Top += Cursor.Position.Y - _old.Value.Y;
                _old = Cursor.Position;
            }
        }

        private void ChangePlaystationPrice_MouseUp(object sender, MouseEventArgs e)
        {
            _old = null;
        }
    }
}
