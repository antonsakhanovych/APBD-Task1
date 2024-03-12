// See https://aka.ms/new-console-template for more information
class Hello
{
    static double getAverage(int[] arr)
    {
        double sum = 0;
        for (int i = 0; i < arr.Length; i++) {
            sum += i;
        }
        return sum/arr.Length;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        string sNumber = "s26776";
        int age = 20;
        for (int i = 0; i < 3; i++) {
            Console.WriteLine(sNumber + " loves APBD! and " + sNumber + " is " + age + " years old." );
        }

    }
}
