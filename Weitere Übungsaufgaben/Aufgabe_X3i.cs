// C# program to print Emirp
// numbers less than n
using System;

class Aufgabe_X3i
{
    // Function to find
    // reverse of any number
    static int reverse(int x)
    {
        int rev = 0;
        while (x > 0)
        {
            rev = (rev * 10) + x % 10;
            x = x / 10;
        }
        return rev;
    }

    // Sieve method used for
    // generating emirp number
    // (use of sieve of Eratosthenes)
    static void printEmirp()
    {
        int n = int.MaxValue / 2;
        // Create a boolean array
        // "prime[0..n]" and initialize
        // all entries it as true. A value
        // in prime[i] will finally be false 
        // if i is Not a prime, else true.
        bool[] prime = new bool[n + 1];
        for (int i = 0; i < n + 1; i++)
            prime[i] = true;


        for (int p = 2; p * p <= n; p++)
        {
            // If prime[p] is not changed,
            // then it is a prime
            if (prime[p] == true)
            {
                // Update all multiples of p
                for (int i = p * 2; i <= n; i += p)
                    prime[i] = false;
            }
        }

        // Traverse all prime numbers
        for (int p = 2; p <= n; p++)
        {
            if (prime[p])
            {
                // Find reverse a number
                int rev = reverse(p);

                // A number is emrip if it
                // is not a palindrome number
                // and its reverse is also prime.
                if (p != rev && rev <= n && prime[rev])
                {
                    Console.Write(p + " " + rev + " ");

                    // Mark reverse prime as false
                    // so that it's not printed again
                    prime[rev] = false;
                }
            }
        }
    }

    // Driver code
    public static void Start()
    {
        Console.WriteLine("Wie viele Mirpzahlen ausgeben?");
        for (int i = 0; i < Convert.ToInt32(Console.ReadLine()); i++)
            printEmirp();
    }
}

// This code is contributed by nitin mittal.