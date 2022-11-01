using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_Concescionaria
{
    public class Motos
    {
        public DataTable DTmotos { get; set; } = new DataTable();
        
        public Motos()
        {
            DTmotos.TableName = "Motos";
            DTmotos.Columns.Add("MARCA", typeof(string));
            DTmotos.Columns.Add("MODELO", typeof(string));
            DTmotos.Columns.Add("CILINDRADA", typeof(string));
            DTmotos.Columns.Add("ESTILO", typeof(string));
            DTmotos.Columns.Add("PRECIO", typeof(string));

            Leer_DTM();
        }

        private void Leer_DTM()
        {
            if (System.IO.File.Exists(@"D:\ProgramasVS2022\Concesionaria\Motoslista.xml"))
            {
                DTmotos.ReadXml(@"D:\ProgramasVS2022\Concesionaria\Motoslista.xml");
            }
        }
        public bool AgregarMoto(Moto moto)
        {
            bool res = false;
            DTmotos.Rows.Add();
            int i = DTmotos.Rows.Count - 1;

            DTmotos.Rows[i]["MARCA"] = moto.Marca;
            DTmotos.Rows[i]["MODELO"] = moto.Modelo;
            DTmotos.Rows[i]["CILINDRADA"] = moto.Cilindrada;
            DTmotos.Rows[i]["ESTILO"] = moto.Estilo;
            DTmotos.Rows[i]["PRECIO"] = moto.Precio;

            DTmotos.WriteXml(@"D:\ProgramasVS2022\Concesionaria\Motoslista.xml");

            res = true;
            return res;
        }
    }
}
