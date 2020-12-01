namespace Inheritance
{
    public interface IElectricVehicle
    {
        void ChargeBattery();
        double BatteryKWh { get; set; }
        double CurrentChargePercentage { get; set; }
    }
    public interface IGasVehicle
    {
        void RefuelTank();
        double FuelCapacity { get; set; }
        double CurrentTankPercentage { get; set; }
    }
}