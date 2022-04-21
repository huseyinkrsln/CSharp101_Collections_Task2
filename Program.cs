using System.Collections.Generic;
using System.Collections;
using System.Linq;
/*
-Enter 20 number. The numbers you entered can not be negative and non-numeric and you have to add them to two seperate ArrayList which you created.
-Print the elements of each array in order such as from max to min.
-Print the number of elements and average of both arrays on the screen.
*/
Console.WriteLine("Enter 20 number");
ArrayList nums = new ArrayList();
ArrayList Prime = new ArrayList();
ArrayList NotPrime = new ArrayList();

int counterNums = 1;
while (counterNums < 21)
{
    Console.Write($"<{counterNums}>" + ". number =");
    try
    {
        nums.Add(Convert.ToUInt32(Console.ReadLine()));
    }
    catch (FormatException e)
    {
        Console.WriteLine("Invalid format. Please just enter positive number !", e.Message);
        continue;
    }
    catch (Exception e)
    {
        Console.WriteLine("You can not enter negative number !", e.Message);
        continue;
    }
    counterNums++;
}

int flg;

foreach (uint n in nums)
{
    if (n == 1 || n == 0)
    {
        NotPrime.Add(Convert.ToUInt32(n));
        continue;
    }
    flg = 1;
    for (int x = 2; x < n; x++)
    {
        if (n % x == 0)
        {
            flg = 0;
            break;
        }
    }
    if (flg == 1)
        Prime.Add(Convert.ToUInt32(n));
    else
        NotPrime.Add(Convert.ToUInt32(n));
}

uint sumPrime = 0, sumNotPrime = 0;
Prime.Sort();
Prime.Reverse();
NotPrime.Sort();
NotPrime.Reverse();
Console.WriteLine("****PRIME NUMBERS****");

foreach (uint p in Prime)
{
    Console.Write(p+" ");
    sumPrime += p;
}

Console.WriteLine("\n"+$"Element number of primes': {Prime.Count}" + "");
Console.WriteLine($"Avg: {sumPrime / Prime.Count}");

Console.WriteLine("****NonPRIME NUMBERS****");

foreach (uint np in NotPrime)
{
    Console.Write(np+" ");

    sumPrime += np;
}
Console.WriteLine("\n"+$"Element number of primes': {NotPrime.Count}" + "");
Console.WriteLine($"Avg: {sumNotPrime / NotPrime.Count}");









