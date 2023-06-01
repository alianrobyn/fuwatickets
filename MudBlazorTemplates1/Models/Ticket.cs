using System.Diagnostics;

namespace MudTrain.Models
{
    //public enum Grade
    //{
    //    A, B, C, D, F
    //}

    //public enum Status
    //{
    //    Придбано, В_кошику,  Сплинувша_дата
    //}

    //public enum Service
    //{
    //    Постільна_білизна_Напій_і_Бізнес_ланч, Постільна_білизна_і_Напій, Постільна_білизна_і_Бізнес_ланч, Напій_і_Бізнес_ланч, Напій, Бізнес_ланч, Постільна_білизна, 
    //}

    //public enum Type
    //{
    //    Студентський, Дитячий, Повний, Пільговий
    //}

    public class Ticket
    {
        public int Id { get; set; }

        public string Status { get; set; }

        public int UserId { get; set; }

        public string Surname { get; set; }

        public string Name { get; set; }

        public int TrainId { get; set; }

        public string Z_K { get; set; }

        public DateTime Date { get; set; }

        public string V_P { get; set; }

        public string Type { get; set; }

        public string? Service { get; set; }

        public int Sum { get; set; }

        public string? Action { get; set; }


        public User User { get; set; }
        public Train Train { get; set; }
    }
}
