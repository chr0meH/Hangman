using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {


        public static Form1 instance;
        public static string[] words = new string[1];
        public static Random rand = new Random();
        public static string word;
        public static IList<int> indexes = new List<int>();
        public static int attempts = 7;
        HashSet<char> tried = new HashSet<char>();
        
       



        public Form1()
        {
            InitializeComponent();
            instance = this;
            attempts = 7;

            

            word = words[rand.Next(words.Length)];
            label1.Text = new string('*', word.Length);

            label1.Left = (this.ClientSize.Width) / 2 - label1.Width/2;
            label2.Left = (this.ClientSize.Width) / 2 - label2.Width / 2;
            textBox1.Left = (this.ClientSize.Width) / 2 - textBox1.Width / 2;
            button1.Left = (this.ClientSize.Width) /2 - button1.Width / 2;

            
            //Показуємо одну випадкову букву бо занадто складно без неї
            char[] labeltext = label1.Text.ToCharArray();
            int random = rand.Next(word.Length);
            labeltext[random] = word.ToCharArray()[random];
            label1.Text = new string(labeltext);
            label4.Text = LanguageChoice.lang;


        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            if (textBox1.Text.Length > 1 && textBox1.Text.Length != word.Length) label2.Text = "Треба ввести одну букву або ціле слово ";
            else if (textBox1.Text.Length == word.Length) label2.Text = "Ти вже знаєш слово?";
            else if (textBox1.Text.Length == 1 && tried.Contains(char.Parse(textBox1.Text)) ) { label2.Text = "Ти вже пробував цю букву";}
            else label2.Text = "Угадуй по букві або ціле слово";
            label2.Left = (this.ClientSize.Width - label2.Width) / 2;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            indexes.Clear();
            if (textBox1.Text.Length == 1)
            {
                textBox1.Text = textBox1.Text.ToLower();
                if (tried.Contains(char.Parse(textBox1.Text))) { label2.Text = "Ви вже пробували цю букву"; return; }
                for (int i = 0; i < word.Length; i++)
                {
                    if (char.Parse(textBox1.Text) == word[i]) { indexes.Add(i); } 


                }
                if (indexes.Count == 0) { DrawPart(attempts); attempts--; tried.Add(char.Parse(textBox1.Text)); TriedBox.Items.Add(char.Parse(textBox1.Text)); }
            }
            else if (textBox1.Text.Length == word.Length) { 
                if (textBox1.Text == word) { label1.Text = word; }
                else { DrawPart(attempts); attempts--; TriedBox.Items.Add(textBox1.Text); } 
            }
            else label2.Text = "Так не можна";
            if (indexes.Count > 0)
            {
                for (int i = indexes.Count - 1; i >= 0; i--)
                {
                    char[] label1text = label1.Text.ToCharArray();
                    label1text[indexes[i]] = char.Parse(textBox1.Text);
                    label1.Text = new string(label1text);

                }
            }
            if(label1.Text == word) { MessageBox.Show("Перемога"); Close();  }
            
            if (attempts == 0) { MessageBox.Show("Поразка"); Close(); }

            textBox1.Clear();

            




        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 3);
            
            g.DrawLine(pen, panel1.Width / 2, 10, panel1.Width / 2 + 50, 10);
            g.DrawLine(pen, panel1.Width / 2 + 50, 10, panel1.Width / 2 + 50, 150);
            g.DrawLine(pen, panel1.Width / 2 + 20, 150, panel1.Width / 2 + 80, 150);

        }

        private void DrawPart(int atts)
        {
            
            Graphics g = panel1.CreateGraphics();
            Pen pen = new Pen(Color.Black, 3);
            switch (atts)
            {
                case 7: g.DrawLine(pen, panel1.Width / 2, 10, panel1.Width / 2, 40);
                    break;
                case 6: g.DrawEllipse(pen, panel1.Width/2 - 10, 40, 20, 20 ); 
                    break;
                case 5: g.DrawLine(pen, panel1.Width / 2, 60, panel1.Width / 2, 90); 
                    break;
                case 4: g.DrawLine(pen, panel1.Width / 2, 70, panel1.Width / 2 - 15, 75); 
                    break;
                case 3: g.DrawLine(pen, panel1.Width / 2, 70, panel1.Width / 2 + 15, 75);
                    break;
                case 2: g.DrawLine(pen, panel1.Width / 2, 90, panel1.Width / 2 - 10, 105);
                    break;
                case 1: g.DrawLine(pen, panel1.Width / 2, 90, panel1.Width / 2 + 10, 105);
                    break;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Text = word;
        }
    }
}
