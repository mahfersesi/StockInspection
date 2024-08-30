using System.Collections.Generic;
using System.Text.Json;
using Microsoft.Maui.Controls;

namespace StockInspection
{
    public partial class EnvioSilk : ContentPage
    {
        public EnvioSilk()
        {
            InitializeComponent();
        }

        private async void ButtonAnexarClicked(object sender, EventArgs e)
        {
            // Lógica para abrir o seletor de arquivos e carregar a imagem
            var result = await FilePicker.Default.PickAsync();
            if (result != null)
            {
                // Aqui você pode salvar o caminho do arquivo ou carregar a imagem para exibição
                // ...
            }
        }

        private async void ButtonCadastrarClicked(object sender, EventArgs e)
        {
            // Lógica para cadastrar o envio
            var nomeSilk = txtNomeSilk.Text;
            var quantidade = int.Parse(txtQuantidade.Text);
            // ...
            await DisplayAlert("Sucesso", "Envio cadastrado com sucesso!", "OK");
        }
    }
}
