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
    public partial class Inicio_CL : Form
    {
        public Inicio_CL()
        {
            InitializeComponent();
        }

        private void Inicio_CL_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            G1_NumeroAleatorio btnNumero = new G1_NumeroAleatorio();
            btnNumero.Show();                                      //Mostrar el formulario "G1_NumeroAleatorio"                      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            piedra_papel_tijera btnJuego = new piedra_papel_tijera();
            btnJuego.Show();                                          //Mostrar el formulario "piedra_papel_tijera"
        }
    }
}
