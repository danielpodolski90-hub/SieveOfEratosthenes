// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;
using System.Security.Cryptography;

Console.WriteLine("Please entern number range: ");
int n = 0;

n = Convert.ToInt32(Console.ReadLine());

Dictionary<int, bool> A = new Dictionary<int, bool>();

for (int i = 2; i < n; i++)
{
    A.Add(i, true);
}

for (int i = 2; i < Math.Sqrt(n); i++)
{
    if (A[i])
    {
        for (double j = 0; j < n; j++)
        {
            double pow = Math.Pow(i, 2) + j * i;
            int parsed = (int)pow;
            A[parsed] = false;
        }
    }
}

foreach (var keyValue in A)
{
    if (keyValue.Value == true)
    {
        Console.WriteLine(keyValue.Key + " isPrime: " + keyValue.Value);
    }
}

Console.ReadLine();
