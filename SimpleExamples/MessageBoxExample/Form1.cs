﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBoxExample
{
    public partial class Form1 : Form
    {
        MessageBoxButtons bType;
        MessageBoxIcon iType;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Text = "Ok";
            radioButton2.Text = "OKCancel";
            radioButton3.Text = "RetryCancel";
            radioButton4.Text = "YesNo";
            radioButton5.Text = "YesNoCancel";
            radioButton6.Text = "AbortRetryIgnore";
            radioButton7.Text = "Asterisk";
            radioButton8.Text = "Error";
            radioButton9.Text = "Exclamation";
            radioButton10.Text = "Hand";
            radioButton11.Text = "Information";
            radioButton12.Text = "None";
            radioButton13.Text = "Question";
            radioButton14.Text = "OkStop";
            radioButton15.Text = "Warning";
            radioButton1.Checked = true;
            radioButton7.Checked = true;
        }

        void bType_CheckedChanged(object sender, EventArgs e)
        {
            switch ((sender as Control).Name)
            {
                case "Rdo1":
                    bType = MessageBoxButtons.OK;
                    break;
                case "Rdo2":
                    bType = MessageBoxButtons.OKCancel;
                    break;
                case "Rdo3":
                    bType = MessageBoxButtons.RetryCancel;
                    break;
                case "Rdo4":
                    bType = MessageBoxButtons.YesNo;
                    break;
                case "Rdo5":
                    bType = MessageBoxButtons.YesNoCancel;
                    break;
                case "Rdo6":
                    bType = MessageBoxButtons.AbortRetryIgnore;
                    break;
            }
        }

        void iType_CheckedChanged(object sender, EventArgs e)
        {
            switch ((sender as Control).Name)
            {
                case "Rdo7":
                    iType = MessageBoxIcon.Asterisk;
                    break;
                case "Rdo8":
                    iType = MessageBoxIcon.Error;
                    break;
                case "Rdo9":
                    iType = MessageBoxIcon.Exclamation;
                    break;
                case "Rdo10":
                    iType = MessageBoxIcon.Hand;
                    break;
                case "Rdo11":
                    iType = MessageBoxIcon.Information;
                    break;
                case "Rdo12":
                    iType = MessageBoxIcon.None;
                    break;
                case "Rdo13":
                    iType = MessageBoxIcon.Question;
                    break;
                case "Rdo14":
                    iType = MessageBoxIcon.Stop;
                    break;
                case "Rdo15":
                    iType = MessageBoxIcon.Warning;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult state = MessageBox.Show("Message Box", "Info", bType, iType);
            switch (state)
            {
                case DialogResult.OK:
                    label1.Text = "OK";
                    break;
                case DialogResult.Cancel:
                    label1.Text = "Cancel";
                    break;
                case DialogResult.Abort:
                    label1.Text = "Abort";
                    break;
                case DialogResult.Retry:
                    label1.Text = "Retry";
                    break;
                case DialogResult.Ignore:
                    label1.Text = "Ignore";
                    break;
                case DialogResult.Yes:
                    label1.Text = "Yes";
                    break;
                case DialogResult.No:
                    label1.Text = "No";
                    break;
            }
        }
    }
}
