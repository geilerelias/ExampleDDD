﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Console
{
    public partial class frmIncidencia : Form
    {
        public frmIncidencia()
        {
            InitializeComponent();
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {
            Incidencia incidencia = new Incidencia();
            incidencia.nombre = this.txtNombre.Text;
            incidencia.descripcion = this.txtDescripcion.Text;

        }
    }
}
