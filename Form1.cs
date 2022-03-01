using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LogoKaresz
{
	public partial class Form1 : Form
	{
		/* Függvények */

		void Kedvenc_szín()
        {
			MessageBox.Show("Zöld");
        }

		/* Függvények vége */
		void FELADAT()
		{
            /* Ezt indítja a START gomb! */
            // Teleport(közép.X, közép.Y+150, észak);
            MessageBox.Show("Hello vilag!");
			Köszön();

		}
	}
}
