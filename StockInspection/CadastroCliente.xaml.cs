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

        private void OnSalvarClicked(object sender, EventArgs e)
        { 
            
           
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
    }
}
