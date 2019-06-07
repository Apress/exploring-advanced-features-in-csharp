namespace ExploringCSharp
{
    public interface ICarrier<T>
    {
        void AddVehicle(T value);
        void GetAllVehicles();
    }
}