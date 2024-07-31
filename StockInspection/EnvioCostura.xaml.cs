using System;
using Microsoft.Maui.Controls;

namespace StockInspection
{
    public partial class EnvioCostura : ContentPage
    {
        public EnvioCostura()
        {
            InitializeComponent();
        }

        private void OnCadastrarClicked(object sender, EventArgs e)
        {
            string nomeDaCostureira = CostureiraEntry.Text;
            string numeroFrenteCamisetas = FrenteCamisetasEntry.Text;
            string numeroCostasCamisetas = CostasCamisetasEntry.Text;
            string numeroLinhasEnviadas = LinhasEnviadasEntry.Text;

            // Handle the data here, e.g., save to a database or display a message
            DisplayAlert("Cadastro", "Dados cadastrados com sucesso!", "OK");
        }
    }
}
