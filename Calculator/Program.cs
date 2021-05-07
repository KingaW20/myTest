using System;

namespace Calculator
{
    class Program
    {
        public enum OptionType
        {
            None = 0,
            Sum = 1
        }

        static void Main(string[] args)
        {
            var option = DisplayMenuForUser();

            switch (option)
            {
                case OptionType.Sum:
                    Sum();
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
    }
}
