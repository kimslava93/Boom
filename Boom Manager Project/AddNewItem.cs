using System;
using System.Drawing;
using System.Windows.Forms;
using Boom_Manager_Project.DataBaseClasses;

namespace Boom_Manager_Project
{
    public partial class AddNewItem : Form
    {
        private Point? _old;
        public AddNewItem()
        {
            InitializeComponent();
        }

        private void bCancell_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bAddItem_Click(object sender, EventArgs e)
        {
            if (AllFieldsAreFulFilled())
            {
                DataBaseClass.Instancedb()
                    .AddNewItem(tbItemName.Text, tbCategoryName.Text, (double) numUpDCost.Value, rtbDescription.Text);
                Close();
            }
            else
            {
                MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(9));
            }
        }

        private bool AllFieldsAreFulFilled()
        {
            if (string.IsNullOrEmpty(tbCategoryName.Text) || string.IsNullOrEmpty(rtbDescription.Text) ||
                numUpDCost.Value > 5000 && numUpDCost.Value < 1 || string.IsNullOrEmpty(tbCategoryName.Text))
            {
                return false;
            }
            return true;
        }

        private void AddNewItem_MouseDown(object sender, MouseEventArgs e)
        {
            _old = Cursor.Position;
        }

        private void AddNewItem_MouseMove(object sender, MouseEventArgs e)
        {
            if (_old.HasValue && _old.Value != Cursor.Position)
            {
                Left += Cursor.Position.X - _old.Value.X;
                Top += Cursor.Position.Y - _old.Value.Y;
                _old = Cursor.Position;
            }
        }

        private void AddNewItem_MouseUp(object sender, MouseEventArgs e)
        {
            _old = null;
        }
    }
}
