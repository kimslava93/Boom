using System;
using System.Windows.Forms;
using Boom_Manager_Project.Controllers;
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
            BarRevisionController.BarRevisionControllerInstance().InsertOrUpdateAllItemsInBar();
            int dailyId = DataBaseClass.Instancedb().GetOpenedGlobalSession().daily_id;
            dgvAllItems.DataSource = DataBaseClass.Instancedb().GetAllBarRevisionItems(dailyId);
            dgvAllItems.Invalidate();
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
