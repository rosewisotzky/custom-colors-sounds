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
            rose.Drive();
            truck.Drive();
            zero.Drive();
        }
    }
}
