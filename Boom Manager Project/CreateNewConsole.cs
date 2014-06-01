using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Boom_Manager_Project.Controllers;
using Boom_Manager_Project.DataBaseClasses;

namespace Boom_Manager_Project
{
    public partial class CreateNewConsole : Form
    {
        private Point? _old;
        public CreateNewConsole()
        {
            InitializeComponent();
        }

        private void CreateNewConsole_Load(object sender, EventArgs e)
        {

        }

        private void bCreate_Click(object sender, EventArgs e)
        {
            if (
                CreateNewConsoleController.CreateNewConsoleControllerIstance()
                    .CheckNameOfConsoleOnRepeat(tbConsoleName.Text))
            {
                DataBaseClass.Instancedb().InsertNewConsole(tbConsoleName.Text);
                Height = 395;
                tbConsoleName.Enabled = false;
                bCreate.Enabled = false;
                UpdatePriceListTable();
//                CheckListOfTimezonesOnFilledPrices();
            }
            else
            {
                MessageBox.Show("Enter name of new console point!");
            }
        }

//        private void CheckNullPrices()
//        {
//            foreach (TimezonePricesMyClass t in _timezonePrices)
//            {
//                if (textBoxNameOfNewConsole.Text.Equals(t.Приставка))
//                {
//                    if (t.TimezoneCostPerHour <= 0)
//                    {
//                        for (int j = 0; j < dataGridView1.RowCount; j++)
//                        {
//                            if (dataGridView1.Rows[j].Cells[0].Value.Equals(t.TimezoneName))
//                            {
//                                dataGridView1.Rows[j].DefaultCellStyle.BackColor = Color.Crimson;
//                                dataGridView1.Rows[j].DefaultCellStyle.SelectionBackColor = Color.Transparent;
//                                dataGridView1.Rows[j].DefaultCellStyle.SelectionForeColor = Color.White;
//                            }
//                        }
//                    }
//                    else
//                    {
//                        for (int j = 0; j < dataGridView1.RowCount; j++)
//                        {
//                            if ((string)dataGridView1.Rows[j].Cells[0].Value == t.TimezoneName)
//                            {
//                                dataGridView1.Rows[j].DefaultCellStyle.BackColor = Color.GreenYellow;
//                                dataGridView1.Rows[j].DefaultCellStyle.SelectionBackColor = Color.Transparent;
//                                dataGridView1.Rows[j].DefaultCellStyle.SelectionForeColor = Color.DarkBlue;
//                            }
//                        }
//                    }
//                    dataGridView1.Invalidate();
//                }
//            }
//        }

        private void UpdatePriceListTable()
        {
            var result = (from r in TimeZoneManagerController.TimeZoneManagerControllerInstance().GetTimeZonePrices()
                          where r.playstation_id == tbConsoleName.Text
                          select new
                          {
                              r.timezone_name,
                              r.timezone_cost_per_hour
                          }).ToList();
            dgvPriceList.DataSource = result;
            dgvPriceList.Invalidate();
        }

        private void bApply_Click(object sender, EventArgs e)
        {
            if (AllPricesNotEqualToNull())
            {
                Close();
            }
        }

//        private void UpdatingPrices()
//        {
//
//        }

        private bool AllPricesNotEqualToNull()
        {
            return dgvPriceList.Rows.Cast<DataGridViewRow>().All(row => !row.Cells[1].Value.Equals(0));
        }

        private void dgvPriceList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPriceList.CurrentRow != null)
            {
                CreateNewConsoleController.CreateNewConsoleControllerIstance()
                    .CallChangePrice(tbConsoleName.Text, (string) dgvPriceList.CurrentRow.Cells[0].Value);
            }
            else
            {
                MessageBox.Show("Choose at least one playstation");
            }
            UpdatePriceListTable();
        }

        private void CreateNewConsole_MouseDown(object sender, MouseEventArgs e)
        {
            _old = Cursor.Position;
        }

        private void CreateNewConsole_MouseMove(object sender, MouseEventArgs e)
        {
            if (_old.HasValue && _old.Value != Cursor.Position)
            {
                Left += Cursor.Position.X - _old.Value.X;
                Top += Cursor.Position.Y - _old.Value.Y;
                _old = Cursor.Position;
            }
        }

        private void CreateNewConsole_MouseUp(object sender, MouseEventArgs e)
        {
            _old = null;
        }

    }
}
