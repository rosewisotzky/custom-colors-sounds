using System;
namespace custom_colors_sounds
{
    public class Tesla : Vehicle
    {
        
        public double BatteryKWh { get; set; }
        public void ChargeBattery()
        {
            Console.WriteLine("Charging...");
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla drives by. Zoooooom!");
        }

    }
}