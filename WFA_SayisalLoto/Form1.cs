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
        sayi:
            sayi = rnd.Next(1, 49);
            if (textboxNumber < 6)
            {
                if (toplam < 10)
                {
                    txt.Text = sayi.ToString();
                    toplam++;
                }
                else if (toplam == 10 && !loto.Contains(sayi))
                {
                    if (textboxNumber < 6)
                    {
                        loto.Add(sayi);
                        txt.Text = sayi.ToString();
                        toplam = 0;
                        textboxNumber++;
                    }
                    if (textboxNumber == 6)
                    {
                        loto.Sort();
                        for (int i = 0; i < loto.Count; i++)
                        {
                            controls[i].Text = loto[i].ToString();
                        }
                        timer1.Stop();
                    }
                }
                else
                {
                    toplam--;
                    goto sayi;
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

        private void metroTile2_Click(object sender, EventArgs e)
        {
            loto.Clear();
            toplam = 0;
            textboxNumber = 0;
            for (int i = 0; i < controls.Length; i++)
            {
                controls[i].Text = "0";

            }
            timer1.Stop();

            


        }
    }
}
