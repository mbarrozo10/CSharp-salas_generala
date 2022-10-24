using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionalidad.clases
{
    public class Jugador
    {
        string nombre;
        int puntaje;
        int generala;
        int dobleGenerala;
        int full;
        int poker;
        int escalera;



        public Jugador(string nombre, int puntaje)
        {
            Nombre = nombre;
            Puntaje = puntaje;
            generala = 0;
            dobleGenerala = 0;
            full = 0;
            poker = 0;
            escalera = 0;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Puntaje { get => puntaje; set => puntaje = value; }
        public int Generala { get => generala; set => generala = value; }
        public int DobleGenerala { get => dobleGenerala; set => dobleGenerala = value; }
        public int Full { get => full; set => full = value; }
        public int Poker { get => poker; set => poker = value; }
        public int Escalera { get => escalera; set => escalera = value; }


        public bool CheckGenerala(int[] tirada)
        {
            if (tirada[0] == tirada[1] && tirada[1] == tirada[2]
                && tirada[2] == tirada[3] && tirada[3] == tirada[4])
            {
                return true;
            }

            return false;
        }

        public bool CheckEscalera(int[] tirada)
        {
            for (int i = 0; i < tirada.Length - 1; i++)
            {
                for (int j = i + 1; j < tirada.Length; j++)
                {
                    if (tirada[j] == tirada[i])
                    {

                        return false;
                    }
                }
            }

            return true;
        }


        public bool CheckPoker(int[] tirada)
        {
            int contador = 0;
            Ordenar(tirada);
            for (int i = 0; i < tirada.Length - 1; i++)
            {
                for (int j = i + 1; j < tirada.Length; j++)
                    if (tirada[i] == tirada[j])
                    {
                        contador++;
                        if (contador == 4)
                        {
                            return true;
                        }
                    }
            }
            return false;
        }

        public bool CheckFull(int[] tirada)
        {
            int contadorUno = 1;
            int contadorDos = 1;
            bool numeroDistinto = false;
            Ordenar(tirada);
            for (int i = 0; i < tirada.Length - 1; i++)
            {
                for (int j = i + 1; j < tirada.Length; j++)
                    if (tirada[i] == tirada[j])
                    {
                        if (numeroDistinto)
                        {
                            contadorDos++;
                        }
                        else
                        {
                            contadorUno++;
                        }
                        if (contadorUno == 3 && contadorDos == 2 || contadorDos == 3 && contadorUno == 2)
                        {
                            return true;
                        }
                        break;

                    }
                    else
                    {
                        numeroDistinto = true;
                    }
            }
            return false;
        }
        private static void Ordenar(int[] vector)
        {
            for (int x = 0; x < vector.Length - 1; x++)
            {
                for (int k = 0; k < vector.Length - 1 - x; k++)
                {

                    if (vector[k] < vector[k + 1])
                    {
                        int aux;
                        aux = vector[k];
                        vector[k] = vector[k + 1];
                        vector[k + 1] = aux;
                    }

                }
            }
        }
    }
}
