class Program
{
    /// <summary>
    ///  Method calculates the number of trailing zeros in a factorial of a given number.
    ///  As n grows large, factorials begin acquiring tails of trailing zeros. It works with large numbers.
    /// </summary>
    /// <param name="n">number</param>
    /// <returns>number of trailing zeroes</returns>
    public static int TrailingZeros(int n)
    {
        if (n <= 0) throw new Exception("Number must be positive");
        int result = 0;
        double k = Math.Log(n) / Math.Log(5);

        for (int i = 1; i <= k; i++)
        {
            result += (int)(n / Math.Pow(5, i));
        }
        return result;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Tests:");
        for (int i = 1; i < 10; i++)
        {
            Console.WriteLine(i + " " + TrailingZeros(i));
        }
        for (int i = 2000000000; i < 2000000010; i++)
        {
            Console.WriteLine(i + " " + TrailingZeros(i));
        }
        // TrailingZeros(0); //exception
    }
}