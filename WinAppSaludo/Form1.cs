﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppSaludo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSaludar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola " + TxtName.Text + " " + TxtLastName.Text + ", tienes " + TxtEdad.Text + "\n Vives en" + TxtAdress.Text);
        }
    }
}
