using CoffeeClasses.Models;

namespace CoffeeClasses.Operations
{
    public class LongBlack : Coffee
    {

        public LongBlack()
        {
            CupType = "tulip cup (150ml)";
            CoffeeName = "Long Black";
            HasWater = true;
            InstructionTitle = "The extraction is poured on top of the water so the crema is not disturbed";
            Instructions = "Fill the cup just over half full with hot water from the espresso machine. Then, place the cup with water under the group and extract a double shot over the hot water. If requested, serve the long black with a small jug of hot water.";
        }

    }
}
