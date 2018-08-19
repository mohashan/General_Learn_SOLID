using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public class Program
    {
        static void Main(string[] args)
        {
            ElectricalCar NissanLeaf = new NissanLeaf();
            InternalCombustionCar Corvet = new Corvete();

            NissanLeaf.getCharge(ChargeLevel.SeventyFivePercent);
            Corvet.getGas(60);

        }
    }
}
