using CoffeeClasses.Models;

namespace CoffeeClasses.Operations
{
    public class Factory
    {


        public static Coffee GetAStudent(int? id)
        {
            switch (id)
            {

                case 0:
                    return new Latte();

                case 1:
                    return new Macchiato();

                case 2:
                    return new Cappuchino();
                case 3:
                    return new FlatWhite();
                case 4:
                    return new LongBlack();

                default:
                    return new Cappuchino();
            }




        }


    }
}
