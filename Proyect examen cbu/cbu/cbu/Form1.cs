

using System.Text;

namespace cbu
{
    public partial class Form1 : Form
    {
        public static Dictionary<string, string> bancos = new Dictionary<string, string>();


        public Form1()
        {
            leerArchivo();
            
            InitializeComponent();
        }

        public void leerArchivo()
        {
            string numbanco = null;
            string nomBanco = null;
            try
            {
                using (StreamReader sr = new StreamReader("bancos.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        foreach (char c in line)
                        {
                            if (char.IsDigit(c))
                            {
                                numbanco += c;
                            }
                            else
                            {
                                nomBanco += c;
                            }
                        }

                        bancos.Add(numbanco, nomBanco);

                        numbanco = null;
                        nomBanco = null;
                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                MessageBox.Show($"Error: {e}");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cbu = textBox1.Text;
            Verificar verificar = new Verificar(cbu, bancos);

        }
    }
}