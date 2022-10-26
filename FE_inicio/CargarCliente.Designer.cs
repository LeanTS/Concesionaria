namespace FE_inicio
{
    partial class CargarCliente
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
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_apellidos = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_moto = new System.Windows.Forms.Label();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.tb_apellidos = new System.Windows.Forms.TextBox();
            this.tb_moto = new System.Windows.Forms.TextBox();
            this.tb_fecha = new System.Windows.Forms.TextBox();
            this.tb_telefono = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.dtgv_cargar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_estado = new System.Windows.Forms.TextBox();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Moto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_cargar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(58, 9);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(85, 20);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "NOMBRE";
            // 
            // lbl_apellidos
            // 
            this.lbl_apellidos.AutoSize = true;
            this.lbl_apellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellidos.Location = new System.Drawing.Point(363, 9);
            this.lbl_apellidos.Name = "lbl_apellidos";
            this.lbl_apellidos.Size = new System.Drawing.Size(108, 20);
            this.lbl_apellidos.TabIndex = 1;
            this.lbl_apellidos.Text = "APELLIDOS";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.Location = new System.Drawing.Point(402, 78);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(69, 20);
            this.lbl_fecha.TabIndex = 2;
            this.lbl_fecha.Text = "FECHA";
            // 
            // lbl_moto
            // 
            this.lbl_moto.AutoSize = true;
            this.lbl_moto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_moto.Location = new System.Drawing.Point(84, 78);
            this.lbl_moto.Name = "lbl_moto";
            this.lbl_moto.Size = new System.Drawing.Size(59, 20);
            this.lbl_moto.TabIndex = 2;
            this.lbl_moto.Text = "MOTO";
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estado.Location = new System.Drawing.Point(390, 150);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(81, 20);
            this.lbl_estado.TabIndex = 3;
            this.lbl_estado.Text = "ESTADO";
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(149, 9);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(208, 20);
            this.tb_nombre.TabIndex = 4;
            // 
            // tb_apellidos
            // 
            this.tb_apellidos.Location = new System.Drawing.Point(477, 11);
            this.tb_apellidos.Name = "tb_apellidos";
            this.tb_apellidos.Size = new System.Drawing.Size(208, 20);
            this.tb_apellidos.TabIndex = 5;
            // 
            // tb_moto
            // 
            this.tb_moto.Location = new System.Drawing.Point(149, 80);
            this.tb_moto.Name = "tb_moto";
            this.tb_moto.Size = new System.Drawing.Size(208, 20);
            this.tb_moto.TabIndex = 6;
            // 
            // tb_fecha
            // 
            this.tb_fecha.Location = new System.Drawing.Point(477, 78);
            this.tb_fecha.Name = "tb_fecha";
            this.tb_fecha.Size = new System.Drawing.Size(208, 20);
            this.tb_fecha.TabIndex = 7;
            this.tb_fecha.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // tb_telefono
            // 
            this.tb_telefono.Location = new System.Drawing.Point(149, 150);
            this.tb_telefono.Name = "tb_telefono";
            this.tb_telefono.Size = new System.Drawing.Size(208, 20);
            this.tb_telefono.TabIndex = 8;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Location = new System.Drawing.Point(317, 189);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(134, 40);
            this.btn_agregar.TabIndex = 10;
            this.btn_agregar.Text = "AÑADIR";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtgv_cargar
            // 
            this.dtgv_cargar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.Nombre,
            this.Apellido,
            this.Telefono,
            this.Fecha,
            this.Moto,
            this.Estado});
            this.dtgv_cargar.Location = new System.Drawing.Point(12, 251);
            this.dtgv_cargar.Name = "dtgv_cargar";
            this.dtgv_cargar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_cargar.Size = new System.Drawing.Size(776, 150);
            this.dtgv_cargar.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "TELEFONO";
            // 
            // tb_estado
            // 
            this.tb_estado.Location = new System.Drawing.Point(477, 150);
            this.tb_estado.Name = "tb_estado";
            this.tb_estado.Size = new System.Drawing.Size(208, 20);
            this.tb_estado.TabIndex = 9;
            // 
            // btn_borrar
            // 
            this.btn_borrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_borrar.Location = new System.Drawing.Point(488, 189);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(134, 40);
            this.btn_borrar.TabIndex = 13;
            this.btn_borrar.Text = "BORRAR";
            this.btn_borrar.UseVisualStyleBackColor = true;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // Num
            // 
            this.Num.HeaderText = "Num";
            this.Num.Name = "Num";
            this.Num.Visible = false;
            this.Num.Width = 105;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Visible = false;
            this.Nombre.Width = 104;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.Visible = false;
            this.Apellido.Width = 105;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.Visible = false;
            this.Telefono.Width = 105;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.Visible = false;
            this.Fecha.Width = 105;
            // 
            // Moto
            // 
            this.Moto.HeaderText = "Moto";
            this.Moto.Name = "Moto";
            this.Moto.Visible = false;
            this.Moto.Width = 104;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Visible = false;
            this.Estado.Width = 105;
            // 
            // CargarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.tb_estado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgv_cargar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.tb_telefono);
            this.Controls.Add(this.tb_fecha);
            this.Controls.Add(this.tb_moto);
            this.Controls.Add(this.tb_apellidos);
            this.Controls.Add(this.tb_nombre);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.lbl_moto);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.lbl_apellidos);
            this.Controls.Add(this.lbl_nombre);
            this.Name = "CargarCliente";
            this.Text = "CargarCliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CargarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_cargar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_apellidos;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_moto;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.TextBox tb_apellidos;
        private System.Windows.Forms.TextBox tb_moto;
        private System.Windows.Forms.TextBox tb_fecha;
        private System.Windows.Forms.TextBox tb_telefono;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.DataGridView dtgv_cargar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_estado;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Moto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}