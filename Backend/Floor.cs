using System.Collections.Generic;

namespace ParkhouseSimulation.Backend
{
   public class Floor
   {
      public string FloorID => floorID;
      public ParkingSlot[] CarSlots => carSlots.ToArray();
      public ParkingSlot[] BikeSlots => bikeSlots.ToArray();
      
      private List<ParkingSlot> carSlots = new List<ParkingSlot>();
      private List<ParkingSlot> bikeSlots = new List<ParkingSlot>();
      private string floorID;
      
      public Floor(int carCount, int bikeCount, string id)
      {
         floorID = id;
         int slotID = 0;
         
         for(; slotID < carCount; slotID++)
            carSlots.Add(new ParkingSlot(id + slotID, VehicleType.Car));
         
         for(; slotID < bikeCount + carCount; slotID++)
            bikeSlots.Add(new ParkingSlot(id + slotID, VehicleType.Bike));
      }
   }
}