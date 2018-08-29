public interface IFlyingVehicle {
    bool Winged { get; set; }
    double MaxAirSpeed { get; set; }
    void Fly ();
}