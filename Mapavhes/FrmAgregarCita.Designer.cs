namespace Mapavhes
{
    partial class FrmAgregarCita
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarCita));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNombreCliente = new TextBox();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            txtTelefono = new TextBox();
            txtServicioSolicitado = new TextBox();
            txtCostoServicio = new TextBox();
            dtimeDiaAgendado = new DateTimePicker();
            txtHoraCita = new TextBox();
            btnAgendar = new Button();
            btnCancelar = new Button();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 200);
            label1.Name = "label1";
            label1.Size = new Size(140, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre del cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(145, 264);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Telefóno:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 315);
            label3.Name = "label3";
            label3.Size = new Size(133, 20);
            label3.TabIndex = 2;
            label3.Text = "Servicio solicitado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(90, 375);
            label4.Name = "label4";
            label4.Size = new Size(129, 20);
            label4.TabIndex = 3;
            label4.Text = "Costo del servicio:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(496, 193);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 4;
            label5.Text = "Día agendado:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(493, 253);
            label6.Name = "label6";
            label6.Size = new Size(110, 20);
            label6.TabIndex = 5;
            label6.Text = "Hora de la cita:";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(215, 189);
            txtNombreCliente.Margin = new Padding(3, 4, 3, 4);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(196, 27);
            txtNombreCliente.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(151, 12);
            label7.Name = "label7";
            label7.Size = new Size(585, 81);
            label7.TabIndex = 8;
            label7.Text = "Agregar Nueva Cita";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(215, 253);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(196, 27);
            txtTelefono.TabIndex = 9;
            // 
            // txtServicioSolicitado
            // 
            txtServicioSolicitado.Location = new Point(215, 311);
            txtServicioSolicitado.Margin = new Padding(3, 4, 3, 4);
            txtServicioSolicitado.Name = "txtServicioSolicitado";
            txtServicioSolicitado.Size = new Size(196, 27);
            txtServicioSolicitado.TabIndex = 10;
            // 
            // txtCostoServicio
            // 
            txtCostoServicio.Location = new Point(215, 371);
            txtCostoServicio.Margin = new Padding(3, 4, 3, 4);
            txtCostoServicio.Name = "txtCostoServicio";
            txtCostoServicio.Size = new Size(107, 27);
            txtCostoServicio.TabIndex = 11;
            // 
            // dtimeDiaAgendado
            // 
            dtimeDiaAgendado.Location = new Point(598, 185);
            dtimeDiaAgendado.Margin = new Padding(3, 4, 3, 4);
            dtimeDiaAgendado.Name = "dtimeDiaAgendado";
            dtimeDiaAgendado.Size = new Size(259, 27);
            dtimeDiaAgendado.TabIndex = 12;
            // 
            // txtHoraCita
            // 
            txtHoraCita.Location = new Point(598, 243);
            txtHoraCita.Margin = new Padding(3, 4, 3, 4);
            txtHoraCita.Name = "txtHoraCita";
            txtHoraCita.Size = new Size(107, 27);
            txtHoraCita.TabIndex = 13;
            txtHoraCita.TextChanged += txtHoraCita_TextChanged;
            // 
            // btnAgendar
            // 
            btnAgendar.Location = new Point(299, 452);
            btnAgendar.Margin = new Padding(3, 4, 3, 4);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(194, 77);
            btnAgendar.TabIndex = 14;
            btnAgendar.Text = "Agendar";
            btnAgendar.UseVisualStyleBackColor = true;
            btnAgendar.Click += btnAgendar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(569, 452);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(194, 77);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(428, 315);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(196, 28);
            comboBox1.TabIndex = 16;
            // 
            // FrmAgregarCita
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(comboBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgendar);
            Controls.Add(txtHoraCita);
            Controls.Add(dtimeDiaAgendado);
            Controls.Add(txtCostoServicio);
            Controls.Add(txtServicioSolicitado);
            Controls.Add(txtTelefono);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(txtNombreCliente);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmAgregarCita";
            Text = "FrmAgregarCita";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNombreCliente;
        private PictureBox pictureBox1;
        private Label label7;
        private TextBox txtTelefono;
        private TextBox txtServicioSolicitado;
        private TextBox txtCostoServicio;
        private DateTimePicker dtimeDiaAgendado;
        private TextBox txtHoraCita;
        private Button btnAgendar;
        private Button btnCancelar;
        private ComboBox comboBox1;
    }
}