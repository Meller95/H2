using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlayV23
{
    public class Defender : Character
    {
        public Defender(string name, int hitPoints, int minDamage, int maxDamage) : base(name, hitPoints, minDamage, maxDamage)
        {

        }

        protected override int ReceiveDamageModifyChance
        {
            get { return 45; }
        }

        protected override int CalculateModifiedReceivedDamage(int receivedDamage)
        {
            return receivedDamage / 2;
        }
    }
}
