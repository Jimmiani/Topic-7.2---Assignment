using System.Xml.Schema;

namespace Topic_7._2___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LOOK! THE ROCKET'S BLASTING OFF!!!");
            Console.WriteLine();
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
            Console.WriteLine();
            Console.WriteLine("BLAST OFF!!");
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Do you like tables of value? I do too! Look at this one I worked very hard on!");
            Console.WriteLine();
            Console.WriteLine("\t X \t Y");
            Console.WriteLine("\t------------");
            for (double i = -10; i <= 10; i += 2)
            {
                double xVar = i, yVar = Math.Pow(i, 2);
                Console.WriteLine("\t" + xVar + "|\t" + yVar);
            }
        }
    }
}
