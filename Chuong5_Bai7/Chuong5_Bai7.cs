namespace Chuong5_Bai7;

internal class Chuong5_Bai7
{
    static void Main(string[] args)
    {
        int a;
        int b;
        int oldA;
        int oldB;
        double uSCLN;
        double bSCNN;
        Console.WriteLine("Nhap a ");
        int.TryParse(Console.ReadLine(), out a);
        Console.WriteLine("Nhap b ");
        int.TryParse(Console.ReadLine(), out b);
        oldA = a;
        oldB = b;
        //Tim Uoc chung lon nhat
        while (a != 0 && b != 0)
        {
            if (a >= b)
            {
                a = a % b;
            }else
            {
                b = b % a;
            }
            
        }
        uSCLN = a + b;
        bSCNN = (oldA * oldB) / uSCLN;
        Console.WriteLine($"Uoc so chung lon nhat la : {uSCLN}");
        Console.WriteLine($"Boi so chung nho nhat la : {bSCNN}");
    }

}
