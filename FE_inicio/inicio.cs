using BE_Concescionaria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FE_inicio
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cARGARCLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarCliente newcargarcliente = new CargarCliente();
            
            newcargarcliente.MdiParent = this;

            newcargarcliente.Show();
            
        }

        private void lISTADECLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        { 
           
            ListadeClientes newlistclient = new ListadeClientes();
            
            newlistclient.MdiParent = this;
            
            newlistclient.Show();

        }

        private void aCTUALIZARToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ListadeClientes newlistclient = new ListadeClientes();

            newlistclient.MdiParent = this;
            //ver mas tarde
        }
    }
}
