internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Bir sayi giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        int faktoriyel = 1;
        for (int i = 1; i <= sayi; i++)
        {
            faktoriyel *= i;
        }
        Console.WriteLine(sayi + "! = " + faktoriyel);

        Console.ReadLine();
    }
}