using AnotadorPuntos.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AnotadorPuntos.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NuevaPartida : ContentPage
    {
        private PartidasViewModel _viewModel;

        public NuevaPartida(PartidasViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
        }
        private void OnCrearPartidaClicked(object sender, EventArgs e)
        {
            string nombrePartida = NombreEntry.Text;
            List<string> participantes = ParticipantesEntry.Text.Split(',').Select(p => p.Trim()).ToList();
            string tipoPuntuacion = TipoPuntuacionPicker.SelectedItem.ToString();
            int numeroEnteroAdicional = string.IsNullOrEmpty(NumeroEnteroEntry.Text) ? 0 : Convert.ToInt32(NumeroEnteroEntry.Text);

            _viewModel.CrearNuevaPartida(nombrePartida, participantes, tipoPuntuacion, numeroEnteroAdicional);
        }
    }
}