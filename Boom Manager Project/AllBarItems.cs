using System;
using System.Drawing;
using System.Windows.Forms;
using Boom_Manager_Project.DataBaseClasses;

namespace Boom_Manager_Project
{
    public partial class AllBarItems : Form
    {
        private Point? _old;
        public AllBarItems()
        {
            InitializeComponent();
        }

        private void bAddNewItem_Click(object sender, EventArgs e)
        {
            var ani = new AddNewItem();
            ani.ShowDialog();
            LoadDgv();
        }

        private void LoadDgv()
        {
            dgvAllItems.DataSource = DataBaseClass.Instancedb().GetAllItems();
            dgvAllItems.Invalidate();
        }

        private void AllBarItems_Load(object sender, EventArgs e)
        {
            LoadDgv();
        }

        private void AllBarItems_MouseDown(object sender, MouseEventArgs e)
        {
            _old = Cursor.Position;
        }

        private void AllBarItems_MouseMove(object sender, MouseEventArgs e)
        {
            if (_old.HasValue && _old.Value != Cursor.Position)
            {
                Left += Cursor.Position.X - _old.Value.X;
                Top += Cursor.Position.Y - _old.Value.Y;
                _old = Cursor.Position;
            }
        }

        private void AllBarItems_MouseUp(object sender, MouseEventArgs e)
        {
            _old = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bChangeNumber_Click(object sender, EventArgs e)
        {
            if (dgvAllItems.CurrentRow != null)
            {
                var cni = new ChangeNumberOfItem((int) dgvAllItems.CurrentRow.Cells[4].Value,
                    (string) dgvAllItems.CurrentRow.Cells[0].Value);
                cni.ShowDialog();
                LoadDgv();
            }
        }

        private void bDeleteItem_Click(object sender, EventArgs e)
        {
            if (dgvAllItems.CurrentRow != null)
            {
                DataBaseClass.Instancedb().RemoveItem((string)dgvAllItems.CurrentRow.Cells[0].Value);
                MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetWarning(12));
                LoadDgv();
            }
        }
    }
}
