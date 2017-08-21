using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class RandomnessGeneratorHelper
    {
        private int _a;
        private int _b;

        Random rand = new Random();

        public int RandomAnnoy(int a, int b, TypeOfCalculus typeOfCalculus)
        {
            if (typeOfCalculus == TypeOfCalculus.Addition)
            {
                a = a * rand.Next(1,10);
                b = b * rand.Next(1,10);
                return a + b;
            }
            if (typeOfCalculus == TypeOfCalculus.Substraction)
            {
                a = a / rand.Next(2,4);
                b = b / rand.Next(4,5);
                return a - b;
            }
            return a;
        }
    }
}
