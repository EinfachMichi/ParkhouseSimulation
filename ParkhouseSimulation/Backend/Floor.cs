﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ParkhouseSimulation.Backend
{
   public class Floor
   {
      public string FloorID => floorID;
      public ParkingSlot[] CarSlots => carSlots.ToArray();
      public ParkingSlot[] BikeSlots => bikeSlots.ToArray();

      private List<ParkingSlot> slots => (List<ParkingSlot>) carSlots.Concat(bikeSlots);
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