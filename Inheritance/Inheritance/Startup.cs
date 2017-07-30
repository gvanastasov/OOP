using Inheritance.Animals;
using Inheritance.Animals.Enums;
using Inheritance.BookShop;
using Inheritance.Mankind;
using Inheritance.MordersCrueltyPlan;
using Inheritance.OnlineRadioDatabasse;
using Inheritance.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Startup
    {
        static void Main()
        {
            Task6();
        }

        private static void Task1()
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            try
            {
                Child child = new Child(name, age);
                Console.WriteLine(child);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }

        private static void Task2()
        {
            try
            {
                string author = Console.ReadLine();
                string title = Console.ReadLine();
                decimal price = decimal.Parse(Console.ReadLine());

                Book book = new Book(author, title, price);
                GoldenEditionBook goldenEditionBook = new GoldenEditionBook(author, title, price);

                Console.WriteLine(book);
                Console.WriteLine(goldenEditionBook);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void Task3()
        {
            try
            {
                var studentTokens = Console.ReadLine().Split(' ');
                var workerTokens = Console.ReadLine().Split(' ');

                var student = new Student(studentTokens[0], studentTokens[1], studentTokens[2]);
                var worker = new Worker(workerTokens[0], workerTokens[1], decimal.Parse(workerTokens[2]), int.Parse(workerTokens[3]));

                Console.WriteLine(student.ToString() + Environment.NewLine + worker.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void Task4()
        {
            var songCount = int.Parse(Console.ReadLine());
            var playlist = new Playlist();

            for (int i = 0; i < songCount; i++)
            {
                try
                {
                    var dataString = Console.ReadLine();

                    playlist.TryAddSong(dataString);
                    Console.WriteLine("Song added.");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.WriteLine($"Songs added: {playlist.Songs.Count}");
            Console.WriteLine($"Playlist length: {playlist.Length}");
        }

        private static void Task5()
        {
            var foodData = Console.ReadLine().Split(new string[] { ", ", " " }, StringSplitOptions.RemoveEmptyEntries);

            var happinesPoints = 0;
            foreach (var foodName in foodData)
            {
                var food = FoodFactory.Get(foodName);
                happinesPoints += food.Points;
            }

            var mood = MoodFactory.Get(happinesPoints);
            Console.WriteLine(happinesPoints + Environment.NewLine + mood.Name);
        }

        private static void Task6()
        {
            while (true)
            {
                var cmd = Console.ReadLine();

                if(cmd == "Beast!")
                {
                    break;
                }

                try
                {
                    cmd = cmd.ToLower();

                    Type type = typeof(Animal).Assembly.GetTypes().Where(t => t.IsSubclassOf(typeof(Animal))).FirstOrDefault(t => t.Name.ToLower() == cmd);

                    if(type != null)
                    {
                        var tokens = Console.ReadLine().Split(' ');

                        var name = tokens[0];
                        var age = int.Parse(tokens[1]);
                        Gender gender;
                        Enum.TryParse(tokens[2], out gender);

                        var animal = Activator.CreateInstance(type, name, age, gender) as Animal;

                        animal.ProduceSound();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
