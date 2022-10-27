using Azure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionalidad.clases
{
    public class Jugador
    {
        int id;
        string nombre;
        string apellido;
        string usuario;
        int puntaje;
        int generala;
        int dobleGenerala;
        int full;
        int poker;
        int escalera;

        public Jugador()
        {

        }
        public Jugador(int id,string nombre, string apellido, string usuario):this()
        {
            Nombre = nombre;
            this.Apellido = apellido;
            this.Usuario = usuario;
            this.id = id;
            ReiniciarValores();
        }


        public int Id { get { return id; } }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Usuario { get => usuario; set => usuario = value; }
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
        public static void Ordenar(int[] vector)
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

        private void ReiniciarValores()
        {
            this.generala = 0;
            this.full = 0;
            this.escalera = 0;
            this.poker = 0;
            this.dobleGenerala = 0;
            this.puntaje = 0;
        }
    }
}
