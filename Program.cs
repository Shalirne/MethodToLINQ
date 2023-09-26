using System.Collections;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Xml.Linq;

namespace MethodToLINQ
{
    internal class Program
    {
        public static List<Person> person = new List<Person>();
        static void Main(string[] args)
        {
            String[] name = { "Игорь", "Николай", "Руслан", "Алексей", "Юрий", "Ярослав", "Семен", "Евгений", "Олег", "Артур", "Петр", "Степан", "Илья" };
            var rnd = new Random();
            List<int> IEnumerable1 = new List<int>();
            for (int i = 0; i < 50; i++)
            {
                IEnumerable1.Add(rnd.Next(0, 10000));
            }
            for (int i = 0; i < 12; i++)
            {
                person.Add(new Person { Name = name[i], Age = rnd.Next(20, 55) });
            }
            var selectedNumbers = IEnumerable1.Top(41);
            var selectedUsers = person.Top(33, p => p.Age);
            Console.WriteLine(JsonSerializer.Serialize(selectedNumbers));
            Console.WriteLine(JsonSerializer.Serialize(selectedUsers));
        }
    }
}