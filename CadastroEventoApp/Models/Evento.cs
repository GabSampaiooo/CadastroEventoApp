namespace CadastroEventoApp.Models
{
    public class Evento
    {
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public int NumeroParticipantes { get; set; }
        public string Local { get; set; }
        public decimal CustoPorParticipante { get; set; }

        //Cálculo da duração do evento em dias
        public int DuracaoEvento
        {
            get
            {
                return (DataTermino - DataInicio).Days;
            }
        }

        //Cálculo do custo total do evento
        public decimal CustoTotal
        {
            get
            {
                return NumeroParticipantes * CustoPorParticipante;
            }
        }

    }
}
