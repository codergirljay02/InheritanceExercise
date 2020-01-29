using System;
namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
            InTheWild = true;
            LaysEggs = true;
            LifeSpan = 200;
            Size = 15;
            IsColdBlooded = true;
            Diet = "other animals";
            AnimalType = "American Alligator";
            MatingCall = "chirp chirp";
          Console.WriteLine($"An {AnimalType} can be {Size} ft long and live" +
               $"up to {LifeSpan} years. It's {InTheWild} that you can find" +
            $"them in the wild. It's {LaysEggs} that they can lay a large" +
            $"amount of eggs. It is also {IsColdBlooded} that an {AnimalType}" +
            $"is cold blooded. Their diet consist of {Diet}. The mating call" +
               $"is a {MatingCall} sound.");
        }
        public bool IsColdBlooded { get; set; }
        public string Diet { get; set; }
        public string AnimalType { get; set; }
        public string MatingCall { get; set; }
    }
}
