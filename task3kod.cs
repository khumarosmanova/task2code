namespace task3codee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array verilir ve n ededi daxil olunur, eger n ededi arrayin icerisindeki istenilen bir ededden boyukdurse true, deyilse false yazdirin.

            int[] numbers = { 25, 38, 110, 212 };
            int n = 15;

            bool answer = false;
            for(int i = 0; i < numbers.Length; i++)
            {
                if(n > numbers[i])
                {
                    answer = true;
                    break;
                }
            }
            Console.WriteLine(answer);

        }
    }
}
