namespace ParkhouseSimulation.Backend
{
   public class Vehicle
   {
      public string ID => id;
      public VehicleType Type => type;
      
      private string id;
      private VehicleType type;

      public Vehicle(string id, VehicleType type)
      {
         this.id = id;
         this.type = type;
      }
   }
}