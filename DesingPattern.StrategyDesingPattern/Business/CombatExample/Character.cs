using DesingPattern.StrategyDesingPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPattern.StrategyDesingPattern.Business.CombatExample
{
    public class Character
    {
        private ICombatStrategy combatStrategy;
        public Character(ICombatStrategy combatStrategy)
        {
            this.combatStrategy = combatStrategy;
        }
        public Character() { }

        public void SetCombatStrategy(ICombatStrategy combatStrategy)
        {
            this.combatStrategy=combatStrategy;
        }
        public void ApplyAttachStrategy()
        {
            if(combatStrategy!=null)
            {
                combatStrategy.Attack();

            }
            else
            {
                Console.WriteLine("Constracter Set Edemedi");
            }
        }


    }
}
