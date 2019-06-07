using System;
namespace custom_colors_sounds
{
    public class Cessna : Vehicle
    {

        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            Console.WriteLine("Fueling...");
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna flies by. Hope there are no snakes on THIS plane!");
        }

    }
}