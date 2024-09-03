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

        string[] myStringArray = { "hello", "c#", "array!" };
        for (int i = 0; i < myStringArray.Length; i++)
        {
            Console.WriteLine(myStringArray[i]);
        }
        List<int> myNumbers = new List<int>();
        myNumbers.Add(1);
        myNumbers.Add(2);
        myNumbers.Add(3);
        for (int i = 0; i < myNumbers.Count(); i++)
        {
            foreach (string strings in myStringArray)
        }
    }
}
