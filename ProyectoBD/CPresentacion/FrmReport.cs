﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPresentacion
{
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eSTUDIANTEDataSet.TblDatos' table. You can move, or remove it, as needed.
            this.tblDatosTableAdapter.Fill(this.eSTUDIANTEDataSet.TblDatos);
            // TODO: This line of code loads data into the 'eSTUDIANTEDataSet.TblDatos' table. You can move, or remove it, as needed.
            try
            {

                this.reportViewer1.RefreshReport();

            }catch(Exception ex)
            {
                MessageBox.Show("No hay datos", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
            }
        }
    }
}
