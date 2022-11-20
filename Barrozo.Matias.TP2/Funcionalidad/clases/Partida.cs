using BibliotecaDeClases;

namespace Funcionalidad.clases
{
    public class Partida
    {
        int id;
        DateTime date;
        List<Jugador> jugadores;
        string ganador;
        int cantidadJugadores;
        Dado dado;
        public int[] dadosEnMesa = new int[5]; //hacer metodo
        public int indice = 0; //hacer
        public event Action EventAction;
        private int turnosMaximos;
        public int turnosJugados = 1; // hacer metodo
        private string estado;
        string bitacora = "";
        public event Action<Partida> mostrarInfo;
        Task tarea;
        public event Action<Partida> finalizar;
        static ConexionBdPartidas conexionBdPartidas = new ConexionBdPartidas();
        
 
        public Partida(CancellationToken cancel,List<Jugador> jugadores, string ganador, int cantidad, DateTime date, int id, int turnosMaximos, string estado) : this(ganador, cantidad, date, id, turnosMaximos, estado)
        {
            this.jugadores = jugadores;
            dado = new Dado();
            tarea = new Task(()=> EmpezarPartida(cancel));
        }
        public Partida(string ganador, int cantidad, DateTime date, int id, int turnosMaximos, string estado)
        {
            this.ganador = ganador;
            cantidadJugadores = cantidad;
            this.id = id;
            this.date = date;
            dado = new Dado();
            this.turnosMaximos = turnosMaximos;
            this.estado = estado;
        }


        //public int Id
        //{
        //    get { return id; }
        //}

        public List<Jugador> Jugadores { get => jugadores; set => jugadores = value; }
        public string Ganador { get => ganador; set => ganador = value; }
        public int CantidadJugadores { get => cantidadJugadores; set => cantidadJugadores = value; }

        public DateTime Date
        {
            get { return date; }
        }

        public string Estado { get => estado; set => estado = value; }

        public void TirarDados(int discriminador, int[] tirada)
        {
            Random rnd = new Random();
            if (tirada is not null && tirada.Length!=0)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (tirada[i] != discriminador)
                    {
                        tirada[i] = dado.Caras[rnd.Next(0, 6)];
                    }
                    else
                    {
                        tirada[i] = discriminador;
                    }
                }
                Jugador.Ordenar(tirada);
            }
            else
            {
                throw new ArgumentNullException();
            }
        }
            

        public static int GuardarNumero(int[] aux)
        {
            int maximo = -1;
            int retorno = 0;
            Dado dado = new Dado();
            if(aux != null && aux.Length!=0)
            {
                foreach(int cara in dado.Caras)
                {
                    int contador = 0;
                    foreach (int numeroEnArray in aux)
                    {
                        if (cara == numeroEnArray)
                        {
                            contador++;
                        }
                    }
                    if (contador > maximo)
                    {
                        maximo = contador;
                        retorno = cara;
                    }
                }

            }else
            {
                throw new ArgumentNullException();
            }
            return retorno;
        }

        public void EncontrarGanador()
        {
            EventAction();
            int puntajeMaximo = 0;
            foreach (Jugador jugador in Jugadores)
            {
                if (jugador.Puntaje > puntajeMaximo)
                {
                    puntajeMaximo = jugador.Puntaje;
                    Ganador = jugador.Usuario.Nombre;
                }
                else if (jugador.Puntaje == puntajeMaximo)
                {
                    Ganador = "Empate";
                }
            }
            foreach(Jugador jugador in jugadores)
            {
                if(jugador.Puntaje== puntajeMaximo && Ganador!="Empate")
                {
                    jugador.Usuario.PartiasGanadas++;
                    ConexionBdUsuarios conexion = new ConexionBdUsuarios();
                    conexion.ActualizarPartidasGanadas(jugador.Usuario);
                }
            }
            estado = "Finalizada";
        }


        public string Jugar()
        {
            string retorno="Vacio";
            if (dadosEnMesa != null)
            {
                if (Jugadores[indice].TurnosJugados == 1)
                {
                    TirarDados(-1, dadosEnMesa);
                }
                else
                {
                    int numeroAGuardar = GuardarNumero(dadosEnMesa);
                    TirarDados(numeroAGuardar, dadosEnMesa);
                }
                retorno = "Tirada :" + dadosEnMesa[0].ToString();
                retorno += "-" + dadosEnMesa[1].ToString();
                retorno += "-" + dadosEnMesa[2].ToString();
                retorno += "-" + dadosEnMesa[3].ToString();
                retorno += "-" + dadosEnMesa[4].ToString();
            }
            return retorno;
        }

        public bool VerificarTurno(){

            jugadores[indice].del(dadosEnMesa);
            if (jugadores[indice].TerminoTurno)
            {
                jugadores[indice].TerminoTurno = false;
                return CambiarJugador();
            }
            return false;
        }

        bool CambiarJugador() 
        {
            dadosEnMesa = new int[5];
            if (indice >= 0 && indice < jugadores.Count-1) 
            {
                indice++;
            }
            else
            {
                indice = 0;
            }
            turnosJugados++;
            if (turnosJugados > turnosMaximos)
            {
                EncontrarGanador();
                return true;
            }
            return false;
        }

        public void EmpezarPartida(CancellationToken cancel)
        {
            while (Ganador == "")
            {
                if (cancel.IsCancellationRequested)
                {
                    ganador = "Cancelada";
                    estado = "Cancelada";
                    jugadores.ForEach((x) => x.Usuario.Estado = EEstado.libre);
                    break;
                }
                Thread.Sleep(2000);
                string resumenPartida = Jugar();

                mostrarInfo?.Invoke(this);

                bitacora += Jugadores[indice].Usuario.Nombre + " " + resumenPartida + "\n";
                if (VerificarTurno())
                {
                    finalizar?.Invoke(this);
                    jugadores.ForEach((x) => x.Usuario.Estado = EEstado.libre);
                    GuardarPartida();
                }
                mostrarInfo?.Invoke(this);
            }
        }

        public void GuardarResumenPartida()
        {
            string archivo = "BitacoraDePartida" + id;
            Archivo.Escribir(bitacora, archivo);
        }

        public async Task EmpezarTarea()
        {
            tarea.Start();
        }

        public void GuardarPartida()
        {
            conexionBdPartidas.GuardarPartida(this);
        }
    }
}
