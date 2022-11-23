using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRadix_Sort
{
    public partial class Form1 : Form
    {
        int[] arreglo;
        public Form1()
        {
            InitializeComponent();
        }
        private void creararreglo()
        {
            int n= int.Parse(TxtTamaño.Text);
            arreglo = new int[n];
            Aleatorio();
        }
        private void Aleatorio()
        {
            Random R = new Random();
            int Minimo = 0;
            int Maximo = 100;
            for (int I = 0; I < arreglo.Length; I++)
            {
                arreglo[I] = R.Next(Minimo, Maximo + 1);
            }
        }
        private void Sort()
        {
            creararreglo();
            int i, j;
            int[] tmp = new int[arreglo.Length];
            if (LtbDesordenada.Items.Count == 0)
            {
                for (int shift = 31; shift > -1; --shift)
                {
                    j = 0;
                    for (i = 0; i < arreglo.Length; i++)
                    {
                        bool move = arreglo[i] << shift >= 0;
                        if (shift == 0 ? move : move)
                        {
                            arreglo[i - j] = arreglo[i];
                        }
                        else
                        {
                            tmp[j++] = arreglo[i];
                        }
                    }
                    Array.Copy(tmp, 0, arreglo, arreglo.Length - j, j);
                }
            }
            else
            {
                for (int shift = 31; shift > -1; --shift)
                {
                    j = 0;
                    for (i = 0; i < arreglo.Length; i++)
                    {
                        bool move = arreglo[i] << shift >= 0;
                        if (shift == 0 ? move : move)
                        {
                            arreglo[i - j] = arreglo[i];
                        }
                        else
                        {
                            tmp[j++] = arreglo[i];
                        }
                    }
                    Array.Copy(tmp, 0, arreglo, arreglo.Length - j, j);
                }
            }
           
        }
        private void Mostrar()
        {
            creararreglo();
            foreach (var item in arreglo)
            {
                LtbDesordenada.Items.Add(""+item);
            }
            Stopwatch tiempo = Stopwatch.StartNew();
            tiempo.Start();
            Sort();
            tiempo.Stop(); 
            foreach (var item in arreglo)
            {
                LtbOrdenada.Items.Add("" + item);
            }
            string mostrarT = "";
            mostrarT = tiempo.Elapsed.ToString();
            LtbTiempo.Items.Insert(0, mostrarT);
        }
        private void vaciar()
        {
            LtbDesordenada.Items.Clear();
            LtbOrdenada.Items.Clear();
            LtbTiempo.Items.Clear();
            TxtTamaño.Clear();
        }
        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            Mostrar();
        }
        private void BtnVaciar_Click(object sender, EventArgs e)
        {
            vaciar();
        }
    }
}
