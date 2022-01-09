using System;
using System.Collections.Generic;
using System.Text;

namespace navegandoaluno
{
    class Jornalero:Empleado
    {
        //ATRIBUTOS
        private double precio;
        private int hora;

        //METODOS CONSTRUCTORES POR DEFECTO 
        public Jornalero ()
        {
            precio = -1;
            hora = -1;
        }        
        //METODOS CONSTRUCTORES COMPLETOS 
        public Jornalero (int pCi, string pNombre, DateTime pNacio,Empresa e, double pJornal, int pDias)
            :base(pCi,pNombre,pNacio,e)   //Invocando al CONSTRUCTOR de la Clase BASE (Empleado).
        {
            precio=pJornal;
            hora = pDias;
        }
        public double Jornal
        {
            get
            {
                return precio;
            }
            set
            {
                precio = value;
            }
        }
        public int Dias
        {
            get
            {
                return hora;
            }
            set
            {
                hora = value;
            }
        }
                
        public override string ToString()
        {
            return base.ToString() + " " + this.precio + " " + this.hora + " " + SueldoNominal(); 
        }
        public override double SueldoNominal()
        {
            double sueldo=precio * Dias;
            return sueldo - (sueldo * 21 / 100);
        }
    }
}
