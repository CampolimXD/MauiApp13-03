namespace MauiApp13_03;

public partial class ListaCarros : ContentPage
{
	public ListaCarros()
	{
        List<Carros> lista = Carros.Lista;

        InitializeComponent();
        listaCarro.ItemsSource = lista;
    }

    private void ViewCell_Tapped(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ProdutoPage() { BindingContext = ((ViewCell)sender).BindingContext });
    }

    private async void btnVoltar_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//MainPage");
    }
}