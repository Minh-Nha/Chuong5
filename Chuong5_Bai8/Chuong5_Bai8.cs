namespace Chuong5_Bai8;

internal class Chuong5_Bai8
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 9; i++)
        {
            Console.WriteLine();
            for(int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"{i} x {j} = {i * j}");
            }
        }
    }
}
