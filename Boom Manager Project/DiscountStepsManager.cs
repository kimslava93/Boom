using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Boom_Manager_Project
{
    public partial class DiscountStepsManager : Form
    {
        public DiscountStepsManager()
        {
            InitializeComponent();
        }

        private void DiscountStepsManager_Load(object sender, EventArgs e)
        {
            DgvLoad();
            dgvDiscountSteps.Columns[0].HeaderText =
                DiscountStepsManagerController.DiscountStepsManagerControllerInstance().FirstColumn; 
            dgvDiscountSteps.Columns[1].HeaderText =
                DiscountStepsManagerController.DiscountStepsManagerControllerInstance().SecondColumn; 
            dgvDiscountSteps.Columns[2].HeaderText =
                DiscountStepsManagerController.DiscountStepsManagerControllerInstance().ThirdColumn;

        }

        private void DgvLoad()
        {
            dgvDiscountSteps.DataSource =
                DiscountStepsManagerController.DiscountStepsManagerControllerInstance().GetAllDiscountSteps();
        }

        private void bCreate_Click(object sender, EventArgs e)
        {
            var cnds = new CreateNewDiscountStep();
            cnds.ShowDialog();
            DgvLoad();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            if (dgvDiscountSteps.CurrentRow != null)
            {
                DiscountStepsManagerController.DiscountStepsManagerControllerInstance()
                    .DeleteDiscountStep((string) dgvDiscountSteps.CurrentRow.Cells[0].Value);
                MessageBox.Show(@"Success");
                DgvLoad();
            }
        }
    }
}
