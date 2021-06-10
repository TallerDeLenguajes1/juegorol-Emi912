
namespace JuegoRol
{
    partial class CrearPJ
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Apodo = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dt_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.btn_crear = new System.Windows.Forms.Button();
            this.num_edad = new System.Windows.Forms.NumericUpDown();
            this.listbox_personajes = new System.Windows.Forms.ListBox();
            this.btn_pelea = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_edad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apodo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edad";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(195, 59);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 23);
            this.txt_Nombre.TabIndex = 3;
            // 
            // txt_Apodo
            // 
            this.txt_Apodo.Location = new System.Drawing.Point(195, 93);
            this.txt_Apodo.Name = "txt_Apodo";
            this.txt_Apodo.Size = new System.Drawing.Size(100, 23);
            this.txt_Apodo.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(195, 178);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha de Nacimiento";
            // 
            // dt_nacimiento
            // 
            this.dt_nacimiento.Location = new System.Drawing.Point(196, 214);
            this.dt_nacimiento.Name = "dt_nacimiento";
            this.dt_nacimiento.Size = new System.Drawing.Size(200, 23);
            this.dt_nacimiento.TabIndex = 9;
            // 
            // btn_crear
            // 
            this.btn_crear.Location = new System.Drawing.Point(196, 269);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Size = new System.Drawing.Size(75, 23);
            this.btn_crear.TabIndex = 10;
            this.btn_crear.Text = "Crear Personaje";
            this.btn_crear.UseVisualStyleBackColor = true;
            this.btn_crear.Click += new System.EventHandler(this.btn_crear_Click);
            // 
            // num_edad
            // 
            this.num_edad.Location = new System.Drawing.Point(196, 132);
            this.num_edad.Name = "num_edad";
            this.num_edad.Size = new System.Drawing.Size(120, 23);
            this.num_edad.TabIndex = 11;
            // 
            // listbox_personajes
            // 
            this.listbox_personajes.FormattingEnabled = true;
            this.listbox_personajes.ItemHeight = 15;
            this.listbox_personajes.Location = new System.Drawing.Point(469, 41);
            this.listbox_personajes.Name = "listbox_personajes";
            this.listbox_personajes.Size = new System.Drawing.Size(286, 364);
            this.listbox_personajes.TabIndex = 12;
            // 
            // btn_pelea
            // 
            this.btn_pelea.Location = new System.Drawing.Point(292, 269);
            this.btn_pelea.Name = "btn_pelea";
            this.btn_pelea.Size = new System.Drawing.Size(75, 23);
            this.btn_pelea.TabIndex = 13;
            this.btn_pelea.Text = "¡Pelea!";
            this.btn_pelea.UseVisualStyleBackColor = true;
            this.btn_pelea.Click += new System.EventHandler(this.btn_pelea_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(521, 412);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 14;
            this.btn_eliminar.Text = "Borrar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // CrearPJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_pelea);
            this.Controls.Add(this.listbox_personajes);
            this.Controls.Add(this.num_edad);
            this.Controls.Add(this.btn_crear);
            this.Controls.Add(this.dt_nacimiento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txt_Apodo);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CrearPJ";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.num_edad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Apodo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dt_nacimiento;
        private System.Windows.Forms.Button btn_crear;
        private System.Windows.Forms.NumericUpDown num_edad;
        private System.Windows.Forms.ListBox listbox_personajes;
        private System.Windows.Forms.Button btn_pelea;
        private System.Windows.Forms.Button btn_eliminar;
    }
}

