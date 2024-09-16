namespace Mapavhes
{
    partial class FrmCitasRegistradas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCitasRegistradas));
            label7 = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Telefóno = new DataGridViewTextBoxColumn();
            Servicio = new DataGridViewTextBoxColumn();
            btnRegresarInicio = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(185, 18);
            label7.Name = "label7";
            label7.Size = new Size(413, 65);
            label7.TabIndex = 9;
            label7.Text = "Citas Registradas";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(42, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nombre, Telefóno, Servicio });
            dataGridView1.Location = new Point(42, 134);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(713, 193);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Column1";
            Nombre.Name = "Nombre";
            // 
            // Telefóno
            // 
            Telefóno.HeaderText = "Column1";
            Telefóno.Name = "Telefóno";
            // 
            // Servicio
            // 
            Servicio.HeaderText = "Column1";
            Servicio.Name = "Servicio";
            // 
            // btnRegresarInicio
            // 
            btnRegresarInicio.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegresarInicio.Location = new Point(528, 354);
            btnRegresarInicio.Name = "btnRegresarInicio";
            btnRegresarInicio.Size = new Size(183, 60);
            btnRegresarInicio.TabIndex = 16;
            btnRegresarInicio.Text = "Regresar al inicio";
            btnRegresarInicio.UseVisualStyleBackColor = true;
            btnRegresarInicio.Click += btnRegresarInicio_Click;
            // 
            // FrmCitasRegistradas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegresarInicio);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Name = "FrmCitasRegistradas";
            Text = "FrmCitasRegistradas";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Telefóno;
        private DataGridViewTextBoxColumn Servicio;
        private Button btnRegresarInicio;
    }
}