using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObligatorioPOO
{
    class Cliente
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

        String lugar_nacimiento;
        public String Lugar_nacimiento
        {
            get { return lugar_nacimiento; }
            set { lugar_nacimiento = value; }
        }

        DateTime fecha_nacimiento;
        public DateTime Fecha_nacimiento
        {
            get { return fecha_nacimiento; }
            set { fecha_nacimiento = value; }
        }

        String sexo;
        public String Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        
        DateTime inicio_clases;
        public DateTime Inicio_clases
        {
            get { return inicio_clases; }
            set { inicio_clases = value; }
        }

        DateTime final_clases;
        public DateTime Final_clases
        {
            get { return final_clases; }
            set { final_clases = value; }
        }

        int cantidad_clases;
        public int Cantidad_clases
        {
            get { return cantidad_clases; }
            set { cantidad_clases = value; }
        }

        //Constructor por parametros
        public Cliente(String cedula, String nombre, String apellido, String sexo, String lugarNac, DateTime fechaNac, DateTime inicioClases, DateTime finalClases, int cantidad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.cedula = cedula;
            this.sexo = sexo;
            this.lugar_nacimiento = lugarNac;
            this.fecha_nacimiento = fechaNac;
            this.inicio_clases = inicioClases;
            this.final_clases = finalClases;
            this.cantidad_clases = cantidad;
        }


    }
}
