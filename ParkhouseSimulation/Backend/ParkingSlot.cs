using System;

namespace ParkhouseSimulation.Backend
{
   public class ParkingSlot
   {
      public event Action<string> OnRename; 

      public string ParkingSlotID => parkingSlotID;
      public VehicleType Type => type;
      
      private VehicleType type;
      private string parkingSlotID;
      
      public ParkingSlot(string id, VehicleType type)
      {
         parkingSlotID = id;
         this.type = type;
      }

      public void Rename(string id)
      {
         parkingSlotID = id;
         OnRename?.Invoke(id);
      }
   }
}