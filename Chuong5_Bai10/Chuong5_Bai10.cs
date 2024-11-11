namespace Chuong5_Bai10;

internal class Chuong5_Bai10
{
    static void Main(string[] args)
    {
        int n;
        Console.WriteLine("Nhap n ");
        int.TryParse(Console.ReadLine(), out n);
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }

            // In dấu * cho dòng hiện tại
            for (int k = 1; k <= i; k++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }

    }
}
