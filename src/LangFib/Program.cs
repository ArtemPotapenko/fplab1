using System.Numerics;

class Program
{
    public static void Main(string[] args)
    {
        BigInteger a = 0;
        BigInteger b = 1;
        int count = 1;
        while (b.ToString().Length < 1000)
        {
            count++;
            b = BigInteger.Add(a, b);
            a = BigInteger.Subtract(b, a);
        }

        Console.WriteLine(count);
    }
}