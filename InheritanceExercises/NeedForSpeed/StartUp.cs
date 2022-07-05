namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var car = new SportCar(100, 22);
            car.Drive(12);

            var car2 = new Car(100, 22);
            car2.Drive(12);

            var bike = new RaceMotorcycle(100,22);
            bike.Drive(12);
        }
    }
}
