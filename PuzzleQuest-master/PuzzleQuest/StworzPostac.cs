using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PuzzleQuest
{
   
    public partial class Stworz_Postac : Form
    {

        public class Konto : Stworz_Postac
        {
            string nazwa;
            string log;
            string pass;
            string klasa;
            

            public Konto(string nazwa_postaci, string login, string haslo, string klasa_postaci)
            {
                this.nazwa = nazwa_postaci;
                this.log = login;
                this.pass = haslo;
                this.klasa = klasa_postaci;
            }
        }

        List<Image> lista_zdjec = new List<Image>();
        List<Konto> lista_typu_konto = new List<Konto>();
        

        int id_Zdjecia = 0;

        public Stworz_Postac()
        {
            InitializeComponent();
        }

        


        private void Zatwierdz_Click(object sender, EventArgs e)
        {
            
            lista_typu_konto.Add(new Konto(NazwaPostaci.Text,Login.Text,Haslo.Text," "));


            MessageBox.Show("Nazwa postaci : " + NazwaPostaci.Text + "\n"
                                  + "Login : " + Login.Text + "\n"
                                  + "Haslo : " + Haslo.Text + "\n"
                                  + "Klasa Postaci : " + lista_typu_konto[0]);

            //Wrzucenie danych do bazy danych

            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\kaczy\OneDrive\Pulpit\Api\BazaDanych.mdf; Integrated Security = True; Connect Timeout = 30");
            string dat = "Insert into [Tabela](Login, Haslo, Nazwa, Postac) Values ('" + Login.Text + "', '" + Haslo.Text + "', '" + NazwaPostaci.Text + "', '" + Wojownik.Text + "')";
            SqlCommand com = new SqlCommand(dat, con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();

         }

        private void W_Lewo_Click(object sender, EventArgs e)
        {

            lista_zdjec.Add(global::PuzzleQuest.Properties.Resources.rycerz);

            lista_zdjec.Add(global::PuzzleQuest.Properties.Resources.czarodziej);

            lista_zdjec.Add(global::PuzzleQuest.Properties.Resources.paladyn);
           


            if (id_Zdjecia > 0)
            {
                id_Zdjecia--;

                if (id_Zdjecia == 0)
                {
                    id_Zdjecia = 3;
                }
                
                Wojownik.Text = id_Zdjecia.ToString();
                pictureBox1.Image = lista_zdjec[id_Zdjecia];
            }
            else
            {
                id_Zdjecia = lista_zdjec.Count - 1;
                pictureBox1.Image = lista_zdjec[id_Zdjecia];
            }
            

        }

        private void W_Prawo_Click(object sender, EventArgs e)
        {

            


            if (id_Zdjecia < lista_zdjec.Count - 1)
            {
                id_Zdjecia++;
                if (id_Zdjecia == 4)
                {
                    id_Zdjecia = 1;
                }

                Wojownik.Text = id_Zdjecia.ToString();
                pictureBox1.Image = lista_zdjec[id_Zdjecia];
            }

            



        }
        private void WrocDoMenu()

        {

            Application.Run(new PuzzleQuest());

        }

        

        private void Stworz_Postac_Load(object sender, EventArgs e)
        {

        }

        private void Wroc_Click(object sender, EventArgs e)
        {
            System.Threading.Thread zaloguj =
            new System.Threading.Thread(new System.Threading.ThreadStart(WrocDoMenu));


            //uruchomienie nowego wątku
            
            zaloguj.Start();

            //zamknięcie starego wątku
            
            Application.ExitThread();
        }
    }
    
}

