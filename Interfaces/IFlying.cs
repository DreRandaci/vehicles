namespace vehicles
{
    public interface IFlying
    {
        double MaxAirSpeed { get; set; }
        bool Winged { get; set; }
        void Fly();
    }
}