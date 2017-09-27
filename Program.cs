using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;

            Car.numberAvailable = 0;
            Car.valueOfCurrentStock = 0;

            List<Car> carlot = new List<Car>();


            Car car1 = new Car("Ford", "Mustang", 1111, 2000, 30000, false, carlot);
            Car car2 = new Car("BMW", "Continental", 1222, 2005, 45000, false, carlot);
            Car car3 = new Car("Jaguar", "r-models", 1333, 2009, 60000, false, carlot);

            string selection = "";

            Console.WriteLine("Would you like to enter a car press <a>");
            Console.WriteLine("Would you like view carlot press <d>");
            Console.WriteLine("Press e to exit");
            selection = Console.ReadLine();

            do
            {
                switch (selection)
                {

                    case "a":
                        Car car4 = new Car(false, carlot);
                        Console.Clear();
                        selection = Console.ReadLine();
                       
                        break;

                    case "d":
                        Console.Clear();
                        Car.displayCars(carlot);
                        Console.WriteLine("Press any key to continue...");
                        selection = Console.ReadLine();

                       break;

                    default:

                        Console.Clear();
                        Console.WriteLine("Would you like to enter a car press a");
                        Console.WriteLine("Would you like view carlot press <d>");
                        Console.WriteLine("Press e to exit");
                        selection = Console.ReadLine();
                        continue;
                }
            } while (selection != "e");


            

        }
    }
    class Car
    {

        //these are instance variables or non static... updated with constructer method below 

        public string make;
        public string model;
        public int reg;
        public int year;
        public int price;
        public bool sold;





        public Car(string make, string model, int reg, int year, int price, bool sold, List<Car> mycars)
        {

            this.make = make;
            this.model = model;
            this.reg = reg;
            this.year = year;
            this.price = price;
            this.sold = false;
            mycars.Add(this);
            Car.numberAvailable++;

        }


        public Car(bool sold, List<Car> mycars)
        {
            Console.WriteLine("Please enter a car make?");
            make = Console.ReadLine();
            Console.WriteLine("Please enter a car model?");
            model = Console.ReadLine();
            Console.WriteLine("Please enter a reg number?");
            reg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a price?");
            price = Convert.ToInt32(Console.ReadLine());
            this.sold = false;
            mycars.Add(this);
            Car.numberAvailable++;
        }


        public static int numberAvailable;
        //public int carCount = ++numberAvailable; (now in constrcutor)

        public static int valueOfCurrentStock;

        //method1 this will change to true/false
        public void sellCar(int price)
        {
            this.sold = true;
            this.price = price;
        }

        //method2 check availability the test is based on a boolean true or false
        public static void isAvailable(Car car)
        {
            if (car.sold)
            {
                Console.WriteLine("sorry... this car {0) has now been sold");
            }
            else
            {
                Console.WriteLine("Your in luck this car {0} is available");
            }
        }


        //method3 get total stock value

        public static void totalValue(List<Car> allcars)

        {
            foreach (Car c in allcars)
            {
                if (!c.sold)
                {
                    valueOfCurrentStock += c.price;
                }

            }
            Console.WriteLine("Total value of all stock is {0}", valueOfCurrentStock);
        }

        // display all reamining cars available...

        public static void displayCars(List<Car> carlot)
        {
            foreach (Car c in carlot)
            {
                if (!c.sold)
                {
                    Console.WriteLine(c.make + " " + c.model);
                }

            }

        }


        public static int totalSales;
        public int totalSalesCount = ++totalSales;




    }
}
