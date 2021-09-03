using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StategyPatterns
{
    public class Animal
    {
        private string name;
        private double height;
        private int weight;
        private string sound;


        public IFlys flyingType;

        public void setName(string newName) { name = newName; }
        public string getName() { return name; }

        public void setSound(string newSound) { sound = newSound; }
        public string getSound() { return sound; }



        public string tryToFly()
        {
            return flyingType.fly();
        }

        public void setFlyingAbility(IFlys newFlyingType)
        {
            flyingType = newFlyingType;
        }

    }
}