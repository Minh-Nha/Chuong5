namespace Chuong5_Vidu6;

internal class Vidu6
{
    static void Main(string[] args)
    {
        //Nhap so nguyen
        //In bang cuu chuong
        for (int i = 2; i <= 9; i++)
        {
            Console.Write("**************");
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"{i} * {j} = {i*j}");                
            }
        }
    }
}
