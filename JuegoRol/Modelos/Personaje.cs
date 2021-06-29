using System;
using System.Collections.Generic;
using System.Text;
using JuegoRol.Modelos;


namespace JuegoRol
{
    
    public enum TipoPersonaje
    {
        PersonajeDelBosque,
        Humano,
        Elfo,
        Orco,
        Hobbit
    }
    public class Personaje
    {
        
        private string nombre;
        private TipoPersonaje tipo;
        private string apodo;
        private DateTime fechaDeNacimiento;
        private int edad;
        private int salud = 100;
        private string equipacion;
    

        private int velocidad;
        private int destreza;
        private int armadura;
        private int nivel;
        private int fuerza;

        public Personaje(string nombre, TipoPersonaje tipo, string apodo, DateTime _fechaDeNacimiento, int edad, string equipamiento)
        {
            Random random = new Random();
            Nombre = nombre;
            Salud = 100;
            Tipo = tipo;
            Apodo = apodo;
            FechaDeNacimiento = _fechaDeNacimiento;
            Edad = edad;
            Velocidad = random.Next(1, 10);
            Destreza = random.Next(1, 10);
            Armadura = random.Next(1, 10);
            Fuerza = random.Next(1, 10);
            Nivel = 1;
            Equipacion = equipamiento; 
        }

        public void Ataque(Personaje enemigo) {
            Random aleatorio = new Random();
            //int poderdisparo = Destreza * Fuerza * Nivel;
            //int efectividaddisparo = (aleatorio.Next(1, 100));
            //int valorataque = poderdisparo * efectividaddisparo;
            //int poderdefensa = enemigo.Armadura * enemigo.Velocidad;
            //int dañoprovocado = (((valorataque * efectividaddisparo) - poderdefensa) / 50000) * 100;

            enemigo.Salud -= aleatorio.Next(0,50);
            
        }


        public override string ToString()
        {
           return "Nivel: " + Nivel + " Apodo: " + Apodo + " Tipo: " + Tipo + " Arma: " + Equipacion;

        }

        public int Velocidad { get => velocidad; set => velocidad = value; }
        public int Destreza { get => destreza; set => destreza = value; }
        public int Armadura { get => armadura; set => armadura = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        public int Fuerza { get => fuerza; set => fuerza = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apodo { get => apodo; set => apodo = value; }
        public DateTime FechaDeNacimiento { get => fechaDeNacimiento; set => fechaDeNacimiento = value; }
        public int Edad { get => edad; set => edad = value; }
        public TipoPersonaje Tipo { get => tipo; set => tipo = value; }
        public int Salud { get => salud; set => salud = value; }
        public string Equipacion { get => equipacion; set => equipacion = value; }
    }
}
