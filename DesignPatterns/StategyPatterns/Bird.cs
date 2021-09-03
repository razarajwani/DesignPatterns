using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StategyPatterns
{
    public class Bird : Animal
    {
        public Bird()
        {
            setSound("Tweet");
            flyingType = new ItFlys();
        }
    }
}
