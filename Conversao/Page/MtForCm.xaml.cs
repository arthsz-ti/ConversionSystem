using Microsoft.Maui.Controls;

namespace Conversao.Page
{
    public partial class MtForCm : ContentPage
    {
        public MtForCm()
        {
            InitializeComponent();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            if (double.TryParse(etrMtToCm.Text, out double metros))
            {
                double centimetros = metros * 100;
                lblResultadoMt.Text = $"{metros} metros é igual a {centimetros} centímetros.";
            }
            else
            {
                lblResultadoMt.Text = "Por favor, insira um número válido.";
            }
        }
    }
}
