namespace FE_inicio
{
    partial class ListaMotos
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
            this.dtgv_motos = new System.Windows.Forms.DataGridView();
            this.btn_agmoto = new System.Windows.Forms.Button();
            this.tb_marca = new System.Windows.Forms.TextBox();
            this.tb_modelo = new System.Windows.Forms.TextBox();
            this.tb_cil = new System.Windows.Forms.TextBox();
            this.tb_estilo = new System.Windows.Forms.TextBox();
            this.tb_precio = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_motos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_motos
            // 
            this.dtgv_motos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_motos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_motos.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.dtgv_motos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_motos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgv_motos.Location = new System.Drawing.Point(0, 60);
            this.dtgv_motos.Name = "dtgv_motos";
            this.dtgv_motos.Size = new System.Drawing.Size(799, 390);
            this.dtgv_motos.TabIndex = 0;
            this.dtgv_motos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_motos_CellContentClick);
            // 
            // btn_agmoto
            // 
            this.btn_agmoto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_agmoto.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_agmoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agmoto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_agmoto.Location = new System.Drawing.Point(689, 23);
            this.btn_agmoto.MaximumSize = new System.Drawing.Size(134, 40);
            this.btn_agmoto.Name = "btn_agmoto";
            this.btn_agmoto.Size = new System.Drawing.Size(110, 31);
            this.btn_agmoto.TabIndex = 6;
            this.btn_agmoto.Text = "AGREGAR";
            this.btn_agmoto.UseVisualStyleBackColor = false;
            this.btn_agmoto.Click += new System.EventHandler(this.btn_agmoto_Click);
            // 
            // tb_marca
            // 
            this.tb_marca.Location = new System.Drawing.Point(21, 34);
            this.tb_marca.Name = "tb_marca";
            this.tb_marca.Size = new System.Drawing.Size(100, 20);
            this.tb_marca.TabIndex = 1;
            // 
            // tb_modelo
            // 
            this.tb_modelo.Location = new System.Drawing.Point(140, 34);
            this.tb_modelo.Name = "tb_modelo";
            this.tb_modelo.Size = new System.Drawing.Size(100, 20);
            this.tb_modelo.TabIndex = 2;
            // 
            // tb_cil
            // 
            this.tb_cil.Location = new System.Drawing.Point(262, 34);
            this.tb_cil.Name = "tb_cil";
            this.tb_cil.Size = new System.Drawing.Size(100, 20);
            this.tb_cil.TabIndex = 3;
            // 
            // tb_estilo
            // 
            this.tb_estilo.Location = new System.Drawing.Point(381, 34);
            this.tb_estilo.Name = "tb_estilo";
            this.tb_estilo.Size = new System.Drawing.Size(100, 20);
            this.tb_estilo.TabIndex = 4;
            // 
            // tb_precio
            // 
            this.tb_precio.Location = new System.Drawing.Point(502, 34);
            this.tb_precio.Name = "tb_precio";
            this.tb_precio.Size = new System.Drawing.Size(100, 20);
            this.tb_precio.TabIndex = 5;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(17, 11);
            this.lbl_nombre.MaximumSize = new System.Drawing.Size(108, 20);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(66, 17);
            this.lbl_nombre.TabIndex = 7;
            this.lbl_nombre.Text = "MARCA:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 11);
            this.label1.MaximumSize = new System.Drawing.Size(108, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "MODELO:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 11);
            this.label2.MaximumSize = new System.Drawing.Size(108, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "CILINDRADA:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(377, 11);
            this.label3.MaximumSize = new System.Drawing.Size(108, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "ESTILO:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(498, 11);
            this.label4.MaximumSize = new System.Drawing.Size(108, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "PRECIO:";
            // 
            // ListaMotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.tb_precio);
            this.Controls.Add(this.tb_estilo);
            this.Controls.Add(this.tb_cil);
            this.Controls.Add(this.tb_modelo);
            this.Controls.Add(this.tb_marca);
            this.Controls.Add(this.btn_agmoto);
            this.Controls.Add(this.dtgv_motos);
            this.Name = "ListaMotos";
            this.Text = "Motos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Motos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_motos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_motos;
        private System.Windows.Forms.Button btn_agmoto;
        private System.Windows.Forms.TextBox tb_marca;
        private System.Windows.Forms.TextBox tb_modelo;
        private System.Windows.Forms.TextBox tb_cil;
        private System.Windows.Forms.TextBox tb_estilo;
        private System.Windows.Forms.TextBox tb_precio;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}