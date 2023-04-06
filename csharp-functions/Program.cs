namespace csharp_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arrayNum = { 3, 4, 2, 6, 8, 9, 23, 7, 12 };
            //StampaArray(arrayNum);

            int num;
            Console.Write("Inserisci un numero : ");
            int.TryParse(Console.ReadLine(),out num);
           
            Console.WriteLine($"Il quadrato di {num} è {Quadrato(num)} ");
        }
        //public static void StampaArray(int[] array)
        //{
        //    Console.Write("[");
        //    for (int i = 0; i < array.Length; i++)
        //    {
              
        //        Console.Write(array[i]);

        //        if (array[i] != array[array.Length-1])
        //         Console.Write(",");
          
        //    }
        //    Console.Write("]");
        //}
        public static double Quadrato(int num)
        {
            double quadrato = Math.Sqrt(num);
            return quadrato;

        }

    }
}