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
            string nameGet = name[rand.Next(0, name.Length)].ToLower();
            string surnameGet = surname[rand.Next(0, surname.Length)].ToLower();
            nameGet = char.ToUpper(nameGet[0]) + nameGet.Substring(1).ToLower();
            surnameGet = char.ToUpper(surnameGet[0]) + surnameGet.Substring(1).ToLower();
            Console.WriteLine(nameGet + " " + surnameGet "/n/n" + "Dosyada " + name.Length + " ad " + surname.Length + " soyad bulunmaktadır.");
        }
    }
}