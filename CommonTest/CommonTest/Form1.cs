﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coded by IPHONG993");
        }
        private void btnLeft_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This's a button Left!");
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This's a button Right!");

        }
    }
}
