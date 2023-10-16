using System;



public string FizzBuzz(int number)
{
    if(number % 3 == 0)
    {
        Console.WriteLine("fizz");
    }
    if (number % 5 == 0)
    {
        Console.WriteLine("buzz");
    }
    if (number % 3 == 0 && number % 5 ==0)
    {
        Console.WriteLine("fizzbuzz");
    }
}
