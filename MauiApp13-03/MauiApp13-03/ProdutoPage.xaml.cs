namespace MauiApp13_03;

public partial class ProdutoPage : ContentPage
{
	public ProdutoPage()
	{
		InitializeComponent();
	}

    private async void btnVoltarLista_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//ListaCarros");
    }
}