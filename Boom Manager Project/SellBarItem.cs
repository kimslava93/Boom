using System;
using System.Globalization;
using System.Windows.Forms;
using Boom_Manager_Project.Controllers;
using Boom_Manager_Project.DataBaseClasses;

namespace Boom_Manager_Project
{
    public partial class SellBarItem : Form
    {
        public SellBarItem()
        {
            InitializeComponent();
        }

        private void SellBarItem_Load(object sender, EventArgs e)
        {
            SetDefaultValues();
            CalculatePrice();
        }
        private void LoadDgv()
        {
            dgvAllItems.DataSource = DataBaseClass.Instancedb().GetListOfItemsWithPrice();
            dgvAllItems.Invalidate();
        }
        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bSell_Click(object sender, EventArgs e)
        {
            if (dgvAllItems.CurrentRow != null)
            {
                SellBarItemController.SellBarItemControllerInstance()
                    .SellItem((string) dgvAllItems.CurrentRow.Cells[1].Value, (int) numUpDNumber.Value,
                        double.Parse(tbSum.Text.ToString(CultureInfo.InvariantCulture)));
                MessageBox.Show(@"Товар " + dgvAllItems.CurrentRow.Cells[1].Value + @" в количестве " + numUpDNumber.Value + @"шт. был успешно занесен в список проданных товаров!");
                SetDefaultValues();

            }
            else
            {
                MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(47),
                    ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetCaption(2), MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void numUpDNumber_ValueChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }

        private void dgvAllItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CalculatePrice();
        }

        private void SetDefaultValues()
        {
            LoadDgv();
            numUpDNumber.Value = 1;
            CalculatePrice();
        }

        private void CalculatePrice()
        {
            if (dgvAllItems.CurrentRow != null)
            {
                tbSum.Text =
                    SellBarItemController.SellBarItemControllerInstance()
                        .GetSumOfItems((string)dgvAllItems.CurrentRow.Cells[1].Value, (int)numUpDNumber.Value).ToString(CultureInfo.InvariantCulture);
            }
            else
            {
                MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(47));
            }
        }

        private void dgvAllItems_KeyDown(object sender, KeyEventArgs e)
        {
            CalculatePrice();
        }
    }
}
