namespace task206
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sozlerden ibaret arrayin icerisinde verilmis sozu tapin. (Mes: ["lorem", "ipsum"] => ipsum'u tapin)

            string[] words = { "lorem", "ipsum", "hello", "world" };
            Console.WriteLine("Sozu daxil et:");
            string grade = Console.ReadLine();
            bool answer = false;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == grade)
                {
                    answer = true;
                    break;
                }
            }
            if ( answer)
            {
                Console.WriteLine("Soz tapildi");
            }
            else
            {
                Console.WriteLine("Soz tapilmadi");
            }
        }
    }
}
