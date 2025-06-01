using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Menu : Form
    {

        public static Menu instance;
        
        public Menu()
        {
            InitializeComponent();
            instance = this;
            
        }

        private void GameStartBtn_Click(object sender, EventArgs e)
        {


            if (Form1.words.Length == 1) { label2.Visible = true; }

            else
            {
                Form1 gamewindow = new Form1();

                this.Hide();
                gamewindow.ShowDialog();

                this.Show();
            }
        }
           

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangeLangBtn_Click(object sender, EventArgs e)
        {
            LanguageChoice language = new LanguageChoice();
            language.Show();
        }
    }
}
