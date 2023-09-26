public delegate int MyDelegate(int numOne, int numTwo);
class Program1
{
    static int Add(int numOne, int numTwo) => numOne + numTwo;
    static int Subtract (int numOne, int numTwo) => numOne - numTwo;
    static void Main(string[] args)
    {
        int n1 = 25;
        int n2 = 15;
        int resurt;
        MyDelegate obj1 = new MyDelegate(Add);
        resurt = obj1(n1, n2);
        Console.WriteLine($"{ n1} + { n1} = { resurt}");
        MyDelegate obj2 = new MyDelegate(Subtract);
        resurt = obj2.Invoke(n1, n2);
        Console.WriteLine($"{n1} - {n1} = {resurt}");
        Console.ReadLine();
    }
}