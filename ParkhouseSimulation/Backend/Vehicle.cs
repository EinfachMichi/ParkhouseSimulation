namespace ParkhouseSimulation.Backend
{
   public class Vehicle
   {
      public string ID => id;
      public VehicleType Type => type;
      public string Position => position;
      
      private string id;
      private VehicleType type;
      private string position;

      public Vehicle(string id, VehicleType type, string position)
      {
         this.id = id;
         this.type = type;
         this.position = position;
      }
   }
}