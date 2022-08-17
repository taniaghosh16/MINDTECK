using System;
namespace ConsoleApp
{
    class tania
    {
        public delegate void Taniadelegate(string name);
        public delegate void Multidelegate(int x, int y);
        public void Multi(int x, int y)
        {
            Console.WriteLine(x * y);

        }
        public void name(string name)
        {
            Console.WriteLine("my name is" + " " + name);

        }
        static void Main(string[] args)
        {
            tania d = new tania();
            Taniadelegate obj1 = new Taniadelegate(d.name);
            Multidelegate obj2 = new Multidelegate(d.Multi);
            obj1("Tania");
            obj2(20, 20);

        }

    }

}