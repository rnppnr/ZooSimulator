using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;

namespace ZooSimulator
{
    class Program
    {        
        static Random _rnd = new Random();
        static List<Monkey> monkeyList;
        static List<Giraffe> giraffeList;
        static List<Elephant> elephantList;
        static DateTime simtime = DateTime.Now;        

        static void Main(string[] args)
        {
            Timer timer = new Timer(2000);
            timer.Elapsed += OnTimerEvent;
            timer.Start();

            monkeyList = new List<Monkey>() {
                new Monkey() { Id = "M1" },
                new Monkey() { Id = "M2" },
                new Monkey() { Id = "M3" },
                new Monkey() { Id = "M4" },
                new Monkey() { Id = "M5" }
            };
            giraffeList = new List<Giraffe>() {
                new Giraffe() { Id = "G1" },
                new Giraffe() { Id = "G2" },
                new Giraffe() { Id = "G3" },
                new Giraffe() { Id = "G4" },
                new Giraffe() { Id = "G5" }
            };
            elephantList = new List<Elephant>() {
                new Elephant() { Id = "E1" },
                new Elephant() { Id = "E2" },
                new Elephant() { Id = "E3" },
                new Elephant() { Id = "E4" },
                new Elephant() { Id = "E5" }
            };

            simtime = simtime.AddHours(1);
            Console.WriteLine(simtime.ToLongTimeString());

            MonkeyHealthCheck();
            GiraffeHealthCheck();
            ElephantHealthCheck();

            do
            {
                if ( Console.ReadKey().KeyChar == ' ' )
                {
                    int randHealth = 0;
                    randHealth = _rnd.Next(10, 25);
                    foreach (var item in monkeyList)
                        item.Health += randHealth;
                    randHealth = _rnd.Next(10, 25);
                    foreach (var item in giraffeList)
                        item.Health += randHealth;
                    randHealth = _rnd.Next(10, 25);
                    foreach (var item in elephantList)
                        item.Health += randHealth;
                }
            }
            while (true);

        }

        static void OnTimerEvent(object sender, ElapsedEventArgs e)
        {
            simtime = simtime.AddHours(1);
            Console.WriteLine(simtime.ToLongTimeString());
            MonkeyHealthCheck();
            GiraffeHealthCheck();
            ElephantHealthCheck();
            Console.WriteLine("Press spacebar to feed the animals");
        }

        static void MonkeyHealthCheck()
        {
            foreach (var item in monkeyList)
            {
                if (item.Alive)
                {
                    item.Health -= _rnd.Next(0, 20);
                    item.HealthChanged();
                    if (item.Alive)
                        Console.WriteLine(item.Id + " - " + item.Health);
                    else
                        Console.WriteLine(item.Id + " - is dead");
                }
            }
        }

        static void GiraffeHealthCheck()
        {
            foreach (var item in giraffeList)
            {
                if (item.Alive)
                {
                    item.Health -= _rnd.Next(0, 20);
                    item.HealthChanged();
                    if (item.Alive)
                        Console.WriteLine(item.Id + " - " + item.Health);
                    else
                        Console.WriteLine(item.Id + " - is dead");
                }
            }
        }

        static void ElephantHealthCheck()
        {
            foreach (var item in elephantList)
            {
                if (item.Alive)
                {
                    item.Health -= _rnd.Next(0, 20);
                    item.HealthChanged();
                    if (item.Alive)
                    {
                        Console.WriteLine(item.Id + " Can Walk - " + item.CanWalk);
                        Console.WriteLine(item.Id + " - " + item.Health);
                    }
                    else
                        Console.WriteLine(item.Id + " - is dead");
                }
            }
            Console.WriteLine();
        }

    }
}
