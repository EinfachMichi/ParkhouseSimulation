using System;
using System.Collections.Generic;
using ParkhouseSimulation.Frontend;

namespace ParkhouseSimulation.Backend
{
   public class Parkhouse
   {
      public int Floors => floors.Count;

      public int Slots
      {
         get
         {
            int count = 0;
            foreach(Floor floor in floors)
            {
               count += floor.SlotCount;
            }
            return count;
         }
      }
      public int Cars
      {
         get
         {
            int count = 0;
            foreach(Floor floor in floors)
            {
               count += floor.OccupiedParkingSlotCountForCars();
            }
            return count;
         }
      }
      public int Bikes
      {
         get
         {
            int count = 0;
            foreach(Floor floor in floors)
            {
               count += floor.OccupiedParkingSlotCountForBikes();
            }
            return count;
         }
      }
      public int CarSlots
      {
         get
         {
            int count = 0;
            foreach(Floor floor in floors)
            {
               count += floor.CarSlots.Length;
            }
            return count;
         }
      }
      public int BikeSlots
      {
         get
         {
            int count = 0;
            foreach(Floor floor in floors)
            {
               count += floor.BikeSlots.Length;
            }
            return count;
         }
      }
      
      private List<Floor> floors = new List<Floor>();
      private int uniqueVehicleID;

      public Floor AddFloor(int carCount, int bikeCount)
      {
         Floor floor = new Floor(carCount, bikeCount, MainForm.GetAlphabeticalCharacterAt(Floors));
         floors.Add(floor);
         return floor;
      }

      public void ReplaceFloor(int index, Floor floor)
      {
         floors[index] = floor;
      }

      public Floor RemoveFloor(int index)
      {
         Floor removedFloor = floors[index];
         floors.RemoveAt(index);
         return removedFloor;
      }

      public Vehicle AddVehicle(VehicleType type)
      {
         ParkingSlot slot = FindFreeSlotFor(type);
         if(slot != null)
         {
            Vehicle vehicle = new Vehicle(GenerateVehicleSignID(slot.GetHashCode()), type, slot.ParkingSlotID);
            slot.Vehicle = vehicle;
            return vehicle;
         }
         return null;
      }

      public Vehicle[] RemoveVehicle(int floorIndex)
      {
         return floors[floorIndex].RemoveAllVehicles();
      }
      
      public Vehicle RemoveVehicle(VehicleType type)
      {
         for(int i = Floors - 1; i >= 0; i--)
         {
            Vehicle vehicle = floors[i].RemoveVehicle(type);
            if(vehicle != null)
            {
               return vehicle;
            }
         }
         return null;
      }

      public int FreeParkingSlotCountForCars()
      {
         int count = 0;
         foreach(Floor floor in floors)
         {
            count += floor.FreeParkingSlotCountForCars();
         }
         return count;
      }
      
      public int FreeParkingSlotCountForBikes()
      {
         int count = 0;
         foreach(Floor floor in floors)
         {
            count += floor.FreeParkingSlotCountForBikes();
         }
         return count;
      }

      public int OccupiedParkingSlotCountForCars()
      {
         int count = 0;
         foreach(Floor floor in floors)
         {
            count += floor.OccupiedParkingSlotCountForCars();
         }
         return count;
      }
      
      public int OccupiedParkingSlotCountForBikes()
      {
         int count = 0;
         foreach(Floor floor in floors)
         {
            count += floor.OccupiedParkingSlotCountForBikes();
         }
         return count;
      }

      public Vehicle FindVehicle(string id)
      {
         foreach(Floor floor in floors)
         {
            Vehicle vehicle = floor.FindVehicle(id);
            if(vehicle == null) continue;
            return vehicle;
         }
         return null;
      }
      
      public Floor GetFloor(int index) => floors[index];
      public int GetCarSlotCount(Floor floor) => floor.CarSlots.Length;
      public int GetBikeSlotCount(Floor floor) => floor.BikeSlots.Length;

      private ParkingSlot FindFreeSlotFor(VehicleType type)
      {
         foreach(Floor floor in floors)
         {
            if(floor.FindFreeParkingSlotFor(type, out ParkingSlot slot))
            {
               return slot;
            }
         }
         return null;
      }

      private string GenerateVehicleSignID(int seed = 0)
      {
         string signID = "K:";
         Random random = new Random(seed);
         int firstRandomCharacter = random.Next(1, 26);
         signID += ((char) ('A' + firstRandomCharacter)).ToString();
         signID += $":{uniqueVehicleID.ToString("0000")}";
         uniqueVehicleID++;
         return signID;
      }
   }
}