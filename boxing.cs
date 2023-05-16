namespace boxing
{
    internal class Program
    {
        static  public void  Main()
        {
            //boxing
            int i = 200;
            object o = i;
           
            i = 400;
            Console.WriteLine(i);
            Console.WriteLine(o);

        }
    }
}