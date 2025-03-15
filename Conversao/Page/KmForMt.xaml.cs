using Microsoft.Maui.Controls;

namespace Conversao.Page
{
    public partial class KmForMt : ContentPage
    {
        public KmForMt()
        {
            InitializeComponent();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            if (double.TryParse(etrKmToMt1.Text, out double km))
            {
                double meters = km * 1000;
                lblResultado.Text = $"{km} km é igual a {meters} metros.";
            }
            else
            {
                lblResultado.Text = "Por favor, insira um número válido.";
            }
        }
    }
}
