using System.Collections.Generic;
using System.Text.Json;
using Microsoft.Maui.Controls;

namespace StockInspection
{
    public partial class LoteAcabamento : ContentPage
    {
        public LoteAcabamento()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            // Lógica para buscar as informações do lote (simularia uma chamada para um serviço)
            var numeroLote = txtNumeroLote.Text;
            var informacoesLote = await BuscarInformacoesLote(numeroLote);

            if (informacoesLote != null)
            {
                lblInformacoesLote.Text = JsonSerializer.Serialize(informacoesLote, new JsonSerializerOptions { WriteIndented = true });
                lblInformacoesLote.IsVisible = true;
            }
            else
            {
                await DisplayAlert("Erro", "Lote não encontrado", "OK");
            }
        }

        // Método para simular a busca das informações do lote (substituir por sua lógica real)
        private async Task<dynamic> BuscarInformacoesLote(string numeroLote)
        {
            // Aqui você implementaria a lógica para buscar as informações do lote em um banco de dados, API, etc.
            // Por enquanto, vamos simular um retorno fixo:
            if (numeroLote == "258845")
            {
                return new
                {
                    NomeCliente = "Josefina Campos Guimarães",
                    Tecido = "5 rolos de malha",
                    UnidadeMedida = "Metro",
                    CamisetasCosturadas = 645,
                    NumeroLote = 258845
                };
            }
            return null;
        }
    }
}
