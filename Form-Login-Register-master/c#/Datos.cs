using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nuevo_Proyecto.Clases
{
    public class Datos
    {
        private string nombre_doc;
        private DateTime fecha=DateTime.Now;
        private string tipo;
        private string nom_carp;
        private string placa;
        private int id_carp;
        private int id_doc;
        public Datos()
        {
            
        }
        public Datos(string nombre_doc, DateTime fecha, string tipo,string nom_carp, string placa,int id_carp,int id_doc)
        {
            this.nombre_doc = nombre_doc;
            this.fecha = fecha;
            this.tipo = tipo;
            this.nom_carp = nom_carp;
            this.placa = placa;
            this.id_carp = id_carp;
            this.id_doc = id_doc;
        }
        public String Nombre_Doc
        {
            get { return nombre_doc; }
            set { nombre_doc = value; }
        }
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public String Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public String Nom_Carp
        {
            get { return nom_carp; }
            set { nom_carp = value; }
        }
        public String Placa
        {
            get { return placa; }
            set { placa = value; }
        }
        public int Id_Carp
        {
            get { return id_carp; }
            set { id_carp = value; }
        }
        public int Id_Doc
        {
            get { return id_doc; }
            set { id_doc = value; }
        }
    }
}