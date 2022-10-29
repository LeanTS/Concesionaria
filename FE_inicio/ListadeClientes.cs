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
    public partial class ListadeClientes : Form
    {
        private BE_Concescionaria.Clientes clientes = new BE_Concescionaria.Clientes();
        public ListadeClientes()
        {
            InitializeComponent();
            dtgv_lista.DataSource = clientes.DT;
        }

        private void dtgv_lista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
