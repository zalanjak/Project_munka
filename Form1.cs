using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace LogoKaresz
{
	public partial class Form1 : Form
	{
		/* Függvények */


		/* Függvények vége */
		void FELADAT()
		{
			/* Ezt indítja a START gomb! */
			// Teleport(közép.X, közép.Y+150, észak);
			//Fordulj(180);
            using (new Frissítés(false))
            {
				//Jobbra(90);
				Alakzat(200, Color.DarkOliveGreen);
				/*Búrasátor(200, Color.DarkOliveGreen, Color.Beige);
				Jobbra(90);
				using(new Rajzol(false))
					Előre(100);
				Balra(90);
				Sátorbúra(200, Color.DarkOliveGreen, Color.Beige);*/
			}
		}
	}
}
