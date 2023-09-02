using System.Drawing;
using System.Windows.Forms;
using ParkhouseSimulation.Backend;

namespace ParkhouseSimulation.Frontend
{
   public class ParkingSlotGroupBox : GroupBox
   {
      private Panel panel;
      private Label vehicleTypeLabel;
      private TextBox vehicleTypeTextbox;
      private Label carIdLabel;
      private TextBox cardIDTextbox;

      private ParkingSlot parkingSlot;
      
      public ParkingSlotGroupBox(ParkingSlot slot)
      {
         parkingSlot = slot;

         slot.OnRename += Rename;
         slot.OnVehicleChanged += SlotOnOnVehicleChanged;

         panel = new Panel();
         vehicleTypeLabel = new Label();
         vehicleTypeTextbox = new TextBox();
         carIdLabel = new Label();
         cardIDTextbox = new TextBox();
         
         BackColor = Color.FromArgb(0, 192, 0);
         Controls.Add(panel);
         Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
         ForeColor = SystemColors.ControlLightLight;
         Location = new Point(3, 3);
         Name = $"Slot{slot.ParkingSlotID}";
         Size = new Size(100, 75);
         TabStop = false;
         Text = slot.ParkingSlotID;

         Color color = slot.Type == VehicleType.Car ? Color.LightSkyBlue : Color.Chocolate;
         panel.BackColor = color;
         panel.Controls.Add(vehicleTypeLabel);
         panel.Controls.Add(vehicleTypeTextbox);
         panel.Controls.Add(carIdLabel);
         panel.Controls.Add(cardIDTextbox);
         panel.Location = new Point(6, 15);
         panel.Name = $"SlotPanel{slot.ParkingSlotID}";
         panel.Size = new Size(88, 54);

         vehicleTypeLabel.AutoSize = true;
         vehicleTypeLabel.Location = new Point(3, 29);
         vehicleTypeLabel.Name = $"SlotVehicleTypeLabel{slot.ParkingSlotID}";
         vehicleTypeLabel.Size = new Size(39, 13);
         vehicleTypeLabel.Text = "Type:";
         vehicleTypeLabel.ForeColor = SystemColors.WindowText;
         vehicleTypeLabel.Font = new Font("Microsoft Sans Serif", 9F, GraphicsUnit.Point);

         carIdLabel.AutoSize = true;
         carIdLabel.Location = new Point(3, 9);
         carIdLabel.Name = $"SlotCarIDLabel{slot.ParkingSlotID}";
         carIdLabel.Size = new Size(43, 13);
         carIdLabel.TabIndex = 0;
         carIdLabel.Text = "ID:";
         carIdLabel.ForeColor = SystemColors.WindowText;
         carIdLabel.Font = new Font("Microsoft Sans Serif", 9F, GraphicsUnit.Point);
         
         cardIDTextbox.Location = new Point(40, 6);
         cardIDTextbox.Name = "textBox1";
         cardIDTextbox.ReadOnly = true;
         cardIDTextbox.Size = new Size(45, 22);
         cardIDTextbox.TabIndex = 1;
         cardIDTextbox.Text = "NONE";
         cardIDTextbox.Font = new Font("Microsoft Sans Serif", 9F, GraphicsUnit.Point);

         vehicleTypeTextbox.Location = new Point(40, 29);
         vehicleTypeTextbox.Name = "textBox2";
         vehicleTypeTextbox.ReadOnly = true;
         vehicleTypeTextbox.Size = new Size(45, 22);
         vehicleTypeTextbox.TabIndex = 2;
         vehicleTypeTextbox.Text = slot.Type.ToString();
         vehicleTypeTextbox.Font = new Font("Microsoft Sans Serif", 9F, GraphicsUnit.Point);
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
            cardIDTextbox.Text = vehicle.ID;
            BackColor = Color.FromArgb(192, 0 ,0);
         }
         else
         {
            cardIDTextbox.Text = "NONE";
            BackColor = Color.FromArgb(0, 192 ,0);
         }
      }
      
      public void Rename(string id)
      {
         Text = id;
      }
   }
}