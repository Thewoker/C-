using System.IO;

namespace Practica_Recuperatorio_Prog_3___Generador_Lorem_Ipsum
{
    public partial class Form1 : Form
    {
        private string comboBoxSelect;
        private int numericInt;
        private int maxPalabrasOracion;
        private int maxOracionesParrafo;
        Random Random = new Random();
        TextReader leerLorem = new StreamReader("palabras.txt");
        private string textoOracion;
        private string textoParrafo;
        private string textoFinal;





        public Form1()
        {
            InitializeComponent();
            comboBoxTipo.Items.Add("PARRAFO");
            comboBoxTipo.Items.Add("PALABRAS");
            maxPalabrasOracion = Random.Next(1,20); //generador de palabras random en una oracion
            maxOracionesParrafo = Random.Next(5,8); //generador de palabras random en un parrafo

        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)// Inicio click
        {
            comboBoxSelect = comboBoxTipo.SelectedItem.ToString();
            numericInt = Convert.ToInt32(NumPalabras.Value);

            Condicion();
            GuardarContenido();
        }

        private void GuardarContenido()
        {
            TextWriter Escribir = new StreamWriter("Texto.txt");
            Escribir.WriteLine(textoFinal);
            Escribir.Close();
            
        }

        private void Condicion()
        {
            textoOracion = "";
            textoParrafo = "";
            textoFinal = "";
            string linea = "";
            int cont = 0;
            
            
            if(comboBoxSelect == "PALABRAS")
            {
                
                while((linea = leerLorem.ReadLine()) != null && cont < numericInt)
                {
                    textoFinal += $" {linea}";
                    cont++;
                    
                }
                TextoGenerado.Text = textoFinal;
                
                return;
            }
            if (comboBoxSelect == "PARRAFO")
            {
                GeneradorOraciones();
                TextoGenerado.Text = textoFinal;

            }
            else MessageBox.Show("Error de tipo.");
        }

        private void GeneradorOraciones()
        {
            string linea;
            int contPalabras = 0;
            

            for(int i = 0; i < numericInt; i++)// cantidad de parrafos pedidos
            {
                for(int j = 0; j < maxOracionesParrafo; j++)// cantidad de oraciones en un parrafo
                {
                    while ((linea = leerLorem.ReadLine()) != null || contPalabras < maxPalabrasOracion)// cantidad de palabras en una oracion
                    {
                        textoOracion += $" {linea}";
                        contPalabras++;
                    }
                    textoParrafo += $"{textoOracion}.";
                }
                textoFinal += $"{textoParrafo}\n\n";
            }
        }

    }
}