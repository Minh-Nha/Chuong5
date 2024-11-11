namespace Chuong5_Bai17;

internal class Chuong5_Bai17
{
    static void Main(string[] args)
    {
        // Duyệt qua tất cả các số nguyên trong phạm vi 10 đến 99
        for (int num = 10; num <= 99; num++)
        {
            int a = num / 10; // Chữ số hàng chục
            int b = num % 10; // Chữ số hàng đơn vị

            // Kiểm tra điều kiện tích của 2 chữ số bằng 2 lần tổng của 2 chữ số
            if (a * b == 2 * (a + b))
            {
                Console.WriteLine(num);
            }
        }
    }
}
