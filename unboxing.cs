namespace boxing
{
    internal class Program
    {
        static  public void  Main()
        {
            //unboxing
            int i = 200;
            object o = i;
            int j =(int)o;//typecasting
            i = 400;
            Console.WriteLine(i);
            Console.WriteLine(o);

        }
    }
}