using CadastroEventoApp.Models;

namespace CadastroEventoApp.Views;

public partial class CadastroEventos : ContentPage
{
    public Evento Evento { get; set; }
	public CadastroEventos()
	{
		InitializeComponent();
        Evento = new Evento();
        BindingContext = this;
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        if (int.TryParse(NumeroParticipantesEntry.Text, out int numeroParticipantes) &&
            decimal.TryParse(CustoPorParticipanteEntry.Text, out decimal custo))
        {
            Evento.NumeroParticipantes = numeroParticipantes;
            Evento.CustoPorParticipante = custo;

            await Navigation.PushAsync(new EventosCadastrados());
        }
        else
        { 
            await DisplayAlert("Ops!", "Por Favor, preencha os campos corretamente", "OK");
        }
            
        
    }
}


       
            