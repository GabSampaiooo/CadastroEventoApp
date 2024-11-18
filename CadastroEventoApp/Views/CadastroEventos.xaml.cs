using CadastroEventoApp.Models;

namespace CadastroEventoApp.Views;

public partial class CadastroEventos : ContentPage
{
    public Evento Evento { get; set; }
	public CadastroEventos()
	{
		InitializeComponent();

        Evento = new Evento();

        BindingContext = Evento;

        DataInicioPicker.MinimumDate = DateTime.Now;

        DataTerminoPicker.MinimumDate = DateTime.Now;
        DataTerminoPicker.MaximumDate = DataInicioPicker.Date.AddYears(5);
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        try
        {  
            //Validação dos campos, onde são valores numéricos só aceitam numeros
            if (int.TryParse(NumeroParticipantesEntry.Text, out int numeroParticipantes) &&
                double.TryParse(CustoPorParticipanteEntry.Text, out double custo))
            {
                Evento.NumeroParticipantes = numeroParticipantes;
                Evento.CustoPorParticipante = custo;

                //atualizando o objeto Evento com os dados
                Evento d = new Evento
                {
                    Nome = NomeEntry.Text,
                    DataInicio = DataInicioPicker.Date,
                    DataTermino = DataTerminoPicker.Date,
                    NumeroParticipantes = Convert.ToInt32(NumeroParticipantesEntry.Text),
                    Local = LocalEntry.Text,
                    CustoPorParticipante = Convert.ToDouble(CustoPorParticipanteEntry.Text),
                };


                //Navegação para próxima página
                await Navigation.PushAsync(new EventosCadastrados()
                {
                    BindingContext = d
                });
            }
            else
            { 
                await DisplayAlert("Ops!", "Por Favor, preencha os campos corretamente", "OK");
            }
        } catch (Exception ex)
        {
            await DisplayAlert("Ops", ex.Message, "OK");

        }


    }

    private void DataInicioPicker_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;

        DateTime data_selecionada_inicio = elemento.Date;

        DataTerminoPicker.MinimumDate = data_selecionada_inicio;
    }
}



