using System;
namespace custom_colors_sounds
{
    public class Ram : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            Console.WriteLine("Fueling...");
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram drives by. Beefy trucks or somethin'!");
        }
    }
}