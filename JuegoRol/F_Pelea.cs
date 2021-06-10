using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace JuegoRol
{
    public partial class F_Pelea : Form
    {
        List<Personaje> Peleadores = new List<Personaje>();
        private int ContClick = 0;
        public F_Pelea(List<Personaje> Personajes)
        {
            InitializeComponent();
            Peleadores = Personajes;
            ActualizarDatos(Peleadores);
        }

        private void EvaluarGanador(List<Personaje> Peleadores)
        {

            if (IsGanador())
            {
                if (Peleadores[0].Salud > Peleadores[1].Salud)
                {
                    MessageBox.Show("El ganador del combate es " + Peleadores[0].Apodo, "Ganador");
                    Peleadores[0].Salud = 100;
                    Peleadores.RemoveAt(1);
                    btn_atacar1.Enabled = true;
                    btn_atacar2.Enabled = false;
                    ContClick = 0;


                }
                else
                {
                    MessageBox.Show("El ganador del combate es " + Peleadores[1].Apodo, "Ganador");
                    Peleadores[1].Salud = 100;
                    Peleadores.RemoveAt(0);
                    ContClick = 0;

                }
            }
            if (Peleadores.Count == 1)
            {
                MessageBox.Show("El Campeon es " + Peleadores[0].Apodo, "Campeón");
                this.Close();
            }
            else
            {
                ActualizarDatos(Peleadores);

            }



        }

        private bool IsGanador()
        {
            return ContClick == 3 || Peleadores[0].Salud <= 0 || Peleadores[1].Salud <= 0;
        }
        private void ActualizarDatos(List<Personaje> Peleadores)
        {
            lbl_apodo.Text = Peleadores[0].Apodo;
            lbl_edad.Text = Peleadores[0].Edad.ToString();
            lbl_nivel.Text = Peleadores[0].Nivel.ToString();
            lbl_salud.Text = Peleadores[0].Salud.ToString();
            lbl_destreza.Text = Peleadores[0].Destreza.ToString();
            lbl_velocidad.Text = Peleadores[0].Velocidad.ToString();
            lbl_fuerza.Text = Peleadores[0].Fuerza.ToString();
            lbl_tipo.Text = Peleadores[0].Tipo.ToString();
            lbl_armadura.Text = Peleadores[0].Armadura.ToString();
            btn_atacar1.Text = "Atacar a " + Peleadores[1].Apodo;

            lbl_ene_apodo.Text = Peleadores[1].Apodo;
            lbl_ene_edad.Text = Peleadores[1].Edad.ToString();
            lbl_ene_nivel.Text = Peleadores[1].Nivel.ToString();
            lbl_ene_salud.Text = Peleadores[1].Salud.ToString();
            lbl_ene_destreza.Text = Peleadores[1].Destreza.ToString();
            lbl_ene_velocidad.Text = Peleadores[1].Velocidad.ToString();
            lbl_ene_fuerza.Text = Peleadores[1].Fuerza.ToString();
            lbl_ene_tipo.Text = Peleadores[1].Tipo.ToString();
            lbl_ene_armadura.Text = Peleadores[1].Armadura.ToString();
            btn_atacar2.Text = "Atacar a " + Peleadores[0].Apodo;


        }

        private void Ataque_izq(List<Personaje> Peleadores)
        {
            Peleadores[0].Ataque(Peleadores[1]);
        }

        private void Ataque_der(List<Personaje> Peleadores)
        {
            Peleadores[1].Ataque(Peleadores[0]);
        }


        public void btn_atacar1_Click(object sender, EventArgs e)
        {
            Ataque_izq(Peleadores);
            btn_atacar1.Enabled = false;
            btn_atacar2.Enabled = true;
            ActualizarDatos(Peleadores);
            EvaluarGanador(Peleadores);
        }

        private void btn_atacar2_Click(object sender, EventArgs e)
        {
            Ataque_der(Peleadores);
            btn_atacar1.Enabled = true;
            btn_atacar2.Enabled = false;
            ActualizarDatos(Peleadores);
            ContClick++;
            EvaluarGanador(Peleadores);
        }
    }


}
