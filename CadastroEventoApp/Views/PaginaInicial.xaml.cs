namespace CadastroEventoApp.Views;

public partial class PaginaInicial : ContentPage
{
	public PaginaInicial()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        try 
        {
            await Navigation.PushAsync(new CadastroEventos());

        } catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        try
        {
            await Navigation.PushAsync(new Sobre());

        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}