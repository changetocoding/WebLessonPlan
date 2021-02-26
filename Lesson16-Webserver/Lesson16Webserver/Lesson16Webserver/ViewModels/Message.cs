using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson16Webserver.ViewModels
{
    public class Message : IStoreType
    {
        public int Id { get; set; }
        public string To { get; set; }
        public string Say { get; set; }

        public static List<Message> TestData()
        {
            return new List<Message>()
            {
                new Message() {Say = "Wishing on a well", To = "David", Id = 1},
                new Message() {Say = "Good luck", To = "Emmanuel", Id = 2},
                new Message() {Say = "Bonsai Trees", To = "Jacob", Id = 3},
            };
        }
    }

}
