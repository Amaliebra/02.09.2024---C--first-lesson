namespace _02._09._2024___C__first_lesson;

class Program
{
    static void Main(string[] args)
    {
        string helloWorld = "Hello World";

        int myNumber = 10;

        double myDecimal = 10.25;

        Console.WriteLine(helloWorld);
        Console.WriteLine(myNumber + 10.5);
        Console.WriteLine(myDecimal);

        Console.WriteLine("Hei, hva heter du?");
        string? navn = Console.ReadLine();
        Console.WriteLine("Hei" + navn);
        
        char a = '@';

        Console.WriteLine(a);
    }
}
