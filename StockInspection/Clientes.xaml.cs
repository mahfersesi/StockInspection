using System;
using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace StockInspection
{
    public partial class Clientes : ContentPage
    {
       

        public Clientes()
        {
            InitializeComponent();

            clientesListView.ItemsSource = new ObservableCollection<Cliente>
            {
                new Cliente { Name = "Alice Gabriela Gonsalves" },
                new Cliente { Name = "Maria Eduarda Lazore" },
                new Cliente { Name = "Maria Eduarda Morais" },
                new Cliente { Name = "Maria Fernanda Lima Silva" }
            };

        }

        private void OnAddClienteClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(entryNomeDoCliente.Text))
            {
                Clientes.Add(new Cliente { Name = entryNomeDoCliente.Text });
                entryNomeDoCliente.Text = string.Empty;
            }
        }

        private void OnDeleteClienteClicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var cliente = button.BindingContext as Cliente;

            if (cliente != null)
            {
                Clientes.Remove(cliente);
            }
        }
    }

    public class Cliente
    {
        public string Name { get; set; }
    }
}
