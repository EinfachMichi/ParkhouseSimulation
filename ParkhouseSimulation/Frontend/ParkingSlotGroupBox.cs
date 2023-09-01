using System.Drawing;
using System.Windows.Forms;
using ParkhouseSimulation.Backend;

namespace ParkhouseSimulation.Frontend
{
   public class ParkingSlotGroupBox : GroupBox
   {
      private Panel panel;
      private Label vehicleTypeLabel;
      private Label vehicleTypeDisplayLabel;
      private Label carIdLabel;
      private Label carIdDisplayLabel;

      private ParkingSlot parkingSlot;
      
      public ParkingSlotGroupBox(ParkingSlot slot)
      {
         parkingSlot = slot;

         slot.OnRename += Rename;
         slot.OnVehicleChanged += SlotOnOnVehicleChanged;
         
         panel = new Panel();
         vehicleTypeLabel = new Label();
         vehicleTypeDisplayLabel = new Label();
         carIdLabel = new Label();
         carIdDisplayLabel = new Label();
         
         BackColor = Color.FromArgb(0, 192, 0);
         Controls.Add(panel);
         Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
         ForeColor = SystemColors.ControlLightLight;
         Location = new Point(3, 3);
         Name = $"Slot{slot.ParkingSlotID}";
         Size = new Size(100, 75);
         TabStop = false;
         Text = slot.ParkingSlotID;

         panel.BackColor = Color.FromArgb(64, 64, 64);
         panel.Controls.Add(vehicleTypeLabel);
         panel.Controls.Add(vehicleTypeDisplayLabel);
         panel.Controls.Add(carIdLabel);
         panel.Controls.Add(carIdDisplayLabel);
         panel.Location = new Point(6, 15);
         panel.Name = $"SlotPanel{slot.ParkingSlotID}";
         panel.Size = new Size(88, 54);

         vehicleTypeDisplayLabel.Location = new Point(44, 29);
         vehicleTypeDisplayLabel.Name = $"SlotVehicleTypeDisplayLabel{slot.ParkingSlotID}";
         vehicleTypeDisplayLabel.Size = new Size(66, 13);
         vehicleTypeDisplayLabel.Text = slot.Type.ToString();

         vehicleTypeLabel.AutoSize = true;
         vehicleTypeLabel.Location = new Point(3, 29);
         vehicleTypeLabel.Name = $"SlotVehicleTypeLabel{slot.ParkingSlotID}";
         vehicleTypeLabel.Size = new Size(39, 13);
         vehicleTypeLabel.Text = "Type:";

         carIdDisplayLabel.Location = new Point(44, 9);
         carIdDisplayLabel.Name = $"SlotCarIDDisplayLabel{slot.ParkingSlotID}";
         carIdDisplayLabel.Size = new Size(66, 13);
         carIdDisplayLabel.TabIndex = 1;
         carIdDisplayLabel.Text = "NONE";

         carIdLabel.AutoSize = true;
         carIdLabel.Location = new Point(3, 9);
         carIdLabel.Name = $"SlotCarIDLabel{slot.ParkingSlotID}";
         carIdLabel.Size = new Size(43, 13);
         carIdLabel.TabIndex = 0;
         carIdLabel.Text = "ID:";
      }

      ~ParkingSlotGroupBox()
      {
         parkingSlot.OnRename -= Rename;
         parkingSlot.OnVehicleChanged -= SlotOnOnVehicleChanged;
      } 
      
      private void SlotOnOnVehicleChanged(Vehicle vehicle)
      {
         if(vehicle != null)
         {
            carIdDisplayLabel.Text = vehicle.ID;
            BackColor = Color.FromArgb(192, 0 ,0);
         }
         else
         {
            carIdDisplayLabel.Text = "NONE";
            BackColor = Color.FromArgb(0, 192 ,0);
         }
      }
      
      public void Rename(string id)
      {
         Text = id;
      }
   }
}