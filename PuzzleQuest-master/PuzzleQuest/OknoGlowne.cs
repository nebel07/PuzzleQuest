using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleQuest
{
    public partial class PuzzleQuest : Form
    {
        Button[,] karty = new Button[8, 8];
        public PuzzleQuest()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void otworzInterfaceStworzPostac()

        {

            Application.Run(new Stworz_Postac());

        }
        private void otworzMape()

        {

            Application.Run(new Mapa());

        }

        private void Nowa_Gra_Click(object sender, EventArgs e)
        {
            System.Threading.Thread mapa =
                new System.Threading.Thread(new System.Threading.ThreadStart(otworzMape));
            //uruchomienie nowego wątku

            mapa.Start();

            //zamknięcie starego wątku

            Application.ExitThread();
            
            

        }

        private void Najlepsi_Gracze_Click(object sender, EventArgs e)
        {

        }

        private void O_Grze_Click(object sender, EventArgs e)
        {

        }

        private void Wyjscie_Click(object sender, EventArgs e)
        {
            string wiadomosc = "Czy na pewno chcesz wyjsc?";
            string tytul = "Wyjscie";
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            DialogResult rezultat = MessageBox.Show(wiadomosc,tytul,button);
            if(rezultat == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Stworz_Postac_Click(object sender, EventArgs e)
        {
            System.Threading.Thread zaloguj =
                new System.Threading.Thread(new System.Threading.ThreadStart(otworzInterfaceStworzPostac));


            //uruchomienie nowego wątku


            zaloguj.Start();


            //zamknięcie starego wątku


            Application.ExitThread();
        }

        private void Zaloguj_Sie_Click(object sender, EventArgs e)
        {

            this.Hide();
            Logowanie aa = new Logowanie();
            aa.Show();

        }
    }
}
