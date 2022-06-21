using System.Collections;

namespace Simulacion_Prueba_Practica___Prog3__Juego_de_memoria_
{
    public partial class Form1 : Form
    {

        private int mov = 50;
        private List<string> listaAAdivinar = new List<string>();
        private List<string> botonesYaAsignados = new List<string>();
        private ListViewGroup YaAdivinadas = new ListViewGroup("Ya Descubiertas", HorizontalAlignment.Center);
        private List<string> sinUtilizar = new List<string>();
        private List<Button> botones = new List<Button>();
        private int seleccionados = 0;
        private string opcion1;
        private string opcion2;
        private string palabraEnEsperaDel2;
        private int num1;
        private int num2;
        private int i = 0;

        public Form1()
        {
            InitializeComponent();
            listaAAdivinar = ReyenadorDePalabras();

            

        }

        private List<string> ReyenadorDePalabras()
        {
            List<string> list = new List<string>();
            list.Add("Perro");
            list.Add("Gato");
            list.Add("Caballo");
            list.Add("Carpincho");
            list.Add("Pollo");
            list.Add("Serpiente");
            list.Add("Mapache");
            list.Add("Loro");
            list.Add("Vaca");
            list.Add("Burro");

            return list;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Movimientos.Text = $"Movimientos: {mov}";
            ListaPalabrasDescubiertas.Groups.Add("", "Palabras acertadas.");
            sinUtilizar = DuplicadorPalabras();
            for (i = 0; i < 20; i++) { botonesYaAsignados.Add(AsignarPalabra()); }//Asigna palabra a botones
            //lista de botones
            botones.Add(button1);
            botones.Add(button2);
            botones.Add(button3);
            botones.Add(button4);
            botones.Add(button5);
            botones.Add(button6);
            botones.Add(button7);
            botones.Add(button8);
            botones.Add(button9);
            botones.Add(button10);
            botones.Add(button11);
            botones.Add(button12);
            botones.Add(button13);
            botones.Add(button14);
            botones.Add(button15);
            botones.Add(button16);
            botones.Add(button17);
            botones.Add(button18);
            botones.Add(button19);
            botones.Add(button20);


            if (mov == 0)
            {
                MessageBox.Show("PERDISTE");
                Application.Exit();

            }

        }


        //Verifica si es el primero boton del conjunto seleccionado o no.
        private bool Es1o2(string palabra,int num)
        {
            

            seleccionados++;
            if(seleccionados == 1)
            {
                opcion1 = palabra;
                MostrarBoton(num);
                num1 = num;
                botones[(num - 1)].Enabled = false;
                return false;
            }
            else
            {
                MostrarBoton(num);
                opcion2 = palabra;
                num2 = num;
                botones[(num - 1)].Enabled = false;
                Cronometro.Start();
            }
            seleccionados = 0;
            return true;
        }


        private void MostrarBoton(int num)
        {
            switch (num)
            {
                case 1:
                    button1.Text = botonesYaAsignados[0];
                    break;
                case 2:
                    button2.Text = botonesYaAsignados[1];
                    break;
                case 3:
                    button3.Text = botonesYaAsignados[2];
                    break;
                case 4:
                    button4.Text = botonesYaAsignados[3];
                    break;
                case 5:
                    button5.Text = botonesYaAsignados[4];
                    break;
                case 6:
                    button6.Text = botonesYaAsignados[5];
                    break;
                case 7:
                    button7.Text = botonesYaAsignados[6];
                    break;
                case 8:
                    button8.Text = botonesYaAsignados[7];
                    break;
                case 9:
                    button9.Text = botonesYaAsignados[8];
                    break;
                case 10:
                    button10.Text = botonesYaAsignados[9];
                    break;
                case 11:
                    button11.Text = botonesYaAsignados[10];
                    break;
                case 12:
                    button12.Text = botonesYaAsignados[11];
                    break;
                case 13:
                    button13.Text = botonesYaAsignados[12];
                    break;
                case 14:
                    button14.Text = botonesYaAsignados[13];
                    break;
                case 15:
                    button15.Text = botonesYaAsignados[14];
                    break;
                case 16:
                    button16.Text = botonesYaAsignados[15];
                    break;
                case 17:
                    button17.Text = botonesYaAsignados[16];
                    break;
                case 18:
                    button18.Text = botonesYaAsignados[17];
                    break;
                case 19:
                    button19.Text = botonesYaAsignados[18];
                    break;
                case 20:
                    button20.Text = botonesYaAsignados[19];
                    break;
            }
        }

        //Ocultar botones
        private void timer1_Tick(object sender, EventArgs e)
        {
            botones[(num1 - 1)].Text = "";
            botones[(num2 - 1)].Text = "";
            Cronometro.Stop();

        }
        


        private bool ComprobarPalabras(string palabra1, string palabra2)
        {
            Movimientos.Text = $"Movimientos: {mov}";

            //En caso de perder
            if (mov <= 0) {
                MessageBox.Show("PERDISTE");
                Application.Restart();

            }
            if (palabra1 == palabra2)
            {

                ListaPalabrasDescubiertas.Items.Add(new ListViewItem(palabra1, YaAdivinadas));
                ListaPalabrasDescubiertas.Groups.Add(palabra1, "Palabras acertadas.");
                botones[(num1 - 1)].Visible = false;//Saca los botones ya encontrados
                botones[(num2 - 1)].Visible = false;
                
            }
            botones[(num1 - 1)].Enabled = true;//Vuelve a habilitar los botones
            botones[(num2 - 1)].Enabled = true;

            return false;
        }
        //
        //
        //

        private string AsignarPalabra()
        {
            string boton;
            Random random = new Random();

            boton = sinUtilizar[random.Next(sinUtilizar.Count)];
            sinUtilizar.Remove(boton);
 

            return boton;
        }

        private List<string> DuplicadorPalabras()
        {
            List<string> s = new List<string>();
            s = ReyenadorDePalabras();
            List<string> strings = new List<string>();
            for(int i = 0; i < 2; i++)
            {

            foreach (string palabra in s)
            {
                strings.Add(palabra);
            }

            }
            return strings;
        }

        


        //botones
        private void button1_Click_1(object sender, EventArgs e)
        {
            
            bool son2 = Es1o2(botonesYaAsignados[0],1);
            if (son2 == false)
            {
                palabraEnEsperaDel2 = botonesYaAsignados[0];
            }
            else
            {
                ComprobarPalabras(palabraEnEsperaDel2, botonesYaAsignados[0]);
            }
            mov--;
            Movimientos.Refresh();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool son2 = Es1o2(botonesYaAsignados[1],2);
            if (son2 == false)
            {
                palabraEnEsperaDel2 = botonesYaAsignados[1];
            }
            else
            {
                ComprobarPalabras(palabraEnEsperaDel2, botonesYaAsignados[1]);
            }
            mov--;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool son2 = Es1o2(botonesYaAsignados[2],3);
            if (son2 == false)
            {
                palabraEnEsperaDel2 = botonesYaAsignados[2];
            }
            else
            {
                ComprobarPalabras(palabraEnEsperaDel2, botonesYaAsignados[2]);
            }
            mov--;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool son2 = Es1o2(botonesYaAsignados[3],4);
            if (son2 == false)
            {
                palabraEnEsperaDel2 = botonesYaAsignados[3];
            }
            else
            {
                ComprobarPalabras(palabraEnEsperaDel2, botonesYaAsignados[3]);
            }
            mov--;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool son2 = Es1o2(botonesYaAsignados[4],5);
            if (son2 == false)
            {
                palabraEnEsperaDel2 = botonesYaAsignados[4];
            }
            else
            {
                ComprobarPalabras(palabraEnEsperaDel2, botonesYaAsignados[4]);
            }
            mov--;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool son2 = Es1o2(botonesYaAsignados[5],6);
            if (son2 == false)
            {
                palabraEnEsperaDel2 = botonesYaAsignados[5];
            }
            else
            {
                ComprobarPalabras(palabraEnEsperaDel2, botonesYaAsignados[5]);
            }
            mov--;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bool son2 = Es1o2(botonesYaAsignados[6],7);
            if (son2 == false)
            {
                palabraEnEsperaDel2 = botonesYaAsignados[6];
            }
            else
            {
                ComprobarPalabras(palabraEnEsperaDel2, botonesYaAsignados[6]);
            }
            mov--;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bool son2 = Es1o2(botonesYaAsignados[7],8);
            if (son2 == false)
            {
                palabraEnEsperaDel2 = botonesYaAsignados[7];
            }
            else
            {
                ComprobarPalabras(palabraEnEsperaDel2, botonesYaAsignados[7]);
            }
            mov--;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            bool son2 = Es1o2(botonesYaAsignados[8],9);
            if (son2 == false)
            {
                palabraEnEsperaDel2 = botonesYaAsignados[8];
            }
            else
            {
                ComprobarPalabras(palabraEnEsperaDel2, botonesYaAsignados[8]);
            }
            mov--;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            bool son2 = Es1o2(botonesYaAsignados[9],10);
            if (son2 == false)
            {
                palabraEnEsperaDel2 = botonesYaAsignados[9];
            }
            else
            {
                ComprobarPalabras(palabraEnEsperaDel2, botonesYaAsignados[9]);
            }
            mov--;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            bool son2 = Es1o2(botonesYaAsignados[10],11);
            if (son2 == false)
            {
                palabraEnEsperaDel2 = botonesYaAsignados[10];
            }
            else
            {
                ComprobarPalabras(palabraEnEsperaDel2, botonesYaAsignados[10]);
            }
            mov--;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            bool son2 = Es1o2(botonesYaAsignados[11],12);
            if (son2 == false)
            {
                palabraEnEsperaDel2 = botonesYaAsignados[11];
            }
            else
            {
                ComprobarPalabras(palabraEnEsperaDel2, botonesYaAsignados[11]);
            }
            mov--;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            bool son2 = Es1o2(botonesYaAsignados[12],13);
            if (son2 == false)
            {
                palabraEnEsperaDel2 = botonesYaAsignados[12];
            }
            else
            {
                ComprobarPalabras(palabraEnEsperaDel2, botonesYaAsignados[12]);
            }
            mov--;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            bool son2 = Es1o2(botonesYaAsignados[13],14);
            if (son2 == false)
            {
                palabraEnEsperaDel2 = botonesYaAsignados[13];
            }
            else
            {
                ComprobarPalabras(palabraEnEsperaDel2, botonesYaAsignados[13]);
            }
            mov--;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            bool son2 = Es1o2(botonesYaAsignados[14],15);
            if (son2 == false)
            {
                palabraEnEsperaDel2 = botonesYaAsignados[14];
            }
            else
            {
                ComprobarPalabras(palabraEnEsperaDel2, botonesYaAsignados[14]);
            }
            mov--;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            bool son2 = Es1o2(botonesYaAsignados[15],16);
            if (son2 == false)
            {
                palabraEnEsperaDel2 = botonesYaAsignados[15];
            }
            else
            {
                ComprobarPalabras(palabraEnEsperaDel2, botonesYaAsignados[15]);
            }
            mov--;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            bool son2 = Es1o2(botonesYaAsignados[16],17);
            if (son2 == false)
            {
                palabraEnEsperaDel2 = botonesYaAsignados[16];
            }
            else
            {
                ComprobarPalabras(palabraEnEsperaDel2, botonesYaAsignados[16]);
            }
            mov--;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            bool son2 = Es1o2(botonesYaAsignados[17],18);
            if (son2 == false)
            {
                palabraEnEsperaDel2 = botonesYaAsignados[17];
            }
            else
            {
                ComprobarPalabras(palabraEnEsperaDel2, botonesYaAsignados[17]);
            }
            mov--;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            bool son2 = Es1o2(botonesYaAsignados[18],19);
            if (son2 == false)
            {
                palabraEnEsperaDel2 = botonesYaAsignados[18];
            }
            else
            {
                ComprobarPalabras(palabraEnEsperaDel2, botonesYaAsignados[18]);
            }
            mov--;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            bool son2 = Es1o2(botonesYaAsignados[19],20);
            if (son2 == false)
            {
                palabraEnEsperaDel2 = botonesYaAsignados[19];
            }
            else
            {
                ComprobarPalabras(palabraEnEsperaDel2, botonesYaAsignados[19]);
            }
            mov--;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }



    }
}