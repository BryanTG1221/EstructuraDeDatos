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
            

            ShakerSort(Vector);
            //-----------------------------------------------------------------------------------
            //------------------------------MOSTRAR ARREGLO ORDENADO-----------------------------
            MessageBox.Show("Se sorteo el arreglo");
            for (int i = 0; i < Tamaño; i++)
            {
                MessageBox.Show("Espacio " + i + ": " + Vector[i]);
            }

        }


        //-------------------------------------------------------------------------------------------
        //------------------------------------------SHAKER SORT-------------------------------------
        //----------------------------------------------------------------------------------------

        public static void ShakerSort(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                bool intercambio = false;
                for (int j = i; j < array.Length - i - 1; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        int temporal = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temporal;
                        intercambio = true;
                    }
                }
                for (int j = array.Length - 2 - i; j > i; j--)
                {
                    if (array[j] > array[j - 1])
                    {
                        int temporal = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temporal;
                        intercambio = true;
                    }
                }
                if (!intercambio) break;
            }
        }

        //----------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------

    }
}
