using System;

class CalculatorEg
{
    static int res;
    public static int add(int a,int b)
    {
        res = a + b;
        return res;

    }
    public static void Add()
    {
        Console.WriteLine("add method is called");

    }
    public static void addition(int a, int b)
    {
        res=a + b;
        Console.WriteLine("the sum of the two numbers entered is {0}",res);
    }
    public static void subtraction(int a,int b)
    {
        res=a - b;
        Console.WriteLine("the product of the two numbers entered is{0}", res);

    }
    public static void division(int a, int b)
    {
        if (b==0)
        {
            Console.WriteLine("you cannot didvide by zero");
        }
        else
        {
            res = a / b;
            Console.WriteLine("The division of the two numbers entered is {0}", res);
        }
    }
    static void Main(string[]args)
    {
        int Num1, Num2, ch;

    }
}