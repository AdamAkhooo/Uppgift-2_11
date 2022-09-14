using System;
namespace Uppgift_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur långt hoppade Alma och Elin i meter?");
            Console.WriteLine("Elin:  ");

            string Elin = Console.ReadLine();
            
            Console.WriteLine("Alma:  ");

            string Alma = Console.ReadLine();

            int Elinint = int.Parse(Elin);
            int Almaint = int.Parse(Alma);
            int skillnad = Elinint - Almaint;

            Console.WriteLine("Skillnaden mellan dem blir då " + skillnad + " meter ");






        }
    }
}
