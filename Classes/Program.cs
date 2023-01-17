namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
           Car myCar = new Car();
            myCar.Make = "Subaru";
            myCar.Model = "Brat";
            myCar.Year = 1982;


            Console.WriteLine(myCar.Make);
            Console.WriteLine(myCar.Model);
            Console.WriteLine(myCar.Year);

        }
    }
}
