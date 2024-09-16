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
    public partial class FrmCitasRegistradas : Form
    {
        public FrmCitasRegistradas()
        {
            InitializeComponent();

            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "Nombre del Cliente";
            dataGridView1.Columns[1].Name = "Teléfono";
            dataGridView1.Columns[2].Name = "Servicio Solicitado";
            dataGridView1.Columns[3].Name = "Costo del servicio";
            dataGridView1.Columns[4].Name = "Fecha";
            dataGridView1.Columns[5].Name = "Hora del servicio";
        }

        public void AgregarCita(FrmAgregarCita.Cita cita)
        {
            string[] row = {
                cita.NombreCliente,
                cita.Telefono,
                cita.ServicioSolicitado,
                cita.Costo.ToString("C"),
                cita.Fecha.ToShortDateString(),
                cita.Hora
            };
            dataGridView1.Rows.Add(row);
        }
        private void btnRegresarInicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

