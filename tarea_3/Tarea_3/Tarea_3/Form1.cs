using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_3
{
    public partial class Form1 : Form
    {
        List<Button> Botones = new List<Button>();
        List<Label> labels = new List<Label>();
        List<PictureBox> pictureBoxes = new List<PictureBox>();
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            label7.Text = "" + monto;
            //Lista de botones de las letras
            Botones.Add(button1);
            Botones.Add(button2);
            Botones.Add(button3);
            Botones.Add(button4);
            Botones.Add(button5);
            Botones.Add(button6);
            Botones.Add(button7);
            Botones.Add(button8);
            Botones.Add(button9);
            Botones.Add(button10);
            Botones.Add(button11);
            Botones.Add(button12);
            //Lista de Labels para las caja de texto
            labels.Add(label1);
            labels.Add(label2);
            labels.Add(label3);
            labels.Add(label4);
            labels.Add(label5);
            labels.Add(label6);
            pictureBoxes.Add(pictureBox1);
            pictureBoxes.Add(pictureBox2);
            pictureBoxes.Add(pictureBox3);
            pictureBoxes.Add(pictureBox4);
        }
       
        int Nivel = 0;
        //Matriz de imagenes por categoria y nivel
        //Paises desde 0,0 hasta 39,0
        //Animales desde  0,1 hasta 39,1
        //Ciudades desde 0,2 hasta 39,2
        String[] ABECEDARIO = {"B","C","D","F","G","H","J","K","L","M","N","Ñ","P","Q","R","S","T","V","W","X","Y","Z" };
        String[] vocales = { "A", "E", "I", "O", "U" , "A", "E", "I", "O", "U"};
        String[,] Imagen_Nivel={ { "peru1.jpg", "peru2.jpg", "peru3.jpg", "peru4.jpg",
                                    "cuba1.jpg", "cuba2.jpg", "cuba3.jpg", "cuba4.jpg",
                                    "iran1.jpg", "iran2.jpg", "iran3.jpg", "iran4.jpg",
                                    "chile1.jpg", "chile2.jpg", "chile3.jpg", "chile4.jpg",
                                    "qatar1.jpg", "qatar2.jpg", "qatar3.jpg", "qatar4.jpg",
                                    "japon1.jpg", "japon2.jpg", "japon3.jpg", "japon4.jpg",
                                    "india1.jpg", "india2.jpg", "india3.jpg", "india4.jpg",
                                    "egipto1.jpg", "egipto2.jpg", "egipto3.jpg", "egipto4.jpg",
                                    "espana1.jpg", "espana2.jpg", "espana3.jpg", "espana4.jpg",
                                    "taiwan1.jpg", "taiwan2.jpg", "taiwan3.jpg" , "taiwan4.jpeg"},
                                  { "foca1.jpg", "foca2.jpg", "foca3.jpg", "foca4.jpg",
                                    "gato1.jpg", "gato2.jpg", "gato3.jpg", "gato4.jpg",
                                    "leon1.jpg", "leon2.jpg", "leon3.jpg", "leon4.jpg",
                                    "cebra1.jpg", "cebra2.jpg", "cebra3.jpg", "cebra4.jpg",
                                    "abeja1.jpg", "abeja2.jpg", "abeja3.jpg", "abeja4.jpg",
                                    "tigre1.jpg", "tigre2.jpg", "tigre3.jpg", "tigre4.jpg",
                                    "perro1.jpg","perro2.jpg", "perro3.jpg", "perro4.jpg",
                                    "conejo1.jpg", "conejo2.jpg","conejo3.jpg", "conejo4.jpg",
                                    "bufalo1.jpg", "bufalo2.jpg", "bufalo3.jpg","bufalo4.jpg",
                                    "javali1.jpg", "javali2.jpg", "javali3.jpg", "javali4.jpg" },
                                  { "roma1.jpeg", "roma2.jpg", "roma3.jpg", "roma4.jpg",
                                    "niza.jpg", "niza2.jpg", "niza3.jpg", "niza4.jpg",
                                    "lima1.jpg", "lima2.jpg", "lima3.jpg", "lima4.jpg",
                                    "moscu1.jpg", "moscu2.jpg", "moscu3.jpg", "moscu4.jpg",
                                    "viena1.jpg", "viena2.jpg", "viena3.jpg", "viena.jpg",
                                    "paris1.jpg", "paris2.jpg", "paris3.jpg", "paris4.jpg",
                                    "tokio1.jpg",  "tokio2.jpg","tokio3.jpg", "tokyo4.jpg",
                                    "madrid1.jpg", "madrid2.jpg", "madrid3.jpg", "madid4.jpg",
                                    "munich1.jpg", "munich2.jpg", "munich3.jpg" , "munich4.jpg",
                                    "bogota1.jpg", "bogota2.jpg", "bogota3.jpg", "bogota4.jpg" }};
        String[,] respuestas = {{ "PERU", "CUBA", "IRAN", "CHILE", "QATAR", "JAPON", "INDIA", "EGIPTO","ESPAÑA", "TAIWAN"},
                                   {"FOCA", "GATO", "LEON", "CEBRA", "ABEJA", "TIGRE", "PERRO", "CONEJO","BUFALO", "JAVALI" },
                                   { "ROMA", "NIZA", "LIMA", "MOSCU", "VIENA", "PARIS", "TOKIO" , "MADRID", "MUNICH", "BOGOTA"}};

        //Ruta de las imagenes
        private String ruta = Application.StartupPath + "\\Imagenes\\";
        public int c;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            String palabra = (label1.Text + label2.Text + label3.Text + label4.Text + label5.Text + label6.Text).Trim();
            //progresvar();
            if (palabra.Equals(respuestas[cat, Nivel]))
            {
                progressBar1.Increment(10);
                limpiar();
                Form2 for2 = new Form2();
                if (Nivel == 9)
                {
                    timer1.Stop();
                    for2.mensaje = respuestas[cat, Nivel];
                    for2.lev = Nivel;
                    for2.ShowDialog();
                }
                else
                {
                    for2.mensaje = respuestas[cat, Nivel];
                    for2.lev = Nivel;
                    for2.ShowDialog();
                    c++;
                    Nivel++;
                    monto += 60;
                    label7.Text = "" + monto;
                    switch (Nivel)
                    {
                        case 3:
                            label5.Visible = true;
                            label1.Location = new Point(label1.Location.X - 20, label1.Location.Y);
                            label2.Location = new Point(label2.Location.X - 20, label2.Location.Y);
                            label3.Location = new Point(label3.Location.X - 20, label3.Location.Y);
                            label4.Location = new Point(label4.Location.X - 20, label4.Location.Y);
                            break;
                        case 7:
                            label6.Visible = true;
                            label1.Location = new Point(label1.Location.X - 20, label1.Location.Y);
                            label2.Location = new Point(label2.Location.X - 20, label2.Location.Y);
                            label3.Location = new Point(label3.Location.X - 20, label3.Location.Y);
                            label4.Location = new Point(label4.Location.X - 20, label4.Location.Y);
                            label5.Location = new Point(label5.Location.X - 20, label5.Location.Y);
                            break;
                        default:
                            break;
                    }
                    cambiar_BOTONES();
                    cambiar_imagen();
                }
               
            }
            else
             if (palabra.Length == respuestas[cat, Nivel].Length && !palabra.Equals(respuestas[cat, Nivel]))
            {
                contador++;

                if (contador <= 10)
                {
                    if (contador % 2 == 0)
                    {
                        label1.ForeColor = Color.Black;
                        label2.ForeColor = Color.Black;
                        label3.ForeColor = Color.Black;
                        label4.ForeColor = Color.Black;
                        label5.ForeColor = Color.Black;
                        label6.ForeColor = Color.Black;
                    }
                    else
                    {
                        label1.ForeColor = Color.Red;
                        label2.ForeColor = Color.Red;
                        label3.ForeColor = Color.Red;
                        label4.ForeColor = Color.Red;
                        label5.ForeColor = Color.Red;
                    }
                }
               
            }
            else
            {
                contador = 0;
            }
        }
        
        //botones de opciones
        private void Button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }//boton salir
        private void Button14_Click(object sender, EventArgs e)
        {
            if (ayuda())
            {
                monto -= 60;
                label7.Text = "" + monto;
            }
        }//boton lapiz
        private void Button15_Click(object sender, EventArgs e)
        {
             if (borrador())
             {
                monto -= 40;
                label7.Text = "" + monto;
             }
        }//boton borrador
        //
        public void limpiar()
        {
            foreach (Label item in labels)
            {
                item.Text = "";
                item.Enabled = true;
                item.BackColor = Color.LightBlue;
            }
            foreach (Button item in Botones)
            {
                item.Visible = true;
            }

        }
        // labels /casillas de texto
        private void Labels_Click(Object sender,EventArgs e)
        {
            Label label = (Label)(sender);
            string simbolo = label.Text;
            if (QuitarLetra(simbolo))
            {
                label.Text = "";
            }
        }
        
        // Metodos boolean con retorno
        public Boolean borrador()
        {
            Boolean b = false;
            String cadena = respuestas[cat, Nivel];
            if (monto >= 40)
            {
                for (int i = 0; i < cadena.Length; i++)
                {
                    if (!labels[i].Text.Equals(cadena[i].ToString()) && labels[i].Text.Equals("") && verificar(false,cadena[i].ToString()) && labels[i].Visible == true)
                    {
                        QuitarLetra(labels[i].Text);
                        labels[i].Text = "";
                        break;
                    }
                }
            }
            else if (monto < 40)
            {
                MessageBox.Show(this, "no tiene saldo suficiente");
            }
            return b;
        }
        public Boolean ayuda()
        {
            Boolean b = false;
            String cadena = respuestas[cat, Nivel];
            if (monto >= 60)
            {
                for (int i = 0; i < cadena.Length; i++)
                {
                    if (!labels[i].Text.Equals(cadena[i].ToString()) && labels[i].Text.Equals("") && verificar(true,cadena[i].ToString()) && labels[i].Visible==true)
                    {
                        labels[i].Text = cadena[i].ToString();
                        ayuda_letra(labels[i].Text);
                        b = true;
                        labels[i].Enabled = false;
                        labels[i].BackColor = Color.Purple;
                        break;
                    }
                }      
            }
            else
            {
                MessageBox.Show(this,"saldo Insuficiente");
            }
            return b;
        } //lapiz
        public Boolean QuitarLetra(String letra)
        {
            Boolean a = false;
            foreach (Button item in Botones)
            {
                if (item.Visible == false && item.Text.Equals(letra))
                {
                    item.Visible = true;
                    a = true;
                    break;
                }
            }
            return a;
        }//para quitar las letras iguales de los labels
        public Boolean verificar(bool ayuda,String letra)
        {
            Boolean a = false;
            foreach (Button item in Botones)
            {
                if (item.Visible == ayuda && item.Text.Equals(letra))
                {
                    a = true;
                    break;
                }
            }
            return a;
        }
        public Boolean Letras(String letra)
        {
            Boolean ver = false;
            foreach (Label item in labels)
            {
                if (item.Text.Equals("") && item.Visible==true)
                {
                    item.Text = letra;
                    ver = true;
                    break;
                }
            }
            return ver;
        }//añadir letras a los labels
        //metodos sin retorno
        public void cambiar_imagen()
        {
            pictureBox1.ImageLocation = ruta + Imagen_Nivel[cat, c];
            pictureBox2.ImageLocation = ruta + Imagen_Nivel[cat, ++c];
            pictureBox3.ImageLocation = ruta + Imagen_Nivel[cat, ++c];
            pictureBox4.ImageLocation = ruta + Imagen_Nivel[cat, ++c];
        }//cambia imagen al abrir o pasar de nivel
        public void desordenar(char[] texts)
        {
            Random random = new Random();
            int n = texts.Count();
            for (int t = n-1; t >0; t--)
            {
                int r = random.Next(0, t);
                string tmp = texts[t].ToString();
                texts[t] = texts[r];
                texts[r] = Convert.ToChar(tmp);
            }
        }
       

        //desordenar las letras aleatoriamente
        public void cambiar_BOTONES()
        {
            string letr = respuestas[cat, Nivel];
            Random random = new Random();
            while (letr.Length !=10)
            {
                int elegido = random.Next(0, 21);
                if (!letr.Contains(ABECEDARIO[elegido]))
                {
                    letr += ABECEDARIO[elegido];
                }
            }
            while (letr.Length !=12)
            {
                int elegido = random.Next(0, 8);
                if (!letr.Contains(vocales[elegido]))
                {
                    letr += vocales[elegido];
                }
            }
            Char[] arr = letr.ToCharArray();
            int rf = random.Next(3, 10);
            for (int i = 0; i < rf; i++)
            {
                desordenar(arr);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Botones[i].Text = ""+arr[i];
            }
           
        }//cambio botones cada nivel
        
        public void ayuda_letra(String letra)
        {
            foreach (Button item in Botones)
            {
                if (item.Visible == true && item.Text.Equals(letra))
                {
                    item.Visible = false;
                    break;
                }
            }
        }
        public int cat = 0;// categoria de juego Animales/cosas /deportes
        int contador=0;//contador de efecto **Letras rojas/negras**
        int monto = 1000;//monto de inicio
        private void Form1_Load(object sender, EventArgs e)
        {
            label7.Text = "" + monto;
            cambiar_BOTONES();
            this.progressBar1.Maximum = 100;
            this.progressBar1.Minimum = 0;
            cambiar_imagen();
        }
        private void PictureBoxes_Click(Object sender,EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)(sender);
            String imagen = pictureBox.ImageLocation;
            Zoom(imagen);
        }
        //picture boxs
        private void PictureBox7_Click(object sender, EventArgs e)
        {
             pictureBox7.Visible = false;
             pictureBox7.ImageLocation = null;
            
        }
        public void Zoom(String ruta)
        {
            if (pictureBox7.Visible == false)
            {
                pictureBox7.ImageLocation = ruta;
                pictureBox7.Visible = true;
            }
        }

        private void Botones_letras(object sender, EventArgs e)
        {
            Button button =  (Button)(sender);        
            if (Letras(button.Text))
            {
                button.Visible = false;
            }
        }
    }
 }


