using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Boom_Manager_Project.Controllers;
using Boom_Manager_Project.DataBaseClasses;

namespace Boom_Manager_Project
{
    public partial class ConsoleManager : Form
    {
        private Point? _old;
        public ConsoleManager()
        {
            InitializeComponent();
        }

        private void ConsoleManager_Load(object sender, EventArgs e)
        {
            UpdateConsolesTable();
        }

        private void UpdateConsolesTable()
        {
            dgvAllConsoles.DataSource = ConsoleManagerController.ConsoleManagerControllerInstance().GetConsolesList();
            dgvAllConsoles.Invalidate();
        }

        private void UpdateHeaders()
        {
            dgvPriceListOfConsole.Columns[0].HeaderText = "TimeZone";
            dgvPriceListOfConsole.Columns[1].HeaderText = "Price per hour";
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            //Should check does every console have a price
            Close();
        }

        private void dgvAllConsoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAllConsoles.CurrentRow != null)
            {
                ShowInfo();
                UpdateHeaders();
            }
        }
        private void ShowInfo()
        {
            if (dgvAllConsoles.CurrentRow != null)
            {
                string consoleId = dgvAllConsoles.CurrentRow.Cells[0].Value.ToString();
//                UpdateConsolePriceListInfo(id);
                tbConsoleName.Text = consoleId;
                cbCurrentState.SelectedItem =
                    ConsoleManagerController.ConsoleManagerControllerInstance().GetStateOfExactConsole(consoleId);
                mtbOrderTime.Text =
                    ConsoleManagerController.ConsoleManagerControllerInstance()
                        .GetOrderTimeOfExactConsole(consoleId)
                        .ToString("dd.mm.yyyy HH:mm");
                cbCurrentState.BackColor =
                    ConsoleManagerController.ConsoleManagerControllerInstance().GetColorOfStateCb(cbCurrentState.Text);
                UpdatePricesOfConsole(consoleId);
            }
        }

        private void UpdatePricesOfConsole(string consoleId)
        {
            var listOfAllTables = DataBaseClass.Instancedb().GetAllTimeZonePrices();
            if (!String.IsNullOrEmpty(consoleId))
            {
                var result = (from p in listOfAllTables
                              where p.playstation_id == consoleId
                              select new
                              {
                                  p.timezone_name,
                                  p.timezone_cost_per_hour
                              }).ToList();
                dgvPriceListOfConsole.DataSource = result;
            }
        }

        private void bAddNewConsole_Click(object sender, EventArgs e)
        {
            ConsoleManagerController.ConsoleManagerControllerInstance().CallNewConsoleCreator();
            UpdateConsolesTable();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            DialogResult toDelete = MessageBox.Show("Are you sure that you want to delete this console?\nAll sessions, devices, history will be erased!\nProbably it is better to edit this console", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (toDelete == DialogResult.Yes)
            {
                if (dgvAllConsoles.CurrentRow != null)
                {
                    ConsoleManagerController.ConsoleManagerControllerInstance()
                        .DeleteConsole((string) dgvAllConsoles.CurrentRow.Cells[0].Value);
                    dgvAllConsoles.DataSource = null;
                    dgvAllConsoles.Rows.Clear();
                    dgvPriceListOfConsole.DataSource = null;
                    dgvPriceListOfConsole.Rows.Clear();
                    UpdateConsolesTable();
                    UpdatePricesOfConsole(tbConsoleName.Text);
                }
            }
        }

        private void ConsoleManager_MouseDown(object sender, MouseEventArgs e)
        {
            _old = Cursor.Position;
        }

        private void ConsoleManager_MouseMove(object sender, MouseEventArgs e)
        {
            if (_old.HasValue && _old.Value != Cursor.Position)
            {
                Left += Cursor.Position.X - _old.Value.X;
                Top += Cursor.Position.Y - _old.Value.Y;
                _old = Cursor.Position;
            }
        }

        private void ConsoleManager_MouseUp(object sender, MouseEventArgs e)
        {
            _old = null;
        }
    }
}
