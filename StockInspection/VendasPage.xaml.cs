using System;
using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace StockInspection
{
    public partial class VendasPage : ContentPage
    {
        public ObservableCollection<Venda> Vendas { get; set; }

        public VendasPage()
        {
            InitializeComponent();

            Vendas = new ObservableCollection<Venda>
            {
                new Venda
                {
                    Date = "24 Fevereiro 2024",
                    ImageSource = "shirt_red.png",
                    Details = "569 camisetas\n4 rolos de tecido\n569 silk\n573 costuradas\n4 com defeito"
                },
                new Venda
                {
                    Date = "20 Fevereiro 2024",
                    ImageSource = "shirt_purple.png",
                    Details = "739 camisetas\n6 rolos de tecido\n739 silk\n731 costuradas\n8 com defeito"
                }
            };

            vendasListView.ItemsSource = Vendas;
        }

        private void OnAddVendaClicked(object sender, EventArgs e)
        {
             Application.Current.MainPage = new MetaDiaria();
        }

        private void OnDeleteVendaClicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var venda = button.BindingContext as Venda;

            if (venda != null)
            {
                Vendas.Remove(venda);
            }
        }
    }

    public class Venda
    {
        public string Date { get; set; }
        public string ImageSource { get; set; }
        public string Details { get; set; }
    }
}
