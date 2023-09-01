﻿using System.Collections.Generic;
using ParkhouseSimulation.Frontend;

namespace ParkhouseSimulation.Backend
{
   public class Parkhouse
   {
      public int Floors => floors.Count;
      
      private List<Floor> floors = new List<Floor>();

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

      private int uniqueVehicleID;
      
      public bool AddVehicle(VehicleType type)
      {
         Vehicle vehicle = new Vehicle(uniqueVehicleID.ToString(), type);
         ParkingSlot slot = FindFreeSlotFor(vehicle);
         if(slot != null)
         {
            slot.Vehicle = vehicle;
            uniqueVehicleID++;
            return true;
         }
         return false;
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
      
      public Floor GetFloor(int index) => floors[index];
      public int GetCarSlotCount(Floor floor) => floor.CarSlots.Length;
      public int GetBikeSlotCount(Floor floor) => floor.BikeSlots.Length;

      private ParkingSlot FindFreeSlotFor(Vehicle vehicle)
      {
         foreach(Floor floor in floors)
         {
            if(floor.FindFreeParkingSlotFor(vehicle, out ParkingSlot slot))
            {
               return slot;
            }
         }
         return null;
      }
   }
}