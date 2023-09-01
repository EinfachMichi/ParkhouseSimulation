using System;

namespace ParkhouseSimulation.Backend
{
   public class ParkingSlot
   {
      public event Action<string> OnRename;
      public event Action<Vehicle> OnVehicleChanged; 

      public bool Free;
      public string ParkingSlotID => parkingSlotID;
      public VehicleType Type => type;

      public Vehicle Vehicle
      {
         get => vehicle;
         set
         {
            vehicle = value;
            Free = vehicle == null;
            OnVehicleChanged?.Invoke(vehicle);
         }
      }
      
      private VehicleType type;
      private string parkingSlotID;
      private Vehicle vehicle;
      
      public ParkingSlot(string id, VehicleType type)
      {
         parkingSlotID = id;
         this.type = type;
         Free = true;
      }

      public void Rename(string id)
      {
         parkingSlotID = id;
         OnRename?.Invoke(id);
      }
   }
}