delegate int NumberChanger(int n);
class Tester
{
    static int num = 10;
    public static int AddNum(int p)
    {
        num += p;
        return num;
    }
    public static int MulNum(int q)
    {
        num *= q;
        return num;
    }
    public static int DivNum(int r)
    {
        num /= r;
        return num;
    }
    public static int getNum()
    {
        return num;
    }


    static void Main(string[] args)
    {

        NumberChanger nc;
        NumberChanger nc1 = new NumberChanger(AddNum);
        NumberChanger nc2 = new NumberChanger(MulNum);
        NumberChanger nc3 = new NumberChanger(DivNum);

        nc = nc1;
        nc -= nc2;
        nc += nc3;
        nc(10);
        Console.WriteLine("{0}", getNum());


        Console.ReadKey();
    }
}
