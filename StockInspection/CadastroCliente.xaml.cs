using Microsoft.Maui.Controls;

using StockInspection.Modelos;

namespace StockInspection
{
    public partial class CadastroClientePage : ContentPage
{
  
  public Cliente cliente { get; set; }
  Controles.ClienteControle clienteControle = new Controles.ClienteControle();
  Controles.EstadoControle estadoControle = new Controles.EstadoControle();

  
	public CadastroClientePage()
	{
		InitializeComponent();
    pickerEstado.ItemsSource = estadoControle.LerTodos();
	}


        private async void OnSalvarClicked(object sender, EventArgs e)
        { 
           if (await VerificaSeDadosEstaoCorretos()) // Verifica se os dados são válidos antes de salvar no banco
    {
      // O código abaixo preenche o objeto cliente (Modelo) com os dados das Entry's
      var cliente = new Modelos.Cliente();
      if (!String.IsNullOrEmpty(IdLabel.Text))
        cliente.Id      = int.Parse(IdLabel.Text);
      else
        cliente.Id      = 0;
      cliente.Nome      = NomeClienteEntry.Text;
      cliente.DDD       = DDDEntry.Text;
      cliente.CEP       = CEPEntry.Text;
      cliente.Endereço  = EnderecoEntry.SelectedItem as Estado;

      // Com o objeto preenchido enviamos para o controle para criar/atualizar no Banco de Dados
      clienteControle.CriarOuAtualizar(cliente);
      // Mostra a mensagem de sucesso
      await DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");
    }
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
