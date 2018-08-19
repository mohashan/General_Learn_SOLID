namespace LSP
{
    public class Corvete : InternalCombustionCar
    {
        public int gas { get; private set; }
        public override void getGas(int gallon)
        {
            gas += gallon;
        }
    }
}
