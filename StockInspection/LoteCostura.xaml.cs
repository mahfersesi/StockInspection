using System;
using Microsoft.Maui.Controls;

namespace StockInspection
{
    public partial class LoteCostura : ContentPage
    {
        public LoteCostura()
        {
            InitializeComponent();
        }

        private void OnSearchClicked(object sender, EventArgs e)
        {
            // Simulate searching for the lot number
            // In a real application, this data would come from a database or an API
            if (NumeroLoteEntry.Text == "258845")
            {
                // Display the details frame if the lot number is found
                DetailsFrame.IsVisible = true;
            }
            else
            {
                DisplayAlert("Erro", "Numero do lote não encontrado.", "OK");
            }
        }

        private void OnCosturaClicked(object sender, EventArgs e)
        {
            // Handle the costura action here, e.g., save to a database or display a message
            DisplayAlert("Costura", "Dados enviados para costura com sucesso!", "OK");
        }
    }
}
