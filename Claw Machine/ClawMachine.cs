using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claw_Machine
{
    public class ClawMachine
    {
        //properties
        public List<Reward> AllRewards { get; set; }
        public decimal CostToPlay { get; set; }
        //constructor

        public ClawMachine()
        {
            CostToPlay = 1.50m;
            AllRewards = new List<Reward>()
            {
                new Reward("Cheap Candy", 0.50m),
                new Reward("Cheap Candy", 0.50m),
                new Reward("Cheap Candy", 0.50m),
                new Reward("Candy Bar", 1.00m),
                new Reward("Candy Bar", 1.00m),
                new Reward("Stuffed Animal", 10.00m),
            };
        }
        //methods

        public Reward GetReward()
        {
            Random r = new Random();
            int index = r.Next(0,AllRewards.Count);
            return AllRewards[index];
        }

        public bool MadeProfit(Reward r)
        {
            if(r.Value > CostToPlay)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Play()
        {
            Reward result = GetReward();
            Console.WriteLine(result.Name);
            if(MadeProfit(result) == true)
            {
                Console.WriteLine("You made a profit.");
            }
            else
            {
                Console.WriteLine("You lost money");
            }
        }

    }
}
