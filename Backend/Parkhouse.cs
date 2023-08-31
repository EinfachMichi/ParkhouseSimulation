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

      private void AddFloorAt(int index, int carCount, int bikeCount)
      {
         Floor floor = new Floor(carCount, bikeCount, MainForm.GetAlphabeticalCharacterAt(Floors));
         floors.Insert(index, floor);
      }
      
      public void EditFloor(int index, int carCount, int bikeCount)
      {
         floors.RemoveAt(index);
         AddFloorAt(index, carCount, bikeCount);
      }
   }
}