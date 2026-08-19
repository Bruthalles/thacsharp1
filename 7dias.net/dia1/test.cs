namespace test
{
    class TEst
    {
        static void Main(string[] args)
        {
            string[] n = new string[5];
            n = ["1", "2", "3", "4", "5"];

            int tamanho = n.Length;
            Console.WriteLine($"{tamanho}--- {n}");
        }
    }
}