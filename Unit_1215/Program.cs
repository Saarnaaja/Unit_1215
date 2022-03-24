using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Unit_1215
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var users = GetTestUsers();
            Console.WriteLine("Введите ваш логин:");
            string login = Console.ReadLine();
            var user = users.FirstOrDefault(x => x.Login == login);
            if (user == null)
            {
                Console.WriteLine("Пользователь не найден!");
                return;
            }
            Console.WriteLine($"{user.Name}, Добро пожаловать!");
            if (!user.IsPremium)
            {
                ShowAds();
            }
        }

        private static List<User> GetTestUsers()
        {
            var users = new List<User>()
            {
                new User() { Login = "user1", Name = "name1", IsPremium = false },
                new User() { Login = "user2", Name = "name2", IsPremium = true },
                new User() { Login = "user3", Name = "name3", IsPremium = false },
                new User() { Login = "user4", Name = "name4", IsPremium = true },
                new User() { Login = "user5", Name = "name5", IsPremium = false },
                new User() { Login = "user6", Name = "name6", IsPremium = true },
            };
            return users;
        }

        private static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            Thread.Sleep(3000);
        }
    }
}
