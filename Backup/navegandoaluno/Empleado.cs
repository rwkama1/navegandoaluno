using System;
using System.Collections.Generic;
using System.Text;

namespace navegandoaluno
{
    abstract class Empleado
    {   
        //ATRIBUTOS
        private int ci;
        private string nombre;
        private DateTime nacio;
        private static int contador;
        private int numero;
        private Empresa emp;

        //METODOS CONSTRUCTORES POR DEFECTO 
        public Empleado()
        {
            ci = 0;
            nombre = "<S/N>";
            nacio = DateTime.Now;
            numero=contador;
            contador++;
            emp = null;
        }
        //METODOS CONSTRUCTORES COMPLETOS 
        public Empleado(int pCi, string pNombre, DateTime pNacio, Empresa e)
        {
            ci = pCi;
            nombre = pNombre;
            nacio = pNacio;
            numero = contador;
            contador++;
            emp = e;
        }
        
        //PROPIEDADES 
       
        public int Ci
        {
            get
            {
                return ci;
            }
            set
            {
                    ci = value;
            }
        }
        public int Numero
        {
            get
            {
                return numero;
            }
            set
            {
                numero = value;
            }
        }
        public static int Contador
        {
            get
            {
                return contador;
            }
        }
        public Empresa TrabajaEn
        {
            get
            {
                return emp;
            }
            set
            {
                emp = value;
            }
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public DateTime Nacio
        {
            get
            {
                return nacio;
            }
            set
            {
                nacio = value;
            }
        }
        
        //METODOS
        
        public override string ToString()
        {
            return "El estatico "+numero+ " "+ ci + " " + nombre + " " + nacio.ToShortDateString()+" La Empresa "+emp.ToString();
        }
        public abstract double SueldoNominal();

    }
}
