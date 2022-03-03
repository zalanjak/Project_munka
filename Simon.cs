using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LogoKaresz
{
    public partial class Form1
    {
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
                Jobbra(27.5);
            }
            Balra(30);
        }
        void Görbe_nudli(double m)
        {
            hullámosVonal_jobbra(m);
            Ív_balra(180, m / 25);
            using (new Rajzol(false))
                Előre(m / 2.5);
            Fordulj(180);
            hullámosVonal_jobbra(m);
            Fordulj(180);
            using (new Rajzol(false))
                Előre(m / 2.5);
        }
        void Nudlik(double m)
        {
            Fordulj(180);
            for (int i = 0; i < 3; i++)
            {
                Görbe_nudli(m);
                using (new Rajzol(false))
                    Ív(180, m / 25);
            }
        }
        #endregion 
        //Nudlik

        void Lóhere(double m)
        {
            Jobbra(30);
            for (int i = 0; i < 3; i++)
            {
                Ív(240, 10);
                Balra(120);
            }
            
        }
    }
}
