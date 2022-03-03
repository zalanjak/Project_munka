using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace LogoKaresz
{
    partial class Form1
    {
        void Köszön()
        {
            MessageBox.Show("szia");
        }

        void Hali()
        {
            MessageBox.Show("halilali");
        }

        void oldalazz(double meret)
        {
            Tollat(fel);
            Jobbra(90);
            Előre(meret);
            Balra(90);
            Tollat(le);
        }

        void Odatölt(double szög, double hossz, Color szín)
        {
            Tollat(fel);
            Jobbra(szög);
            Előre(hossz);
            Tölt(szín);
            Hátra(hossz);
            Balra(szög);
            Tollat(le);
        }

        void JE(double jobbra, double előre)
        {
            Tollat(fel);
            Jobbra(90);
            Előre(jobbra);
            Balra(90);
            Előre(előre);
            Tollat(le);
        }

        void szabályos_sokszog(int n, double meret, Color szin)
        {
            double fok = 360 / n;
            for (int i = 0; i < n; i++)
            {
                Előre(meret);
                Jobbra(fok);
            }
            Odatölt(10, meret / 3, szin);
        }

        void teglalap( double fuggolegesoldal, double vizszintesoldal, Color szin)
        {
            Tollszín(szin);
            for (int i = 0; i < 2; i++)
            {
                Előre(fuggolegesoldal);
                Jobbra(90);
                Előre(vizszintesoldal);
                Jobbra(90);
            }
            Odatölt(45, vizszintesoldal / 2, szin);
        }

        void negyzet(double a, Color szin)
        {
            Tollszín(szin);
            for (int i = 0; i < 2; i++)
            {
                Előre(a);
                Jobbra(90);
                Előre(a);
                Jobbra(90);
            }
            Odatölt(45, a / 2, szin);
        }

        void rombusz(double meret, Color szin)
        {
            Tollszín(szin);
           Jobbra(50);
            for (int i = 0; i < 2; i++)
            {
                
                Előre(meret);
                Jobbra(80);
                Előre(meret);
                Jobbra(100);
            }
            Odatölt(10, meret / 3, szin);
            Balra(50);
        }

        void kör(double meret, Color szin)
        {
            Tollszín(szin);
            Ív(360, meret/2);
            Odatölt(90, meret / 2, szin);
        }

        void rombusz_a_teglan( Color teglalap_szin, Color rombusz_szin)
        {
            teglalap(130, 155, teglalap_szin);
            Előre(65);
            rombusz(100, rombusz_szin);
        }

        void tegla_a_teglan(Color alsotegla, Color felsotegla)
        {
            teglalap(100, 200, alsotegla);
            JE(10,10);
            teglalap(80, 180, felsotegla);
        }

        void kicsitéglalapok_egymáson(Color alsó, Color felső)
        {
            teglalap(100, 40, alsó);
            Előre(10);
            teglalap(80, 30, felső);
        }

        void kicsitéglalapok_egymáson_jobboldal(Color alsó, Color felső)
        {
            teglalap(100, 40, alsó);
            JE(10, 10);
            teglalap(80, 30, felső);
        }

        void körsor(Color alap, Color körök)
        {
            for (int i = 0; i < 4; i++)
            {
                negyzet(100, alap);
                JE(10, 50);
                kör(80, körök);
                JE(-10, -50);
                oldalazz(100);
            }
        }
    }
}
