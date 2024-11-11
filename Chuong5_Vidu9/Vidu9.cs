namespace Chuong5_Vidu9;

internal class Vidu9
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 10; i++)
        {
            if (i == 5)
            {
                continue;
            }
            Console.Write($"{i}    ");
        }
    }
}
