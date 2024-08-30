using System;
using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace StockInspection
{
    public partial class Estoque : ContentPage
    {
        public ObservableCollection<Item> Items { get; set; }

        public Estoque()
        {
            InitializeComponent();

            Items = new ObservableCollection<Item>
            {
                new Item
                {
                    ImageSource = "mickey_mouse.png",
                    Cliente = "Cliente: Rafaela Lima",
                    Tecido = "Tecido: ok",
                    Costura = "Costura: ok",
                    Acabamento = "Acabamento: off",
                    Silk = "Silk: ok"
                },
                new Item
                {
                    ImageSource = "stitch.png",
                    Cliente = "Cliente: Maria Fernanda",
                    Tecido = "Tecido: ok",
                    Costura = "Costura: ok",
                    Acabamento = "Acabamento: off",
                    Silk = "Silk: ok"
                },
                new Item
                {
                    ImageSource = "default_image.png",
                    Cliente = "Cliente: Rafaela Lima",
                    Tecido = "Tecido: ok",
                    Costura = "Costura: ok",
                    Acabamento = "Acabamento: off",
                    Silk = "Silk: ok"
                }
            };

            estoqueListView.ItemsSource = Items;
        }

        private void OnAddItemClicked(object sender, EventArgs e)
        {
            // Logic to add a new item
        }
    }

    public class Item
    {
        public string ImageSource { get; set; }
        public string Cliente { get; set; }
        public string Tecido { get; set; }
        public string Costura { get; set; }
        public string Acabamento { get; set; }
        public string Silk { get; set; }
    }

    
}
