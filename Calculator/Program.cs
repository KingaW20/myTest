using System;

namespace Calculator
{
    class Program
    {
        public enum OptionType
        {
            None = 0,
            Sum = 1,
            Substract = 2
        }

        public enum OptionType
        {
            var option = DisplayMenuForUser();

            switch (option)
            {
                case OptionType.Sum:
                    Sum();
                    break;
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
            Console.WriteLine("1. Sum");
            Console.WriteLine("2. Substract");

            var option = Console.ReadLine();
            return (OptionType)Enum.Parse(typeof(OptionType), option);
        }

        private static void Sum()
        {
            Console.WriteLine("Give me 2 numbers:");
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            Console.WriteLine($"Your result is {x + y}.");
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
