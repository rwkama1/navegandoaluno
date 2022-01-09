using System;
using System.Collections.Generic;
using System.Text;

namespace navegandoaluno
{
    class Asalariado:Empleado
    {
        //ATRIBUTOS
        private double sueldo;
        //METODOS CONSTRUCTORES POR DEFECTO
        public Asalariado ()
        {
            sueldo=-1;
        }        
        //METODOS CONSTRUCTORES COMPLETOS 
        public Asalariado(int pCi, string pNombre, DateTime pNacio, Empresa e,double pMensualidad)
            :base(pCi,pNombre,pNacio,e)   //Invocando al CONSTRUCTOR de la Clase BASE (Empleado).
        {
            sueldo = pMensualidad;
        }
        public double Mensualidad
        {
            get
            {
                return sueldo;
            }
            set
            {
                sueldo = value;
            }
        }
        
        public override string ToString()
        {
            return base.ToString()+ " " + this.sueldo + " " + SueldoNominal(); ;
        }
        public override double SueldoNominal()
        {
            return sueldo - (sueldo * 21 / 100) ;
        }
    }
}
