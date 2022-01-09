using System;
using System.Collections.Generic;
using System.Text;

namespace navegandoaluno
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Definicion
            ColEmpresas ListaEmpresas = new ColEmpresas();
            ColEmpleados ListaEmpleados = new ColEmpleados();
            Empleado e;
            Empresa emp;
            int oCi, oDias,oRuc;
            double oJornal, oSueldo;
            string oNombre, oOpcion = "1";
            DateTime oNacio;
            while (oOpcion != "0")
            {
                Console.WriteLine("\n\n---------------------------------------------\n");

                

                Console.WriteLine("0 - Salir");
                Console.WriteLine("1 - Agregar Asalariado");
                Console.WriteLine("2 - Agregar Jornalero");
                Console.WriteLine("3 - Buscar por CI");
                Console.WriteLine("4 - Eliminar por CI");
                Console.WriteLine("5 - Modificar por Asalariado");
                Console.WriteLine("6 - Modificar por Jornalero");
                Console.WriteLine("7 - Listar Empleados");
                Console.WriteLine("8 - Total Sueldo");
                Console.WriteLine("9 - Total Sueldo Asalariado");
                Console.WriteLine("10 - Total Sueldo Jornalero");
                Console.WriteLine("11 - Agregar Empresa");
                Console.WriteLine("12 - Listar Empresas");
                Console.WriteLine();
                Console.WriteLine("Ingrese una opcion del 0 al 10");
                oOpcion = Console.ReadLine();
                Console.Clear();
                switch (oOpcion)
                {
                    case "0":
                        Console.WriteLine("Chauuuuuuu");
                        Console.ReadLine();
                        break;
                    case "1":
                        Console.WriteLine("Escriba CI:");
                        oCi = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Escriba el Nacimiento:");
                        oNacio = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Escriba el Nombre:");
                        oNombre = Console.ReadLine();
                        Console.WriteLine("Ingrese Sueldo:");
                        oSueldo = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("El Ruc de la Empresa:");
                        oRuc = Convert.ToInt32(Console.ReadLine());
                        emp=ListaEmpresas.Buscar(oRuc);
                        if (emp != null)
                        {
                            e = new Asalariado(oCi, oNombre, oNacio,emp,oSueldo);
                            if (ListaEmpleados.Agregar(e))
                            {
                                Console.WriteLine("Se Agrego Asalariado");
                            }
                            else
                            {
                                Console.WriteLine("No se agrego Asalariado");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No se agrego Asalariado, porque la empresa no existe");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Escriba CI:");
                        oCi = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Escriba el Nacimiento:");
                        oNacio = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Escriba el Nombre:");
                        oNombre = Console.ReadLine();
                        Console.WriteLine("Ingrese Jornal:");
                        oJornal = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese Dias:");
                        oDias = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("El Ruc de la Empresa:");
                        oRuc = Convert.ToInt32(Console.ReadLine());
                        emp = ListaEmpresas.Buscar(oRuc);
                        if (emp != null)
                        {
                            e = new Jornalero(oCi, oNombre, oNacio, emp, oJornal, oDias);
                            if (ListaEmpleados.Agregar(e))
                            {
                                Console.WriteLine("Se Agrego Jornalero");
                            }
                            else
                            {
                                Console.WriteLine("No se agrego Jornalero");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No se agrego Jornalero,porque no exsite la empresa");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Escriba la CI a Buscar:");
                        oCi = Convert.ToInt32(Console.ReadLine());
                        e = ListaEmpleados.Buscar(oCi);
                        if (e == null)
                        {
                            Console.WriteLine("No esta el empleado");
                        }
                        else
                        {
                            Console.WriteLine(e.ToString());
                        }
                        break;
                    case "4":
                        Console.WriteLine("Escriba CI a Eliminar");
                        oCi = Convert.ToInt32(Console.ReadLine());
                        if (ListaEmpleados.Eliminar(oCi))
                        {
                            Console.WriteLine("Se elimino");
                        }
                        else
                        {
                            Console.WriteLine("No Ta");
                        }
                        break;
                    case "5":
                        Console.WriteLine("Escriba CI la que TIENE el empleado:");
                        oCi = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Escriba el nuevo Nacimiento:");
                        oNacio = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Escriba el nuevo  Nombre:");
                        oNombre = Console.ReadLine();
                        Console.WriteLine("Ingrese  nuevo Sueldo:");
                        oSueldo = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Escriba El Ruc de la nueva empresa del empleado:");
                       oRuc= Convert.ToInt32(Console.ReadLine());
                       emp = ListaEmpresas.Buscar(oRuc);
                       if (emp != null)
                       {
                           e = new Asalariado(oCi, oNombre, oNacio, emp, oSueldo);
                           if (ListaEmpleados.Modificar(e))
                           {
                               Console.WriteLine("Se modifico por un Asalariado");
                           }
                           else
                           {
                               Console.WriteLine("No se modifico");
                           }
                       }
                       else
                       {
                           Console.WriteLine("No se modifico, porque la empresa no exsite");
                       }
                        break;
                    case "6":
                        Console.WriteLine("Escriba CI la que TIENE el empleado:");
                        oCi = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Escriba el nuevo Nacimiento:");
                        oNacio = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Escriba el nuevo  Nombre:");
                        oNombre = Console.ReadLine();
                        Console.WriteLine("Ingrese el  nuevo Jornal:");
                        oJornal = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese los nuevos Dias:");
                        oDias = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Escriba El Ruc de la nueva empresa del empleado:");
                        oRuc = Convert.ToInt32(Console.ReadLine());
                        emp = ListaEmpresas.Buscar(oRuc);
                        if (emp != null)
                        {
                            e = new Jornalero(oCi, oNombre, oNacio, emp, oJornal, oDias);
                            if (ListaEmpleados.Modificar(e))
                            {
                                Console.WriteLine("Se modifico por un Jornalero");
                            }
                            else
                            {
                                Console.WriteLine("No se modifico Jornalero");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No se modifico Jornalero, porque la empresa no existe");
                        }
                        break;
                    case "7":
                        for (int i = 0; i < ListaEmpleados.Contar; i++)
                        {
                            Console.WriteLine(ListaEmpleados[i].ToString());
                        }
                        break;
                    case "8":
                        Console.WriteLine("El Total de Sueldos es: " + ListaEmpleados.TotalSueldo());
                        break;
                    case "9":
                        Console.WriteLine("El Total de Sueldos de los Asalariados es: " + ListaEmpleados.TotalSueldoAsalariado());
                        break;
                    case "10":
                        Console.WriteLine("El Total de Sueldos de los Jornaleros es: " + ListaEmpleados.TotalSueldoJornalero());
                        break;
                    case "11":
                        Console.WriteLine("Escriba el Ruc de la Empresa:");
                        oRuc = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Escriba el Nombre:");
                        oNombre = Console.ReadLine();
                        emp = new Empresa(oNombre, oRuc);
                        if (ListaEmpresas.Agregar(emp))
                        {
                            Console.WriteLine("Se Agrego la Empresa");
                        }
                        else
                        {
                            Console.WriteLine("No se agrego Empresa");
                        }
                        break;
                    case "12":
                        Console.Clear();
                        for (int i = 0; i < ListaEmpresas.Contar; i++)
                        {
                            Console.WriteLine(ListaEmpresas[i].ToString());
                        }
                        break;
                    default:
                        Console.WriteLine("Solo Opciones de 0 a 12");
                        break;
                }
            }
        }
    }
}
