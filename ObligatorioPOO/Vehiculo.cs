using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObligatorioPOO
{
    class Vehiculo
    {
        String matrícula;
        public String Matrícula
        {
            get { return matrícula; }
            set { matrícula = value; }
        }

        String marca;
        public String Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        String modelo;
        public String Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        bool habilitado;
        public bool Habilitado
        {
            get { return habilitado; }
            set { habilitado = value; }
        }

        //Constructor por parametros, habilitado
        public Vehiculo(String matricula, String marca, String modelo, bool habilitado)
        {
            this.matrícula = matricula;
            this.marca = marca;
            this.modelo = modelo;
            this.habilitado = habilitado;
        }

    }
}
