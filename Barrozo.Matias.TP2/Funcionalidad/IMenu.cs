﻿using Funcionalidad.clases;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionalidad
{
    public interface IMenu
    {
        public void MostrarDatosUsuarios(List<Usuario> usuarios);
        public void MostrarDatosPartidas(ConcurrentBag<Partida> partidas);

        public void MostrarEstadisticas(string cantidad, string cantidadEmpatadas,string cantidadCanceladas, string cantidadFinalizada, List<Usuario> usuarios);

        public bool AgregarUsuario(List<Jugador> jugadoresPartida);

        public void MostrarActivas(List<Partida> partidasActivas);
     
    }
}
