using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        char[,] aMapa = new char[10, 10];
        int[] pInicial = new int[2];
        int[] pJugador = new int[2];
        int[] pReinicio = new int[2];
        int[] pFinal = new int[2];
        static int maxTurnos = 10;
        int iTurno = 0;


        public Form1()
        {
            InitializeComponent();

            StreamReader srReader = new StreamReader("mapa.txt");

            while (!srReader.EndOfStream)
            {
                for (int j = 0; j <= 9; j++)
                {
                    var linea = srReader.ReadLine().ToCharArray();
                    for (int i = 0; i <= 9; i++)
                    {
                        aMapa[j, i] = linea[i];
                        if (linea[i] == 'I')
                        {
                            pInicial[0] = j;
                            pInicial[1] = i;
                        }
                        else if (linea[i] == 'R')
                        {
                            pReinicio[0] = j;
                            pReinicio[1] = i;
                        }
                        else if (linea[i] == 'F')
                        {
                            pFinal[0] = j;
                            pFinal[1] = i;
                        }
                    }
                }

            }
            Imprimir();
            asignarPosiciones();
        }

        public void Imprimir() {
            string sImpresion = "";
            int iCont = 0;
            foreach (char item in aMapa)
            {
                sImpresion += item + " ";
                iCont++;
                if (iCont == 10)
                {
                    sImpresion += "\r\n";
                    iCont = 0;
                }
            }
            txtbxLaberinto.Text = sImpresion;
            lblTurno.Text = "Turno actual: " + iTurno.ToString();
        }

        public void asignarPosiciones()
        {
            if (pJugador[0] == pInicial[0] && pJugador[1] == pInicial[1])
            {
                aMapa[pInicial[0], pInicial[1]] = 'I';
            }
            


      
           
            for (int j = 0; j <= 9; j++)
            {
                for (int i = 0; i <= 9; i++)
                {
                    if (aMapa[j, i] == 'I')
                    {
                        pInicial[0] = j;
                        pInicial[1] = i;
                    }
                    else if (aMapa[j, i] == 'J')
                    {
                        pJugador[0] = j;
                        pJugador[1] = i;
                    }
                    else if (aMapa[j, i] == 'R')
                    {
                        pReinicio[0] = j;
                        pReinicio[1] = i;
                        
                    }
                    else if (aMapa[i, j] == 'F')
                    {
                        pFinal[0] = j;
                        pFinal[1] = i;
                       
                        
                    }
                  
                   
                }
               
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            aMapa[pInicial[0], pInicial[1]] = 'J';
            pJugador[0] = pInicial[0];
            pJugador[1] = pInicial[1];
            btnStart.Enabled = false;
            Imprimir();
           
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (iTurno == maxTurnos)
            {
                MessageBox.Show(" \n No hay mas turnos.");                
                Application.Restart();
            }
            if (e.KeyCode == Keys.Right)
            {            
                    if (aMapa[pJugador[0], pJugador[1] + 1] != 'X')
                {
                    iTurno++;
                    while (aMapa[pJugador[0], pJugador[1] + 1] != 'X')
                    {
                        aMapa[pJugador[0], pJugador[1]] = ' ';
                        aMapa[pJugador[0], pJugador[1] + 1] = 'J';
                        Imprimir();
                        asignarPosiciones();
                        if (pJugador[1] + 1 > 9)
                        {
                            aMapa[pJugador[0], pJugador[1]] = ' ';
                            pJugador[1] = 0;
                            aMapa[pJugador[0], pJugador[1]] = 'J';
                        }
                        if (pJugador[0] == pReinicio[0] && pJugador[1] == pReinicio[1])
                        {

                            aMapa[pJugador[0], pJugador[1]] = ' ';
                            aMapa[pInicial[0], pInicial[1]] = 'J';
                            aMapa[pReinicio[0], pReinicio[1]] = 'R';
                            Imprimir();
                            asignarPosiciones();
                         }
                         if (pJugador[0] == pFinal[0] && pJugador[1] == pFinal[1])
                        {
                            MessageBox.Show("Felicidades! llegaste al final del laberinto\nTe tomo " + iTurno + " turnos llegar al final");
                            Application.Restart();
                        }
                    }

                }
                
               

            }
            else if (e.KeyCode == Keys.Left)
            {

                if (aMapa[pJugador[0], pJugador[1] - 1] != 'X')
                {
                    iTurno++;
                    while (aMapa[pJugador[0], pJugador[1] - 1] != 'X')
                    {
                        aMapa[pJugador[0], pJugador[1]] = ' ';
                        aMapa[pJugador[0], pJugador[1] - 1] = 'J';
                        Imprimir();
                        asignarPosiciones();
                        if (pJugador[1] - 1 < 0)
                        {
                            aMapa[pJugador[0], pJugador[1]] = ' ';
                            pJugador[1] = 9;
                            aMapa[pJugador[0], pJugador[1]] = 'J';
                        }
                        if (pJugador[0] == pReinicio[0] && pJugador[1] == pReinicio[1])
                        {

                            aMapa[pJugador[0], pJugador[1]] = ' ';
                            aMapa[pInicial[0], pInicial[1]] = 'J';
                            aMapa[pReinicio[0], pReinicio[1]] = 'R';
                            Imprimir();
                            asignarPosiciones();
                         }
                         if (pJugador[0] == pFinal[0] && pJugador[1] == pFinal[1])
                        {
                            MessageBox.Show("Felicidades! llegaste al final del laberinto\nTe tomo " + iTurno + " turnos llegar al final");
                            Application.Restart();
                        }
                    }
                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                if(aMapa[pJugador[0] - 1, pJugador[1]] != 'X')
                {
                    iTurno++;
                    while (aMapa[pJugador[0] - 1, pJugador[1]] != 'X')
                {
                   
                    aMapa[pJugador[0], pJugador[1]] = ' ';
                    aMapa[pJugador[0] - 1, pJugador[1]] = 'J';
                    Imprimir();
                    asignarPosiciones();
                    if (pJugador[0] - 1 < 0)
                    {
                        aMapa[pJugador[0], pJugador[1]] = ' ';
                        pJugador[0] = 9;
                        aMapa[pJugador[0], pJugador[1]] = 'J';
                    }
                        if (pJugador[0] == pReinicio[0] && pJugador[1] == pReinicio[1])
                        {

                            aMapa[pJugador[0], pJugador[1]] = ' ';
                            aMapa[pInicial[0], pInicial[1]] = 'J';
                            aMapa[pReinicio[0], pReinicio[1]] = 'R';
                            Imprimir();
                            asignarPosiciones();
                     }
                        else if (pJugador[0] == pFinal[0] && pJugador[1] == pFinal[1])
                        {
                            MessageBox.Show("Felicidades! llegaste al final del laberinto\nTe tomo " + iTurno + " turnos llegar al final");
                            Application.Restart();
                        }
                    }

                }
           
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (aMapa[pJugador[0] + 1, pJugador[1]] != 'X')
                {
                    iTurno++;
                        while (aMapa[pJugador[0] + 1, pJugador[1]] != 'X')
                    {
                        aMapa[pJugador[0], pJugador[1]] = ' ';
                        aMapa[pJugador[0] + 1, pJugador[1]] = 'J';
                        Imprimir();
                        asignarPosiciones();
                        if (pJugador[0] + 1 > 9)
                        {
                            aMapa[pJugador[0], pJugador[1]] = ' ';
                            pJugador[0] = 0;
                            aMapa[pJugador[0], pJugador[1]] = 'J';
                        }
                        if (pJugador[0] == pReinicio[0] && pJugador[1] == pReinicio[1])
                        {

                            aMapa[pJugador[0], pJugador[1]] = ' ';
                            aMapa[pInicial[0], pInicial[1]] = 'J';
                            aMapa[pReinicio[0], pReinicio[1]] = 'R';
                            Imprimir();
                            asignarPosiciones();
                        }
                         if (pJugador[0] == pFinal[0] && pJugador[1] == pFinal[1])
                        {
                            MessageBox.Show("Felicidades! llegaste al final del laberinto\nTe tomo " + iTurno + " turnos llegar al final");
                            Application.Restart();
                        }
                    }
                }
               
            }
        }
                
    }
}
