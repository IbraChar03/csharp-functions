namespace csharp_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNum = { 3, 4, 2, 6, 8, 9, 23, 7, 12 };
            StampaArray(arrayNum);
        }
        public static void StampaArray(int[] array)
        {
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
            {
              
                Console.Write(array[i]);

                if (array[i] != array[array.Length-1])
                 Console.Write(",");
          
            }
            Console.Write("]");
        }
    }
}