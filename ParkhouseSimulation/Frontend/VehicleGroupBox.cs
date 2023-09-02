using System.Drawing;
using System.Windows.Forms;
using ParkhouseSimulation.Backend;

namespace ParkhouseSimulation.Frontend
{
   public class VehicleGroupBox : GroupBox
   {
      public string CarID { get; }
      
      private TextBox vehiclePositionTextbox;
      private Label vehiclePostionLabel;
      private TextBox vehicleIDTextbox;
      private Label vehicleIDLabel;

      public VehicleGroupBox(Vehicle vehicle)
      {
         CarID = vehicle.ID;
         
         vehiclePositionTextbox = new TextBox();
         vehiclePostionLabel = new Label();
         vehicleIDTextbox = new TextBox();
         vehicleIDLabel = new Label();

         Color color = vehicle.Type == VehicleType.Car ? Color.LightSkyBlue : Color.Chocolate;
         BackColor = color;
         Controls.Add(vehiclePositionTextbox);
         Controls.Add(vehiclePostionLabel);
         Controls.Add(vehicleIDTextbox);
         Controls.Add(vehicleIDLabel);
         Font = new Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         ForeColor = SystemColors.ControlText;
         Location = new Point(8, 8);
         Name = $"vehicleGroupBox{vehicle.ID}";
         Size = new Size(160, 67);
         TabIndex = 0;
         TabStop = false;
         Text = vehicle.Type.ToString();
         
         vehiclePositionTextbox.Font = new Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         vehiclePositionTextbox.Location = new Point(77, 42);
         vehiclePositionTextbox.Name = $"vehiclePositionTextbox{vehicle.ID}";
         vehiclePositionTextbox.ReadOnly = true;
         vehiclePositionTextbox.Size = new Size(77, 22);
         vehiclePositionTextbox.TabIndex = 3;
         vehiclePositionTextbox.Text = vehicle.Position;

         vehiclePostionLabel.Font = new Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         vehiclePostionLabel.Location = new Point(6, 45);
         vehiclePostionLabel.Name = "vehiclePostionLabel";
         vehiclePostionLabel.Size = new Size(73, 15);
         vehiclePostionLabel.TabIndex = 2;
         vehiclePostionLabel.Text = "Position:";
         
         vehicleIDTextbox.Font = new Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         vehicleIDTextbox.Location = new Point(77, 19);
         vehicleIDTextbox.Name = $"vehicleIDTextbox{vehicle.ID}";
         vehicleIDTextbox.ReadOnly = true;
         vehicleIDTextbox.Size = new Size(77, 22);
         vehicleIDTextbox.TabIndex = 1;
         vehicleIDTextbox.Text = vehicle.ID;
         
         vehicleIDLabel.Font = new Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         vehicleIDLabel.Location = new Point(6, 22);
         vehicleIDLabel.Name = $"vehicleIDLabel{vehicle.ID}";
         vehicleIDLabel.Size = new Size(73, 15);
         vehicleIDLabel.TabIndex = 0;
         vehicleIDLabel.Text = "VehicleID:";
      }
      
   }
}