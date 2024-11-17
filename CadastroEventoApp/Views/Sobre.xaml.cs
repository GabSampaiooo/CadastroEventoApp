namespace CadastroEventoApp.Views;

public partial class Sobre : ContentPage
{
	public Sobre()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            await Navigation.PushAsync(new PaginaInicial());

        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}