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
            

            shellSort(Vector,Tamaño);
            //-----------------------------------------------------------------------------------
            //------------------------------MOSTRAR ARREGLO ORDENADO-----------------------------
            MessageBox.Show("Se sorteo el arreglo");
            for (int i = 0; i < Tamaño; i++)
            {
                MessageBox.Show("Espacio " + i + ": " + Vector[i]);
            }

        }

        //-----------------------------------------------------------------------------------------
        //----------------------------------SHELL SORT-------------------------------------------
        //----------------------------------------------------------------------------------

        static void shellSort(int[] arr, int array_size)
        {
            int i, j, inc, temp;
            inc = 3;
            while (inc > 0)
            {
                for (i = 0; i < array_size; i++)
                {
                    j = i;
                    temp = arr[i];
                    while ((j >= inc) && (arr[j - inc] > temp))
                    {
                        arr[j] = arr[j - inc];
                        j = j - inc;
                    }
                    arr[j] = temp;
                }
                if (inc / 2 != 0)
                    inc = inc / 2;
                else if (inc == 1)
                    inc = 0;
                else
                    inc = 1;
            }
        }

        //-----------------------------------------------------------------------------
        //--------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------

    }
}
