using System.Collections.Generic;
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

      public Floor GetFloor(int index) => floors[index];
      public int GetCarSlotCount(Floor floor) => floor.CarSlots.Length;
      public int GetBikeSlotCount(Floor floor) => floor.BikeSlots.Length;
   }
}