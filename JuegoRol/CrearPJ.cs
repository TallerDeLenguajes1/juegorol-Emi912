using JuegoRol.Modelos;
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
        List<Personaje> Personajes = new List<Personaje>();
        List<Equipment> Equipamientos = new List<Equipment>();
        public CrearPJ()
        {
            InitializeComponent();
            comboBox1.Items.Add("Humano");
            comboBox1.Items.Add("Hobbit");
            comboBox1.Items.Add("Personaje del bosque");
            comboBox1.Items.Add("Orco");
            comboBox1.Items.Add("Elfo");
            comboBox1.SelectedIndex = 0;
            num_edad.Value = 20;
            ApiDeEquipamiento api = new ApiDeEquipamiento();
            Equipamientos = api.ListadoDeEquipamiento; //.GetEquipment()
        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Nombre.Text) || string.IsNullOrWhiteSpace(txt_Apodo.Text))
            {
                MessageBox.Show("Debe llenar los campos de nombre y apodo", "Error");
            }
            else
            {
                Personaje NuevoPersonaje = CrearPersonaje();
                Personajes.Add(NuevoPersonaje);
                listbox_personajes.Items.Add(NuevoPersonaje.ToString());
                LimpiarCampos();
            
            }
        }

        private void LimpiarCampos()
        {
            txt_Nombre.Clear();
            txt_Apodo.Clear();

        }



        private Personaje CrearPersonaje()
        {
            Random random = new Random();
            TipoPersonaje Aux = TipoPersonaje.Humano;
            switch (comboBox1.SelectedItem)
            {
                case "Personaje del bosque":
                    Aux = TipoPersonaje.PersonajeDelBosque;
                    break;
                case "Hobbit":
                    Aux = TipoPersonaje.Hobbit;
                    break;
                case "Humano":
                    Aux = TipoPersonaje.Humano;
                    break;
                case "Orco":
                    Aux = TipoPersonaje.Orco;
                    break;
                case "Elfo":
                    Aux = TipoPersonaje.Elfo;
                    break;
                default:
                    break;
            }

            string equipamiento = Equipamientos[random.Next(0, Equipamientos.Count)].Name; 

            Personaje NuevoPersonaje = new Personaje(txt_Nombre.Text.Trim(),
                                                     Aux,
                                                     txt_Apodo.Text.Trim(),
                                                     dt_nacimiento.Value,
                                                     Convert.ToInt32(num_edad.Value),
                                                     equipamiento);
            return NuevoPersonaje;

        }

        private void btn_pelea_Click(object sender, EventArgs e)
        {
            if (Personajes.Count < 2)
            {
                MessageBox.Show("Debe ver como minimo dos jugadores", "Error");
            }
            else
            {
                F_Pelea pelea = new F_Pelea(Personajes);
                pelea.ShowDialog();
                listbox_personajes.Items.Clear();
                cargarDatosAListbox();
                
            }


            
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (listbox_personajes.SelectedIndex != -1)
            {
                int indice;
                indice = listbox_personajes.SelectedIndex;
                listbox_personajes.Items.RemoveAt(indice);
                Personajes.RemoveAt(indice);
            }
            else
            {
                MessageBox.Show("Debe seleccionar a que personaje borrar");
            }
        }

        private void cargarDatosAListbox()
        {
            foreach (Personaje persona in Personajes)
            {
                listbox_personajes.Items.Add(persona.ToString());
            }
        }
    }
}
