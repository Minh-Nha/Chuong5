namespace Chuong5_Bai1;

internal class Chuong5_Bai1
{
    static void Main(string[] args)
    {
        //declare variables
        int n = 10;
        char choice;
        //input
        Console.WriteLine("*****************************************");
        Console.WriteLine("(A) Tong cac so le nho hon hay bang n ");
        Console.WriteLine("(B) Tich cac boi so cua 3 va nho hon hoac bang n ");
        Console.WriteLine("(C) 1 + 1/2 + 1/3 + 1 + ... + 1/n-1");
        Console.WriteLine("(D) 2 * 4 * 6 * ... 2n");
        Console.WriteLine("(E) N! = 1 * 2 * ... *n");
        Console.WriteLine("*****************************************");
        Console.WriteLine("Nhap n: ");
        int.TryParse(Console.ReadLine(), out n);
        Console.WriteLine("Nhap lua chon cua ban: ");
        char.TryParse(Console.ReadLine(), out choice);
        //processing
        switch (choice) {
            case 'a': 
            case 'A':
                double sum = 0;
                for (int i = 0; i <= n; i++)
                {
                    sum += i; 
                }
                Console.WriteLine(sum);
                break;
            case 'b':
            case 'B':
                sum = 1;
                for (int i = 3; i <= n ; i++)
                {
                    if(i % 3 == 0)
                    {
                        sum *= i;
                    }
                }
                Console.WriteLine(sum);
                break;
            case 'c':
            case 'C':
                sum = 0;
                for (int i = 1; i < n; i++)
                {   
                    sum += 1 /i;
                }
                Console.WriteLine(sum);
                break;
            case 'd':
            case 'D':
                sum = 1;
                for (int i = 1; i <= n; i++)
                {
                    sum *= (2 * i);
                }
                Console.WriteLine(sum);
                break;
            case 'e':
            case 'E':
                sum = 1;
                for(int i = 1;i <= n; i++)
                {
                    sum *= i;
                }
                Console.WriteLine(sum);
                break;
            default:
                Console.WriteLine("Nhap sai lua chon vui long nhap lai");
                break;
        }
    }
}
