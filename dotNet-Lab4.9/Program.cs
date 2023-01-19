// Input for looping time
Console.Write("Enter number of loop : ");
int looptime = Convert.ToInt32(Console.ReadLine());

// Input for number use to find number nearest
Console.Write("Enter number of n : ");
long n = Convert.ToInt64(Console.ReadLine());

// Defalut number nearest value
long? number = null;

// Defalut positive and negative numbers
long numP = 9223372036854775807;
long numM = -9223372036854775807;

// Loop input check number nearest n
for (int i = 1; i <= looptime; i++)
{
    // Input numbers
    Console.Write($"Enter number [{looptime - i + 1}] : ");
    long input = Convert.ToInt64(Console.ReadLine());

    // Check if input is n?
    if (input == n)
        number = n;

    // Check if number not equal n?
    if (number != n)
    {
        if (input - n >= 0 && input < numP)
            numP = input;

        if (input - n < 0 && input > numM)
            numM = input;
    }
}

// Check if number is's n?
if (number != n)
{
    // Check if n is positive or negative?
    if (n >= 0)
    {
        // Check if (positive variable or negative variable - n) > or < (positive variable or negative variable)
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

// Check if numbers nearest n is 2 numbers?
string result = number == null ? ($"\nNuber nearest n({n}) is {numP} and {numM}") : ($"\nNuber nearest n({n}) is {number}");

// Log result
Console.WriteLine(result);