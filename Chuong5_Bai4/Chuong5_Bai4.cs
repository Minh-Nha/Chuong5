namespace Chuong5_Bai4;

internal class Chuong5_Bai4
{
    static void Main(string[] args)
    {
        int num = 0;
        do
        {
            Console.WriteLine("Nhap vao 1 so nguyen duong: ");
            int.TryParse(Console.ReadLine(), out num);
        } while (num <= 0);

        //Cách 1
        int sqrt = (int)Math.Sqrt(num);
        if (sqrt * sqrt == num)
        {
            Console.WriteLine($"{num} la so chinh phuong");
        }
        else
        {
            Console.WriteLine($"{num} khong phai la so chinh phuong");
        }

        //Cách 2
        //bool laSCP = false;
        //for (int i = (int)Math.Sqrt((double)num) - 1; i <= (int)Math.Sqrt((double)num); i++)
        //{
        //    if (i * i == num)
        //    {
        //        laSCP = true;
        //        break;
        //    }
        //}
        //if (laSCP == true)
        //{
        //    Console.WriteLine($"{num} la so chinh phuong");
        //}
        //else
        //{
        //    Console.WriteLine($"{num} khong phai la so chinh phuong");
        //}

    }
}
