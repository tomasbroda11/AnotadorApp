
using AnotadorPuntos.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AnotadorPuntos.ViewModels
{
    public class PartidasViewModel : ContentPage
    {
        public ObservableCollection<Partida> Partidas { get; set; }
        public PartidasViewModel()
        {
            Partidas = new ObservableCollection<Partida>();
        }
        public void CrearNuevaPartida(string nombre, List<string> participantes, string tipoPuntuacion, int numeroEnteroAdicional)
        {
            Partida nuevaPartida = new Partida
            {
                Nombre = nombre,
                Participantes = participantes,
                TipoPuntuacion = tipoPuntuacion,
                NumeroEnteroAdicional = numeroEnteroAdicional
            };


            Partidas.Add(nuevaPartida);
        }
    }
}