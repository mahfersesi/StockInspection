using Microsoft.Maui.Controls;

namespace StockInspection
{
    public partial class LoteCorte : ContentPage
    {
        public LoteCorte()
        {
            InitializeComponent();
            txtNumeroLote.TextChanged += TxtNumeroLote_TextChanged; // Adiciona o evento TextChanged
        }

        private async void TxtNumeroLote_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Lógica para buscar as informações do lote (simularia uma chamada para um serviço)
            var numeroLote = txtNumeroLote.Text;
            var informacoesLote = await BuscarInformacoesLote(numeroLote);

            if (informacoesLote != null)
            {
                lblInformacoesLote.Text = $"Nome do Cliente: {informacoesLote.NomeCliente}\n" +
                                           $"Tecido: {informacoesLote.Tecido}\n" +
                                           $"Unidade de Medida: {informacoesLote.UnidadeMedida}\n" +
                                           $"Número do Lote: {informacoesLote.NumeroLote}";
                lblInformacoesLote.IsVisible = true;
            }
            else
            {
                lblInformacoesLote.Text = "Lote não encontrado";
                lblInformacoesLote.IsVisible = true;
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
                    NumeroLote = 258845
                };
            }
            return null;
        }
    }
}
