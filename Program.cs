public class Programm
{
    static void Main(string[] args)
    {
        int a = 6;
        string a1 = "6";
        bool isSoNguyenTo = CheckSoNguyenTo(a);
        // float double
        double ketqua = Math.Sqrt(9);
        Console.WriteLine(ketqua);
        if (isSoNguyenTo)
        {
            Console.WriteLine("{0} la so nguyen to", a);
        }
        else
        {
            Console.WriteLine("{0} khong la so nguyen to", a);
        }

        Console.WriteLine(TinhTong(a));
    }

    static bool CheckSoNguyenTo(int number)
    {
        for (int i = 2; i <= number / 2; i++)
        {
            if (CheckChiaHet(number, i))
            {
                return false;
            }
        }
        return true;
    }

    static bool CheckChiaHet(int a123, int b)
    {
        return a123 % b == 0;
    }

    static int TinhTong(int number)
    {
        int tong = 0;
        for (int i = 1; i <= number; i++)
        {
            // tong = tong + i;
            tong += i; 
        }
        return tong;
    }
}