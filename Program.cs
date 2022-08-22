namespace HashTable
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FrequencyOfWords<string, string> hash = new FrequencyOfWords<string, string>(5);

            hash.GetFreq();



            Console.ReadKey();

        }
    }
}
