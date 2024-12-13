using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFromWednesday.Classes
{
    internal class Helper
    {
        public void DirectionWithTheProblem(Clients clients, Window window1, Window window2, Window window3)
        {
            if (clients.Temperament.Smart == 1)
            {
                switch (clients.Problems.Number)
                {
                    case 1:
                        window1.AddClients(clients);
                        break;
                    case 2:
                        window2.AddClients(clients);
                        break;
                    default:
                        window3.AddClients(clients);
                        break;
                }
            }
            else
            {
                Random random = new Random();
                int randomWindow = random.Next(1, 4);
                switch (randomWindow)
                {
                    case 1:
                        window1.AddClients(clients);
                        break;
                    case 2:
                        window2.AddClients(clients);
                        break;
                    case 3:
                        window3.AddClients(clients);
                        break;
                }
            }
        }
        public void OvertakingTheQueue(Clients client, Stack<Clients> queue, int overtaking)
        {
            for (int i = 0; i < overtaking; i++)
            {
                if (queue.Count > 0)
                {
                    Clients personInQueue = queue.Pop();
                    queue.Push(personInQueue);
                }
            }
        }
    }
}
