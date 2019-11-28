using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PuzzleQuest
{
    public partial class Mapa : Form
    {
       static int y = 0;
       static int x = 0;
        
        const int sizeCard = 70;
        const int rozmiar = 8;
        Button[,] karty = new Button[rozmiar, rozmiar];
        Image[] nazwa_obrazkow = new Image[7];
        List<Image> droga = new List<Image>();
        List<Image> przeciwnicy_na_mapie = new List<Image>();
        List<Image> przeciwnicy_w_grze = new List<Image>();
        List<Image> bohater = new List<Image>();
        Image[] tablica_przeciwnikow = new Image[7];
        Image[] tablica_przeciwnicy_na_drodze = new Image[7];
        Button rycerz = new Button();
        public Nowa_Gra p = new Nowa_Gra();

        
        

        
        
        public Mapa()
        {
            bohater.Add(global::PuzzleQuest.Properties.Resources.czarny_Rycerz);
            droga.Add(global::PuzzleQuest.Properties.Resources.Droga_prosta);
            droga.Add(global::PuzzleQuest.Properties.Resources.zakret_1);
            droga.Add(global::PuzzleQuest.Properties.Resources.zakret_2);
            droga.Add(global::PuzzleQuest.Properties.Resources.zakret_3);
            droga.Add(global::PuzzleQuest.Properties.Resources.zakret_4);

            przeciwnicy_na_mapie.Add(global::PuzzleQuest.Properties.Resources.belial_na_mapie);
            przeciwnicy_na_mapie.Add(global::PuzzleQuest.Properties.Resources.radament_na_mapie);

            przeciwnicy_w_grze.Add(global::PuzzleQuest.Properties.Resources.belial_przeciwnik);
            przeciwnicy_w_grze.Add(global::PuzzleQuest.Properties.Resources.radament_przeciwnik);
            

           
            InitializeComponent();
            
            rycerz.Location = new Point(x*70, y*70);
            rycerz.Size = new Size(sizeCard, sizeCard);
            rycerz.BackgroundImage = bohater[0];
            rycerz.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(rycerz);
            rycerz.KeyPress += KeyPress_pressed;
            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 8; x++)
                {
                    Button b = new Button();
                    b.Location = new Point(x * 70, y * 70);
                    b.Size = new Size(sizeCard, sizeCard);
                    if (((y%2 == 0) && (x <= 6 && x >= 1)) || (x == 0 && y == 0) ||
                       ((y%2 == 1 || y == 7) && (x >= 1 && x <= 6)) || (x == 0 && y == 7))
                    {
                        b.BackgroundImage = droga[0];
                    }
                    else if (x == 7 && (y%2 == 0))
                    {   
                        if(x == 7 && y == 0)
                        {
                            b.BackgroundImage = przeciwnicy_na_mapie[0];
                        }
                        else
                        b.BackgroundImage = droga[2];
                    }
                    else if (x == 7 && (y%2 == 1))
                    {
                        b.BackgroundImage = droga[1];
                    }
                    else if (x == 0 && (y%2 == 1))
                    {
                        
                        b.BackgroundImage = droga[3];
                        b.BackgroundImageLayout = ImageLayout.Zoom;
                    }
                    else if (x == 0 && (y%2 == 0))
                    {
                        if (x == 0 && y == 2)
                        {
                            b.BackgroundImage = przeciwnicy_na_mapie[1];
                        }
                        else
                            b.BackgroundImage = droga[4];
                    }
                    b.BackgroundImageLayout = ImageLayout.Zoom; 
                    b.Tag = new Point(x, y);

                    

                    panel1.Location = new Point(400, 0);
                    panel1.Size = new Size(700, 700);
                    panel1.Controls.Add(b);
                    
                    karty[y, x] = b;
                    
                   b.KeyPress += KeyPress_pressed;
                    
                }
            }

            
            
                

        }

        
        private void otworzInterface()
        {
            
            Application.Run(p);
        }


        

        private void Mapa_Load(object sender, EventArgs e)
        {

        }

        private void KeyPress_pressed(object sender, KeyPressEventArgs e)
        {
            
            if ((Keys)e.KeyChar == Keys.D || e.KeyChar == 'd')
            {
                if (y % 2 == 0 && x <= 6)
                {
                    x++;
                    Console.WriteLine("x = " + x);
                }
                rycerz.Location = new Point(x * 70, y * 70);

                if (rycerz.Location.X == karty[0,7].Location.X  
                    && rycerz.Location.Y == karty[0,7].Location.Y)
                {
                    przeciwnik_Beliar();
                }

                Console.WriteLine("x = " + rycerz.Location.X);
                Console.WriteLine("y = " + rycerz.Location.Y);
            }

            else if((Keys)e.KeyChar == Keys.S || e.KeyChar == 's')
            {
                if (y <= 6)
                {
                    if (y % 2 == 0 && x == 7)
                    {
                        y++;
                        Console.WriteLine("y = " + y);
                    }
                    else if( y % 2 == 1 && x == 0)
                    {
                        y++;
                        Console.WriteLine("y = " + y);
                    }

               }
                
                rycerz.Location = new Point(x * 70, y * 70);
                
                if (rycerz.Location.X == karty[2, 0].Location.X && rycerz.Location.Y == karty[2, 0].Location.Y)
                {
                    przeciwnik_Radament();
                }

            }

            else if((Keys)e.KeyChar == Keys.A || e.KeyChar == 'a')
            {
                if (y % 2 == 1 && x >= 1)
                {
                    x--;
                    Console.WriteLine("x = " + x);
                }
                
                rycerz.Location = new Point(x * 70, y * 70);

                Console.WriteLine("x = " + rycerz.Location.X);
                Console.WriteLine("y = " + rycerz.Location.Y);

            }

            else if((Keys)e.KeyChar == Keys.W || e.KeyChar == 'w')
            {
                if (x == 1 && x == 6)
                {
                    y--;
                    Console.WriteLine("y = " + y);
                }
                
                rycerz.Location = new Point(x * 70, y * 70);

                Console.WriteLine("x = " + rycerz.Location.X);
                Console.WriteLine("y = " + rycerz.Location.Y);
            }
        }
        
        private void przeciwnik_Beliar()
        {
            
            DialogResult belial_result;
            
            string podpis = "Przeciwnik";
            belial_result = MessageBox.Show("Czy chcesz walczyc z przeciwnikiem Belial " + "\n"
                + "Zycie 1000",podpis,MessageBoxButtons.YesNo);
            if(belial_result == DialogResult.Yes)
            {
                
                p.panel2.BackgroundImage = przeciwnicy_w_grze[0];
                p.panel2.BackgroundImageLayout = ImageLayout.Zoom;
                
                
                System.Threading.Thread nowagra =
                new System.Threading.Thread(new System.Threading.ThreadStart(otworzInterface));
                //uruchomienie nowego wątku

                
                nowagra.Start();
                
                //zamknięcie starego wątku

                Application.ExitThread();
            }
            else if(belial_result == DialogResult.No)
            {
                x--;
                rycerz.Location = new Point(x * 70, y * 70);
            }
        }
        private void przeciwnik_Radament()
        {

            DialogResult radament_result;

            string podpis = "Przeciwnik";

            radament_result = MessageBox.Show("Czy chcesz walczyc z przeciwnikiem Radament" + "\n"
                + "Zycie 2500", podpis, MessageBoxButtons.YesNo);
            if (radament_result == DialogResult.Yes)
            {

                p.panel2.BackgroundImage = przeciwnicy_w_grze[1];
                p.panel2.BackgroundImageLayout = ImageLayout.Zoom;
                
                System.Threading.Thread nowagra =
                new System.Threading.Thread(new System.Threading.ThreadStart(otworzInterface));
                //uruchomienie nowego wątku


                nowagra.Start();

                //zamknięcie starego wątku

                Application.ExitThread();
            }
            else if (radament_result == DialogResult.No)
            {
                x--;
                rycerz.Location = new Point(x * 70, y * 70);
            }
        }
    }
}
