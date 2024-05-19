﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpeningMultipleForms
{
    public partial class Form1 : Form
    {
        private Form2 form2 = new Form2();
        private Form3 form3 = new Form3();
        private Form4 form4 = new Form4();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form4.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
