using Microsoft.Maui.Controls;

namespace StockInspection;


    public partial class Produto : ContentPage
    {
        public Produto()
        {
            InitializeComponent();
        }
        
        // Adicione manipuladores de eventos, se necessário, por exemplo:
        private void OnMateriaPrimaClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MateriaPrima();
        }

        private void OnCorteClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new EnvioCorte();
        }

        private void OnSilkClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new EnvioSilk();
        }

        private void OnCosturaClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new EnvioCostura();
        }

        private void OnAcabamentoClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new EnvioAcabamento();
        }

        private void QuadoBotao(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MainPage();
        }
    }

