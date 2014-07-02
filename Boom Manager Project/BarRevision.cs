using System;
using System.Windows.Forms;
using Boom_Manager_Project.DataBaseClasses;

namespace Boom_Manager_Project
{
    public partial class BarRevision : Form
    {
        public BarRevision()
        {
            InitializeComponent();
        }

        private void BarRevision_Load(object sender, EventArgs e)
        {
            LoadDgv();
        }

        private void LoadDgv()
        {
            dgvAllItems.DataSource = DataBaseClass.Instancedb().GetAllBarRevisionItems();
            dgvAllItems.Invalidate();
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
