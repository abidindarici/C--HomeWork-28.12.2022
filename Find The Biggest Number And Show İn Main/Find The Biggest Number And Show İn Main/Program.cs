internal class Program
{
    private static void Main(string[] args)
    {
        enbuyuksayi();
    }

    public static void enbuyuksayi()
    {
        Console.Write("1. sayıyı girin:");
        int sayi = Convert.ToInt32(Console.ReadLine());
        int enBuyuk = sayi;

        for (int i = 1; i < 10; i++)
        {
            Console.Write("{0}. sayıyı girin:", i + 1);
            sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi > enBuyuk)
                enBuyuk = sayi;
        }
        Console.WriteLine("Girilen en büyük sayı={0}", enBuyuk);
        Console.ReadKey();
    }
}
