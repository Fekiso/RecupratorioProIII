using Alquiler_de_Elementos.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Alquiler_de_Elementos.AD_Alquileres
{
    public class AD_Alquileres
    {
        Alquiler alq;
        TipoElemento te;

        public static bool InstertarAlquiler(Alquiler alq) {
            bool sepudo = false;

            string CadenaConeccion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"].ToString();
            SqlConnection cn = new SqlConnection(CadenaConeccion);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string Consulta = @"INSERT INTO Alquileres 
                                    VALUES(@Nom_Cliente, @Nom_Elemento, @id_TipoElemento, @Tiempo, 1)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nom_Cliente", alq.Nom_Cliente);
                cmd.Parameters.AddWithValue("@Nom_Elemento", alq.NomElemento);
                cmd.Parameters.AddWithValue("@id_TipoElemento", alq.id_Tipo_Elemento);
                cmd.Parameters.AddWithValue("@Tiempo", alq.Tiempo);

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = Consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();  
                sepudo = true;
            }
            catch (Exception)
            {
                sepudo = false;
                throw;
            }
            finally {
                cn.Close();
            }
            return sepudo;
        } 
    }
}