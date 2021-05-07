using System;

namespace Calculator
{
    class Program
    {
        public enum OptionType
        {
            None = 0,
            Substract = 1
        }

        static void Main(string[] args)
        {
            var option = DisplayMenuForUser();

            switch (option)
            {
                case OptionType.Substract:
                    Substract();
                    break;
                case OptionType.None:
                    return;
            }

            Console.Read();
        }

        private static OptionType DisplayMenuForUser()
        {
            Console.WriteLine("Choose option to do some crazy stuff:");
            Console.WriteLine("1. Substract");

            var option = Console.ReadLine();
            return (OptionType)Enum.Parse(typeof(OptionType), option);
        }

        private static void Substract()
        {
            Console.WriteLine("Give me 2 numbers:");
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            Console.WriteLine($"Your result is {x - y}.");
        }
    }
}
