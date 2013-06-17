using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace ObligatorioPOO
{
    class ListaVehiculos
    {
        private List<Vehiculo> lista_vehiculos;

        //Agregar un vehículo al sistema.
        public void AgregarVehiculo(Vehiculo v)
        {
            this.lista_vehiculos.Add(v);
        }

        //Habilitar un vehículo 
        //(si un vehículo necesita mantenimiento, no puede ser utilizado para las clases de manejo).
        public void Habilitar(Vehiculo v)
        {
            v.Habilitado = true;
        }

        //Inhabilitar un vehículo 
        public void Inhabilitar(Vehiculo v)
        {
            v.Habilitado = false;
        }
                   
        //Dar de baja un vehículo (porque se vendió).
        public void BorrarVehiculo(Vehiculo v)
        {
            this.lista_vehiculos.Remove(v);
        }

        //Cargar los vehículos a partir de un archivo de texto definido por ustedes.
        public void CargarVehiculos(String nomArchivo)
        {
            ArrayList ArchivoVehiculos = new ArrayList();
            ManejadorArchivos m = new ManejadorArchivos();
            ArchivoVehiculos = m.Leer(nomArchivo);

            //Formato del archivo:
                //Posicion 0+4*i = Matricula
                //Posicion 1+4*i = Marca
                //Posicion 2+4*i = Modelo
                //Posicion 3+4*i = habilitado 
            for (int i = 0; i < ArchivoVehiculos.Count; i=i+4)
            {
	            String matricula = ArchivoVehiculos[i] as String;
	            String marca = ArchivoVehiculos[i+1] as String;
                String modelo = ArchivoVehiculos[i+2] as String;
                //Podriamos asumir que todos los vehiculos estan habilitados al cargarlos?
                bool habilitado;
                if (ArchivoVehiculos[i+3]=="1")
                    habilitado = true;
                else if (ArchivoVehiculos[i+3]=="0")
                    habilitado = false;
                else
                    habilitado = true;

                Vehiculo v = new Vehiculo(matricula, marca, modelo, habilitado);
                AgregarVehiculo(v);
	        }
        }

        //Listado de los vehículos. Windows Form?

    }
}
