using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace Nuevo_Proyecto.Clases
{
    public class Conection
    {
        private static SqlConnection obj;
        private static string error;
        public Conection()
        {
            getConection();
        } 
        public SqlConnection getConection()
        {
            if (obj != null)
            {
                obj = new SqlConnection();
                obj.ConnectionString = @"Data Source=UF150174BF1B\SQLEXPRESS; Initial Catalog = Ingreso_Datos; Integrated Security = True";
                try
                {
                    obj.Open();
                    return obj;
                }
                catch (Exception e)
                {

                    error = e.Message;
                    return null;
                }
            }
            else
            {
                cerrarConnection();
            }
            return obj;
        }
            public static void cerrarConnection()
            {
                if (obj!=null)
                {
                    obj.Close();
                }
            }
    }
}