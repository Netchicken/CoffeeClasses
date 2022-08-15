namespace CoffeeClasses.Models
{
    public class Cappuchino : Coffee
    {
        public Cappuchino()
        {
            CoffeeName = "Cappuchino";
            HasMilk = true;
            CupType = "190ml Cup";
            InstructionTitle = "A double shot with a very thick, head of frothy milk";
            Instructions = "Carefully spoon all the heavily textured top milk in to the cup then pour the hot, lightly textured milk through the centre of the frothed milk OR hold back the heavily textured milk and pour approximately ½ a cup of lightly textured milk in to the double shot. {Environment.NewLine} Use the spoon to push the remaining, heavily textured top milk in to the remainder of the cup. A dome of thicker foam will rise up above the rim of the cup. Sprinkle with plenty of chocolate powder or a lighter sprinkle of cinnamon.";

            ListOfExtras.Add("Chocolate");
            ListOfExtras.Add("Cinnamon");
        }
    }

}
