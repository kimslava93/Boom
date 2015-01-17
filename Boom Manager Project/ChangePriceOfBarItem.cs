using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Boom_Manager_Project.DataBaseClasses;

namespace Boom_Manager_Project
{
    public partial class ChangePriceOfBarItem : Form
    {
        private Point? _old;
        private readonly string _item;
        public ChangePriceOfBarItem(string item)
        {
            _item = item;
            InitializeComponent();
        }

        private void lNumber_Click(object sender, EventArgs e)
        {

        }

        private void ChangePriceOfBarItem_Load(object sender, EventArgs e)
        {

        }

        private void bApply_Click(object sender, EventArgs e)
        {
            if (numUpDPrice.Value <= numUpDPrice.Maximum && numUpDPrice.Value >= numUpDPrice.Minimum)
            {
                DataBaseClass.Instancedb().ChangeBarItemPrice(_item, (int)numUpDPrice.Value);
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

        private void ChangePriceOfBarItem_MouseDown(object sender, MouseEventArgs e)
        {
            _old = Cursor.Position;
        }

        private void ChangePriceOfBarItem_MouseMove(object sender, MouseEventArgs e)
        {
            if (_old.HasValue && _old.Value != Cursor.Position)
            {
                Left += Cursor.Position.X - _old.Value.X;
                Top += Cursor.Position.Y - _old.Value.Y;
                _old = Cursor.Position;
            }
        }

        private void ChangePriceOfBarItem_MouseUp(object sender, MouseEventArgs e)
        {
            _old = null;
        }
    }
}
