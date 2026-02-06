namespace task106
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ededlerden ibaret bir array verilir, bu arrayin icerisindeki en boyuk elementi tapin.

            int[] numbers = { 5, 12, 16, 18, 22 };
            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine("En boyuk eded:" + max);
        }
    }
}
