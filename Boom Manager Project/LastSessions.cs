using System;
using System.Windows.Forms;
using Boom_Manager_Project.DataBaseClasses;

namespace Boom_Manager_Project
{
    public partial class LastSessions : Form
    {
        public LastSessions()
        {
            InitializeComponent();
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LastSessions_Load(object sender, EventArgs e)
        {
            LoadDgv();
        }

        private void LoadDgv()
        {
            dgvLastSessions.DataSource = DataBaseClass.Instancedb().GetLastDaySessions(10);
            dgvLastSessions.Invalidate();
        }

        private void dgvLastSessions_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var dataGridViewColumn = dgvLastSessions.Columns["Начало"];
            if (dataGridViewColumn != null)
                dataGridViewColumn.DefaultCellStyle.Format = "t";
            var gridViewColumn = dgvLastSessions.Columns["Конец"];
            if (gridViewColumn != null)
                gridViewColumn.DefaultCellStyle.Format = "t";
        }

        private void dgvLastSessions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvLastSessions_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLastSessions.CurrentRow != null)
            {
                var cs = new CheckoutPriceAndTime((int)dgvLastSessions.CurrentRow.Cells[0].Value);
                cs.ShowDialog();
            }
        }
    }
}
