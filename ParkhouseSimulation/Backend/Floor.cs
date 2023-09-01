using System.Collections.Generic;

namespace ParkhouseSimulation.Backend
{
   public class Floor
   {
      public string FloorID => floorID;
      public int SlotCount => slots.Count;
      public ParkingSlot[] CarSlots => carSlots.ToArray();
      public ParkingSlot[] BikeSlots => bikeSlots.ToArray();

      private List<ParkingSlot> slots
      {
         get
         {
            List<ParkingSlot> slotList = new List<ParkingSlot>();
            foreach(ParkingSlot slot in carSlots) slotList.Add(slot);
            foreach(ParkingSlot slot in bikeSlots) slotList.Add(slot);
            return slotList;
         }
      }
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

      public void Rename(string id)
      {
         floorID = id;
         int slotID = 0;
         
         for(; slotID < carSlots.Count; slotID++)
            carSlots[slotID].Rename(id + slotID);
         
         for(; slotID < bikeSlots.Count + carSlots.Count; slotID++)
            bikeSlots[slotID].Rename(id + slotID);
      }

      public int FreeParkingSlotCount()
      {
         int count = 0;
         foreach(ParkingSlot slot in slots)
         {
            if(slot.Free) count++;
         }
         return count;
      }

      public bool FindFreeParkingSlotFor(Vehicle vehicle, out ParkingSlot slot)
      {
         foreach(ParkingSlot parkingSlot in slots)
         {
            if(parkingSlot.Free && parkingSlot.Type == vehicle.Type)
            {
               slot = parkingSlot;
               return true;
            }
         }
         slot = null;
         return false;
      }
   }
}