// we can open a new thread > start it and once done join it to main threat
Thread evens = new Thread(() => PrintEvenNumbers(1, 10));
Thread evens2 = new Thread(() => PrintEvenNumbers(1000, 2100));
Thread evens3 = new Thread(() => PrintEvenNumbers(11, 20));

evens.Start();
evens2.Start();
evens3.Start();
evens.Join();
evens2.Join();
evens3.Join();
Console.WriteLine("Threads finished work");

void PrintEvenNumbers(int start, int end)
{
    for (int i = start; i <= end; i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine(i);
        }
    }
}