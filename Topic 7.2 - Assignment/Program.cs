using System.Xml.Schema;

namespace Topic_7._2___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool done = false;
            string choice = "";
            while (!done)
            {
                Console.Clear();
                Console.WriteLine("Welcome to my super cool main menu! Select any option.");
                Console.WriteLine();
                Console.WriteLine("1. Rocket Blast Off");
                Console.WriteLine("2. Table of Values");
                Console.WriteLine("3. Fun Loop");
                Console.WriteLine("Q. Quit");
                Console.WriteLine();
                Console.Write("Select option: ");
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    RocketBlast();
                }
                else if (choice == "2")
                {
                    ValueTable();
                }
                else if (choice == "3")
                {
                    FunLoop();
                }
                else if (choice.ToUpper().Trim() == "Q")
                {
                    done = true;
                }
                Console.WriteLine();
                Console.WriteLine("Hope you enjoyed your time!");
                Console.WriteLine("Goodbye Buckaroo!");
            }
        }
        public static void RocketBlast()
        {
            Console.Clear();
            Console.WriteLine("LOOK! THE ROCKET'S BLASTING OFF!!!");
            Console.WriteLine();
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(600);
            }
            Console.WriteLine();
            Console.WriteLine("BLAST OFF!!");
            Console.WriteLine();
            Console.WriteLine("Press Enter to return to main menu.");
            Console.ReadLine();
            Console.Clear();
        }
        public static void ValueTable()
        {
            Console.Clear();
            Console.WriteLine("Do you like tables of value? I do too! Look at this one I worked very hard on! The equation for this function is y = x\xB2");
            Console.WriteLine();
            Console.WriteLine("\t X \t\t Y");
            Console.WriteLine("\t------------------");
            for (double i = -10; i <= 10; i += 2)
            {
                double xVar = i, yVar = Math.Pow(i, 2);
                Console.WriteLine("\t" + xVar + "\t|\t" + yVar);
            }
            Console.WriteLine();
            Console.WriteLine("Press Enter to return to main menu.");
            Console.ReadLine();
            Console.Clear();
        }
        public static void FunLoop()
        {
            string name;
            int endNumber = 10;
            Console.Clear();
            Console.WriteLine("Hello there sir! Give me your name, and I'll repeat it 10 times!");
            Console.WriteLine();
            Console.Write("Enter name here: ");
            name = Console.ReadLine();
            Console.WriteLine();
            if (name.ToLower() == "aldworth")
                endNumber = 5;
            for (int i = 1; i <= endNumber; i++)
            {
                Console.WriteLine(i + ". " + name);
            }
            Console.WriteLine();
            Console.WriteLine("Pretty cool, huh?");
            Console.WriteLine();
            Console.WriteLine("Press Enter to return to main menu.");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
