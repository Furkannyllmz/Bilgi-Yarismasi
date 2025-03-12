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
                richTextBox1.Text = "Hangisi asal bir sayýdýr?";
                button1.Text = "15";
                button2.Text = "23";
                button3.Text = "27";
                button4.Text = "35";
                label4.Text = "23";
                dogrucevap = "23";


            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Aþaðýdaki ürünlerden hangisi Türkiye'de yetiþmez?";
                button1.Text = "Muz";
                button2.Text = "Limon";
                button3.Text = "Mango";
                button4.Text = "Portakal";
                label4.Text = "Mango";
                dogrucevap = "Mango";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Dünya'nýn en büyük okyanusu hangisidir?";
                button1.Text = "Pasifik Okyanusu";
                button2.Text = "Hint Okyanusu";
                button3.Text = "Atlas Okyanusu";
                button4.Text = "Arktik Okyanusu";
                label4.Text = "Pasifik Okyanusu";
                dogrucevap = "Pasifik Okyanusu";
               
            }
            if (soruno == 4)
            
                {
                richTextBox1.Text = "Ýlk modern olimpiyat oyunlarý hangi þehirde düzenlenmiþtir?";
                button1.Text = "Paris";
                button2.Text = "Atina";
                button3.Text = "New York";
                button4.Text = "Londra";
                label4.Text = "Atina";
                dogrucevap = "Atina";
                }
            if ((soruno == 5))
            {
                richTextBox1.Text = "Hangi ünlü ressam \"Çýðlýk\" adlý tablosuyla tanýnýr?";
                button1.Text = "Pablo Picasso";
                button2.Text = "Leonardo da Vinci";
                button3.Text = "Edvard Munch";
                button4.Text = "Claude Monet";
                label4.Text = "Edvard Munch";
                dogrucevap = "Edvard Munch";
            }
             if ((soruno == 6))
            {
                richTextBox1.Text = "Aþaðýdaki gezegenlerden hangisinin halkasý yoktur?";
                button1.Text = "Venüs";
                button2.Text = "Neptün";
                button3.Text = "Jupiter";
                button4.Text = "Satürn";
                label4.Text = "Venüs";
                dogrucevap = "Venüs";
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Hangisi dünyadaki ilk yazýlý hukuk metnidir?";
                button1.Text = "Magna Carta";
                button2.Text = "Hammurabi Kanunlarý";
                button3.Text = "Code Napoleon";
                button4.Text = "Roma Kanunlarý";
                label4.Text = "Hammurabi Kanunlarý";
                dogrucevap = "Hammurabi Kanunlarý";
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "1893 Dünya Fuarý'nda \"Felsefi Taç\" ödülünü kazanan Türk þairi kimdir?";
                button1.Text = " Yahya Kemal Beyatlý";
                button2.Text = "Necip Fazýl Kýsakürek";
                button3.Text = "Tevfik Fikret";
                button4.Text = " Ziya Gökalp";
                label4.Text = "Tevfik Fikret";
                dogrucevap = "Tevfik Fikret";
            }
             if (soruno==9)
            {
                richTextBox1.Text = "Hangi filozof \"Ýyi, doðru ve güzel\" kavramlarýný birleþtiren bir düþünce sistemine sahiptir?";
                button1.Text = "Aristoteles";
                button2.Text = "Platon";
                button3.Text = "Sokrates";
                button4.Text = "Friedrich Nietzsche";
                label4.Text = "Platon";
                dogrucevap = "Platon";


            }

            if (soruno == 10) 
            {
                richTextBox1.Text = "Riyad'da 2018 yýlýnda keþfedilen \"en eski dinozor fosili\" hangi döneme aittir?";
                button1.Text = "Triyas";
                button2.Text = " Jura";
                button3.Text = "Karbonifer";
                button4.Text = "Kretase";
                label4.Text = "Triyas";
                dogrucevap = "Triyas";
                button5.Text = "Sonuçlar";
            }
           if (soruno==11)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                MessageBox.Show("Doðru: " + dogru + "\n" + "Yanlýþ:" + yanlis);
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
                label6.Text = "Doðru Cevap:" + dogrucevap;
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
                label6.Text = "Doðru Cevap:" + dogrucevap;
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
                label6.Text = "Doðru Cevap:" + dogrucevap;
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
                label6.Text = "Doðru Cevap:" + dogrucevap;
                label6.Visible = true;

            }
        }
    }
}
