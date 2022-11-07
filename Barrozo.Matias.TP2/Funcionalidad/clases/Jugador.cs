using Azure.Core;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Funcionalidad.clases
{
    public class Jugador
    {
        Usuario usuario;
        int turnosJugados;
        bool terminoTurno;
        int puntaje;
        int generala;
        int dobleGenerala;
        int full;
        int poker;
        int escalera;
        int uno;
        int dos;
        int tres;
        int cuatro;
        int cinco;
        int seis;
        public delegate void DTiradas(int[] tirada);
        public DTiradas del;
        public Jugador(Usuario usuario)
        {
            this.usuario = usuario;
            turnosJugados = 1;
            ReiniciarValores();
            del = RevisarEscalera;
            del += RevisarFull;
            del += RevisarPoker;
            del += RevisarGenerala;
            del += AsignarANumeros;
        }

      
        public int Puntaje { get => puntaje; set => puntaje = value; }
        public int Generala { get => generala; set => generala = value; }
        public int DobleGenerala { get => dobleGenerala; set => dobleGenerala = value; }
        public int Full { get => full; set => full = value; }
        public int Poker { get => poker; set => poker = value; }
        public int Escalera { get => escalera; set => escalera = value; }
        public int Uno { get => uno; set => uno = value; }
        public int Dos { get => dos; set => dos = value; }
        public int Tres { get => tres; set => tres = value; }
        public int Cuatro { get => cuatro; set => cuatro = value; }
        public int Cinco { get => cinco; set => cinco = value; }
        public int Seis { get => seis; set => seis = value; }
        public bool TerminoTurno { get => terminoTurno; set => terminoTurno = value; }
        public Usuario Usuario { get => usuario; set => usuario = value; }
        public int TurnosJugados { get => turnosJugados; set => turnosJugados = value; }

        public void RevisarGenerala(int[] tirada)
        {
            if ((tirada[0] == tirada[1] && tirada[1] == tirada[2]
                && tirada[2] == tirada[3] && tirada[3] == tirada[4])&& generala==0)
            {
                generala = 50;
                TerminoTurno = true;
            }else if((tirada[0] == tirada[1] && tirada[1] == tirada[2]
                && tirada[2] == tirada[3] && tirada[3] == tirada[4]) && dobleGenerala == 0)
            {
                dobleGenerala = 50;
                TerminoTurno = true;

            }

        }

        public void RevisarEscalera(int[] tirada)
        {
            Ordenar(tirada);
            if (tirada[4]+1 == tirada[3] && tirada[3]+1 == tirada[2]&& tirada[2]+1 == tirada[1] && tirada[1]+1 == tirada[0] )
            {
                if(escalera == 0)
                {
                    escalera = 20;
                    TerminoTurno = true;
                    turnosJugados = 1;

                }
            }
        }


        public void RevisarPoker(int[] tirada)
        {
            int contador = 0;
            Ordenar(tirada);
            for (int i = 0; i < tirada.Length - 1; i++)
            {
                for (int j = i + 1; j < tirada.Length; j++)
                {
                    if (tirada[i] == tirada[j])
                    {
                        contador++;
                        if ((contador == 4 && poker==0) && !terminoTurno)
                        {
                            poker = 40;
                            TerminoTurno = true;
                            turnosJugados = 1;
                            break;
                        }
                    }

                }
            }
        }

        public void RevisarFull(int[] tirada)
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
                        if ((contadorUno == 3 && contadorDos == 2 || contadorDos == 3 && contadorUno == 2)&& full==0 && !terminoTurno)
                        {
                            full = 30;
                            TerminoTurno = true;
                            turnosJugados = 1;

                        }
                        break;

                    }
                    else
                    {
                        numeroDistinto = true;
                    }
            }
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

        public void AsignarANumeros(int[] dadosEnMesa)
        {
            if (!terminoTurno && turnosJugados==3)
            {
                int vueltasEnWhile = 0;
                int numeroRepetido = 0; 
                bool salir =false;
                int numeroSumar= Partida.GuardarNumero(dadosEnMesa);
                turnosJugados = 1;
                do
                {
                    switch (numeroSumar)
                    {
                        case 1:
                            if (Uno == 0)
                            {
                                if (terminoTurno)
                                {
                                    Uno = -1;
                                    salir = true;
                                }  
                                else if (!salir)
                                {
                                    Uno = BuscarCantidad(dadosEnMesa, numeroSumar) * numeroSumar;
                                    salir = true;
                                }
                                else
                                {
                                    numeroSumar = Tachar(dadosEnMesa, numeroRepetido);
                                }
                            }
                            break;
                        case 2:
                            if (Dos == 0)
                            {
                                if (!salir)
                                {
                                    Dos = BuscarCantidad(dadosEnMesa, numeroSumar) * numeroSumar;
                                    salir = true;
                                }
                                else if (terminoTurno)
                                {
                                    Dos = -1;
                                    salir = true;
                                }
                                else
                                {
                                    numeroSumar = Tachar(dadosEnMesa, numeroRepetido);
                                }
                            }

                            break;
                        case 3:
                            if (Tres == 0)
                            {
                                if (!salir)
                                {
                                    Tres = BuscarCantidad(dadosEnMesa, numeroSumar) * numeroSumar;
                                    salir = true;
                                }
                                else if (terminoTurno)
                                {
                                    Tres = -1;
                                    salir = true;
                                }
                                else
                                {
                                    numeroSumar = Tachar(dadosEnMesa, numeroRepetido);
                                }
                            }
                            break;
                        case 4:
                            if (Cuatro == 0)
                            {
                                if (!salir)
                                {
                                    Cuatro = BuscarCantidad(dadosEnMesa, numeroSumar) * numeroSumar;
                                    salir = true;
                                }
                                else if (terminoTurno)
                                {
                                    Cuatro = -1;
                                    salir = true;
                                }
                                else
                                {
                                    numeroSumar = Tachar(dadosEnMesa, numeroRepetido);
                                }
                            }
                            break;
                        case 5:
                            if (Cinco == 0)
                            {
                                if (!salir)
                                {
                                    Cinco = BuscarCantidad(dadosEnMesa, numeroSumar) * numeroSumar;
                                    salir = true;
                                }
                                else if (terminoTurno)
                                {
                                    Cinco = -1;
                                    salir = true;
                                }
                                else
                                {
                                    numeroSumar = Tachar(dadosEnMesa, numeroRepetido);
                                }
                            }
                            break;
                        case 6:
                            if (Seis == 0)
                            {
                                if (!salir)
                                {
                                    Seis = BuscarCantidad(dadosEnMesa, numeroSumar) * numeroSumar;
                                    salir = true;
                                }
                                else if (terminoTurno)
                                {
                                    Seis = -1;
                                    salir = true;
                                }
                                else
                                {
                                    numeroSumar = Tachar(dadosEnMesa, numeroRepetido);
                                }
                            }
                           
                            break;

                    }
                    if(Uno!=0 || Dos!=0 || Tres!=0 || Cuatro !=0 || Cinco != 0 || Seis != 0)
                    {
                        numeroRepetido = numeroSumar;
                        numeroSumar = Tachar(dadosEnMesa, numeroRepetido);
                    }
                    terminoTurno = true;
                    vueltasEnWhile++;
                    if (vueltasEnWhile > 3 && !salir)
                    {
                        Random rnd = new Random();
                        numeroSumar = rnd.Next(1, 7);
                    }
                } while (!salir);
            }
            else if(!terminoTurno)
            {
                turnosJugados++;
            }
        }


        private int BuscarCantidad(int[] dadosEnMesa, int numeroSumar)
        {
            int contador = 0;
            for (int i = 0; i < dadosEnMesa.Length; i++)
            {
                if (dadosEnMesa[i] == numeroSumar)
                {
                    contador++;
                }
            }

            return contador;
        }

        private int Tachar(int[] dadosEnMesa, int numeroRepetido)
        {
            Dado dado = new Dado();
            int minimo = 5;
            int retorno = 0;
            foreach (int cara in dado.Caras)
            {
                int contador = 0;
                foreach (int numeroEnArray in dadosEnMesa)
                {
                    if (cara == numeroEnArray && cara!= numeroRepetido)
                    {
                        contador++;
                    }
                }
                if (contador < minimo)
                {
                    minimo = contador;
                    retorno = cara;
                }
            }

            return retorno;
        }

        private void ReiniciarValores()
        {
            this.generala = 0;
            this.full = 0;
            this.escalera = 0;
            this.poker = 0;
            this.dobleGenerala = 0;
            this.puntaje = 0;
            this.uno = 0;
            this.dos = 0;
            this.tres = 0;
            this.cuatro = 0;
            this.cinco = 0;
            this.seis = 0;
        }

        public void SumarPuntaje()
        {
            Puntaje += Full + Poker + Generala+ DobleGenerala+ Escalera;
            if(Uno!=-1)
                Puntaje+=Uno;
            if (Dos != -1)
                Puntaje += Dos;
            if (Tres != -1)
                Puntaje += Tres;
            if (Cuatro!=-1)
                Puntaje += Cuatro;
            if (Cinco != -1)
                Puntaje += Cinco;
            if(Seis!=-1)
                Puntaje += Seis;
        }
    }
}
