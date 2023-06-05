using Chronometer;

var chronometer = new Chron();
string cmd;
while ((cmd = Console.ReadLine()) != "exit")
{
    switch (cmd)
    {
        case "start":
            Task.Run(() =>
            {
                chronometer.Start();
            });
            break;
        case "stop":
            Task.Run(() =>
            {
                chronometer.Stop();
            });
            break;
        case "lap":
            Console.WriteLine(chronometer.Lap());
            break;
        case "laps":
            if (chronometer.Laps.Count == 0)
            {
                Console.WriteLine("No laps to display");
            }
            else
            {
                Console.WriteLine("Laps: ");
                for (int i = 0; i < chronometer.Laps.Count; i++)
                {
                    Console.WriteLine($"{i+1}: {chronometer.Laps[i]}");
                }
            }
            break;
        case "reset":
            chronometer.Reset();
            break;
        case "time":
            Console.WriteLine(chronometer.GetTime);
            break;
    }
}
chronometer.Stop();