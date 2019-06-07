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
        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Cessna swiftly turns to the {direction}");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Cessna thinks about the void surrounding all of us and then stops respectfully and with great care.");
        }

    }
}