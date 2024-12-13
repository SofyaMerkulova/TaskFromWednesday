using System;
using System.Collections;
using System.Collections.Generic;
namespace TaskFromWednesday.Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Начался отопительный сезон, в городе начали включать отопление и у жителей
            возникают проблемы. Для решения этих проблем они идут в жэк. В жэке есть 3 окна:
            1. В первом окно помогает людям решить проблемы с отоплением (подключение и
            тд);
           2. Во втором окне решают проблемы с оплатой отопления;
           3. В третье окно идут все остальные.
           Необходимо создать класс жителя. У жителя есть: имя, номер паспорта (для
           однозначной идентификации), проблема, темперамент. Проблема характеризуется
           номером и описанием. Темперамент характеризуется степенью скандальности от 0 до
           10 (10-скандалист, 0-паинька), умом(1-умный, 0-тупой).
           В каждое окно жители встают по очереди. Перед входом в жэк стоит сотрудница Зина,
           которая уточняет у жителей, какая у них проблема и по ключевым словам определяет
           их в нужное окно.
           Если житель скандалист (от 5 и выше), то он не будет обращать внимание на очередь
           и обгонит людей, которые впереди него (на сколько человек обгонять житель
           спрашивает у пользователя). Если человек тупой, то он встаёт не в то окно, даже
           несмотря на указание Зины (случайным образом). К Зине все выстраиваются по
           правилу стека.*/
            Console.WriteLine("Задание про отопительный сезон");
            Window window1 = new Window("Решение проблем с отоплнением.Окно1");
            Window window2 = new Window("Решение проблем с оплатой отоплнения.Окно2");
            Window window3 = new Window("Другая проблема.Окно3");
            Clients clients1 = new Clients("Анна", "999999", new Problems(1, "Надо подключить отопление"), new Temperament(3, 1));
            Clients clients2 = new Clients("Алсу", "555555", new Problems(2, "Надо опатить отопление"), new Temperament(2, 0));
            Clients clients3 = new Clients("Эвелина", "111111", new Problems(3, "Другая проблема (не связанная с оплатой и ооплением)"), new Temperament(10, 0));
            Helper helper1 = new Helper();
            Stack<Clients> queue = new Stack<Clients>();
            queue.Push(clients1);
            queue.Push(clients2);
            queue.Push(clients3);
            Helper helper = new Helper();
            while (queue.Count > 0)
            {
                Clients client = queue.Pop();
                if (client.Temperament.Scandalous >= 5)
                {
                    Console.Write("На сколько человек обгонять: ");
                    int overtaking = int.Parse(Console.ReadLine());

                    helper.OvertakingTheQueue(client, queue, overtaking);
                }
                    helper.DirectionWithTheProblem(client, window1, window2, window3);
            }
                PrintInfo(window1);
                PrintInfo(window2);
                PrintInfo(window3);
        }
        static void PrintInfo(Window window)
        {
            Console.WriteLine($"{window.Name}: ");
            foreach (var client in window.Client)
            {
                Console.WriteLine($"{client.Name} с проблемой: {client.Problems.Description}");
            }


        }

    }
}
