/*while (true)
{
    var cmd = Console.ReadLine();
    if (cmd == "show")
    {
        var result = SumAsync();
        Console.WriteLine(result);
    }
}

 static long SumAsync()
{
    return Task.Run(() =>
    {
        long sum = 0;
        for (int i = 1; i < 1000000000; i++)
        {
            if (i % 2 == 0)
            {
                sum += i;
            }
        }
        return sum;
    }).Result;
}*/

long sum = 0;

var task = Task.Run(() =>
{
    for (int i = 0; i < 1000000000; i++)
    {
        if (i % 2 == 0)
        {
            sum += i;
        }
    }
});

while (true)
{
    var cmd = Console.ReadLine();
    if (cmd == "show")
    {
        Console.WriteLine(sum);
    }
}