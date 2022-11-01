namespace FE_inicio
{
    partial class inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inicio));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.CPGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nosotrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VEHICULOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mOTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CLIENTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lISTADECLIENTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cARGARCLIENTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asdToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CPGToolStripMenuItem,
            this.VEHICULOSToolStripMenuItem,
            this.CLIENTESToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.MaximumSize = new System.Drawing.Size(0, 27);
            this.menu.MinimumSize = new System.Drawing.Size(798, 27);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(798, 27);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // CPGToolStripMenuItem
            // 
            this.CPGToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nosotrosToolStripMenuItem});
            this.CPGToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.CPGToolStripMenuItem.Name = "CPGToolStripMenuItem";
            this.CPGToolStripMenuItem.Size = new System.Drawing.Size(49, 23);
            this.CPGToolStripMenuItem.Text = "CPG";
            // 
            // nosotrosToolStripMenuItem
            // 
            this.nosotrosToolStripMenuItem.Name = "nosotrosToolStripMenuItem";
            this.nosotrosToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.nosotrosToolStripMenuItem.Text = "Nosotros";
            // 
            // VEHICULOSToolStripMenuItem
            // 
            this.VEHICULOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mOTOSToolStripMenuItem});
            this.VEHICULOSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.VEHICULOSToolStripMenuItem.Name = "VEHICULOSToolStripMenuItem";
            this.VEHICULOSToolStripMenuItem.Size = new System.Drawing.Size(97, 23);
            this.VEHICULOSToolStripMenuItem.Text = "VEHICULOS";
            // 
            // mOTOSToolStripMenuItem
            // 
            this.mOTOSToolStripMenuItem.Name = "mOTOSToolStripMenuItem";
            this.mOTOSToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.mOTOSToolStripMenuItem.Text = "MOTOS";
            this.mOTOSToolStripMenuItem.Click += new System.EventHandler(this.mOTOSToolStripMenuItem_Click);
            // 
            // CLIENTESToolStripMenuItem
            // 
            this.CLIENTESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lISTADECLIENTESToolStripMenuItem,
            this.cARGARCLIENTEToolStripMenuItem});
            this.CLIENTESToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.CLIENTESToolStripMenuItem.Name = "CLIENTESToolStripMenuItem";
            this.CLIENTESToolStripMenuItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
            this.CLIENTESToolStripMenuItem.Size = new System.Drawing.Size(82, 23);
            this.CLIENTESToolStripMenuItem.Text = "CLIENTES";
            // 
            // lISTADECLIENTESToolStripMenuItem
            // 
            this.lISTADECLIENTESToolStripMenuItem.Name = "lISTADECLIENTESToolStripMenuItem";
            this.lISTADECLIENTESToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.lISTADECLIENTESToolStripMenuItem.Text = "LISTA DE CLIENTES";
            this.lISTADECLIENTESToolStripMenuItem.Click += new System.EventHandler(this.lISTADECLIENTESToolStripMenuItem_Click);
            // 
            // cARGARCLIENTEToolStripMenuItem
            // 
            this.cARGARCLIENTEToolStripMenuItem.Name = "cARGARCLIENTEToolStripMenuItem";
            this.cARGARCLIENTEToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.cARGARCLIENTEToolStripMenuItem.Text = "CARGAR CLIENTE";
            this.cARGARCLIENTEToolStripMenuItem.Click += new System.EventHandler(this.cARGARCLIENTEToolStripMenuItem_Click);
            // 
            // asdToolStripMenuItem4
            // 
            this.asdToolStripMenuItem4.Name = "asdToolStripMenuItem4";
            this.asdToolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.asdToolStripMenuItem4.Text = "Nosotros";
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(798, 450);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu;
            this.Name = "inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem CPGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nosotrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VEHICULOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mOTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CLIENTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asdToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem lISTADECLIENTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cARGARCLIENTEToolStripMenuItem;
    }
}

