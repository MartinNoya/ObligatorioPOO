using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace ObligatorioPOO
{
    class ListaEmpleados
    {
        private List<Empleado> lista_empleados;

        //Agregar un empleado a la empresa.
        public void AgregarEmpleado(Empleado e)
        {
            this.lista_empleados.Add(e);
        }

        public Empleado BuscarEmpleado(String cedula)
        {
            foreach (Empleado e in this.lista_empleados)
            {
                if (e.Cedula == cedula)
                    return e;
            }
            return null;
        }

        //Dar de baja un empleado de la empresa.
        public void EliminarEmpleado(String cedula) //Por nombre? cedula?
        {
            this.lista_empleados.Remove(BuscarEmpleado(cedula));
        }

        //Dado un chofer, mostrar la cantidad de clases dictadas en un día X.
        //public int CantidadClases(Chofer f)
        
        //Listado de empleados. Windows Form?
        
        //Cargar nómina de empleados a partir de un archivo de texto dado por ACDC. 
        //El formato del mismo no está especificado, por lo que ACDC pide a ustedes que definan uno.
        public void CargarEmpleados(String nomArchivo)
        {
            ArrayList ArchivoEmpleados = new ArrayList();
            ManejadorArchivos m = new ManejadorArchivos();
            ArchivoEmpleados= m.Leer(nomArchivo);

            //Formato del archivo:
                //Posicion 0+4*i = Cedula
                //Posicion 1+4*i = Nombre
                //Posicion 2+4*i = Apellido
             for (int i = 0; i < ArchivoEmpleados.Count; i=i+3)
            {
	            String cedula = ArchivoEmpleados[i] as String;
                String nombre = ArchivoEmpleados[i + 1] as String;
                String apellido = ArchivoEmpleados[i + 2] as String;
 
                Empleado e = new Empleado(cedula, nombre, apellido);
                AgregarEmpleado(e);
	        }
        }
    }
}
