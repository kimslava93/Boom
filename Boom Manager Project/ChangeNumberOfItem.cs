using System;
using System.Drawing;
using System.Windows.Forms;
using Boom_Manager_Project.DataBaseClasses;

namespace Boom_Manager_Project
{
    public partial class ChangeNumberOfItem : Form
    {
        private readonly int _numberwas;
        private readonly string _itemId;
        private Point? _old;
        public ChangeNumberOfItem(int numberWas, string itemId)
        {
            InitializeComponent();
            _itemId = itemId;
            _numberwas = numberWas;
        }

        private void ChangeNumberOfItem_MouseDown(object sender, MouseEventArgs e)
        {
            _old = Cursor.Position;
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

        private void ChangeNumberOfItem_Load(object sender, EventArgs e)
        {
            if (_numberwas < 0)
                numUpDNumber.Value = 0;
            else
                numUpDNumber.Value = _numberwas;
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bApply_Click(object sender, EventArgs e)
        {
            if (numUpDNumber.Value <= numUpDNumber.Maximum && numUpDNumber.Value >= numUpDNumber.Minimum)
            {
                DataBaseClass.Instancedb().ChangeItemNumber(_itemId, (int)numUpDNumber.Value);
                Close();
            }
            else
            {
                MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(9));
            }
        }

        private void ChangeNumberOfItem_MouseUp(object sender, MouseEventArgs e)
        {
            _old = null;
        }
    }
}
