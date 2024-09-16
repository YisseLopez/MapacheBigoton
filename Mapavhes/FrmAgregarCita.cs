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
    public partial class FrmAgregarCita : Form
    {
        public class Cita
        {
            public string NombreCliente { get; set; }
            public string Telefono { get; set; }
            public string ServicioSolicitado { get; set; }
            public decimal Costo { get; set; }
            public DateTime Fecha { get; set; }
            public string Hora { get; set; }
        }

        private FrmCitasRegistradas frmCitasRegistradas;
       
        public FrmAgregarCita(FrmCitasRegistradas citasRegistradas)
        {
            InitializeComponent();
            this.frmCitasRegistradas = citasRegistradas;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            Cita nuevaCita = new Cita
            {
                NombreCliente = txtNombreCliente.Text,
                Telefono = txtTelefono.Text,
                ServicioSolicitado = txtServicioSolicitado.Text,
                Costo = Convert.ToDecimal(txtCostoServicio.Text),
                Fecha = dtimeDiaAgendado.Value,
                Hora = txtHoraCita.Text,
            };

            frmCitasRegistradas.AgregarCita(nuevaCita);

            txtNombreCliente.Clear();
            txtTelefono.Clear();
            txtServicioSolicitado.Clear();
            txtCostoServicio .Clear();
            txtHoraCita.Clear();

        }


    }
}
