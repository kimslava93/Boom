using System;
using System.Drawing;
using System.Windows.Forms;

namespace Boom_Manager_Project
{
    public partial class CreateNewDiscountStep : Form
    {
        private Point? _old;
        public CreateNewDiscountStep()
        {
            InitializeComponent();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bCreate_Click(object sender, EventArgs e)
        {
            CreateNewDiscountStepController.CreateNewDiscountControllerInstance()
                .CreateNewDiscountStep(tbName.Text, tbRequirements.Text, (double) numUpdDiscount.Value);
            Close();
        }

        private void CreateNewDiscountStep_MouseDown(object sender, MouseEventArgs e)
        {
            _old = Cursor.Position;
        }

        private void CreateNewDiscountStep_MouseMove(object sender, MouseEventArgs e)
        {
            if (_old.HasValue && _old.Value != Cursor.Position)
            {
                Left += Cursor.Position.X - _old.Value.X;
                Top += Cursor.Position.Y - _old.Value.Y;
                _old = Cursor.Position;
            }
        }

        private void CreateNewDiscountStep_MouseUp(object sender, MouseEventArgs e)
        {
            _old = null;
        }


    }
}
