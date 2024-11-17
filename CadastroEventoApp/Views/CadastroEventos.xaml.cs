namespace CadastroEventoApp.Views;

public partial class CadastroEventos : ContentPage
{
	public CadastroEventos()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            await Navigation.PushAsync(new EventosCadastrados());

        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}