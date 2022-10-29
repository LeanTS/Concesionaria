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
    public partial class CargarCliente : Form
    {
        private BE_Concescionaria.Clientes clientes = new BE_Concescionaria.Clientes();
        public CargarCliente()
        {
            InitializeComponent();
            dtgv_cargar.DataSource = clientes.DT;
            Limpiarpantalla();
        }

        
        private void CargarCliente_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //envia los datos a agregar
            Persona persona = new Persona();
            if(tb_nombre.Text != "" & tb_fecha.Text != "")
            {
                persona.Nombre = tb_nombre.Text;
                persona.Apellido = tb_apellidos.Text;
                persona.Telefono = tb_telefono.Text;
                persona.Moto = tb_moto.Text;
                persona.Fecha = tb_fecha.Text;
                persona.Estado = tb_estado.Text;
                clientes.CargarCliente(persona);
            }
            else
            {
                MessageBox.Show("Falta Nombre, apellido o fecha");
            }
            Limpiarpantalla();

        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            //envia el valor de la celda seleccionada
            int f = 0;
            for (int i = 0; i < dtgv_cargar.Rows.Count - 1; i++)
            {
                if (dtgv_cargar.Rows[i].Selected == true)
                {
                    f = i;
                    clientes.BorrarCliente(f);
                    break;
                }
                
            }
            Limpiarpantalla();
        }
        private void Limpiarpantalla()
        {
            tb_apellidos.Text = "";
            tb_nombre.Text = "";
            tb_fecha.Text = "";
            tb_moto.Text = "";
            tb_telefono.Text = "";
            tb_estado.Text = "";
            tb_nombre.Focus();
        }
    }
}
