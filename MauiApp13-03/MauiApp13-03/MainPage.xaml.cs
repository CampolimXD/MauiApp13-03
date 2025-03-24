namespace MauiApp13_03
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnListaCarros_Clicked(object sender, EventArgs e)
        {
            
           await Shell.Current.GoToAsync("//ListaCarros");

        }
    }

}
