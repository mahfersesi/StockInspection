using Microsoft.Maui.Controls;

namespace StockInspection
{
    public partial class EnvioCorte : ContentPage
    {
        public EnvioCorte()
        {
            InitializeComponent();
        }

        private async void Button_Cadastrar_Clicked(object sender, EventArgs e)
        {
            // Lógica para cadastrar as informações
            string cortador = txtCortador.Text;
            int quantidade = int.Parse(txtQuantidade.Text);

            // Aqui você implementaria a lógica para salvar as informações em um banco de dados, enviar para uma API, etc.
            // Por exemplo:
            await DisplayAlert("Sucesso", "Dados cadastrados com sucesso!", "OK");
        }
    }
}
