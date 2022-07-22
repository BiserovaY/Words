class Program
{
    enum Variant { рублей, рубль, рубля };

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nВведите число");
            Console.WriteLine(Case(long.Parse(Console.ReadLine())));
        }

    }

    static string Case(long number)
    {
        long result = (number % 100 > 20) ? number % 10 : number % 20;
        Console.WriteLine("Результат: ");
        switch (result)
        {
            case 1: return number + " " + Variant.рубль.ToString();
            case 2:
            case 3:
            case 4: return number + " " + Variant.рубля.ToString();
            default: return number + " " + Variant.рублей.ToString();

        }

    }
}