namespace Chuong5_Vidu1;

internal class Vidu1
{
    static void Main(string[] args)
    {
        int num = 0;
        Console.WriteLine("Nhap vao 1 so nguyen: ");
        num = int.Parse(Console.ReadLine());
        //in cac so tu 1 den num ra man hinh
        for (int i = 0; i <= num; i++)
        {
            Console.Write($" {i}");
        }
    }
}
