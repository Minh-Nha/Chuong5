namespace Chuong5_Bai6;

internal class Chuong5_Bai6
{
    static void Main(string[] args)
    {
        int num;
        int n1 = 0, n2 = 1, n3 = 0;
        Console.WriteLine("Nhap so ");
        int.TryParse(Console.ReadLine(), out num);
        //
        if (num == 1)
        {
            Console.WriteLine("So hang thu 1 cua day Fibonacci la 0");
            return;
        }
        else if (num == 2)
        {
            Console.WriteLine("So hang thu 2 cua day Fibonacci la 1");
            return;
        }
        //
        for (int i = 2; i <= num; i++)
        {
            n3 = n1 + n2;
            Console.WriteLine(n3);
            n1 = n2;
            n2 = n3;
        }
        Console.WriteLine($"So hang thu {num} cua day Fibonacci la {n3}" );

    }
}
