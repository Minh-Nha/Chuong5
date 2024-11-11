namespace Chuong5_Vidu10;

internal class Vidu10
{
    static void Main(string[] args)
    {
        int i = 0;
        int j = 0;
        for (i = 0; i < 6; i++)
        {
            for (j = 0; j < 6; j++)
            {
                if(j == 3)
                {
                    continue;
                }
                Console.Write($"({i}, {j})  ");
            }
            Console.WriteLine();
        }
    }
}
