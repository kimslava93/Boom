using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Boom_Manager_Project.Controllers;
using Boom_Manager_Project.DataBaseClasses;

namespace Boom_Manager_Project
{
    public partial class TimeZoneManager : Form
    {
        private Point? _old;
        private bool _isNewTimeZoneCreated;
        public TimeZoneManager()
        {
            InitializeComponent();
        }

        private void TimeZoneManager_Load(object sender, EventArgs e)
        {
            RefreshTable();
            LoadComboBox();
        }

        private void LoadComboBox()
        {
            var timezones = DataBaseClass.Instancedb().GetAllTimeZones();
            foreach (var t in timezones)
            {
                cbAllTimeZones.Items.Add(t.timezone_name);
            }
        }
        private void RefreshTable()
        {
            dgvAllTimezones.DataSource =
                TimeZoneManagerController.TimeZoneManagerControllerInstance().GetAlTimeZonesData();
        }

        private void bAddTimezone_Click(object sender, EventArgs e)
        {
            bExit.Enabled = false;
            if (TimeZoneManagerController.TimeZoneManagerControllerInstance()
                    .CheckAllInputDataToInsertTimeZone(tbTimezoneName.Text, (int)numUpDStartHours.Value,
                        (int)numUpDEndHours.Value))
            {
                TimeZoneManagerController.TimeZoneManagerControllerInstance()
                    .CreateTimeZoneWithGivenData(tbTimezoneName.Text, (int) numUpDStartHours.Value,
                        (int) numUpDEndHours.Value);
                cbAllTimeZones.Items.Add(tbTimezoneName.Text);
                cbAllTimeZones.SelectedText = tbTimezoneName.Text;
                RefreshPriceList();
                tbTimezoneName.Text = "";
                RefreshTable();
                _isNewTimeZoneCreated = true;
                MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetWarning(10));
            }
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            if (bExit.Enabled)
            {
                Close();
            }
            else
            {
                MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetWarning(11));
            }
        }

        private void cbAllTimeZones_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshPriceList();
        }

        private void RefreshPriceList()
        {
            var result = (from r in TimeZoneManagerController.TimeZoneManagerControllerInstance().GetTimeZonePrices()
                          where r.timezone_name == cbAllTimeZones.Text
                          select new
                          {
                              r.playstation_id,
                              r.timezone_cost_per_hour
                          }).ToList();
            dgvTimeZonePrices.DataSource = result;
            dgvTimeZonePrices.Invalidate();
        }

        private void bChangePrices_Click(object sender, EventArgs e)
        {
            if (dgvTimeZonePrices.SelectedRows.Count > 0)
            {
                var listToChange = new List<string>();
                for (int i = 0; i < dgvTimeZonePrices.SelectedRows.Count; i++)
                {
                    listToChange.Add(dgvTimeZonePrices.SelectedRows[i].Cells[0].Value.ToString());
                }
                var cc = new ChangePlaystationPrice(listToChange, cbAllTimeZones.Text);
                cc.ShowDialog();
                RefreshPriceList();
            }
            else
            {
                MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(43));
            }
        }

//        private void cbAllTimeZones_MouseClick(object sender, MouseEventArgs e)
//        {
//            RefreshPriceList();
//        }

        private void bDeleteTimezone_Click(object sender, EventArgs e)
        {
            if (dgvAllTimezones.CurrentRow != null)
            {
                var timeZoneToDelete = (string) dgvAllTimezones.CurrentRow.Cells[0].Value;
                DataBaseClass.Instancedb().DeleteTimeZoneWithData(timeZoneToDelete);
                cbAllTimeZones.Items.RemoveAt(cbAllTimeZones.Items.IndexOf(timeZoneToDelete));
                if (TimeZoneManagerController.TimeZoneManagerControllerInstance().CheckOnNullPrices())
                {
                    bExit.Enabled = true;
//                    sContainer.Panel2Collapsed = true;
                    if (ActiveForm != null)
                        ActiveForm.Height = 218;
                }
                RefreshPriceList();
                RefreshTable();

            }
        }

        private void bCreateNewTimeZone_Click(object sender, EventArgs e)
        {
//            sContainer.Panel2Collapsed = false;
            if (ActiveForm != null)
                ActiveForm.Height = 527;
        }

        private void bExitCreatingMode_Click(object sender, EventArgs e)
        {
            if (_isNewTimeZoneCreated)
            {
                if (TimeZoneManagerController.TimeZoneManagerControllerInstance().CheckOnNullPrices())
                {
                    _isNewTimeZoneCreated = false;
//                    sContainer.Panel2Collapsed = true;
                    bExit.Enabled = true;
                    if (ActiveForm != null)
                        ActiveForm.Height = 218;
                }
                else
                {
//                    sContainer.Panel2Collapsed = false;
                    bExit.Enabled = false;
                    if (ActiveForm != null)
                        ActiveForm.Height = 527;
                }
            }
            else
            {
//                sContainer.Panel2Collapsed = true;
                bExit.Enabled = true;
                if (ActiveForm != null)
                    ActiveForm.Height = 218;
            }
        }

        private void TimeZoneManager_MouseDown(object sender, MouseEventArgs e)
        {
            _old = Cursor.Position;
        }

        private void TimeZoneManager_MouseMove(object sender, MouseEventArgs e)
        {
            if (_old.HasValue && _old.Value != Cursor.Position)
            {
                Left += Cursor.Position.X - _old.Value.X;
                Top += Cursor.Position.Y - _old.Value.Y;
                _old = Cursor.Position;
            }
        }

        private void TimeZoneManager_MouseUp(object sender, MouseEventArgs e)
        {
            _old = null;
        }

        private void cbAllTimeZones_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            RefreshPriceList();
        }

        private void numUpDStartHours_ValueChanged(object sender, EventArgs e)
        {
            if (numUpDStartHours.Value >= 24)
            {
                numUpDStartHours.Value = 0;
            }
        }

        private void numUpDEndHours_ValueChanged(object sender, EventArgs e)
        {
            if (numUpDEndHours.Value >= 24)
            {
                numUpDEndHours.Value = 0;
            }
        }

    }
}
