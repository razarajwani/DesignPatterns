using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StategyPatterns
{
    public interface IFlys
    {
        string fly();
    }


    public class ItFlys : IFlys
    {
        public string fly()
        {
            return "Flying High";
        }
    }

    public class CantFly : IFlys
    {
        public string fly()
        {
            return "I can't fly";
        }
    }
}
