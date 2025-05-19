using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumeroAletorio_CL
{
    public partial class piedra_papel_tijera : Form 
    {
       
        Random rand = new Random(); 
        int aleatorio = 0;

        public piedra_papel_tijera()
        {
            InitializeComponent();
        }

        private void btnPiedra_Click_1(object sender, EventArgs e)
        {
            aleatorio = rand.Next(1, 4);
            if (aleatorio == 1)
            {
                MessageBox.Show($"Tu compañero de juego ha sacado Piedra. Es un empate");
            }
            if (aleatorio == 2)
            {
                MessageBox.Show($"Tu compañero de juego ha sacado Papel. Has perdido");
            }
            if (aleatorio == 3)
            {
                MessageBox.Show($"Tu compañero de juego ha sacado Tijera. ¡Has ganado!");
            }
        }
        private void btnPapel_Click(object sender, EventArgs e)
        {
            aleatorio = rand.Next(1, 4);
            if (aleatorio == 2)
            {
                MessageBox.Show($"Tu compañero de juego ha sacado Papel. Es un empate");
            }
            if (aleatorio == 3)
            {
                MessageBox.Show($"Tu compañero de juego ha sacado Tijera. Has perdido");
            }
            if (aleatorio == 1)
            {
                MessageBox.Show($"Tu compañero de juego ha sacado Piedra. ¡Has ganado!");
            }
        }

        private void btnTijera_Click(object sender, EventArgs e)
        {
            aleatorio = rand.Next(1, 4);
            if (aleatorio == 3)
            {
                MessageBox.Show($"Tu compañero de juego ha sacado Tijera. Es un empate");
            }
            if (aleatorio == 1)
            {
                MessageBox.Show($"Tu compañero de juego ha sacado Piedra. Has perdido");
            }
            if (aleatorio == 2)
            {
                MessageBox.Show($"Tu compañero de juego ha sacado Papel. ¡Has ganado!");
            }
        }
        
    }
}
