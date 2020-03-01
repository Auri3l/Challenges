using System;

namespace RandomNameGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            string[] name = { "Ata", "Yiğit", "Öbürü" };
            string[] surname = { "Telli", "Değil", "Başka" };
            Console.WriteLine(name[rand.Next(0, name.Length)] + " " + surname[rand.Next(0, surname.Length)]);
        }
    }
}
