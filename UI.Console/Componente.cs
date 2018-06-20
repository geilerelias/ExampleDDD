using Domain.Entities;
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
    public partial class frmComponente : Form
    {
        public frmComponente()
        {
            InitializeComponent();
        }

        private void materialSingleLineTextField3_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel4_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField2_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
           frmComponente frm= new frmComponente();
            frm.ShowDialog();
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            frmPrincipal frm = new frmPrincipal();
            frm.ShowDialog();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            frmIncidencia frm = new frmIncidencia();
            frm.ShowDialog();
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            frmTarea frm = new frmTarea();
            frm.ShowDialog();
        }

        private void materialLabel3_Click_1(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField3_Click_1(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField2_Click_1(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {
            Componente componente = new Componente();
            componente.nombre = this.txtNombre.Text;
            componente.referencia = this.txtReferencia.Text;
            componente.descripcion = this.txtDescripcion.Text;
            
        }
    }
    }

