using Microsoft.Maui.Controls;

namespace StockInspection
{
    public partial class MetaDiaria : ContentPage
    {
        public MetaDiaria()
        {
            InitializeComponent();
        }

        private async void Button_Salvar_Clicked(object sender, EventArgs e)
        {
            // Lógica para salvar as alterações
            string corte = txtCorte.Text;
            string silk = txtSilk.Text;
            string costura = txtCostura.Text;
            string acabamento = txtAcabamento.Text;

            // Aqui você implementaria a lógica para salvar as informações em um banco de dados, enviar para uma API, etc.
            // Por exemplo:
            await DisplayAlert("Sucesso", "Alterações salvas com sucesso!", "OK");
        }
    }
}
