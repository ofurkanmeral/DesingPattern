using DesingPattern.StrategyDesingPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPattern.StrategyDesingPattern.Business.CombatExample
{
    public class AgressiveCombatStrategy:ICombatStrategy
    {
        public void Attack()
        {
            Console.WriteLine("Aggrevise Attack");
        }

    }
}
