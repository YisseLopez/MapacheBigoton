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
            btnRegresarInicio = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(211, 24);
            label7.Name = "label7";
            label7.Size = new Size(511, 81);
            label7.TabIndex = 9;
            label7.Text = "Citas Registradas";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(48, 24);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(48, 179);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(815, 257);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnRegresarInicio
            // 
            btnRegresarInicio.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegresarInicio.Location = new Point(603, 472);
            btnRegresarInicio.Margin = new Padding(3, 4, 3, 4);
            btnRegresarInicio.Name = "btnRegresarInicio";
            btnRegresarInicio.Size = new Size(209, 80);
            btnRegresarInicio.TabIndex = 16;
            btnRegresarInicio.Text = "Regresar al inicio";
            btnRegresarInicio.UseVisualStyleBackColor = true;
            btnRegresarInicio.Click += btnRegresarInicio_Click;
            // 
            // FrmCitasRegistradas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnRegresarInicio);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button btnRegresarInicio;
    }
}