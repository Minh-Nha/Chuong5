namespace Chuong5_Vidu2;

internal class Vidu2
{
    static void Main(string[] args)
    {
        int num = 0;
        //Nhap so nguyen duong
        Console.WriteLine("Nhap vao 1 so nguyen: ");
        num = int.Parse(Console.ReadLine());
        //Kiem tra dieu kien nhap
        while (num <= 0)
        {
            Console.WriteLine("Vui long nhap vao 1 so nguyen duong: ");
            num = int.Parse(Console.ReadLine());
        }   
    }
}
