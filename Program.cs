using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inhertince_class_car_truck
{
    

internal class Program
    {
        static void Main(string[] args)
        {
            car car_obj = new car();
            truck truck_obj = new truck();


            Console.WriteLine($"The brand of the car is : {car_obj.brand} ");
            Console.WriteLine($"The model name of the car is : {car_obj.modelname} ");
            Console.WriteLine();
            Console.WriteLine($"The brand of the truck is : {truck_obj.brand} ");
            Console.WriteLine($"The model name of the truck is : {truck_obj.modelname} ");
            Console.WriteLine();

           
            Console.ReadLine();
        }
    }
	class Vehicle
	{
		public string brand;


	}
	class MotorVehicle : Vehicle
	{
		public string modelname;
	}
	class car : MotorVehicle
	{
		public car(string Brand = "BMW", string Modelname = "BMW_2022")
		{
			brand = Brand;
			modelname = Modelname;
		}
	}
	class truck : MotorVehicle
	{
		public truck(string Brandtruck = "american truck AM", string Modelnametruck = " DSM truck")
		{
			brand = Brandtruck;
			modelname = Modelnametruck;
		}
	}
}
