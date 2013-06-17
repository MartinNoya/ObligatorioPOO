using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObligatorioPOO
{
    class ListaClientes
    {
        private List<Cliente> lista_clientes;

        //Agregar un cliente al sistema.
        public void AgregarCliente(Cliente c){
            this.   lista_clientes.Add(c);
        }

        //Buscar un cliente por cédula de identidad.
        public Cliente BuscarCliente(String cedula)
        {
            if (cedula != "") 
                return this.lista_clientes.Find(cliente => cliente.Cedula == cedula);
            else 
                return null;
        }

        //Inicio de clases de un cliente.
        public DateTime InicioClases(Cliente c) //Por nombre? Por cedula? Usando BuscarCliente.
        {
            //PreCondicion: El cliente existe

            return c.Inicio_clases;
        }

        //Finalización de clases.
        public DateTime FinalizacionClases(Cliente c)
        {
            //PreCondicion: El cliente existe

            return c.Final_clases;
        }

        //Cantidad de clases tomadas por un cliente.
        public int CantidadClases(Cliente c)
        {
            return c.Cantidad_clases;
        }

    }

}
