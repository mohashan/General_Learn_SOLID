namespace LSP
{
    public abstract class ElectricalCar : Car
    {
        public abstract void getCharge(ChargeLevel chargeLevel);
    }
    public enum ChargeLevel
    {
        Empty,
        TwentyFivePercewnt,
        FiftyPercent,
        SeventyFivePercent,
        Full,
    }
}
