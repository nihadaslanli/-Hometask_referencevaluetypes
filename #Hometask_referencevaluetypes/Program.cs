namespace _Hometask_referencevaluetypes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region task1
            //int[] numbers = { -2, -1, 1, 2, 3, -4 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] < 0)
            //    { numbers[i] *= -1;}

            //    Console.WriteLine(numbers[i]);
            #endregion






            #region task5
            //Console.WriteLine("Hello, World!");

            //string word = "salam";
            //char[] characters = word.ToCharArray();

            //Array.Reverse(characters);

            //string reversedWord = new string(characters);

            //Console.WriteLine("Tersine Çevrilmiş söz: " + reversedWord);
            #endregion


           
            {
                Console.WriteLine(Repeat("Ha!"));
                Console.WriteLine(Repeat("Ha!", 2));
                Console.WriteLine(Repeat("Ha!", 3));
            }

            static string Repeat(string word, int count = 1)
            {
                string result = "";
                for (int i = 0; i < count; i++)
                {
                    result += word;
                }
                return result;
            }
        }
    }
}
