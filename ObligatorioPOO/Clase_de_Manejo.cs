using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObligatorioPOO
{
    class Clase_de_Manejo
    {
        Cliente cliente;
        Vehiculo vehiculo;
        Chofer chofer;
        DateTime fecha;
        //información relevante sobre todo para la facturación y seguimiento de sus clientes.

        //Iniciar una clase de manejo, para un cliente, un vehículo en particular y el chofer que dictará las clases.
        public void Clase_de_Manejo(Cliente c, Vehiculo v, Chofer h, DateTime fecha)
        {

            
            this.cliente = c;
            this.vehiculo = v;
            //Cabe aclarar que el vehículo quedará no disponible para otros clientes hasta que termine la clase de manejo.
            this.chofer = h;
            this.fecha = fecha;
        }

        
        //Cantidad de clases de manejo a personas mayores (personas donde su edad actual es mayor a 50 años).
        //Finalizar una clase de manejo.

        //Para tener un monitoreo en tiempo real, la empresa necesita saber en todo momento información de las clases de manejo que se están dictando actualmente.
        //Cuando se finaliza una clase de manejo, el sistema deberá poder generar un archivo de texto como certificado de que el cliente ha realizado dicha clase de manejo. 
        //ACDC solicita que el formato deba ser definido por ustedes.

    }
}
