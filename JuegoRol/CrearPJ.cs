using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoRol
{
    public partial class CrearPJ : Form
    {
        public CrearPJ()
        {
            InitializeComponent();
            comboBox1.Items.Add("Personaje del bosque");
            comboBox1.Items.Add("Hobbit");
            comboBox1.Items.Add("Humano");
            comboBox1.Items.Add("Orco");
            comboBox1.Items.Add("Elfo");
        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            Personaje NuevoPersonaje = CrearPersonaje();

        }

        private Personaje CrearPersonaje()
        {
            Tipos Aux = Tipos.Humano;
            switch (comboBox1.SelectedItem)
            {
                case "Personaje del bosque":
                    Aux = Tipos.PersonajeDelBosque;
                    break;
                case "Hobbit":
                    Aux = Tipos.Hobbit;
                    break;
                case "Humano":
                    Aux = Tipos.Humano;
                    break;
                case "Orco":
                    Aux = Tipos.Orco;
                    break;
                case "Elfo":
                    Aux = Tipos.Elfo;
                    break;
                default:
                    break;
            }
            Personaje NuevoPersonaje = new Personaje(txt_Nombre.Text,
                                                     Aux,
                                                     txt_Apodo.Text,
                                                     dt_nacimiento.Value,
                                                     Convert.ToInt32(num_edad.Value));
            return NuevoPersonaje;

        }
    }
}
