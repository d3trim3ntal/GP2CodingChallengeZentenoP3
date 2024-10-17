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

        //Challenge 4
        Console.WriteLine("Let's try calculating circuit power! \n");

        Console.WriteLine("Give me a value for the voltage: ");
        var volt = Console.ReadLine();
        int voltint = int.Parse(volt);

        Console.WriteLine("Give me a value for the current: ");
        var currentval = Console.ReadLine();
        int currentvalint = int.Parse(currentval);

        Console.WriteLine("Your circuit power is equal to: " + CircuitPow(currentvalint, voltint));
        circuitpow(currentvalint, voltint);


        //Challenge 5
        Console.WriteLine("Lets try converting your age into days! \n");
        Console.WriteLine("How old are you?: ");
        var age1 = Console.ReadLine();
        int age1int = int.Parse(age1);

        Console.WriteLine("If you are " + age1 + " years old, then you are " + age(age1int) + " days old. \n");

        //Challenge 6
        Console.WriteLine("Let's try finding the area of a triangle!");
        Console.WriteLine("Give me the base of the triangle: \n");

        var base1 = Console.ReadLine();
        int baseint = int.Parse(base1);

        Console.WriteLine("Awesome! Please input the height.");

        var height = Console.ReadLine();
        int heightint = int.Parse(height);

        Console.WriteLine("The area of a triangle with a base: " + base1 + " and the a height of : " + height + " is: " + triArea(baseint, heightint));
        triArea(baseint, heightint);

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

    public static int CircuitPow(int currentval, int volt)
    {
        return currentval * volt;
    }

    public static int age(int age1)
    { 
        return age1 * 365; 
    }

    public static int triArea(int base1, int height)
    {
        return (base1 * height) / 2;
    }
}
