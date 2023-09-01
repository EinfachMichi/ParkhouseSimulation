using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ParkhouseSimulation.Backend;

namespace ParkhouseSimulation.Frontend
{
   public class FloorPanel : FlowLayoutPanel
   {
      private List<ParkingSlotGroupBox> carParkingSlots = new List<ParkingSlotGroupBox>();
      private List<ParkingSlotGroupBox> bikeParkingSlots = new List<ParkingSlotGroupBox>();

      public FloorPanel(Floor floor)
      {
         Size = new Size(547, 498);
         Location = new Point(0, 0);
         AutoScroll = true;
         
         foreach(ParkingSlot carSlot in floor.CarSlots)
         {
            ParkingSlotGroupBox newSlot = new ParkingSlotGroupBox(carSlot);
            carParkingSlots.Add(newSlot);
            Controls.Add(newSlot);
         }
         
         foreach(ParkingSlot bikeSlot in floor.BikeSlots)
         {
            ParkingSlotGroupBox newSlot = new ParkingSlotGroupBox(bikeSlot);
            bikeParkingSlots.Add(newSlot);
            Controls.Add(newSlot);
         }
      }
   }
}