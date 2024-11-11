namespace Chuong5_Bai13;

internal class Chuong5_Bai13
{
    static void Main(string[] args)
    {
        Console.Write("Nhap so dong cua tam giac pascal: ");
        int rows = int.Parse(Console.ReadLine());

        for (int i = 0; i < rows; i++)
        {
            // Tính và in các phần tử của hàng thứ i
            int number = 1; // Phần tử đầu tiên trong mỗi hàng là 1
            for (int k = 0; k <= i; k++)
            {
                Console.Write(number + " ");

                // Cập nhật giá trị của `number` cho phần tử tiếp theo
                number = number * (i - k) / (k + 1);
            }

            Console.WriteLine();
        }
    }
}
