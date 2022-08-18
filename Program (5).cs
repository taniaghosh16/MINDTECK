using System;

namespace Inheritance
{


    class Animal
    {

        public string name;

        public void display()
        {
            Console.WriteLine("I am an animal");
        }

    }


    class Cat : Animal
    {

        public void getName()
        {
            Console.WriteLine("My name is " + name);
        }
    }

    class Program
    {

        static void Main(string[] args)
        {


            Cat C = new Cat();


            C.name = "Max";
            C.display();


            C.getName();

            Console.ReadLine();
        }

    }
}
