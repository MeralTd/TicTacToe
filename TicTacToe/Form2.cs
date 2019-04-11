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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int[] panel = new int[10] { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 };
        int HarfDegeri = 0, score1 = 0, score2 = 0, Berabere = 0;

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            f.Show();
            this.Hide();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            HarfDegeri = 0;
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();

            for (int i = 0; i <= 9; i++)
            {
                panel[i] = 2;
            }
            score1 = 0;
            score2 = 0;
            Berabere = 0;
            label13.Text = score1.ToString();
            label14.Text = score2.ToString();
            label15.Text = Berabere.ToString();
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.White;
            label6.ForeColor = Color.White;
            label7.ForeColor = Color.White;
            label8.ForeColor = Color.White;
            label9.ForeColor = Color.White;
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Show();
            if (HarfDegeri == 0)
            {
                label1.Text = "O";
                HarfDegeri = 1;
                panel[1] = 0;
            }
            else
            {
                label1.Text = "X";
                panel[1] = 1;
                HarfDegeri = 0;
            }
            KazananKontrol();
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            label2.Show();
            if (HarfDegeri == 0)
            {
                label2.Text = "O";
                HarfDegeri = 1;
                panel[2] = 0;
            }
            else
            {
                label2.Text = "X";
                panel[2] = 1;
                HarfDegeri = 0;
            }
            KazananKontrol();
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            label3.Show();
            if (HarfDegeri == 0)
            {
                label3.Text = "O";
                HarfDegeri = 1;
                panel[3] = 0;
            }
            else
            {
                label3.Text = "X";
                panel[3] = 1;
                HarfDegeri = 0;
            }
            KazananKontrol();
        }

        private void panel4_MouseClick(object sender, MouseEventArgs e)
        {
            label4.Show();
            if (HarfDegeri == 0)
            {
                label4.Text = "O";
                HarfDegeri = 1;
                panel[4] = 0;
            }
            else
            {
                label4.Text = "X";
                panel[4] = 1;
                HarfDegeri = 0;
            }
            KazananKontrol();
        }

        private void panel5_MouseClick(object sender, MouseEventArgs e)
        {
            label5.Show();
            if (HarfDegeri == 0)
            {
                label5.Text = "O";
                HarfDegeri = 1;
                panel[5] = 0;
            }
            else
            {
                label5.Text = "X";
                panel[5] = 1;
                HarfDegeri = 0;
            }
            KazananKontrol();
        }

        private void panel6_MouseClick(object sender, MouseEventArgs e)
        {
            label6.Show();
            if (HarfDegeri == 0)
            {
                label6.Text = "O";
                HarfDegeri = 1;
                panel[6] = 0;
            }
            else
            {
                label6.Text = "X";
                panel[6] = 1;
                HarfDegeri = 0;
            }
            KazananKontrol();
        }

        private void panel7_MouseClick(object sender, MouseEventArgs e)
        {
            label7.Show();
            if (HarfDegeri == 0)
            {
                label7.Text = "O";
                HarfDegeri = 1;
                panel[7] = 0;
            }
            else
            {
                label7.Text = "X";
                panel[7] = 1;
                HarfDegeri = 0;
            }
            KazananKontrol();
        }

        private void panel8_MouseClick(object sender, MouseEventArgs e)
        {
            label8.Show();
            if (HarfDegeri == 0)
            {
                label8.Text = "O";
                HarfDegeri = 1;
                panel[8] = 0;
            }
            else
            {
                label8.Text = "X";
                panel[8] = 1;
                HarfDegeri = 0;
            }
            KazananKontrol();
        }

        private void panel9_MouseClick(object sender, MouseEventArgs e)
        {
            label9.Show();
            if (HarfDegeri == 0)
            {
                label9.Text = "O";
                HarfDegeri = 1;
                panel[9] = 0;
            }
            else
            {
                label9.Text = "X";
                panel[9] = 1;
                HarfDegeri = 0;
            }
            KazananKontrol();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        public void KazananKontrol()
        {
            if (panel[1] == panel[2] && panel[1] == panel[3] && panel[1] == 0)
            {

                label1.ForeColor = Color.Maroon;
                label2.ForeColor = Color.Maroon;
                label3.ForeColor = Color.Maroon;
                MessageBox.Show("    1. Oyuncu Kazandı");
                score1++;
                label13.Text = score1.ToString();
                Continue();
            }
            if (panel[1] == panel[4] && panel[1] == panel[7] && panel[1] == 0)
            {

                label1.ForeColor = Color.Maroon;
                label4.ForeColor = Color.Maroon;
                label7.ForeColor = Color.Maroon;
                MessageBox.Show("    1. Oyuncu Kazandı");
                score1++;
                label13.Text = score1.ToString();
                Continue();
            }
            if (panel[1] == panel[5] && panel[1] == panel[9] && panel[1] == 0)
            {

                label1.ForeColor = Color.Maroon;
                label5.ForeColor = Color.Maroon;
                label9.ForeColor = Color.Maroon;
                MessageBox.Show("    1. Oyuncu Kazandı");
                score1++;
                label13.Text = score1.ToString();
                Continue();
            }
            if (panel[4] == panel[5] && panel[4] == panel[6] && panel[4] == 0)
            {

                label5.ForeColor = Color.Maroon;
                label4.ForeColor = Color.Maroon;
                label6.ForeColor = Color.Maroon;
                MessageBox.Show("    1. Oyuncu Kazandı");
                score1++;
                label13.Text = score1.ToString();
                Continue();
            }
            if (panel[2] == panel[5] && panel[2] == panel[8] && panel[2] == 0)
            {

                label2.ForeColor = Color.Maroon;
                label5.ForeColor = Color.Maroon;
                label8.ForeColor = Color.Maroon;
                MessageBox.Show("    1. Oyuncu Kazandı");
                score1++;
                label13.Text = score1.ToString();
                Continue();
            }
            if (panel[3] == panel[5] && panel[3] == panel[7] && panel[3] == 0)
            {

                label3.ForeColor = Color.Maroon;
                label5.ForeColor = Color.Maroon;
                label7.ForeColor = Color.Maroon;
                MessageBox.Show("    1. Oyuncu Kazandı");
                score1++;
                label13.Text = score1.ToString();
                Continue();
            }
            if (panel[7] == panel[8] && panel[7] == panel[9] && panel[7] == 0)
            {

                label8.ForeColor = Color.Maroon;
                label9.ForeColor = Color.Maroon;
                label7.ForeColor = Color.Maroon;
                MessageBox.Show("    1. Oyuncu Kazandı");
                score1++;
                label13.Text = score1.ToString();
                Continue();
            }
            if (panel[3] == panel[6] && panel[3] == panel[9] && panel[3] == 0)
            {

                label3.ForeColor = Color.Maroon;
                label6.ForeColor = Color.Maroon;
                label9.ForeColor = Color.Maroon;
                MessageBox.Show("    1. Oyuncu Kazandı");
                score1++;
                label13.Text = score1.ToString();
                Continue();
            }
            if (panel[1] == panel[2] && panel[1] == panel[3] && panel[1] == 1)
            {

                label1.ForeColor = Color.Maroon;
                label2.ForeColor = Color.Maroon;
                label3.ForeColor = Color.Maroon;
                MessageBox.Show("    2. Oyuncu Kazandı");
                score2++;
                label14.Text = score2.ToString();
                Continue();
            }
            if (panel[1] == panel[4] && panel[1] == panel[7] && panel[1] == 1)
            {

                label1.ForeColor = Color.Maroon;
                label4.ForeColor = Color.Maroon;
                label7.ForeColor = Color.Maroon;
                MessageBox.Show("   2. Oyuncu Kazandı");
                score2++;
                label14.Text = score2.ToString();
                Continue();
            }
            if (panel[1] == panel[5] && panel[1] == panel[9] && panel[1] == 1)
            {

                label1.ForeColor = Color.Maroon;
                label5.ForeColor = Color.Maroon;
                label9.ForeColor = Color.Maroon;
                MessageBox.Show("    2. Oyuncu Kazandı");
                score2++;
                label14.Text = score2.ToString();
                Continue();
            }
            if (panel[4] == panel[5] && panel[4] == panel[6] && panel[4] == 1)
            {

                label5.ForeColor = Color.Maroon;
                label4.ForeColor = Color.Maroon;
                label6.ForeColor = Color.Maroon;
                MessageBox.Show("    2. Oyuncu Kazandı");
                score2++;
                label14.Text = score2.ToString();
                Continue();
            }
            if (panel[2] == panel[5] && panel[2] == panel[8] && panel[2] == 1)
            {

                label2.ForeColor = Color.Maroon;
                label5.ForeColor = Color.Maroon;
                label8.ForeColor = Color.Maroon;
                MessageBox.Show("    2. Oyuncu Kazandı");
                score2++;
                label14.Text = score2.ToString();
                Continue();
            }
            if (panel[3] == panel[5] && panel[3] == panel[7] && panel[3] == 1)
            {

                label3.ForeColor = Color.Maroon;
                label5.ForeColor = Color.Maroon;
                label7.ForeColor = Color.Maroon;
                MessageBox.Show("    2. Oyuncu Kazandı");
                score2++;
                label14.Text = score2.ToString();
                Continue();
            }
            if (panel[7] == panel[8] && panel[7] == panel[9] && panel[7] == 1)
            {

                label7.ForeColor = Color.Maroon;
                label9.ForeColor = Color.Maroon;
                label8.ForeColor = Color.Maroon;
                MessageBox.Show("    2. Oyuncu Kazandı");
                score2++;
                label14.Text = score2.ToString();
                Continue();
            }
            if (panel[3] == panel[6] && panel[3] == panel[9] && panel[3] == 1)
            {

                label3.ForeColor = Color.Maroon;
                label6.ForeColor = Color.Maroon;
                label9.ForeColor = Color.Maroon;
                MessageBox.Show("    2. Oyuncu Kazandı");
                score2++;
                label14.Text = score2.ToString();
                Continue();
            }
            else
            {
                if (panel[1] != 2 && panel[2] != 2 && panel[3] != 2 && panel[4] != 2 && panel[5] != 2 && panel[6] != 2 && panel[7] != 2 && panel[8] != 2 && panel[9] != 2)
                {
                    MessageBox.Show("     Beraberlik Kazandı");
                    Berabere++;
                    label15.Text = Berabere.ToString();
                    Continue();
                }
            }
        }

        public void Continue()
        {
            {
                label1.Hide();
                label2.Hide();
                label3.Hide();
                label4.Hide();
                label5.Hide();
                label6.Hide();
                label7.Hide();
                label8.Hide();
                label9.Hide();
                HarfDegeri = 0;
                for (int i = 1; i <= 9; i++)
                {
                    panel[i] = 2;
                }
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label5.ForeColor = Color.White;
                label6.ForeColor = Color.White;
                label7.ForeColor = Color.White;
                label8.ForeColor = Color.White;
                label9.ForeColor = Color.White;

            }
        }
    }
}

        

