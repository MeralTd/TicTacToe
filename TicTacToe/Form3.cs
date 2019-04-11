using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
          
        }
        int[,] label = new int[3, 3];
        int HamleSayısı, HarfDegeri, a, b, c = 1, d = 1, score1 = 0, score2=0, Berabere = 0;
        char OyuncununHarfi;
        String pl1 = "Oyuncu", pl2 = "Bilgiseyar";
        Random random = new Random();
        bool turn = true;
        
       

        private void Form3_Load(object sender, EventArgs e)
        {
            reset();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            String pl1 = "Oyuncu", pl2 = "Bilgiseyar";
            score1= 0;
            score2 = 0;
            Berabere = 0;
            label13.Text = score1.ToString();
            label14.Text = score2.ToString();
            label15.Text = Berabere.ToString();
            reset();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Show();
            if (Oyun(0, 2) && turn == true)
                OyunaBasla(HarfDegeri);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Show();
            if (Oyun(0, 1) && turn == true)
                OyunaBasla(HarfDegeri);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Show();
            if (Oyun(0, 0) && turn == true)
                OyunaBasla(HarfDegeri);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.Show();
            if (Oyun(1, 2) && turn == true)
                OyunaBasla(HarfDegeri);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            label5.Show();
            if (Oyun(1, 1) && turn == true)
                OyunaBasla(HarfDegeri);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            label6.Show();
            if (Oyun(1, 0) && turn == true)
                OyunaBasla(HarfDegeri);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            label7.Show();
            if (Oyun(2, 2) && turn == true)
                OyunaBasla(HarfDegeri);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            label8.Show();
            if (Oyun(2, 1) && turn == true)
                OyunaBasla(HarfDegeri);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            label9.Show();
            if (Oyun(2, 0) && turn == true)
                OyunaBasla(HarfDegeri);
        }

        public void reset()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++) { label[i, j] = 0; }
            }

            label1.Text = "_";
            label2.Text = "_";
            label3.Text = "_";
            label4.Text = "_";
            label5.Text = "_";
            label6.Text = "_";
            label7.Text = "_";
            label8.Text = "_";
            label9.Text = "_";
            label10.Text = "Bilgiseyar :";
            label11.Text = "Oyuncu :";
            label12.Text = "Beraberlik :";


            HamleSayısı = 0;
            HarfDegeri = 1;
            OyuncununHarfi = 'X';
        }

        public bool Oyun(int l, int m)
        {
            if (label[l, m] == 0)
            {
                a = c; b = d; c = l; d = m;
                Label ctrl = Konum(l, m);
                ctrl.Text = OyuncununHarfi.ToString();

                label[l, m] = HarfDegeri;
                HarfDegistir();
                KazanananKontrol(l, m, label[l, m]);
                return true;
            }
            else
                return false;
        }

       public  Label Konum(int l, int m)
        {
            if (l == 0)
            {
                if (m == 0)
                    return label1;
                if (m == 1)
                    return label2;
                if (m == 2)
                    return label3;
            }
            if (l == 1)
            {
                if (m == 0)
                    return label6;
                if (m == 1)
                    return label5;
                if (m == 2)
                    return label4;
            }
            if (l == 2)
            {
                if (m == 0)
                    return label9;
                if (m == 1)
                    return label8;
                if (m == 2)
                    return label7;
            }
            return null;
        }

        public void HarfDegistir()
        {
            if (OyuncununHarfi == 'X')
            {
                OyuncununHarfi = 'O';
                HarfDegeri = 4;
                HamleSayısı++;
            }
            else
            {
                OyuncununHarfi = 'X';
                HarfDegeri = 1;
                HamleSayısı++;
            }
        }

        public void KazanananKontrol(int l, int m, int n)
        {
            if (HamleSayısı == 1)
                turn = true;
            if (HamleSayısı > 4)
            {
                if ((label[l, 0] + label[l, 1] + label[l, 2] == n * 3) || (label[0, m] + label[1, m] + label[2, m] == n * 3))
                {
                    HamleSayısı = n;
                }
                else
                {
                    if ((label[0, 0] + label[1, 1] + label[2, 2] == n * 3) || (label[2, 0] + label[1, 1] + label[0, 2] == n * 3))
                    {
                        HamleSayısı = n;
                    }
                    else
                    {
                        if (HamleSayısı == 9)
                        {
                            HamleSayısı = 0;
                        }
                    }
                }
                if (HamleSayısı == 1 || HamleSayısı == 0)
                {
                    if (HamleSayısı == 1)
                    {
                        MessageBox.Show(pl1 + " Kazandı");
                        
                        if (pl1 == "Bilgiseyar")
                        {
                            score1++;
                            label13.Text = score1.ToString();
                        }
                            
                        else
                        {
                            score2++;
                            label14.Text = score2.ToString();
                        }
                            
                    }
                    if (HamleSayısı == 0)
                    {
                        MessageBox.Show("Beraberlik Kazandı");
                        Berabere++;
                        label15.Text = Berabere.ToString();


                    }
                    reset();
                   
                    if (pl1 == "Bilgiseyar")
                    {
                        turn = false;
                        OyunaBasla(HarfDegeri);
                    }
                    else
                        turn = false;
                           
                }
                else
                if (HamleSayısı == 4)
                {

                    MessageBox.Show(pl2 + " Kazandı");
                    
                    if (pl2 == "Bilgiseyar")
                    {
                        score1++;
                        label13.Text = score1.ToString();
                    }
                        
                    else
                    {
                        score2++;
                        label14.Text = score2.ToString();

                    }
                        
                    String temp = pl1;
                    pl1 = pl2;
                    pl2 = temp;
                    reset();
                   
                    if (pl1 == "Bilgiseyar")
                        OyunaBasla(HarfDegeri);
                    else
                        turn = false;
                }
            }
        }
      

        public void OyunaBasla(int n)
        {
            int l = 2, m = 0;
            switch (HamleSayısı)
            {
                case 0:
                    Oyun(0, 0);
                    break;
                case 1:
                    if (!(Oyun(1, 1)))
                        Oyun(0, 0);
                    break;
                case 2:
                    if (!(Oyun(2, 2)))
                        Oyun(0, 2);
                    break;
                case 3:
                    if ((label[0, 1] + label[1, 1] + label[2, 1]) == HarfDegeri)
                        Oyun(0, 1);
                    else
                    if ((label[1, 0] + label[1, 1] + label[1, 2]) == HarfDegeri)
                        Oyun(1, 0);
                    else
                        if (label[0, 1] != 0)
                        Oyun(0, 2);
                    else
                        Oyun(2, 0);

                    break;
                default:
                    while (!(Oyun(l, m)))
                    {
                        l = random.Next(3);
                        m = random.Next(3);
                    }
                    break;
            }
        }

        public void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        
    }
}



