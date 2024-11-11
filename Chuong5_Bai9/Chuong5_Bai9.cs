namespace Chuong5_Bai9;

internal class Chuong5_Bai9
{
    static void Main(string[] args)
    {
        int n;
        //
        Console.WriteLine("Nhap n: ");
        int.TryParse(Console.ReadLine(), out n);
        //
        for (int i = 0; i <= n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}
