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
}