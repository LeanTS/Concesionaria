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

        private void button1_Click_1(object sender, EventArgs e)
        {
            int f = 0;
            for (int i = 0; i < dtgv_cargar.Rows.Count - 1; i++)
            {
                if (dtgv_cargar.Rows[i].Selected == true)
                {
                    f = i;
                    string nom = tb_nombre.Text;
                    string ape = tb_apellidos.Text;
                    string tel = tb_telefono.Text;
                    string fec = tb_fecha.Text;
                    string mot = tb_moto.Text;
                    string est = tb_estado.Text;

                    clientes.ModCliente(f, nom, ape, tel, fec, mot, est);
                    break;
                }

            }
        }

        private void dtgv_cargar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int f = 0;
            for (int i = 0; i < dtgv_cargar.Rows.Count - 1; i++)
            {
                if (dtgv_cargar.Rows[i].Selected == true)
                {
                    f = i;
                    tb_nombre.Text = (string)clientes.DT.Rows[f]["Nombre"];
                    tb_apellidos.Text = (string)clientes.DT.Rows[f]["Apellido"];
                    tb_telefono.Text = (string)clientes.DT.Rows[f]["Telefono"];
                    tb_fecha.Text = (string)clientes.DT.Rows[f]["Fecha"];
                    tb_moto.Text = (string)clientes.DT.Rows[f]["Moto"];
                    tb_estado.Text = (string)clientes.DT.Rows[f]["Estado"];
                    break;
                }

            }
        }
    }
}
