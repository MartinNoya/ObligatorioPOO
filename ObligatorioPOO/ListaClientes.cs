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
        public void AgregarCliente(String cedula, String nombre, String apellido, String sexo, String lugarNac, DateTime fechaNac, DateTime inicioClases, DateTime finalClases, int cantidad)
        {
            this.lista_clientes.Add(new Cliente(cedula, nombre, apellido, sexo, lugarNac, fechaNac, inicioClases, finalClases, cantidad));
        }

        //Buscar un cliente por cédula de identidad.
        public Cliente BuscarCliente(String cedula)
        {
            foreach (Cliente c in this.lista_clientes)
            {
                if (c.Cedula == cedula)
                    return c;
            }
            return null;
        }

        //Inicio de clases de un cliente.
        public DateTime InicioClases(String cedula)
        {
            //PreCondicion: El cliente existe
            return "Cedula";
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
