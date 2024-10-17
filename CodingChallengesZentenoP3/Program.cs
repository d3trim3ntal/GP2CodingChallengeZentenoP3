using System;
class Challlenges
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to my coding challenge program. There will be a variety of different functions you will have to choose from. Please pick one!");
        Console.WriteLine("Today we are going to use the number adder called sum. Please input two numbers for us to add. \n");

        var number1 = Console.ReadLine();
        int number1int = int.Parse(number1);

        Console.WriteLine("Awesome! Please input a second number.");

        var number2 = Console.ReadLine();
        int number2int = int.Parse(number2);

        Console.WriteLine("The sum of the number: " + number1 + " and the number: " + number2 + " is equal to: " + sum(number1int, number2int));
        sum(number1int, number2int);
        
        Console.WriteLine("Lets try converting minutes into seconds! \n");
        Console.WriteLine("Give me a number to convert into seconds: ");
        var second1 = Console.ReadLine();
        int second1int = int.Parse(second1);

        Console.WriteLine(second1 + "minutes would convert to : " + min(second1int) + "seconds.");
    }

    public static int sum(int number1, int number2)
    {
        return number1 + number2;
    }

    public static int min(int second1)
    {
        return second1 * 60;
    }
}
