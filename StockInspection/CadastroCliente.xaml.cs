using Microsoft.Maui.Controls;

namespace StockInspection
{
    public partial class CadastroCliente : ContentPage
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void OnSalvarClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(entryNomeDoCliente.Text))
            {
                var a = new Cliente();
                a.SetNome(entryNomeDoCliente.Text);
                lista.Add(a);
                entryNomeDoCliente.Text = string.Empty;
            }
        }

        private void OnCancelarClicked(object sender, EventArgs e)
        {
            // Lógica para cancelar a operação
        }
    }
}
