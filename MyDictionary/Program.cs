// See https://aka.ms/new-console-template for more information
namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> dictionary = new MyDictionary<int, string>();
            dictionary.Add(1, "Aydın");
            dictionary.Add(2, "Ankara");
            dictionary.Add(3, "İstanbul");
            dictionary.Add(4, "Bursa");
            dictionary.Add(5, "İzmir");

            for (int i = 0; i < dictionary.Key.Length; i++)
            {
                Console.WriteLine(dictionary.Key[i]);
            }

            for (int i = 0; i < dictionary.Value.Length; i++)
            {
                Console.WriteLine(dictionary.Value[i]);
            }
        }
    }
}
