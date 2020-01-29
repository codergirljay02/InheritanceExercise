using System;
namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
            
            InTheWild = true;
            LaysEggs = true;
            LifeSpan = 50;
            Size = 4;
            Type = "Hyacinth Macaw";
            CanFly = true;
            Gender = "male or female";
            Sound = "tweet tweet";
            Console.Write($"It is {InTheWild} that you can find a {Type} in " +
                $"the wild. It's {CanFly} that this bird can fly. A {Type} " +
                $"can be {Gender}. The sound it makes is {Sound}. Its life " +
                $"span is {LifeSpan} and its size is {Size} ft. A {Type} is" +
                $"not a mammal so it is {LaysEggs} that it lays eggs. ");
        }
        public string Type { get; set; }
        public bool CanFly { get; set; }
        public string Gender { get; set; }
        public string Sound { get; set; }

    }
}
