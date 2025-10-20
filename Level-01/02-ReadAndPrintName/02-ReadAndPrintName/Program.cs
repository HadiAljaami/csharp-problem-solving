
using System.Runtime.CompilerServices;

namespace _02_ReadAndPrintName
{
    internal class Program
    {
        static bool IsValidName(string name)
        {
            return !string.IsNullOrWhiteSpace(name);
        }

        static string ReadName()
        {
            string Name= string.Empty;
            bool isValid = false;



            Console.WriteLine("Enter Your Name Please : ");

            do 
            {
                Name = Console.ReadLine()!;
                 isValid = IsValidName(Name);
                if (!isValid)
                {
                    Console.WriteLine("Name cannot be empty. Please enter your name:");
                }
            }
            while (!isValid);
  
            return Name;
        }

        static string  PrintName(string name)
        {
            return name;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("My Name Is :" + PrintName(ReadName()));
        }
    }
}
