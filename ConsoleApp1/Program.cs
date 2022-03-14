using System;

class ArrayExample
{
    static void Main()
    {
        StartSequence();
    }

    static void StartSequence()
    {
        Console.WriteLine("Please enter a number greater than zero.");

        int[] userArray = Populate();
       

        int summation = GetSum(userArray);

        int product = GetProduct(userArray,summation);

        int random = product / summation;
       decimal quotient =  GetQuotient(product);

        decimal det = Decimal.Divide(product, quotient);


        Console.WriteLine("Your array is size: {0}" , userArray.Length);
        printArray(userArray);
        Console.WriteLine("The sum of the array is: {0}",summation);
        Console.WriteLine("{0} * {1} = {2}" ,summation, random ,product);
        Console.WriteLine("{0} / {1} = {2} " ,product, det, quotient);
        Console.WriteLine("The program is complete.");
    }

    static int[] Populate()
    {
        int userInput = Convert.ToInt32(Console.ReadLine());
        int[] newArray = new int[userInput];
        

        for (int i = 0; i < newArray.Length; i++)
        {
            Console.WriteLine("Please enter a number: {0} of {1}", i+1 , userInput );
            int input = Convert.ToInt32(Console.ReadLine());
            newArray[i] = input;
        }
        return newArray;
    }

    static int GetSum(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        
        if (sum < 10)
        {
            throw new Exception("The sum must be more than 10.");
        }
        
        return sum;
    }

    static int GetProduct(int[] arr , int sum)
    {
       
        Console.WriteLine("Please enter a random number between 1 and {0}", arr.Length);
        int random = Convert.ToInt32(Console.ReadLine());
        int prod = arr[random] * sum;
        return prod;
    }
    static decimal GetQuotient(int prod)
    {
        Console.WriteLine("Please enter a number to divide your product {0} by: ", prod);
        int denominator = Convert.ToInt32(Console.ReadLine());
        decimal quotient = Decimal.Divide(prod, denominator);
        try
        {
            if (denominator != 0)
            {
            }
        } catch(DivideByZeroException)
        {
            Console.WriteLine("The denominator can't be equal to zero");
            return 0;
        }
        return quotient;

    }
    static void printArray(int[] arr)
    {
        Console.Write("The number is the array are: ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + ", ");
        }
        Console.WriteLine("");
    }
}