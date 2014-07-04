using System;
using System.Windows.Forms;
using Boom_Manager_Project.DataBaseClasses;

namespace Boom_Manager_Project
{
    public partial class SoldItems : Form
    {
        public SoldItems()
        {
            InitializeComponent();
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SoldItems_Load(object sender, EventArgs e)
        {
            LoadDgv();
        }

        private void LoadDgv()
        {
            dgvAllItems.DataSource = DataBaseClass.Instancedb().GetListOfSoldItems(DataBaseClass.Instancedb().GetOpenedGlobalSession().daily_id);
            dgvAllItems.Invalidate();
        }
    }
}
