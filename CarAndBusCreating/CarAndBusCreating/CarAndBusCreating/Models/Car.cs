using System;
using System.Collections.Generic;
using System.Text;

namespace CarAndBusCreating.Models
{
    class Car
    {
        public Car()
        {
            Console.WriteLine("Car was created.");
        }


        public Car(string brand, string model)
        {
            this.Brand = brand;
            this.Model = model;
        }

        public Car(string brand, string model, string color, int maxSpeed):this(brand, model)
        {
            this.Color = color;
            this.MaxSpeed = maxSpeed;
        }

        public string Brand;
        public string Model;
        public string Color;
        public int MaxSpeed;

        public virtual string InfoAll()
        {
            return $"Brand: {Brand}, Model: {Model}, Color: {Color}, Maximum Speed: {MaxSpeed}";
        }
    }
}
