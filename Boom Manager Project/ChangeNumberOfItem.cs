using System;
using System.Drawing;
using System.Windows.Forms;
using Boom_Manager_Project.DataBaseClasses;

namespace Boom_Manager_Project
{
    public partial class ChangeNumberOfItem : Form
    {
        private Point? _old;
        private readonly string _item;
        public ChangeNumberOfItem(string item)
        {
            _item = item;
            InitializeComponent();
        }

        private void bApply_Click(object sender, EventArgs e)
        {
            if (numUpDNumber.Value <= numUpDNumber.Maximum && numUpDNumber.Value >= numUpDNumber.Minimum)
            {
                DataBaseClass.Instancedb().ChangeItemNumber(_item, (int)numUpDNumber.Value);
                Close();
            }
            else
            {
                MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(9));
            }
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChangeNumberOfItem_MouseDown(object sender, MouseEventArgs e)
        {
            _old = Cursor.Position;
        }

        private void ChangeNumberOfItem_MouseLeave(object sender, EventArgs e)
        {

        }

        private void ChangeNumberOfItem_MouseMove(object sender, MouseEventArgs e)
        {
            if (_old.HasValue && _old.Value != Cursor.Position)
            {
                Left += Cursor.Position.X - _old.Value.X;
                Top += Cursor.Position.Y - _old.Value.Y;
                _old = Cursor.Position;
            }
        }

        private void ChangeNumberOfItem_MouseUp(object sender, MouseEventArgs e)
        {
            _old = null;
        }

        private void ChangeNumberOfItem_Load(object sender, EventArgs e)
        {

        }
    }
}
