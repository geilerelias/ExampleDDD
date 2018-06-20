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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField2_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel4_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField3_Click(object sender, EventArgs e)
        {

        }

        private void Maquinaria_Load(object sender, EventArgs e)
        {

        }

       

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            frmPrincipal frm = new frmPrincipal();
            frm.ShowDialog();
        }

        private void txtPlaca_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {
            Maquinaria maquina = new Maquinaria();
            maquina.Placa = this.txtPlaca.Text;
            maquina.Marca = this.txtMarca.Text;
            maquina.Linea = this.txtLinea.Text;
            maquina.Modelo = this.txtModelo.Text;
            maquina.Color = this.txtColor.Text;
            maquina.FechaAdquisicion = this.txtFecha.Text;
            maquina.Chasi = this.txtChasis.Text;
            maquina.Motor = this.txtMotor.Text;

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            frmComponente frm = new frmComponente();
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
    }
}
