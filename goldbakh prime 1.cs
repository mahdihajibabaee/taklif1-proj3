Console.WriteLine("yek add zog vard konid");
int n = int.Parse(Console.ReadLine());

if (n % 2 != 0 || n < 4)
{
    Console.WriteLine("add bayad bozorg tar az 3 bashad");
    return;
}

for (int i = 2; i <= n / 2; i++)
{
    int j = n - i;

    bool iPrime = true;
    for (int a = 2; a <= Math.Sqrt(i); a++)
    {
        if (i % a == 0)
        {
            iPrime = false;
            break;
        }
    }

    bool jPrime = true;
    for (int b = 2; b <= Math.Sqrt(j); b++)
    {
        if (j % b == 0)
        {
            jPrime = false;
            break;
        }
    }

    if (iPrime && jPrime)
    {
        Console.WriteLine($"{i} + {j} = {n}");
        break;
    }
}