using JuegoRol.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoRol
{
    public partial class CrearPJ : Form
    {
        List<Personaje> Personajes = new List<Personaje>();
        List<Equipment> Equipamientos;
        string[] nombres = { "Pedro", "Miguel", "Luciana", "Valentina", "Roberto", "Sandra" };
        string[] apodos = { "Storm Crow", "Razor", "Zeus", "Night Wolf", "Mog", "Ragnar" };
        
        public CrearPJ()
        {
            InitializeComponent();


            comboBox1.Items.Add("Humano");
            comboBox1.Items.Add("Hobbit");
            comboBox1.Items.Add("Personaje del bosque");
            comboBox1.Items.Add("Orco");
            comboBox1.Items.Add("Elfo");
            comboBox1.SelectedIndex = 0;
            
            ApiDeEquipamiento api = new ApiDeEquipamiento();
            Equipamientos = api.ListadoDeEquipamiento;
            
            if (File.Exists("Campeon.json"))
            {
                btn_delCampeon.Enabled = true;
            }

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
                btn_delCampeon.Enabled = true;
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

        private void btn_random_Click(object sender, EventArgs e)
        {

            Personaje NuevoPersonaje = crearAleatorio();
            Personajes.Add(NuevoPersonaje);
            listbox_personajes.Items.Add(NuevoPersonaje.ToString());

        }

        private Personaje crearAleatorio()
        {
            Random random = new Random();

            var valoresEnum = Enum.GetValues(typeof(TipoPersonaje));        
            var aux = (TipoPersonaje)valoresEnum.GetValue(random.Next(valoresEnum.Length));  //Genero un tipo aleatorio

            string equipamiento = Equipamientos[random.Next(0, Equipamientos.Count)].Name;      //Equipamiento  aleatorio


            DateTime fechaAleatoria = CalcularFechaAleatoria();     //Calculo fecha de nacimiento aleatoria

            int edad = DateTime.Today.AddTicks(-fechaAleatoria.Ticks).Year; // Calculo de la edad

            string nombreAleatorio = nombres[random.Next(0, nombres.Length)]; //Nombre aleatorio    
            string apodoAleatorio = apodos[random.Next(0, apodos.Length)];     //Apodo Aleatorio

            Personaje pjAleatorio = new Personaje(nombreAleatorio,aux, apodoAleatorio, fechaAleatoria, edad, equipamiento);


            return pjAleatorio;


        }

        private DateTime CalcularFechaAleatoria()
        {
            DateTime start = new DateTime(1721, 1, 1); 
            Random random = new Random(); 
            int range = (DateTime.Today - start).Days; 
            return start.AddDays(random.Next(range));

        
        }

        private void btn_campeon_Click(object sender, EventArgs e)
        {
            if (File.Exists("Campeon.json"))
            {
                Personaje campeon = LeerCampeon();
                MostrarCampeon(campeon);
            }
            else
            {
                MessageBox.Show("No hay ningun ultimo campeón, juega una partida primero", ":C");
            }

        }

        private void MostrarCampeon(Personaje campeon)
        {
            MessageBox.Show($"El ultimo campeón es {campeon.Apodo} \n" +
                $"Estadisticas:\n" +
                $"Fuerza: {campeon.Fuerza}\n" +
                $"Destreza: {campeon.Destreza}\n" +
                $"Velocidad:{campeon.Velocidad}\n" +
                $"Armadura:{campeon.Armadura}\n" +
                $"Nivel:{campeon.Nivel}\n" +
                $"Edad:{campeon.Edad}");
        }

        private Personaje LeerCampeon()
        {
            StreamReader strReader = new StreamReader("Campeon.json");
            string campeonString = strReader.ReadToEnd();
            strReader.Close();
            Personaje campeon = JsonSerializer.Deserialize<Personaje>(campeonString);

            return campeon;
        }

        private void btn_delCampeon_Click(object sender, EventArgs e)
        {
            if (File.Exists("Campeon.json"))
            {
                File.Delete("Campeon.json");
                MessageBox.Show("Historial borrado con exito", "Exito");
                btn_delCampeon.Enabled = false;
            }
            
        }
    }
}
