﻿using System.Collections.Generic;

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

         for(int i = 0; i < carSlots.Count; i++)
         {
            carSlots[i].Rename(id + slotID);
            slotID++;
         }
         
         for(int i = 0; i < bikeSlots.Count; i++)
         {
            bikeSlots[i].Rename(id + slotID);
            slotID++;
         }
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

      public int FreeParkingSlotCountForCars()
      {
         int count = 0;
         foreach(ParkingSlot slot in carSlots)
         {
            if(slot.Free) count++;
         }
         return count;
      }
      
      public int FreeParkingSlotCountForBikes()
      {
         int count = 0;
         foreach(ParkingSlot slot in bikeSlots)
         {
            if(slot.Free) count++;
         }
         return count;
      }

      public int OccupiedParkingSlotCountForCars()
      {
         int count = 0;
         foreach(ParkingSlot slot in carSlots)
         {
            if(!slot.Free) count++;
         }
         return count;
      }
      
      public int OccupiedParkingSlotCountForBikes()
      {
         int count = 0;
         foreach(ParkingSlot slot in bikeSlots)
         {
            if(!slot.Free) count++;
         }
         return count;
      }
      
      public bool FindFreeParkingSlotFor(VehicleType type, out ParkingSlot slot)
      {
         foreach(ParkingSlot parkingSlot in slots)
         {
            if(parkingSlot.Free && parkingSlot.Type == type)
            {
               slot = parkingSlot;
               return true;
            }
         }
         slot = null;
         return false;
      }

      public Vehicle RemoveVehicle(VehicleType type)
      {
         for(int i = slots.Count - 1; i >= 0; i--)
         {
            if(!slots[i].Free && slots[i].Type == type)
            {
               Vehicle vehicle = slots[i].Vehicle;
               slots[i].Vehicle = null;
               return vehicle;
            }
         }
         return null;
      }

      public Vehicle[] RemoveAllVehicles()
      {
         List<Vehicle> vehicles = new List<Vehicle>();
         for(int i = 0; i < slots.Count; i++)
         {
            if(!slots[i].Free)
            {
               vehicles.Add(slots[i].Vehicle);
            }
            slots[i].Vehicle = null;
         }
         return vehicles.ToArray();
      }

      public Vehicle FindVehicle(string id)
      {
         foreach(ParkingSlot slot in slots)
         {
            if(slot.Vehicle.ID == id)
            {
               return slot.Vehicle;
            }
         }
         return null;
      }
   }
}