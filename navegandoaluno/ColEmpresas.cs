using System;
using System.Collections.Generic;
using System.Text;

namespace navegandoaluno
{
    class ColEmpresas
    {
        List<Empresa> lista;
        public ColEmpresas()
        {
            lista = new List<Empresa>();
        }

        public int Contar
        {
            get
            {
                return lista.Count;
            }
        }
        public bool Agregar(Empresa e)
        {
            bool oAgregar = true;
            lista.Add(e);
            return oAgregar;
        }
        public Empresa Buscar(int ruc)
        {
           Empresa oBuscado = null;
            for (int i = 0; i < lista.Count; i++)
            {
                if (ruc == lista[i].Ruc)
                {
                    oBuscado = lista[i];
                }
            }
            return oBuscado;
        }
        public bool Eliminar(int ruc)
        {
            bool oEliminado = false;
            for (int i = 0; i < lista.Count; i++)
            {
                if (ruc == lista[i].Ruc)
                {
                    lista.RemoveAt(i);
                    oEliminado = true;
                }
            } return oEliminado;
        }
        public bool Modificar(Empresa e)
        {
            bool oModificado = false;
            Empresa oEmpBuscado = Buscar(e.Ruc);
            if (lista.Remove(oEmpBuscado))
            {
                lista.Add(e);
                oModificado = true;
            }
            return oModificado;
        }
        public Empresa this[int pPosicion]
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
    }
}
