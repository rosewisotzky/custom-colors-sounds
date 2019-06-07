using System;
namespace custom_colors_sounds
{
    public class Zero : Vehicle
    {  // Electric motorcycle
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            Console.WriteLine("Charging...");
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero drives by. Driving noise!!!!");
        }
    }
}