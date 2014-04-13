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
    public partial class AddDiscountCardToSession : Form
    {
        public string Result { get; set; }
        public string Client { get; set; }
        public double MoneyLeft { get; set; }
        public AddDiscountCardToSession()
        {
            InitializeComponent();
        }

        private void AddDiscountCardToSession_Load(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Client = "0";
            MoneyLeft = 0.0;
            Close();
        }
    }
}
