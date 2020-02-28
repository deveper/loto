using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WFA_SayisalLoto
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
   
        int toplam = 0;
        int sayi = 0;
        List<int> loto = new List<int>();
        Control[] controls;
        int textboxNumber = 0;
        private void metroTile1_Click(object sender, System.EventArgs e)
        {
           
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Control txt = controls[textboxNumber];

            if (textboxNumber<6)
            {
                //sayi = rnd.Next(1, 49);
                //txt.Text = sayi.ToString();
                //toplam++;
                //if (!loto.Contains(sayi))
                //{
                //    loto.Add(sayi);
                //}
                //else
                //{
                //    toplam--;
                //}
                //if (toplam == 10)
                //{
                //    timer1.Stop();
                //    toplam = 0;
                //}

                if (toplam < 11)
                {
                    sayi = rnd.Next(1, 7);
                    txt.Text = sayi.ToString();
                    toplam ++;
                }
                else if (toplam == 11)
                {
                    if (!loto.Contains(sayi))
                    {
                        loto.Add(sayi);
                        txt.Text = sayi.ToString();
                    }
                    else
                    {
                        toplam--;
                        
                    }
                    textboxNumber++;
                    toplam = 0;
                    if (textboxNumber == 6)
                    {
                        loto.Sort();
                        for (int i = 0; i < loto.Count-1; i++)
                        {
                            controls[i].Text = loto[i].ToString();
                        }
                        timer1.Stop();

                    }
                }
            }

            

        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            controls = new Control[]
           {
                txt1, txt2, txt3, txt4, txt5, txt6
           };
        }
    }
}
