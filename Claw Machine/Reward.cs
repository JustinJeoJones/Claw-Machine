using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claw_Machine
{
    public class Reward
    {
        //Properties
        public string Name { get; set; }
        public decimal Value { get; set; }
        //Constructor
        public Reward(string _name, decimal _value)
        {
            Name = _name;
            Value = _value;
        }
    }
}
