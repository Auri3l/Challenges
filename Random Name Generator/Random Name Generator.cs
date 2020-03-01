using System;

namespace RandomNameGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            string[] name = System.IO.File.ReadAllLines(@"C:\Users\Ata Yiğit TELLİ\Source\Repos\Challenges\Random Name Generator\Namelists\isimler.txt");
            string[] surname = System.IO.File.ReadAllLines(@"C:\Users\Ata Yiğit TELLİ\Source\Repos\Challenges\Random Name Generator\Namelists\soyisimler.txt");
            Console.WriteLine(name[rand.Next(0, name.Length)].ToLower() + " " + surname[rand.Next(0, surname.Length)].ToLower());
        }
    }
}