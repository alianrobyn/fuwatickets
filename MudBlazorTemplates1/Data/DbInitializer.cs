using MudTrain.Models;

namespace MudTrain.Data
{
    public class DbInitializer
    {
        public static void Initialize(TicketContext context)
        {
            context.Database.EnsureCreated();

            // Look for any users.
            if (context.Users.Any())
            {
                return;   // DB has been seeded
            }

            var users = new User[]
            {
            new User{Email="qwerty@gmail.com",Password="qwerty123",Surname="Qwerty",Name="Uiop",Phone="+380972684027"},
            new User{Email="asdfg@gmail.com",Password="asdfg456",Surname="Asdfg",Name="Hjkl",Phone="+380672936193"}
            };
            foreach (User u in users)
            {
                context.Users.Add(u);
            }
            context.SaveChanges();

            var trains = new Train[]
            {
            new Train{Z_K="Київ / Ужгород",Date=DateTime.Parse("2023-01-01"),V_P="9:30 - 19:00",VM=46, Sum=140},
            new Train{Z_K="Київ / Ворохта",Date=DateTime.Parse("2023-02-14"),V_P="7:00 - 10:30",VM=55, Sum=330},
            new Train{Z_K="Київ / Одеса",Date=DateTime.Parse("2023-03-25"),V_P="5:30 - 22:30",VM=8, Sum=360},
            new Train{Z_K="Київ / Чернівці",Date=DateTime.Parse("2023-04-10"),V_P="10:30 - 18:00",VM=29, Sum=190},
            new Train{Z_K="Київ / Жмеринка",Date=DateTime.Parse("2023-05-05"),V_P="13:00 - 23:30",VM=22, Sum=385},
            new Train{Z_K="Миколаїв / Вінниця",Date=DateTime.Parse("2023-06-19"),V_P="2:30 - 21:00",VM=52, Sum=490},
            new Train{Z_K="Житомир / Харків",Date=DateTime.Parse("2023-07-21"),V_P="1:00 - 19:00",VM=23, Sum=485},
            new Train{Z_K="Тернопіль / Львів",Date=DateTime.Parse("2023-08-16"),V_P="17:00 - 0:30",VM=56, Sum=384},
            };
            foreach (Train t in trains)
            {
                context.Trains.Add(t);
            }
            context.SaveChanges();

            //var tickets = new Ticket[]
            //{
            //new Ticket{Status=Status.Придбано, UserId=1, Surname="Qwerty", Name="Uiop", TrainId=1, Z_K="Київ / Ужгород", Date=DateTime.Parse("2023-01-01"), V_P="9:30 - 19:00", Type=Models.Type.Повний, Service=Service.Постільна_білизна_і_Бізнес_ланч, Sum=140},
            //new Ticket{Status=Status.В_кошику, UserId=2, Surname="Asdfg", Name="Hjkl", TrainId=2, Z_K="Київ / Ворохта", Date=DateTime.Parse("2023-02-14"), V_P="7:00 - 10:30", Type=Models.Type.Пільговий, Sum=330 },
            //new Ticket{Status=Status.Сплинувша_дата, UserId=1, Surname="Qwerty", Name="Uiop", TrainId=3, Z_K="Київ / Одеса", Date=DateTime.Parse("2023-03-25"), V_P="5:30 - 22:30", Type=Models.Type.Дитячий, Service=Service.Напій_і_Бізнес_ланч, Sum=320 }
            //};
            //foreach (Ticket e in tickets)
            //{
            //    context.Tickets.Add(e);
            //}
            context.SaveChanges();
        }
    }
}
