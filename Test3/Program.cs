using System;
using System.Linq;

namespace Test3
{
    class Program
    {
        static void Main(string[] args)
        {
            // добавление данных
            //using (ApplicationContext db = new ApplicationContext())
            //{
            //    // создаем два объекта User
            //    User user1 = new User { Name = "Tom", Surname = "Tom2", Patronymic = "Tom3" };
            //    User user2 = new User { Name = "Alice", Surname = "Alice2", Patronymic = "Alice3" };

            //    // добавляем их в бд
            //    db.Operators.AddRange(user1, user2);
            //    db.SaveChanges();
            //}
            // получение данных
            using (ApplicationContext db = new ApplicationContext())
            {
                // получаем объекты из бд и выводим на консоль
                var users = db.Operators.ToList();
                Console.WriteLine("Users list:");
                foreach (User u in users)
                {
                    Console.WriteLine($"{u.id}.{u.Name} - {u.Surname}");
                }
            }
        }
    }
}
//Scaffold-DbContext "Host=localhost;Port=5432;Database=DBRimeraDefect;Username=postgres;Password=scisci"
//Npgsql.EntityFrameworkCore.PostgreSQL
