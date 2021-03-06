﻿using System;
using System.Globalization;
using System.Windows.Forms;
using Boom_Manager_Project.Controllers;
using Boom_Manager_Project.DataBaseClasses;

namespace Boom_Manager_Project
{
    public partial class ManagerCardReader : Form
    {
        private bool _passed;
        private string _manager;
        private int _ticks = 3;
        public bool Passed
        {
            get { return _passed; }
        }
        public string ManagerLoggined
        {
            get { return _manager; }
        }
        public ManagerCardReader()
        {
            InitializeComponent();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbDiscountCards_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (!string.IsNullOrWhiteSpace(tbDiscountCards.Text))
                {
                    var c = ManagerCardReaderController.ManagerCardReaderControllerInstance()
                             .GetManagerById(tbDiscountCards.Text);
                    if (c != null)
                    {
                        _passed = true;
                        _manager = c.person_id;
                    }
                    else
                    {
                        MessageBox.Show(ErrorsAndWarningsMessages.ErrorsAndWarningsInstance().GetError(32));
                        _passed = false;
                    }
                    Close();
                }
            }
        }

        private void ManagerCardReader_Load(object sender, EventArgs e)
        {
            timer.Start();

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            _ticks--;
            if (_ticks <= 0)
            {
                Close();
            }
            else
                lTime.Text = _ticks.ToString(CultureInfo.InvariantCulture);
        }
    }
}
