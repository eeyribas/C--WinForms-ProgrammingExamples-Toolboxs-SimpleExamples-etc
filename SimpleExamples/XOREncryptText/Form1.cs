﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XOREncryptText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte password;
            
            try
            {
                password = byte.Parse(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Enter a number between 0 and 255 as the key : ");
                return;
            }

            string text = textBox1.Text;
            string encryptText = "";
            for (int i = 0; i <= text.Length - 1; i++)
            {
                byte c = (byte)(text[i] ^ password);
                encryptText += (char)(c);
            }
            textBox3.Text = encryptText;
        }
    }
}
