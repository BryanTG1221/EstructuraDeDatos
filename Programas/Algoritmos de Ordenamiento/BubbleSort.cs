﻿using System;
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
            //-------------------------------------------------------------------------------
            //----------------------------BUBBLE SORT----------------------------------------

            bool flag = true;
            int temp;
            for (int i = 1; (i <= (Vector.Length - 1)) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < (Vector.Length - 1); j++)
                {
                    if (Vector[j + 1] > Vector[j])
                    {
                        temp = Vector[j];
                        Vector[j] = Vector[j + 1];
                        Vector[j + 1] = temp;
                        flag = true;
                    }
                }
            }

            //-----------------------------------------------------------------------------------
            //------------------------------MOSTRAR ARREGLO ORDENADO-----------------------------
            MessageBox.Show("Se sorteo el arreglo");
            for (int i = 0; i < Tamaño; i++)
            {
                MessageBox.Show("Espacio " + i + ": " + Vector[i]);
            }

        }

       

    }
}
