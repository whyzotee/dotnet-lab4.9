Console.Write("Enter number of loop : ");
int looptime = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of n : ");
long n = Convert.ToInt64(Console.ReadLine());

long? number = null;

long numP = 9223372036854775807;
long numM = -9223372036854775807;

for (int i = 1; i <= looptime; i++)
{
    Console.Write($"Enter number [{looptime - i + 1}] : ");
    long input = Convert.ToInt64(Console.ReadLine());

    if (input == n)
        number = n;

    if (number != n)
    {
        if (input - n >= 0 && input < numP)
            numP = input;

        if (input - n < 0 && input > numM)
            numM = input;
    }
}

if (number != n)
{
    if (n >= 0)
    {
        if (numP - n < n - numM)
            number = numP;
        else if (numP - n > n - numM)
            number = numM;
        else
            number = null;
    }
    else
    {
        if (numP - n > n + numM)
            number = numP;
        else if (numP - n < n + numP)
            number = numM;
        else
            number = null;
    }
}

string result = number == null ? ($"\nNuber nearest n({n}) is {numP} and {numM}") : ($"\nNuber nearest n({n}) is {number}");

Console.WriteLine(result);