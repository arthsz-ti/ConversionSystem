using Microsoft.Maui.Controls;

namespace Conversao.Page
{
    public partial class HecForMt : ContentPage
    {
        public HecForMt()
        {
            InitializeComponent();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            if (double.TryParse(etrHecToMt1.Text, out double hectometros))
            {
                double metros = hectometros * 100; 
                lblResultadoHec.Text = $"{hectometros} hectômetros é igual a {metros} metros.";
            }
            else
            {
                lblResultadoHec.Text = "Por favor, insira um número válido.";
            }
        }
    }
}
