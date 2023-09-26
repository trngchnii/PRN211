
namespace HelloWorld
{
    internal class Boxing
    {
        static void Main(string[] args)
        {
            int i = 123;
            object o = i;
            i = 456;
            Console.WriteLine(o);
            Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}
