using System;
using Microsoft.Maui.Controls;

namespace StockInspection
{
    public partial class EnvioAcabamento : ContentPage
    {
        public EnvioAcabamento()
        {
            InitializeComponent();
        }

        private void OnCadastrarClicked(object sender, EventArgs e)
        {
            string nomeDoAcabamento = AcabamentoEntry.Text;
            string numeroEmbalagens = EmbalagensEntry.Text;
            string numeroAdesivos = AdesivosEntry.Text;
            string numeroTiras = TirasEntry.Text;

            // Handle the data here, e.g., save to a database or display a message
            DisplayAlert("Cadastro", "Dados cadastrados com sucesso!", "OK");
        }
    }
}
