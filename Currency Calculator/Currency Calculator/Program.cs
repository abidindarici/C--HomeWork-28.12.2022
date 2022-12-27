internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Dolar Kurunu Giriniz: ");
        double dolar = double.Parse(Console.ReadLine());
        Console.WriteLine("Euro Kurunu Giriniz: ");
        double euro = double.Parse(Console.ReadLine());
        Console.WriteLine("Sterlin Kurunu Giriniz: ");
        double sterlin = double.Parse(Console.ReadLine());
        Console.WriteLine("Elinizdeki TL Miktarını Giriniz: ");
        double tl = double.Parse(Console.ReadLine());

        Console.WriteLine("Alabileceğiniz Dolar Miktarı: "+ "{0:0.00}",(tl/dolar));
        Console.WriteLine("Alabileceğiniz Euro Miktarı: " + "{0:0.00}", (tl / euro));
        Console.WriteLine("Alabileceğiniz Sterlin Miktarı: " + "{0:0.00}", (tl / sterlin));
        Console.ReadKey();
    }
}