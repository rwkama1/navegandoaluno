using System;
using System.Collections.Generic;
using System.Text;

namespace navegandoaluno
{
    class ColEmpleados
    {
        List<Empleado> lista;
        public ColEmpleados()
        {
            lista = new List<Empleado>();
        }

        public int Contar
        {
            get
            {
                return lista.Count;
            }
        }
        public bool Agregar(Empleado e)
        {
            bool oAgregar = true;
            lista.Add(e);
            return oAgregar;
        }
        public Empleado Buscar(int pCi)
        {
           Empleado oBuscado = null;
            for (int i = 0; i < lista.Count; i++)
            {
                if (pCi == lista[i].Ci)
                {
                    oBuscado = lista[i];
                }
            }
            return oBuscado;
        }
        public bool Eliminar(int pCi)
        {
            bool oEliminado = false;
            for (int i = 0; i < lista.Count; i++)
            {
                if (pCi == lista[i].Ci)
                {
                    lista.RemoveAt(i);
                    oEliminado = true;
                }
            } return oEliminado;
        }
        public bool Modificar(Empleado e)
        {
            bool oModificado = false;
            Empleado oEmpBuscado = Buscar(e.Ci);
            if (lista.Remove(oEmpBuscado))
            {
                lista.Add(e);
                oModificado = true;
            }
            return oModificado;
        }
        public Empleado this[int pPosicion]
        {
            get
            {
                if (pPosicion < 0 || pPosicion >= lista.Count)
                {
                    return null;
                }
                else
                {
                    return lista[pPosicion];
                }
            }
        }
        public double TotalSueldo()
        {
            return TotalSueldoAsalariado() + TotalSueldoJornalero();
        }
        public double TotalSueldoAsalariado()
        {
            double oTotal = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] is Asalariado)
                {
                    oTotal = oTotal + lista[i].SueldoNominal();
                }
            }
            return oTotal;
        }
        public double TotalSueldoJornalero()
        {
            double oTotal = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] is Jornalero)
                {
                    oTotal = oTotal + lista[i].SueldoNominal();
                }
            }
            return oTotal;
        }
    }
}
