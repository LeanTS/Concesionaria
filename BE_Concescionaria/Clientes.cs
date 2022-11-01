using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_Concescionaria
{
    public class Clientes
    {
        int contador = 0;
        public DataTable DT { get; set; } = new DataTable();

        public Clientes()
        {
            DT.TableName = "Clientes";
            DT.Columns.Add("Nombre", typeof(string));
            DT.Columns.Add("Apellido", typeof(string));
            DT.Columns.Add("Telefono", typeof(string));
            DT.Columns.Add("Fecha", typeof(string));
            DT.Columns.Add("Moto", typeof(string));
            DT.Columns.Add("Estado", typeof(string));
            


            Leer_DT();
        }
        private void Leer_DT()
        {
            if (System.IO.File.Exists(@"D:\ProgramasVS2022\Concesionaria\Clientes.xml") == true )
            {
                DT.ReadXml(@"D:\ProgramasVS2022\Concesionaria\Clientes.xml");
            }
        }
        public bool CargarCliente(Persona persona)
        {
            //recibe datos a agregar
            bool res = false;
            DT.Rows.Add();
            int i = DT.Rows.Count - 1;

            DT.Rows[i]["Nombre"] = persona.Nombre;
            DT.Rows[i]["Apellido"] = persona.Apellido;
            DT.Rows[i]["Telefono"] = persona.Telefono;
            DT.Rows[i]["Fecha"] = persona.Fecha;
            DT.Rows[i]["Moto"] = persona.Moto;
            DT.Rows[i]["Estado"] = persona.Estado;

            DT.WriteXml(@"D:\ProgramasVS2022\Concesionaria\Clientes.xml");

            res = true;
            persona.Num = contador;
            return res;
        }
        public int BorrarCliente(int res)
        {
            Persona persona = new Persona();

            //con el resultado que de Res busca la fila en la que se encuenta lo que se quiere eliminar

            for (int i = 0; i < DT.Rows.Count; i++)
            {
                if (i == res)
                {
                    DT.Rows[res].Delete();
                    DT.WriteXml(@"D:\ProgramasVS2022\Concesionaria\Clientes.xml");
                    break;
                }
            }
            return res;
        }
        public int ModCliente(int res, string nombre, string apellido, string telefono, string fecha, string moto, string estado)
        {
            Persona persona = new Persona();

            for (int i = 0; i < DT.Rows.Count; i++)
            {
                if (i == res)
                {
                    DT.Rows[res]["Nombre"] = nombre;
                    DT.Rows[res]["Apellido"] = apellido;
                    DT.Rows[res]["Telefono"] = telefono;
                    DT.Rows[res]["Fecha"] = fecha;
                    DT.Rows[res]["Moto"] = moto;
                    DT.Rows[res]["Estado"] = estado;

                    DT.WriteXml(@"D:\ProgramasVS2022\Concesionaria\Clientes.xml");
                    break;
                }
            }
            return res;
        }
    }
}
