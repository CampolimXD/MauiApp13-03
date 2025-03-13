namespace MauiApp13_03
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void btnProduto_Clicked(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            
            produto.Nome = "XESQUEDELE";
            produto.Preco= 10;
            produto.Categoria = "XESQUE";

            //Produto produto = new Produto
            //{
            //    Nome = "XESQUEDELE",
            //    Preco = 10,
            //    Categoria = "XESQUE"
            //};

            Navigation.PushAsync(new ProdutoPage() { BindingContext = produto });
            
        }

        private void btnOutroProduto_Clicked(object sender, EventArgs e)
        {
            OutroProduto outroProduto = new OutroProduto();

            outroProduto.Nome = "XESQUEDELE";
            outroProduto.Preco = 10;
            outroProduto.Categoria = "XESQUE";

            // outra forma de escrever o codigo acima  
            //Produto produto = new Produto
            //{
            //    Nome = "XESQUEDELE",
            //    Preco = 10,
            //    Categoria = "XESQUE"
            //};

            Navigation.PushAsync(new ProdutoPage() { BindingContext = outroProduto });
        }

        private void btnListaProdutos_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaProdutoPage());    
        }
    }

}
