namespace CoffeeClasses.Models
{
    public class Latte : Coffee
    {

        public Latte()
        {
            CupType = "250ml Cup";
            CoffeeName = "Latte";
            HasMilk = true;
            InstructionTitle = "The texture of the milk in a latte can be slightly thicker than that of the flat white ";
            Instructions = "The texture of the milk in a latte can be slightly thicker than that of the flat white. {Environment.NewLine} Extract a double shot in to the cup. Pour and allow the thicker, lightly textured milk to flow in to and mix with the espresso. TIP: If using a BELL SHAPE JUG, to ensure a consistent pour of the thicker, frothy milk, pour from the side of the jug.{Environment.NewLine}Bowl Latte – milk should be the same as the standard latte but ensure you swirl the milk and keep it blended due to the size of the beverage.";

            

        }
       


    }
}
