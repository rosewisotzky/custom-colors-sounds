using System;

namespace custom_colors_sounds
{
    class Program
    {
        static void Main(string[] args)
        {
            Tesla rose = new Tesla () {
                MainColor = "Red",
            };
            Cessna jameka = new Cessna() {
                MainColor = "Blue"
            };
            Ram truck = new Ram() {
                MainColor = "Teal"
            };
            Zero zero = new Zero() {
                MainColor = "Green"
            };
            
            jameka.Drive();
            jameka.Turn("inside of itself");
            jameka.Stop();
            Console.WriteLine("");
            truck.Drive();
            truck.Turn("sideways");
            truck.Stop();
            Console.WriteLine("");
            rose.Drive();
            rose.Turn("right");
            rose.Stop();
            Console.WriteLine("");
            zero.Drive();
            zero.Turn("left");
            zero.Stop();
            
        }
    }
}
