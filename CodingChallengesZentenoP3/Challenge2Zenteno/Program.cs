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

        //Challenge 2
        Console.WriteLine("Lets try converting minutes into seconds! \n");
        Console.WriteLine("Give me a number to convert into seconds: ");
        var second1 = Console.ReadLine();
        int second1int = int.Parse(second1);

        Console.WriteLine(second1 + " minutes would convert to: " + min(second1int) + " seconds. \n");

        Console.WriteLine("Lets try adding 1 to any given number! \n");
        Console.WriteLine("Give me a number to add one to: ");
        var add1 = Console.ReadLine();
        int add1int = int.Parse(add1);

        Console.WriteLine(add1 + " and 1 would give you: " + plus(add1int));

        //Challenge 3
        Console.WriteLine("Let's try calculating circuit power! \n");

        Console.WriteLine("Give me a value for the voltage: ");
        var volt = Console.ReadLine();
        int voltint = int.Parse(volt);

        Console.WriteLine("Give me a value for the current: ");
        var currentval = Console.ReadLine();
        int currentvalint=int.Parse(currentval);

        Console.WriteLine("Your circuit power is equal to: " + circuitpow(currentvalint, voltint));
        circuitpow(currentvalint, voltint);
    }

    public static int sum(int number1, int number2)
    {
        return number1 + number2;
    }

    public static int min(int second1)
    {
        return second1 * 60;
    }

    public static int plus(int add1)
    {
        return add1 += 1;
    }

    public static int circuitpow(int currentval, int volt)
    {
        return currentval * volt;
    }
}