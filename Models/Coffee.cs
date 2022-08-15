namespace CoffeeClasses.Models
{
    public class Coffee
    {
        //PLEASE NOTE: All drinks should be made with a double shot of espresso, unless otherwise requested by the customer
        public string CoffeeName { get; set; }
        public int Shots { get; set; } = 2;
        public bool HasMilk { get; set; } = false;
        public bool HasWater { get; set; } = false;
        public string CupType { get; set; }
        public string InstructionTitle { get; set; }
        public string Instructions { get; set; }
        public List<string> ListOfExtras { get; set; }

        public string Image { get; set; }

        public Coffee()
        {
            ListOfExtras = new List<string>();
        }

        
    }
}
