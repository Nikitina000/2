using MySqlConnector;

namespace Zadanie2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var eats = db.Eat.ToList();
                Console.WriteLine("Еда и ее граммовка");
                foreach (var s in eats)
                {
                    Console.WriteLine($"{s.Id} {s.name} {s.weight}");
                }
            }



        }
    }
}