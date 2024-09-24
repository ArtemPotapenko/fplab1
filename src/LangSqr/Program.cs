namespace LangSqr;

class Program
{
    public static void Main(string[] args)
    {
        int sum = 0;
        for (int i = 0; i <= 100; i++)
        {
            for (int j = 0; j < i; j++)
            {
                sum += j * i * 2;
            }
        }   
        Console.WriteLine(sum);
    }
}