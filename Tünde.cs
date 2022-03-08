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

        void oldalazz(double meret)
        {
            Tollat(fel);
            Jobbra(90);
            Előre(meret);
            Balra(90);
            Tollat(le);
        }

       void lopakodva_előre(double meret)
        {
            Tollat(fel);
            Előre(meret);
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
            Odatölt(45, fuggolegesoldal / 2, szin);
        }

        void negyzet(double meret, Color szin)
        {
            Tollszín(szin);
            for (int i = 0; i < 2; i++)
            {
                Előre(meret);
                Jobbra(90);
                Előre(meret);
                Jobbra(90);
            }
            Odatölt(45, meret / 2, szin);
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

        void rombusz_a_teglan( Color teglalap_szin, Color rombusz_szin, double meret)
        {
            teglalap(meret, meret*1.17, teglalap_szin);
            lopakodva_előre(meret/2);
            rombusz(meret*0.76, rombusz_szin);
            lopakodva_előre(-meret / 2);
            oldalazz(meret * 1.17);
        }

        void tegla_a_teglan(Color alsotegla, Color felsotegla, double meret)
        {
            teglalap(meret, meret*1.8, alsotegla);
            JE(meret/10,meret/10);
            teglalap(meret*0.80, meret*1.60, felsotegla);
            JE(-meret / 10, -meret / 10);
            oldalazz(meret * 1.8);
        }

        void kicsitéglalapok_egymáson(Color alsó, Color felső, double meret)
        {
            teglalap(meret, meret*0.45, alsó);
            Előre(meret/10);
            teglalap(meret *0.80, meret *0.35, felső);
            Hátra(meret / 10);
            oldalazz(meret * 0.45);
        }

        void kicsitéglalapok_egymáson_jobboldal(Color alsó, Color felső, double meret)
        {
            teglalap(meret, meret*0.45, alsó);
            JE(meret/10, meret/10);
            teglalap(meret*0.80, meret *0.35, felső);
            JE(-(meret / 10), -(meret / 10));
            oldalazz(meret * 0.45);
        }

        void körsor(Color alap, Color körök, int db, double meret)
        {
            for (int i = 0; i < db; i++)
            {
                teglalap(meret, meret*1.3, alap);
                JE(meret/3, meret/2);
                kör(meret*0.6, körök);
                JE(-meret/3, -meret/2);
                oldalazz(meret*1.3);
            }
            oldalazz(-(meret *1.3* db));
        }

        void félkör_balra(double magasság, Color szin)
        {
            Tollszín(szin);
            Előre(magasság);
            Hátra(magasság);
            Balra(90);
            Ív(180, magasság / 2);
            Jobbra(90);
            Odatölt(20, magasság / 2, szin);
            Előre(magasság);
            Jobbra(180);
        }

        void félkör_jobbra(double magasság, Color szin)
        {
            Tollszín(szin);
            Előre(magasság);
            Jobbra(90);
            Ív(180, magasság / 2);
            Jobbra(90);
            Odatölt(30, magasság / 2, szin);
        }

        void ovális_a_téglán(Color alap, Color ovális, double meret)
        {
            double egypontnyolc = 1.8;
            double nullaponthet = 0.7;
            double nullapontotot = 0.55;
            double nullapontkilenc = 0.9;
            double nullapontnullaot = 0.05;

            teglalap(meret, meret*egypontnyolc,alap);
            JE(meret*nullapontotot, meret*nullapontnullaot);
            félkör_balra(meret*nullapontkilenc, ovális);
            teglalap(meret*nullapontkilenc,meret*nullaponthet, ovális);
            oldalazz(meret*nullaponthet);
            félkör_jobbra(meret*nullapontkilenc, ovális);
            JE(-(meret * nullaponthet+ meret * nullapontotot), -meret * nullapontnullaot);
            oldalazz(meret * egypontnyolc);
        }

        void téglasor(Color alap, Color felső, double meret)
        {
            kicsitéglalapok_egymáson(alap, felső, meret);
            oldalazz(meret*0.40);
            rombusz_a_teglan(alap, felső, meret);
            oldalazz( meret *0.40);
            tegla_a_teglan(alap, felső, meret);
            oldalazz( meret*0.40);
            ovális_a_téglán(alap, felső, meret);
            oldalazz( meret *0.40);
            tegla_a_teglan(alap, felső, meret);
            oldalazz( meret*0.40);
            rombusz_a_teglan(alap, felső, meret);
            oldalazz(meret*0.40);
            kicsitéglalapok_egymáson_jobboldal(alap, felső, meret);
        }

        void pöttysor_alappal(Color alap, Color pöttyalap, Color pötty, int db, double meret)
        {
            körsor(pöttyalap, pötty, db, meret);
            lopakodva_előre(meret);
            teglalap(meret*3, db * (meret*1.3), alap);
            lopakodva_előre(meret*3);
            körsor(pöttyalap, pötty, db, meret);
            lopakodva_előre(-meret*3 + -meret);
            
        }

        void koronaközép(Color alap, Color pöttyalap, Color pötty, Color téglaalap, double meret)
        {
            pöttysor_alappal(alap, pöttyalap, pötty, 17, meret);
            lopakodva_előre(meret * 1.5);
            téglasor(téglaalap, pöttyalap, meret*2);
            lopakodva_előre(-meret * 1.5);
            oldalazz(-17 * meret*1.3);
        }




        void kereszt_darab(double hosszabb, double rövidebb, Color szin)
        {
            teglalap(hosszabb, rövidebb, szin);
            lopakodva_előre(hosszabb);
            Jobbra(90);
            félkör_balra(rövidebb, szin);
            Balra(90);
            lopakodva_előre(-hosszabb);
        }

        void kereszt(double meret, Color szin)
        {
           
            kereszt_darab(meret*2.50, meret, szin);
            lopakodva_előre(meret);
            Balra(90);
            kereszt_darab(meret*0.50, meret, szin);
            lopakodva_előre(-meret);
            Jobbra(90);
            lopakodva_előre(meret);
            Jobbra(90);
            kereszt_darab(meret*0.50, meret, szin);
            oldalazz(meret*2);
            lopakodva_előre(-meret);
            Balra(90);
        }

        void országalma(double meret, Color szin)
        {
            Balra(90);
            kör(meret, szin);
            Ív(30+90, meret/2);
            Balra(80);
            lopakodva_előre(-meret/10);
            kereszt(meret/3, szin);
            lopakodva_előre(meret / 10);
            Jobbra(80);
            Ív(360-30-90, meret / 2);
        }

        void koronateteje( double meret, Color szin)
        {
            float tollvastag = 14;
            Tollvastagság(tollvastag);
            /*
            Tollszín(Color.Pink);
            Előre(20);          
            Jobbra(30);
            Előre(3 * 20);
            Jobbra(30);
            Előre(4 * 20);
            Jobbra(30);
            Előre(5 * 20);
            Jobbra(30);
            Előre(4 * 20);
            Jobbra(30);
            Előre(3 * 20);
            Jobbra(30);
            Előre(20);
            Jobbra(180);
            Tollszín(Color.Black);
            */
            for (int i = 0; i < 15; i++)
            {
                Tollszín(szin);
                Előre(meret);
                Tollvastagság(1);
                Balra(160);
                if (i==7)
                {
                    Jobbra(90);
                    országalma(meret/1.4,szin);
                    
                }
                else
                {
                    kör(meret/2.5, szin);
                }
                
                Jobbra(160);
                Tollvastagság(tollvastag);
                if (i==0||i==2||i==5||i==9||i==12||i==14)
                {
                    Jobbra(30);
                }
                
            }
            Előre(meret);
            Tollvastagság(1);
            Tollat(fel);
            Jobbra(180);
            for (int i = 0; i < 15; i++)
            {
                Előre(meret);
                if (i == 0 || i == 2 || i == 5 || i == 9 || i == 12 || i == 14)
                {
                    Jobbra(-30);
                }
            }
            Előre(meret);
            Jobbra(180);
            Tollat(le);
        }

        void koronakozeptetovel()
        {
            koronaközép(Color.SaddleBrown, Color.Beige, Color.DarkOliveGreen, Color.Black, 20);
            lopakodva_előre(5 * 20);
            oldalazz(7);
            koronateteje(38.5, Color.Beige);
        }



    }
}
