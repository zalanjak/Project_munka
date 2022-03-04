using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LogoKaresz
{
	public partial class Form1 : Form
	{
		


		void FELADAT()
		{
			// Teleport(közép.X, közép.Y+150, észak);
			//körsor(Color.Beige, Color.DarkOliveGreen, 1, 100);
			//kicsitéglalapok_egymáson(Color.Black, Color.Beige,100);
			//kicsitéglalapok_egymáson_jobboldal(Color.Black, Color.Beige,100);
			//tegla_a_teglan(Color.Black, Color.Beige,100);
			//rombusz_a_teglan(Color.Black, Color.Beige, 100);
			//ovális_a_téglán(Color.Black, Color.Beige, 100);

			//téglasor(Color.Black, Color.Beige, 50);
			//pöttysor_alappal(Color.SaddleBrown, Color.Beige, Color.DarkOliveGreen, 10, 20);


			pöttysor_alappal(Color.SaddleBrown, Color.Beige, Color.DarkOliveGreen, 17, 30);
			lopakodva_előre(30 * 1.5);
			téglasor(Color.Black, Color.Beige, 60);

		}
	}
}
