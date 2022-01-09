using System;
using System.Collections.Generic;
using System.Text;

namespace navegandoaluno
{
    class Empresa
    {
       
        //Atributos
        private string nombre;
        private int ruc;
       

        //Constructores
        public Empresa ()
        {
            nombre = "<Sin nombre>";
            ruc = 0;
        }

        public Empresa(string pNombre, int pRuc)
        {
            nombre = pNombre;
            ruc = pRuc;

        }


        //Propiedades

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Ruc
        {
            get { return ruc; }
            set { ruc = value; }
        }

        //Métodos


        public override string ToString()
        {
            return ruc+"\t"+nombre;
        }
       

       
    }
}
