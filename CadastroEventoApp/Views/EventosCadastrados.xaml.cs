namespace CadastroEventoApp.Views;

public partial class EventosCadastrados : ContentPage
{
	public EventosCadastrados()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			await Navigation.PopAsync();
		} catch (Exception ex)
		{
			DisplayAlert("Ops", ex.Message, "OK");
		}
		
    }
}