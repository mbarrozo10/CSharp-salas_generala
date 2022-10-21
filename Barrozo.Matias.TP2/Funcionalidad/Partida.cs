using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Funcionalidad
{
    public class Partida
    {
        int id;
        DateTime date;
        List<Jugador> jugadores;
        string ganador;
        List<Dados> dados;
        int cantidadJugadores;
        

        public Partida(List<Jugador> jugadores, string ganador, int cantidad,DateTime date, int id) : this(ganador, cantidad,date,id)
        {
            this.jugadores = jugadores;
            this.dados = CargarDados();
        }
        public Partida(string ganador, int cantidad,DateTime date, int id)
        {
            this.ganador = ganador;
            this.cantidadJugadores = cantidad;
            this.id = id;
            this.date = date;
        }


        public List<Jugador> Jugadores { get => jugadores; set => jugadores = value; }
        public string Ganador { get => ganador; set => ganador = value; }
        public int CantidadJugadores { get => cantidadJugadores; set => cantidadJugadores = value; }
        
        public int Id
        {
            get { return id; }
        }

        public DateTime Date
        {
            get { return date; }
        }

        private List<Dados> CargarDados()
        {
            List<Dados> dados= new List<Dados>();
            dados.Add(new Dados());
            dados.Add(new Dados());
            dados.Add(new Dados());
            dados.Add(new Dados());
            dados.Add(new Dados());

            return dados;
        }

        public int[] TirarDados(int cantidad)
        {
            int[] tirada= new int[cantidad];
            Random rnd = new Random();
            for(int i= 0; i < cantidad; i++)
            {
                Dados dadoAux = this.dados[i];
                tirada[i]= dadoAux.Caras[rnd.Next(1,6)];
            }

            return tirada;
        }

        public static bool CheckGenerala(int[] tirada)
        {
            if (tirada[0] == tirada[1] && tirada[1] == tirada[2]
                && tirada[2] == tirada[3] && tirada[3] == tirada[4])
            {
                return true;
            }

            return false;
        }
        
        public static bool CheckEscalera(int[] tirada)
        {
            for(int i=0; i< tirada.Length - 1; i++)
            {
                for(int j=i+1; j<tirada.Length; j++)
                {
                    if(tirada[j] == tirada[i])
                    {
                        
                        return false;
                    }
                }
            }

            return true;
        }


        public static bool CheckPoker(int[] tirada)
        {
            int contador = 0;
            Ordenar(tirada);
            for (int i = 0; i < tirada.Length -1; i++)
            {
                for(int j =i+1; j < tirada.Length; j++)
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

        public static bool CheckFull(int[] tirada)
        {
            int contadorUno = 1;
            int contadorDos = 1;
            bool numeroDistinto = false;
            Ordenar(tirada);
            for (int i = 0; i < tirada.Length - 1; i++)
            {
                for (int j = i+1; j < tirada.Length; j++)
                    if (tirada[i] == tirada[j])
                    {
                        if (numeroDistinto)
                        {
                            contadorDos++;
                        }else
                        {
                           contadorUno++;
                        }
                        if ((contadorUno == 3 && contadorDos==2) || (contadorDos==3 && contadorUno==2) )
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
