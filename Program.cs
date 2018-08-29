using System;
using System.Collections.Generic;
using System.Linq;


public class JetSki : IVehicle, IWaterVehicle {

    public int PassengerCapacity { get; set; }
    public double MaxWaterSpeed { get; set; }

    public void Drive () {
        Console.WriteLine ("The jetski zips through the waves with the greatest of ease");
    }

    public void Start () {
        throw new NotImplementedException ();
    }

    public void Stop () {
        throw new NotImplementedException ();
    }
}
public class Speedboat : IVehicle, IWaterVehicle {

    public int PassengerCapacity { get; set; } = 3;
    public double MaxWaterSpeed { get; set; } = 34;

    public void Drive () {
        Console.WriteLine ("The speedboat cuts through the waves with the greatest of ease");
    }

    public void Start () {
        throw new NotImplementedException ();
    }

    public void Stop () {
        throw new NotImplementedException ();
    }
}

public class Motorcycle : IVehicle, ILandVehicle {
    public int Wheels { get; set; } = 2;
    public int Doors { get; set; } = 0;
    public int PassengerCapacity { get; set; }
    public string TransmissionType { get; set; } = "Manual";
    public double EngineVolume { get; set; } = 1.3;
    public double MaxLandSpeed { get; set; } = 160.4;

    public void Drive () {
        Console.WriteLine ("The motorcycle screams down the highway");
    }

    public void Start () {
        throw new NotImplementedException ();
    }

    public void Stop () {
        throw new NotImplementedException ();
    }
}
public class Civic : IVehicle, ILandVehicle {
    public int Wheels { get; set; } = 4;
    public int Doors { get; set; } = 2;
    public int PassengerCapacity { get; set; } = 4;
    public string TransmissionType { get; set; } = "Manual";
    public double EngineVolume { get; set; } = 0.9;
    public double MaxLandSpeed { get; set; } = 128;

    public void Drive () {
        Console.WriteLine ("The Civic rolls down the highway");
    }

    public void Start () {
        throw new NotImplementedException ();
    }

    public void Stop () {
        throw new NotImplementedException ();
    }
}

public class Cessna : IVehicle, IFlyingVehicle {
    public int Wheels { get; set; } = 3;
    public int Doors { get; set; } = 3;
    public int PassengerCapacity { get; set; } = 113;
    public bool Winged { get; set; } = true;
    public double EngineVolume { get; set; } = 31.1;
    public double MaxAirSpeed { get; set; } = 309.0;

    public void Fly () {
        Console.WriteLine ("The Cessna effortlessly glides through the clouds like a gleaming god of the Sun");
    }

    public void Start () {
        throw new NotImplementedException ();
    }

    public void Stop () {
        throw new NotImplementedException ();
    }
}

public class Program {

    public static void Main () {

        // Build a collection of all vehicles that fly

        List<Cessna> flyingVehicles = new List<Cessna> ();
        flyingVehicles.Add (new Cessna ());
        // flyingVehicles.Add (new Cessna ());

        // With a single `foreach`, have each vehicle Fly()
        foreach (var flyingMachine in flyingVehicles) {
            flyingMachine.Fly ();
        }

        // Build a collection of all vehicles that operate on roads

        List<ILandVehicle> landVehicles = new List<ILandVehicle> ();
        landVehicles.Add (new Motorcycle ());
        landVehicles.Add (new Civic ());


        // With a single `foreach`, have each road vehicle Drive()
        foreach (var landMachine in landVehicles) {
            landMachine.Drive ();
        }
        // Build a collection of all vehicles that operate on water
        List<IWaterVehicle> waterVehicles = new List<IWaterVehicle> ();
        waterVehicles.Add (new JetSki ());
        waterVehicles.Add (new Speedboat ());

        // With a single `foreach`, have each water vehicle Drive()
        foreach (var waterMachine in waterVehicles) {
            waterMachine.Drive ();
        }
    }

}