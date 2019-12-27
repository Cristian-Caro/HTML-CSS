using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
namespace Nuevo_Proyecto.Clases
{
    public class Gestiona
    {
        public SqlConnection conexion;
        public SqlTransaction transaccion;
        public string error;
        public Gestiona() {
            Conection con = new Conection() ;
            this.conexion = con.getConection();
        }

        public bool agregarDocumento(Datos datos)
        {
            bool agrega = false;
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = "insert into DOCUMENTO values(@identificador,@nombre_doc,@fecha,@tipo,@nombre_persona, @correo)";
            //comando.Parameters.AddWithValue("@identificador", datos.Id);
            comando.Parameters.AddWithValue("@nombre_doc", datos.Nombre_Doc);
            comando.Parameters.AddWithValue("@fecha", datos.Fecha);
            comando.Parameters.AddWithValue("@tipo", datos.Tipo);
            //comando.Parameters.AddWithValue("@nombre_persona", datos.Nombre_Persona);
            //comando.Parameters.AddWithValue("@correo", datos.Destino_Correo);
            try
            {
                comando.ExecuteNonQuery();
                agrega = true;
            }
            catch (SqlException ex)
            {
                this.error = ex.Message;
                ;
            }
            return agrega;
        }

        public Datos consulta(string id)
        {
            SqlCommand comand = new SqlCommand();
            comand.Connection = conexion;
            comand.CommandText = "SELECT * FROM PERSONAS WHERE Id=@identificador";
            comand.Parameters.AddWithValue("@identificador", id);
            SqlDataReader registro = comand.ExecuteReader();
            if (registro.Read())
            {
                Datos dato = new Datos();
                //dato.Id = registro.GetInt32(0);
                dato.Nombre_Doc = registro.GetString(1);
                dato.Fecha = registro.GetDateTime(2);
                dato.Tipo = registro.GetString(3);
                //dato.Nombre_Persona = registro.GetString(4);
                //dato.Destino_Correo = registro.GetString(5);
                registro.Close();
                return dato;
            }
            else
            {
                registro.Close();
                return null;
            }
        }
        public List<Datos> listar()
        {
            List<Datos> lista = new List<Datos>();
            SqlCommand com = new SqlCommand();
            com.Connection = conexion;
            com.CommandText = "Select * from DOCUMENTO";
            SqlDataReader registro = com.ExecuteReader();
            while (registro.Read())
            {
                Datos dato = new Datos();
                //dato.Id = registro.GetInt32(0);
                dato.Nombre_Doc = registro.GetString(1);
                dato.Fecha = registro.GetDateTime(2);
                dato.Tipo = registro.GetString(3);
                //dato.Nombre_Persona = registro.GetString(4);
                //dato.Destino_Correo = registro.GetString(5);
                lista.Add(dato);
            }
            registro.Close();
            return lista;
        }

    }

}