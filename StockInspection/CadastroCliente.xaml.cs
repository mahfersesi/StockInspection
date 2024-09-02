using Microsoft.Maui.Controls;

using StockInspection.Modelos;

namespace StockInspection
{
    public partial class CadastroCliente : ContentPage
    {
        List<Modelos.Cliente> lista;
        public CadastroCliente()
        {
            InitializeComponent();

            lista = new List<Modelos.Cliente>();
            var A=new Cliente();               
            A.SetNome("Alice Gabriela Gonsalves");
            lista.Add(A);

            
        }

        private async void OnSalvarClicked(object sender, EventArgs e)
        { 
            string nome = NomeClienteEntry.Text;
            string ddd = DDDEntry.Text;
            string numero = NumeroCelularEntry.Text;
            string cep = CEPEntry.Text;
            string enderoço = EnderecoEntry.Text;
           
           await DisplayAlert("Sucesso", "Alterações salvas com sucesso!", "OK");
        }

        private void OnCancelarClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Clientes();
        }
        private void OnDeleteClienteClicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var cliente = button.BindingContext as Modelos.Cliente;

            if (cliente != null)
            {
                lista.Remove(cliente);
            }
        }

        private void QuandoBotao(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Clientes();
        }
    }
}
