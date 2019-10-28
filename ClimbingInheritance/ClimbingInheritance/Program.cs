using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimbingInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Bouldering bouldering = new Bouldering();
            Lead lead = new Lead();
            Gym gym = new Gym();
            
        }
    }

    class Climbing
    {
        private bool chalk;
        public string grade;
    }

    class Roped : Climbing
    {
        public bool rope;
        public bool belayDevice;
        public bool carabiner;
    }

    class Bouldering : Climbing
    {
        public double height;
    }

    class Lead : Roped
    {
        public bool quickdraw;
    }

    class Gym
    {
        private Bouldering bouldering;
        private Lead lead;
    }


}
