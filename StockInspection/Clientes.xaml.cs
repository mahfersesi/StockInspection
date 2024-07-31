using System;
using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;
using StockInspection.Modelos;

namespace StockInspection
{
    public partial class Clientes : ContentPage
    {
        ObservableCollection<Modelos.Cliente> lista;

        public Clientes()
        {
            InitializeComponent();

            lista = new ObservableCollection<Modelos.Cliente>
            {
                new Cliente { SetNome = "Alice Gabriela Gonsalves" },
                new Cliente { SetNome = "Maria Eduarda Lazore" },
                new Cliente { SetNome = "Maria Eduarda Morais" },
                new Cliente { SetNome = "Maria Fernanda Lima Silva" }
            };
lista =clientesListView.ItemsSource;
        }

        private void OnAddClienteClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(entryNomeDoCliente.Text))
            {
                lista.Add(new Cliente { Name = entryNomeDoCliente.Text });
                entryNomeDoCliente.Text = string.Empty;
            }
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
