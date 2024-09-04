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

            lista = new ObservableCollection<Modelos.Cliente>();
            var A=new Cliente();               
            A.Nome("Alice Gabriela Gonsalves");
            lista.Add(A);
            var B=new Cliente(); 
            B.Nome ("Maria Eduarda Lazore");
            lista.Add(B);
            var C=new Cliente(); 
            C.Nome ("Maria Eduarda Morais");
            lista.Add(C);
            var D=new Cliente(); 
            D.Nome ("Maria Fernanda Lima Silva");
            lista.Add(D);
            

            clientesListView.ItemsSource = lista;
        }

        private void OnAddClienteClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new CadastroCliente();
        }
        private void QuandBotao(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MainPage();
        }

        
    }

}
