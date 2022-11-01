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
    public partial class ListaMotos : Form
    {

        private BE_Concescionaria.Motos motos = new BE_Concescionaria.Motos();
        public ListaMotos()
        {
            InitializeComponent();
            dtgv_motos.DataSource = motos.DTmotos; 
        }

        private void Motos_Load(object sender, EventArgs e)
        {

        }

        private void dtgv_motos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btn_agmoto_Click(object sender, EventArgs e)
        {
            Moto moto = new Moto();
            if (tb_marca.Text != "" & tb_modelo.Text != "" & tb_cil.Text != "" & tb_estilo.Text != "" & tb_precio.Text != "")
            {
                moto.Marca = tb_marca.Text;
                moto.Modelo = tb_modelo.Text;
                moto.Cilindrada = tb_cil.Text;
                moto.Estilo = tb_estilo.Text;
                moto.Precio = tb_precio.Text;
                motos.AgregarMoto(moto);
            }
            else
            {
                MessageBox.Show("faltan campos en completar");
            }
        }
    }
}
