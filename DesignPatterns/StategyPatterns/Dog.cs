using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StategyPatterns
{
    public class Dog : Animal
    {
        public Dog()
        {
            setSound("Bark");
            flyingType = new CantFly();
        }
    }
}
