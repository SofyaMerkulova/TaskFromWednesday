using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFromWednesday.Classes
{
    internal class Window
    {
        public string Name { get; set; }
        public List<Clients> Client { get; set; }
        public Window(string name)
        {
            Name = name;
            Client = new List<Clients>();
        }
        public void AddClients(Clients clients)
        {
            Client.Add(clients);
            Console.WriteLine($"{clients.Name} подошел к окну: {Name}.");
        }
    }
}
