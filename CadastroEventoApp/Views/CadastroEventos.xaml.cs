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

        DataInicioPicker.MinimumDate = DateTime.Now;

        DataTerminoPicker.MinimumDate = DateTime.Now;
        DataTerminoPicker.MaximumDate = DataInicioPicker.Date.AddYears(5);
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        if (int.TryParse(NumeroParticipantesEntry.Text, out int numeroParticipantes) &&
            double.TryParse(CustoPorParticipanteEntry.Text, out double custo))
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

    private void DataInicioPicker_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;

        DateTime data_selecionada_inicio = elemento.Date;

        DataTerminoPicker.MinimumDate = data_selecionada_inicio;
    }
}



