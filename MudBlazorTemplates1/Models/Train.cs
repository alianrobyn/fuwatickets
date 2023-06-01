namespace MudTrain.Models
{
    public class Train
    {
		public int ID { get; set; }

        public string Z_K { get; set; }

        public DateTime Date { get; set; }

        public string V_P { get; set; }

        public int VM { get; set; }

        public int Sum { get; set; }


        public ICollection<Ticket> Tickets { get; set; }
    }
}
