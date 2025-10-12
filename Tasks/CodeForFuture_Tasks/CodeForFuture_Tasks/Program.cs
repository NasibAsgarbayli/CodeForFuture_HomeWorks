
#region Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin.
Console.Write("Ededi daxil edin: ");

int n = Convert.ToInt32(Console.ReadLine());
bool isPrime = true;

if (n == 0 || n == 1)
{
    Console.WriteLine($"{n} ne sade, ne de mürekkeb ededdir");
}
else
{
    if (n < 0)
    {
        Console.WriteLine("Menfi ededler üçün sadelik yoxlanmır");
    }
    else
    {
        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        if (isPrime)
        {
            Console.WriteLine($"{n} ededi sade ededdir");
        }
        else
        {
            Console.WriteLine($"{n} ededi mürekkeb ededdir");
        }
    }
}
#endregion

