using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace LogoKaresz
{
    public partial class Form1
    {
        void Odatölt(double szög, double hossz, Color szín)
        {
            Tollat(false);
            Jobbra(szög);
            Előre(hossz);
            Tölt(szín);
            Hátra(hossz);
            Balra(szög);
            Tollat(true);
        }
        #region
        void Ív_balra(double fok, double r)//Az Ív-et kimásoltam, aztán átírtam balrára
        {
            double a = 2 * r * Math.Tan(Math.PI / 360);
            Előre(a / 2);
            for (int i = 0; i < fok - 1; i++)
            {
                Balra(1);
                Előre(a);
            }
            Jobbra(1);
            Előre(a / 2);
        }
        void hullámosVonal_jobbra(double m)
        {
            Jobbra(30);
            for (int i = 0; i < 2; i++)
            {
                Ív_balra(30, m / 5);
                Balra(30);
                Ív(30, m / 5);
                Jobbra(27.5);//Azért vannak néhol ilyen random számok, mert az Ívekkel a szögek egy kicsit furcsán viselkednek
            }
            Balra(30);
        }
        void Görbe_nudli(double m, Color szín)
        {
            hullámosVonal_jobbra(m);
            Ív_balra(180, m / 25);
            using (new Rajzol(false))
                Előre(m / 2.5);
            Fordulj(180);
            hullámosVonal_jobbra(m);
            Odatölt(30, m / 30, szín);
            Fordulj(180);
            using (new Rajzol(false))
                Előre(m / 2.5);
        }
        void Nudlik(double m, Color szín)
        {
            Fordulj(180);
            for (int i = 0; i < 3; i++)
            {
                Görbe_nudli(m, szín);
                using (new Rajzol(false))
                    Ív(180, m / 25);
            }
        }
        #endregion
        //Nudlik
        #region
        void Lóhere(double m, Color szín)
        {
            Jobbra(30);
            for (int i = 0; i < 3; i++)
            {
                Ív(240, m / 10);
                Balra(120);
            }
            Balra(30);
            Odatölt(180, m / 30, szín);
        }
        void Három_lóhere(double m, Color szín)
        {
            Lóhere(m / 1.5, szín);//Első
            for (int i = 0; i < 3; i++)
            {
                using (new Rajzol(false))
                    Ív(180, m / 20);
                Fordulj(180);
            }
            Lóhere(m / 1.5, szín);//Második
            Jobbra(30);
            Ív(240, m / 15);
            Balra(120);
            Ív(120, m / 15);
            Jobbra(90);
            for (int i = 0; i < 3; i++)
            {
                using (new Rajzol(false))
                    Ív_balra(180, m / 40);
                Fordulj(180);
            }
            Balra(6);
            Fordulj(180);
            using (new Rajzol(false))
                Előre(m / 20);
            Fordulj(180);
            Lóhere(m / 1.5, szín);//Harmadik
            using (new Rajzol(false))
                Előre(m / 20);
            Balra(90);
            Ív(360, m / 20);//Közepén a kör
            Odatölt(90, m / 30, szín);
        }
        #endregion
        //Lóherék
        void Alakzat(double m, Color szín, Color szín2)
        {
            Nudlik(m, szín);
            for (int i = 0; i < 5; i++)
            {
                using (new Rajzol(false))
                    Ív(180, m / 25);
                Balra(180);
                
            }
            using (new Rajzol(false))
            {
                hullámosVonal_jobbra(m);
                Balra(90);
                Ív(180, m / 20);
                Jobbra(91);
            }
            Három_lóhere(m, szín);
        }

        void Búra(double m, Color szín, Color szín2)
        {
            Előre(m / 4);//Külső búra
            Ív(75, m / 8);
            Balra(120);
            Ív(270, m / 20);
            Jobbra(-120);
            Ív(75, m / 8);
            Előre(m / 4);
            Jobbra(90);//Belső búra
            using(new Rajzol(false))
                Előre(m / 20);
            Jobbra(90);
            Előre(m / 4.5);
            Ív_balra(180, m  /12.5);
            Balra(2);
            Előre(m / 4.5);
            Balra(90);
            Előre(m / 6);
            Fordulj(180);//Rózsa
            Előre(m / 13.5);
            Jobbra(90);
            using(new Rajzol(false))
                Előre(m  /50);
            Balra(90);
            Ív(90, m / 15);
            Előre(m / 7);
            Jobbra(120);
            Előre(m  / 35);
            Balra(120);
            Előre(m / 15);
            Jobbra(120);
            Előre(m  /30);
            Balra(60);
            Előre(m / 30);        
            Jobbra(120);
            Előre(m / 15);
            Balra(120);
            Előre(m / 35); 
            Jobbra(120);
            Előre(m / 7);
            Ív(90, m / 15);
            Odatölt(-10, m / 40, szín);
            Balra(90);
            Odatölt(-180, m / 40, szín2);
            using(new Rajzol(false))//Helyre igazodás
                Előre(m  /50);
            Balra(90);
            Hátra(m / 9);
            Előre(m / 3.95);
            Balra(90);
            Odatölt(-80, m / 40, szín2);
        }
        void Sátor(double m, Color szín, Color szín2)
        {
            Jobbra(90);
            Balra(65);//Külső háromszög
            Előre(m / 2);
            Balra(25);
            for (int i = 0; i < 3; i++)
			{
                Balra(90);
                Ív(180, m / 20);
			}
            Balra(115);
            Előre(m / 2);
            Jobbra(115);
            Előre(m / 1.91);
            Hátra(m / 10);//Belső háromszög
            Jobbra(115);
            Előre(m / 2.7);
            Jobbra(130);
            Előre(m / 2.7);
            Jobbra(115);
            Előre(m / 6.5);
            Jobbra(90);
            using(new Rajzol(false))
                Előre(m / 25);
            Fordulj(180);
            Lóhere(m / 2, Color.White);
            Odatölt(0, m / 30, szín);
            Odatölt(-180, m / 40, szín2);
            using(new Rajzol(false))
                Előre(m / 25);
            Balra(90);
            Előre(m / 3.85);
            Balra(90);
            Odatölt(-40, m / 40, szín2);
        }
        void Búrasátor(double m, Color szín, Color szín2)
        {
            Búra(m, szín, szín2);
            Sátor(m / 1.2, szín, szín2);
        }
        void Sátorbúra(double m, Color szín, Color szín2)
        {
            Sátor(m / 1.2, szín, szín2);
            Búra(m, szín, szín2);
        }
    }
}
