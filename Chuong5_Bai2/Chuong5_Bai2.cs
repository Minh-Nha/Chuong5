namespace Chuong5_Bai2;

internal class Chuong5_Bai2
{
    static void Main(string[] args)
    {
        int num;
       

        do
        {
            Console.WriteLine("Nhap vao 1 so nguyen duong: ");
            int.TryParse(Console.ReadLine(), out num);
            if(num < 0)
            {
                Console.WriteLine("Nhap sai vui long nhap lai");
            }
        } while (num < 0);
        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0) {
                Console.Write($"     {i}");
            }
        }
    }
}
