using System;
using System.Drawing;
using System.Windows.Forms;
using Boom_Manager_Project.Controllers;

namespace Boom_Manager_Project
{
    public partial class ShiftsManager : Form
    {
        private Point? _old;
        public ShiftsManager()
        {
            InitializeComponent();
        }

        private void ShiftsManager_Load(object sender, EventArgs e)
        {
            LoadAllShifts();
        }

        private void LoadAllShifts()
        {
            dgvAllGlobalSessions.DataSource = ShiftsManagerController.ShiftsControllerInstance().GetAllShifts();
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bReport_Click(object sender, EventArgs e)
        {
            if (dgvAllGlobalSessions.CurrentRow != null)
            {
                ShiftsManagerController.ShiftsControllerInstance().GenerateWordReport((int)dgvAllGlobalSessions.CurrentRow.Cells[0].Value);
            }
        }

        private void ShiftsManager_MouseDown(object sender, MouseEventArgs e)
        {
            _old = Cursor.Position;
        }

        private void ShiftsManager_MouseMove(object sender, MouseEventArgs e)
        {
            if (_old.HasValue && _old.Value != Cursor.Position)
            {
                Left += Cursor.Position.X - _old.Value.X;
                Top += Cursor.Position.Y - _old.Value.Y;
                _old = Cursor.Position;
            }
        }

        private void ShiftsManager_MouseUp(object sender, MouseEventArgs e)
        {
            _old = null;
        }

        private void bReport_MouseLeave(object sender, EventArgs e)
        {
            bReport.FlatAppearance.BorderColor = Color.FromArgb(81, 91, 103);
        }

        private void bReport_MouseHover(object sender, EventArgs e)
        {
            bReport.FlatAppearance.BorderColor = Color.White;
        }

        private void bClose_MouseHover(object sender, EventArgs e)
        {
            bClose.FlatAppearance.BorderColor = Color.White;
        }

        private void bClose_MouseLeave(object sender, EventArgs e)
        {
            bClose.FlatAppearance.BorderColor = Color.FromArgb(81, 91, 103);
        }
    }
}
