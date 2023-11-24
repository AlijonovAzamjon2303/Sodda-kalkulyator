using Sodda_kalkulyator;
internal class Program
{
    private static void Main(string[] args)
    {
        string? s = Console.ReadLine();
        Console.WriteLine("Natija = " + Calculator.Calculate(s));
    }
}