namespace Chuong5_Bai11;

internal class Chuong5_Bai11
{
    static void Main(string[] args)
    {
        double sum1 = 0;
        double sum2 = 0;
        Console.WriteLine("Nhap gia tri cua x");
        int.TryParse(Console.ReadLine(), out int x);
        Console.WriteLine("Nhap gia tri cua n");
        int.TryParse(Console.ReadLine(), out int n);
        //
        for (int i = 1; i <= n; i++)
        {
            sum1 += Math.Pow(x, i);
        }
        Console.WriteLine($"a) S = 1 + x + x^2 + x^3 + ... + x^n = {sum1} ");
        //
        for (int i = 1;i <= n; i++)
        {
            // Tính từng phần tử của dãy theo công thức (-1)^i * x^i
            sum2 += (int)(Math.Pow(-1, i) * Math.Pow(x, i));
        }
        Console.WriteLine($"b) S = {sum2}");
    }
}
