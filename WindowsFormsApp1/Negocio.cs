using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class Negocio
    {
        public List<Articulos> Listar()
        {
            List<Articulos> lista = new List<Articulos>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

           try
            {
                conexion.ConnectionString = "server = .\\SQL; database = CATALOGO_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Nombre, Descripcion, idMarca, ImagenUrl From ARTICULOS";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                { 
                    Articulos aux = new Articulos();
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.Marca = (int)lector["idMarca"];
                    aux.URLimagen = (string)lector["ImagenUrl"];


                    lista.Add(aux);
                }
                conexion.Close();
              return lista;
            }
            catch (Exception ex) 
            {
                throw ex;
            }

        }
    }
}
