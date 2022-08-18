using System;
namespace MyConsoleApp
{
    class vehicle
    {
        string Brand_Name;
        public void Quality()
        {
            Console.WriteLine("Quality is so good");
        }
        public void Price(int x)
        {
            Console.WriteLine("The price of the Vehicle is" + "" + "" + x);
        }
        public void Customer_Support(string name)
        {
            Console.WriteLine("Customer support is " + "" + name);
        }
        static void Main()
        {
            vehicle v = new vehicle();
            v.Brand_Name = "Royal Enfield";
            v.Quality();
            v.Price(120000);
            v.Customer_Support("Good");
            Console.WriteLine(v.Brand_Name = "Royal Enfield");
            Console.ReadLine();


        }
    }
}
