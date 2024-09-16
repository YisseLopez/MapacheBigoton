using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mapavhes
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }
        private FrmCitasRegistradas frmCitasRegistradas = new FrmCitasRegistradas();


        private void btnNuevaCita_Click(object sender, EventArgs e)
        {
            FrmAgregarCita agregarCita = new FrmAgregarCita(frmCitasRegistradas);
            agregarCita.Show();
        }

        private void btnCitasRegistradas_Click(object sender, EventArgs e)
        {
            //FrmCitasRegistradas citasRegistradas = new FrmCitasRegistradas();
            frmCitasRegistradas.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
