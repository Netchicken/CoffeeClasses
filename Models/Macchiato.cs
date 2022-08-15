namespace CoffeeClasses.Models
{
    public class Macchiato :Coffee
    {


        public Macchiato()
        {
            CoffeeName = "Macchiato";
            CupType = "70ml Cup";
            HasMilk = true;
            
            InstructionTitle = "A short black ‘marked’ with hot milk";
            Instructions = "Place the cup under the head and extract the double shot. Add the mark of milk to the espresso by spoon.";
            


        }


    }
}
