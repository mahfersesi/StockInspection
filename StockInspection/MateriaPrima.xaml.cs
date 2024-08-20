using Microsoft.Maui.Controls;

namespace StockInspection
{
    public partial class MateriaPrima : ContentPage
    {
        public MateriaPrima()
        {
            InitializeComponent();
        }

        private void OnCadastrarClicked(object sender, EventArgs e)
        {
            // Lógica para cadastrar as informações
        }

        private void QandoBotao(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Produto();
        }
    }
}
