public interface IElectricVehicle
{
    double BatteryKWh { get; set; }
    int currentChargePercentage { get; set; }
    void ChargeBattery();

}

public interface IGasVehicles
{
    void RefuelTank();
    double FuelCapacity { get; set; }
    int CurrentTankPercentage { get; set; }

}

