using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson16Webserver.ViewModels
{
    public class Client :IStoreType
    {
        public Client()
        {
            
        }
        public Client(string email, string password, string name)
        {
            Email = email;
            Password = password;
            Name = name;
        }


        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public static List<Client> Init()
        {
            var client = new Client("jacob@t.co", "Test", "Jacob");
            client.Id = 1;
            return new List<Client>()
            {
                client
            };
        }
    }
}
