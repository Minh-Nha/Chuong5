namespace Chuong5_Vidu8;

internal class Vidu8
{
    static void Main(string[] args)
    {
        int i = 0;
        int j = 0;
        for ( i = 1; i < 6; i++)
        {
            for (j = 1; j < 6; j++)
            {
                if (j == 3)
                {
                    break;
                }
                Console.Write($"({i} , {j})  ");
            }
            Console.WriteLine();
        }
    }
}
