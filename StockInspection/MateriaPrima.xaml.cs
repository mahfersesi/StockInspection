using Microsoft.Maui.Controls;

namespace StockInspection
{
    public partial class MateriaPrima : ContentPage
    {
        public MateriaPrima()
        {
            InitializeComponent();
        }

        private async void OnCadastrarClicked(object sender, EventArgs e)
        {
            string nome = NomeEntry.Text;
            string tecido = TipoTecidoEntry.Text;
            string medida = UnidadeMedidaEntry.Text;
           
           await DisplayAlert("Cadastrado com sucesso", "Item cadastrado", "OK");
        }

        private void QandoBotao(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Produto();
        }
    }
}
