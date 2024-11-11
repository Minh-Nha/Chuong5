namespace Chuong5_Bai15;

internal class Chuong5_Bai15
{
    static void Main(string[] args)
    {
        //Console.Write("Nhập một số nguyên dương: ");
        //string number = Console.ReadLine();

        //// Đảo ngược chuỗi
        //char[] charArray = number.ToCharArray();
        //Array.Reverse(charArray);
        //string reversedString = new string(charArray);

        //// Chuyển lại thành số nguyên
        //int reversedNumber = int.Parse(reversedString);

        //Console.WriteLine("Số ngược lại là: " + reversedNumber);

        Console.Write("Nhập một số nguyên dương: ");
        int.TryParse(Console.ReadLine(), out int number);

        int reversedNumber = 0;
        while (number > 0)
        {
            int remainder = number % 10;
            reversedNumber = reversedNumber * 10 + remainder;
            number /= 10;
        }

        Console.WriteLine("Số ngược lại là: " + reversedNumber);
    }
}
