namespace StockInspection
{
    public partial class MainPage 
    {
        public MainPage()
        {
            InitializeComponent();
        }
        
        // Add event handlers if needed, for example:
        private void Proxim(object sender, EventArgs args)
  {
      Application.Current.MainPage = new Clientes();
  }

        private void Proximo(object sender, EventArgs args)
  {
      Application.Current.MainPage = new Produto();
  }

        private void Proxi(object sender, EventArgs args)
  {
      Application.Current.MainPage = new Estoque();
  }

        private void Prox(object sender, EventArgs args)
  {
      Application.Current.MainPage = new VendasPage();
  }
    }
}

