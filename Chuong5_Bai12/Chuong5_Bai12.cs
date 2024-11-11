namespace Chuong5_Bai12;

internal class Chuong5_Bai12
{
    static void Main(string[] args)
    {
        Console.Write("Nhap so nguyen duong n: ");
        int.TryParse(Console.ReadLine(), out int n );

        if (n <= 1)
        {
            Console.WriteLine("Vui long nhap so nguyen duong lon hon 1");
        }
        else
        {
            Console.WriteLine($"Cac so nguyen to tu 1 den {n} la :");
            // Duyệt qua tất cả các số từ 2 đến n
            for (int i = 2; i <= n; i++)
            {
                bool isPrime = true;

                // Kiểm tra xem i có phải là số nguyên tố không
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                // In số i nếu nó là số nguyên tố
                if (isPrime)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
