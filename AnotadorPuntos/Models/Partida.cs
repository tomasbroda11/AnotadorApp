using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AnotadorPuntos.Models
{
    public class Partida : ContentPage
    {
        public string Nombre { get; set; }
        public List<string> Participantes { get; set; }
        public string TipoPuntuacion { get; set; } 
        public int NumeroEnteroAdicional { get; set; }
        public Partida() { }

    }
}