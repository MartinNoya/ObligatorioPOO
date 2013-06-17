using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObligatorioPOO
{
    class Empleado
    {
        String cedula;
        public String Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

        String nombre;
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        String apellido;
        public String Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        String cargo;
        public String Cargo
        {
          get { return cargo; }
          set { cargo = value; }
        }

        //No fecha de nacimiento/lugar ?

        //Constructor por parametros
        
        public Empleado(String cedula, String nombre, String apellido, String cargo)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.apellido = apellido;
            this.cargo = cargo;
        }
}
