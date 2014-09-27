using System;
using System.Drawing;
using System.Windows.Forms;
using Boom_Manager_Project.Controllers;
using Boom_Manager_Project.DataBaseClasses;

namespace Boom_Manager_Project
{
    public partial class AllClients : Form
    {
        private Point? _old;
        public AllClients()
        {
            InitializeComponent();
            
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void AllClients_Load(object sender, EventArgs e)
        {
            LoadDgv();
        }
        private void bAddNewItem_Click(object sender, EventArgs e)
        {
            var anc = new ClientManager("create");
            anc.ShowDialog();
        }

        private void bChangeNumber_Click(object sender, EventArgs e)
        {

        }

        private void bDeleteItem_Click(object sender, EventArgs e)
        {
            if (dgvAllClients.CurrentRow != null)
            {
                if (dgvAllClients.CurrentRow.Cells[0].Value.Equals("0") || dgvAllClients.CurrentRow.Cells[0].Value.Equals("Usual Client"))
                {
                    MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(53));
                }
                else
                {
                    AllClientsController.AllClientsControllerInstance()
                        .DeleteClient((string) dgvAllClients.CurrentRow.Cells[0].Value);
                }
            }
        }

        private void LoadDgv()
        {
            dgvAllClients.DataSource = AllClientsController.AllClientsControllerInstance().GetAllClients();
            dgvAllClients.Invalidate();
        }

        private void AllClients_MouseDown(object sender, MouseEventArgs e)
        {
            _old = Cursor.Position;
        }

        private void AllClients_MouseUp(object sender, MouseEventArgs e)
        {
            _old = null;
        }

        private void AllClients_MouseMove(object sender, MouseEventArgs e)
        {
            if (_old.HasValue && _old.Value != Cursor.Position)
            {
                Left += Cursor.Position.X - _old.Value.X;
                Top += Cursor.Position.Y - _old.Value.Y;
                _old = Cursor.Position;
            }
        }

    }
}
