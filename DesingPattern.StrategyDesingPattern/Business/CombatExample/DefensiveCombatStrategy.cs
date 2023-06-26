using DesingPattern.StrategyDesingPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DesingPattern.StrategyDesingPattern.Business.CombatExample
{
    public class DefensiveCombatStrategy : ICombatStrategy
    {
        public void Attack()
        {
            Console.WriteLine("Defensive Attack");
        }
    }
}
