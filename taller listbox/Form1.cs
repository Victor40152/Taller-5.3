﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taller_listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            int cant;
            cant = Convert.ToInt16(textBox1.Text);
            int i, f1 = 0, f2 = 1, f3 = 0;
            listBox1.Items.Add(f1);
            listBox1.Items.Add(f2);
            for (i=3; i<=cant;i++)
            {
                f3 = f1 + f2;
                listBox1.Items.Add(f3);
                f1 = f2;
                f2 = f3;

            }
            textBox1.Text = listBox1.Items.Count.ToString();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

        }
    }
}
