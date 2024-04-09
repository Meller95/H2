using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlayV23
{
    public class Damager : Character
    {
        public Damager(string name, int hitPoints, int minDamage, int maxDamage) : base(name, hitPoints, minDamage, maxDamage)
        {

        }

        protected override int DealDamageModifyChance
        {
            get { return 40; }
        }

        protected override int CalculateModifiedDealDamage(int dealtDamage)
        {
            return dealtDamage * 2;
        }
    }
}
