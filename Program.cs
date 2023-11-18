namespace SpreadTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Spread();
            Console.WriteLine();
            Console.WriteLine();
            Spread2();
            Console.WriteLine();
        }

        static void Spread()
        {
            Console.WriteLine();
            int[] row1 = [ 1, 2, 3 ];
            int[] row2 = [ 4, 5, 6 ];
            int[] row3 = [ 7, 8, 9 ];
            int[] ints = [ ..row1, ..row2, ..row3 ];

            foreach (var element in ints)
            {
                Console.Write($"{element}, ");
            }
        }

        static void Spread2()
        {
            string[] day1 = ["Monday", "Tuesday", "Wednesday"];
            string[] day2 = ["Thursday", "Friday"];
            string[] day3 = ["Saturday", "Sunday"];
            string[] strings = [.. day1, .. day2, .. day3];

            foreach (var days in strings)
            {
                Console.Write($"{days}, ");
            }
        }
    }
}
