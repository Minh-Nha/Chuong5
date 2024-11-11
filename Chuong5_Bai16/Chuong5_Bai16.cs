namespace Chuong5_Bai16;

internal class Chuong5_Bai16
{
    static void Main(string[] args)
    {
        Console.Write("Nhap 1 so nguyen duong: ");
        int number = int.Parse(Console.ReadLine());

        int originalNumber = number;
        int reversedNumber = 0;

        // Đảo ngược số
        while (number > 0)
        {
            int remainder = number % 10;
            reversedNumber = reversedNumber * 10 + remainder;
            number /= 10;
        }

        // Kiểm tra số đối xứng
        if (originalNumber == reversedNumber)
        {
            Console.WriteLine("So nay la so doi xung.");
        }
        else
        {
            Console.WriteLine("So nay khong phai la so doi xung.");
        }
    }
}
