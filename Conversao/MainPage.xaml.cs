using Microsoft.Maui.Controls;
using Conversao.Page; // Certifique-se de importar o namespace correto

namespace Conversao
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void KmToMt_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new KmForMt());
        }

        private async void HecToMt_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HecForMt());
        }

        private async void MtToCm_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MtForCm());
        }

        private async void Sobre_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Sobre());
        }
    }
}
