using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackPacking.Algorithms
{
    public class BackPackingSolverSmart : BackPackingSolverBase
{
    public BackPackingSolverSmart(List<BackPackItem> items, double capacity) : base(items, capacity) { }

        public override void Solve(ItemVault theItemVault, BackPack theBackPack)
        {
            while (true)
            {
                var bestItem = PickNextItemByValueToWeightRatio(theItemVault, theBackPack.WeightCapacityLeft);
                if (bestItem == null)
                    break;

                theBackPack.AddItem(bestItem);
                theItemVault.RemoveItem(bestItem.Description);
            }
        }

    }

}
