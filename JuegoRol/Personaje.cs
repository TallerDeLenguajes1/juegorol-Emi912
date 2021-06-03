using System;
using System.Collections.Generic;
using System.Text;

namespace JuegoRol
{
    class Personaje
    {

        private string nombre;
        private string tipo;
        private string apodo;
        private DateTime fechaDeNacimiento;
        private int edad;
        private int salud = 100;
    

        private int velocidad;
        private int destreza;
        private int armadura;
        private int nivel;
        private int fuerza;

        public int Velocidad { get => velocidad; set => velocidad = value; }
        public int Destreza { get => destreza; set => destreza = value; }
        public int Armadura { get => armadura; set => armadura = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        public int Fuerza { get => fuerza; set => fuerza = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Apodo { get => apodo; set => apodo = value; }
        public DateTime FechaDeNacimiento { get => fechaDeNacimiento; set => fechaDeNacimiento = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}
