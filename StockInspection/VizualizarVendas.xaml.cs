using Microsoft.Maui.Controls;

namespace StockInspection
{
    public partial class VizualizarVendas : ContentPage
    {
        public VizualizarVendas()
        {
            InitializeComponent();
        }

        private async void Button_TelaInicial_Clicked(object sender, EventArgs e)
        {
            // Navegar para a tela inicial
            await Navigation.PushAsync(new VizualizarVendas());
        }

        private async void Button_Voltar_Clicked(object sender, EventArgs e)
        {
            // Voltar para a página anterior
            await Navigation.PopAsync();
        }
    }
}
