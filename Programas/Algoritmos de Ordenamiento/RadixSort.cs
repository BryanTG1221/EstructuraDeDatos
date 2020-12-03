using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodo_Ordenamiento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

         Random RandomInt = new Random();
        Algoritmos Sorteadores = new Algoritmos();
        static int Tamaño;


        private void button1_Click(object sender, EventArgs e)
        {
            Tamaño = Convert.ToInt32(textBox1.Text);
            int[] Vector = new int[Tamaño];
            Random randomLOL = new Random();

            for (int i = 0; i < Vector.Length; i++)
            {
                Vector[i] = randomLOL.Next(0, 100);
            }

            for (int i = 0; i < Tamaño; i++)
            {
                MessageBox.Show("Espacio " + i + " : " + Vector[i]);
            }
            

            RadixSort(Vector);
            //-----------------------------------------------------------------------------------
            //------------------------------MOSTRAR ARREGLO ORDENADO-----------------------------
            MessageBox.Show("Se sorteo el arreglo");
            for (int i = 0; i < Tamaño; i++)
            {
                MessageBox.Show("Espacio " + i + ": " + Vector[i]);
            }

        }

        //----------------------------------------------------------------------------------------
        //--------------------------------------------RADIX SORT----------------------------
        //-----------------------------------------------------------------------------
        static void RadixSort(int[] Arraysend)
        {
            int i, j;
            int[] tenporal = new int[Arraysend.Length];
            for (int cambio = 31; cambio > -1; --cambio)
            {
                j = 0;
                for (i = 0; i < Arraysend.Length; ++i)
                {
                    bool move = (Arraysend[i] << cambio) >= 0;
                    if (cambio == 0 ? !move : move)
                        Arraysend[i - j] = Arraysend[i];
                    else
                        tenporal[j++] = Arraysend[i];
                }
                Array.Copy(tenporal, 0, Arraysend, Arraysend.Length - j, j);
            }
        }

        //-----------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------

    }
}
