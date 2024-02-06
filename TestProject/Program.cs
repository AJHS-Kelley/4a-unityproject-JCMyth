namespace TestProject;

class Program
{
    static void Main(string[] args)
    {
        int myInt = 0;
        float myFloat = 3.14f;
        bool myBool = true;
        string myString = "The FSCJ trip was boring.\n";

        Console.WriteLine("My integer variable is " + myInt);
        Console.WriteLine("My Float variable is " + myFloat);
        Console.WriteLine("My Boolean variable is " + myBool);
        Console.WriteLine("My String variable is " + myString);

        for (int i = 0; i <= 20; i++){
            Console.WriteLine("I ate " + i + " waffles for breakfast.\n");
        }

    }
}
