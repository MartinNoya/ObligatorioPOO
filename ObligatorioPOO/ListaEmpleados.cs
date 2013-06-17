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

        //Dar de baja un empleado de la empresa.
        public void EliminarEmpleado(Empleado e) //Por nombre? cedula?
        {
            this.lista_empleados.Remove(e);
        }

        //Dado un chofer, mostrar la cantidad de clases dictadas en un día X.
            //Implementar IEmpleado con Chofer: IEmpleado y Administrativo: IEmpleado ?
        
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
                //Posicion 3+4*i = Cargo
            for (int i = 0; i < ArchivoEmpleados.Count; i=i+4)
            {
	            String cedula = ArchivoEmpleados[i] as String;
                String nombre = ArchivoEmpleados[i + 1] as String;
                String apellido = ArchivoEmpleados[i + 2] as String;
                String cargo = ArchivoEmpleados[i + 3] as String;

                Empleado e = new Empleado(cedula, nombre, apellido, cargo);
                AgregarEmpleado(e);
	        }
        }
    }
}
