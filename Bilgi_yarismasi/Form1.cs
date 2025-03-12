using System.Diagnostics.Eventing.Reader;

namespace Bilgi_yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }
        int soruno = 0, dogru = 0, yanlis = 0;
        string dogrucevap = "";
        private void button5_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            label6.Visible = false;

            soruno++;
            labelsoru.Text = soruno.ToString();

            if (soruno == 1)
            {
                richTextBox1.Text = "Hangisi asal bir say�d�r?";
                button1.Text = "15";
                button2.Text = "23";
                button3.Text = "27";
                button4.Text = "35";
                label4.Text = "23";
                dogrucevap = "23";


            }
            if (soruno == 2)
            {
                richTextBox1.Text = "A�a��daki �r�nlerden hangisi T�rkiye'de yeti�mez?";
                button1.Text = "Muz";
                button2.Text = "Limon";
                button3.Text = "Mango";
                button4.Text = "Portakal";
                label4.Text = "Mango";
                dogrucevap = "Mango";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "D�nya'n�n en b�y�k okyanusu hangisidir?";
                button1.Text = "Pasifik Okyanusu";
                button2.Text = "Hint Okyanusu";
                button3.Text = "Atlas Okyanusu";
                button4.Text = "Arktik Okyanusu";
                label4.Text = "Pasifik Okyanusu";
                dogrucevap = "Pasifik Okyanusu";
               
            }
            if (soruno == 4)
            
                {
                richTextBox1.Text = "�lk modern olimpiyat oyunlar� hangi �ehirde d�zenlenmi�tir?";
                button1.Text = "Paris";
                button2.Text = "Atina";
                button3.Text = "New York";
                button4.Text = "Londra";
                label4.Text = "Atina";
                dogrucevap = "Atina";
                }
            if ((soruno == 5))
            {
                richTextBox1.Text = "Hangi �nl� ressam \"���l�k\" adl� tablosuyla tan�n�r?";
                button1.Text = "Pablo Picasso";
                button2.Text = "Leonardo da Vinci";
                button3.Text = "Edvard Munch";
                button4.Text = "Claude Monet";
                label4.Text = "Edvard Munch";
                dogrucevap = "Edvard Munch";
            }
             if ((soruno == 6))
            {
                richTextBox1.Text = "A�a��daki gezegenlerden hangisinin halkas� yoktur?";
                button1.Text = "Ven�s";
                button2.Text = "Nept�n";
                button3.Text = "Jupiter";
                button4.Text = "Sat�rn";
                label4.Text = "Ven�s";
                dogrucevap = "Ven�s";
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Hangisi d�nyadaki ilk yaz�l� hukuk metnidir?";
                button1.Text = "Magna Carta";
                button2.Text = "Hammurabi Kanunlar�";
                button3.Text = "Code Napoleon";
                button4.Text = "Roma Kanunlar�";
                label4.Text = "Hammurabi Kanunlar�";
                dogrucevap = "Hammurabi Kanunlar�";
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "1893 D�nya Fuar�'nda \"Felsefi Ta�\" �d�l�n� kazanan T�rk �airi kimdir?";
                button1.Text = " Yahya Kemal Beyatl�";
                button2.Text = "Necip Faz�l K�sak�rek";
                button3.Text = "Tevfik Fikret";
                button4.Text = " Ziya G�kalp";
                label4.Text = "Tevfik Fikret";
                dogrucevap = "Tevfik Fikret";
            }
             if (soruno==9)
            {
                richTextBox1.Text = "Hangi filozof \"�yi, do�ru ve g�zel\" kavramlar�n� birle�tiren bir d���nce sistemine sahiptir?";
                button1.Text = "Aristoteles";
                button2.Text = "Platon";
                button3.Text = "Sokrates";
                button4.Text = "Friedrich Nietzsche";
                label4.Text = "Platon";
                dogrucevap = "Platon";


            }

            if (soruno == 10) 
            {
                richTextBox1.Text = "Riyad'da 2018 y�l�nda ke�fedilen \"en eski dinozor fosili\" hangi d�neme aittir?";
                button1.Text = "Triyas";
                button2.Text = " Jura";
                button3.Text = "Karbonifer";
                button4.Text = "Kretase";
                label4.Text = "Triyas";
                dogrucevap = "Triyas";
                button5.Text = "Sonu�lar";
            }
           if (soruno==11)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                MessageBox.Show("Do�ru: " + dogru + "\n" + "Yanl��:" + yanlis);
            }
            
          
          
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;

            label5.Text = button1.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                labeldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                labelyanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
                label6.Text = "Do�ru Cevap:" + dogrucevap;
                label6.Visible = true; 

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;

            label5.Text = button2.Text;
            if (label4.Text == label5.Text)

            {
                dogru++;
                labeldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                labelyanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
                label6.Text = "Do�ru Cevap:" + dogrucevap;
                label6.Visible = true;

                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;


            label5.Text = button3.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                labeldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                labelyanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
                label6.Text = "Do�ru Cevap:" + dogrucevap;
                label6.Visible = true;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;


            label5.Text = button4.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                labeldogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                labelyanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
                label6.Text = "Do�ru Cevap:" + dogrucevap;
                label6.Visible = true;

            }
        }
    }
}
