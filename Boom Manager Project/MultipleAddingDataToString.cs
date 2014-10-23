using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Boom_Manager_Project
{
    public partial class MultipleAddingDataToString : Form
    {
        private readonly List<string> _inputList;
        

        public string Result { get; set; }

        public MultipleAddingDataToString(List<string> inputData)
        {
            _inputList = inputData;
            InitializeComponent();
        }

        private void MultipleAddingDataToString_Load(object sender, EventArgs e)
        {
//            lbAllAvailableItems.DataSource = _inputList;
            foreach (var item in _inputList)
            {
                lbAllAvailableItems.Items.Add(item);
            }
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bAddSelectedItem_Click(object sender, EventArgs e)
        {
            if (lbAllAvailableItems.SelectedItem != null)
            {
                lbResultItems.Items.Add(lbAllAvailableItems.SelectedItem);
                lbAllAvailableItems.Items.Remove(lbAllAvailableItems.SelectedItem);
            }
        }

        private void bDeleteSelectedItem_Click(object sender, EventArgs e)
        {
            if (lbResultItems.SelectedItem != null)
            {
                lbAllAvailableItems.Items.Add(lbResultItems.SelectedItem);
                
                lbResultItems.Items.RemoveAt(lbResultItems.SelectedIndex);
            }
        }

        private void bAddAllItems_Click(object sender, EventArgs e)
        {
            foreach (var item in lbAllAvailableItems.Items)
            {
                lbResultItems.Items.Add(item);
                
            }
            foreach (var item in lbResultItems.Items)
            {
                lbAllAvailableItems.Items.Remove(item);
            }

        }

        private void bDeletAll_Click(object sender, EventArgs e)
        {
            foreach (var item in lbResultItems.Items)
            {
                lbAllAvailableItems.Items.Add(item);
            }
            foreach (var item in lbAllAvailableItems.Items)
            {
                lbResultItems.Items.Remove(item);
            }
        }

        private void bFinish_Click(object sender, EventArgs e)
        {
            if (lbResultItems.Items.Count > 0)
            {
                Result = lbResultItems.Items[0].ToString();
                for(int i = 1; i < lbResultItems.Items.Count; i++)
                {
                    var item = lbResultItems.Items[i];
                    Result += ";" + item;
                }
            }
            Close();
        }
    }
}
