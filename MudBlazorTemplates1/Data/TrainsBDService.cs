using System.Xml.Linq;

namespace MudTrain.Data
{
    public class TrainsBDService
    {
        private static readonly string[] Z_Ks = new[]
        {
            "Київ / Ужгород", "Київ / Ворохта", "Київ / Одеса", "Київ / Чернівці", "Київ / Жмеринка"
        };

        private static readonly string[] V_Ps = new[]
        {
            "9:30 - 19:00", "5:30 - 23:30", "13:00 - 23:30", "1:00 - 19:00", "17:00 - 0:30"
        };

        private static readonly string[] Statuses = new[]
        {
            "Придбано", "В кошику", "Сплинувша дата"
        };

        private static readonly string[] Docs = new[]
        {
            "№749, Київ / Ужгород, 2018-05-06, 9:30 - 19:00" +
            " Прізвище Ім'я"
        };

        private static readonly string[] Actions = new[]
        {
            "Скасувати" +
            " Замовити", "Перегляд документів"
        };

        private static readonly string[] Views = new[]
        {
            "Переглянути"
        };

        private static readonly string[] Surnames = new[]
        {
            "Прізвище"
        };

        private static readonly string[] Names = new[]
        {
            "Ім'я"
        };

        private static readonly string[] Services = new[]
        {
            "Постільна білизна", "Напій", "Бізнес-ланч", "Постільна білизна, Напій", "Постільна білизна, Бізнес-ланч", "Напій, Бізнес-ланч", " "
        };

        private static readonly string[] Types = new[]
        {
            "Студентський", "Дитячий", "Повний", "Пільговий"
        };

        public Task<TrainsBD[]> GetTrainsbdAsync(DateTime startDate)
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new TrainsBD
            {
                N = rng.Next(1, 1000),
                Date = startDate.AddDays(index),
                VM = rng.Next(1, 50),
                Sum = rng.Next(100, 1000),

                Z_K = Z_Ks[rng.Next(Z_Ks.Length)],
                V_P = V_Ps[rng.Next(V_Ps.Length)],
                Status = Statuses[rng.Next(Statuses.Length)],
                Doc = Docs[rng.Next(Docs.Length)],
                Action = Actions[rng.Next(Actions.Length)],
                View = Views[rng.Next(Views.Length)],
                Surname = Surnames[rng.Next(Surnames.Length)],
                Name = Names[rng.Next(Names.Length)],
                Service = Services[rng.Next(Services.Length)],
                Type = Types[rng.Next(Types.Length)]

                //TemperatureC = rng.Next(-20, 55),
                //Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToArray());
        }
    }
}
