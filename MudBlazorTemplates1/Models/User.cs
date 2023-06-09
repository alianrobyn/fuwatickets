﻿using System.Net.Sockets;

namespace MudTrain.Models
{
    public class User
    {
        public int ID { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Password2 { get; set; }

        public string Surname { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }


        public ICollection<Ticket> Tickets { get; set; }
    }
}
