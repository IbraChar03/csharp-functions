namespace csharp_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 funzione

            //int[] arrayNum = { 3, 4, 2, 6, 8, 9, 23, 7, 12 };
            //StampaArray(arrayNum);

            //2 funzione

            //int num;
            //Console.Write("Inserisci un numero : ");
            //int.TryParse(Console.ReadLine(), out num);
            //Console.WriteLine($"Il quadrato di {num} è {Quadrato(num)} ");

            //3 funzione
            int[] arrayNum = { 4, 2, 8, 12, 6, 17, 22, 9 };
            int[] arrayCopia = (int[])arrayNum.Clone();
            ElevaArrayAlQuadrato(arrayCopia);
            Console.Write("[");
            for (int i = 0; i < arrayCopia.Length; i++)
            {

                Console.Write(arrayCopia[i]);

                if (arrayCopia[i] != arrayCopia[arrayCopia.Length - 1])
                    Console.Write(",");

            }
            Console.Write("]");


        }
        //1 funzione

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


        //2 funzione
        //public static int Quadrato(int num)
        //{
        //    int quadrato = num*num;
        //    return quadrato;

        //}


        //3 funzione
        public static int[] ElevaArrayAlQuadrato(int[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] * array[i];
            }
            return array;

        }

    }
}