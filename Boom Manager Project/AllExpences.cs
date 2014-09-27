using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Boom_Manager_Project.DataBaseClasses;
using Boom_Manager_Project.MyClasses;
using Novacode;

namespace Boom_Manager_Project
{
    public partial class AllExpences : Form
    {
        private Point? _old;
        public AllExpences()
        {
            InitializeComponent();
        }

        private void AllSpends_Load(object sender, EventArgs e)
        {
            LoadDgv();
        }

        private void LoadDgv()
        {
            List<expenses_t> allexp = DataBaseClass.Instancedb().GetAllExpensesOnDailyId(DataBaseClass.Instancedb().GetLastOpenedGlobalSessionDailyId());
            var expToShowList = allexp.Select(e => new ExpensesMyClass().ConvertDbTableToMyClass(e)).ToList();
            dgvAllSpends.DataSource = expToShowList;
            dgvAllSpends.Invalidate();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AllExpences_MouseDown(object sender, MouseEventArgs e)
        {
            _old = Cursor.Position;
        }

        private void AllExpences_MouseMove(object sender, MouseEventArgs e)
        {
            if (_old.HasValue && _old.Value != Cursor.Position)
            {
                Left += Cursor.Position.X - _old.Value.X;
                Top += Cursor.Position.Y - _old.Value.Y;
                _old = Cursor.Position;
            }
        }

        private void AllExpences_MouseUp(object sender, MouseEventArgs e)
        {
            _old = null;
        }

        private void bDeleteSpend_Click(object sender, EventArgs e)
        {
            if (dgvAllSpends.CurrentRow != null)
            {
                DataBaseClass.Instancedb().DeleteExpense((int)dgvAllSpends.CurrentRow.Cells[0].Value);
                LoadDgv();
            }
            else
            {
                MessageBox.Show("Выберите предмет на удаление!");
            }
        }
    }
}
