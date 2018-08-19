using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    class NissanLeaf:ElectricalCar
    {
        public ChargeLevel chargeLevel { get; private set; }

        public override void getCharge(ChargeLevel chargeLevel)
        {
            this.chargeLevel = chargeLevel;
        }
    }
}
