namespace Chuong5_Bai5;

internal class Chuong5_Bai5
{
    static void Main(string[] args)
    {
        //declare variables
        int num = 0;
        int sum = 0;
        //input
        Console.WriteLine("Nhap vao 1 so");
        int.TryParse(Console.ReadLine(), out num);
        //processing
        for (int i = 1; i < num; i++)
        {
            if (num % i == 0)
            {
                sum += i;
                //Console.WriteLine(i);
            }
        }
        if (sum == num)
        {
            Console.WriteLine($"{num} la so hoan hao");
        }else
        {
            Console.WriteLine($"{num} khong phai la so hoan hao");
        }

    }
}
