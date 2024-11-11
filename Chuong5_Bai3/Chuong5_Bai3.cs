namespace Chuong5_Bai3;

internal class Chuong5_Bai3
{
    static void Main(string[] args)
    {
        int num = 0;
        Console.WriteLine("Nhap vao 1 so: ");
        int.TryParse(Console.ReadLine(), out num);
        //processing
        bool laSNT = true;
        //int demVL = 0;
        for(uint i = 2; i <= num - 1;i++)
        {
            //demVL++;
            if (num % i == 0)
            {
                laSNT = false;
                break;

            }

        }
        //Console.WriteLine($"so vong lap: {demVL}" );
        //Kiem tra so luong uoc so 
        if (laSNT == true)
        {
            Console.WriteLine($"{num} la so nguyen to");
        }else
        {
            Console.WriteLine($"{num} khong la so nguyen to");
        }
    }
}
