using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_19
{
    public partial class frmEjemplo19 : Form
    {
        public frmEjemplo19()
        {
            InitializeComponent();
        }

        private void cmdOrdenamiento_Click(object sender, EventArgs e)
        {
            // Almacena números aleatorios en un vector, los ordena ascendente y los despliega
            // Ejemplo 19
            // Leslie Giselle Avila Romero 23211918

            // Declaración de variables
            int R, a, b, temp;
            int cont = 10;
            int[] N;

            // Generador de aleatorios enteros
            Random aleatorio = new Random();

            // Creación de la referencia al arreglo
            N = new int[10];

            // Entrada de números aleatorios al vector y desplegado
            for (R=0; R < 10; R++)
            {
                N[R] = aleatorio.Next(100);
                txtOriginal.Text = txtOriginal.Text + N[R].ToString() + "\r\n";
            }
            // Ordenamiento de burbuja
            for (a=1; a<cont;++a)
                for (b= cont-1; b>=a; --b)
                    if (N[b-1]> N[b])
                    {
                        temp = N[b - 1];
                        N[b - 1] = N[b];
                        N[b] = temp;
                    }
            // Desplegado del vector ordenado
            for (R=0; R < 10; R++)
            {
                txtOrdenado.Text = txtOrdenado.Text + N[R].ToString() + "\r\n";
            }
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            txtOrdenado.Clear();
            txtOriginal.Clear();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
