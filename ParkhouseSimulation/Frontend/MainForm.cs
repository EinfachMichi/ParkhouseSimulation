using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ParkhouseSimulation.Backend;

namespace ParkhouseSimulation.Frontend
{
   public partial class MainForm : Form
   {
      private Parkhouse parkhouse = new Parkhouse();

      public MainForm()
      {
         InitializeComponent();
         RefreshFloorCreatePage();
         RefreshDriveInPage();
         RefreshParkhouseStats();
         InitVehicleSearchComboBox();
      }

      #region Floor (Create/Edit/Remove)

      private List<FloorPanel> floorPanels = new List<FloorPanel>();
      
      private void FloorCreationTabControl_SelectedIndexChanged(object sender, EventArgs e)
      {
         switch(floorCreationTabControl.SelectedIndex)
         {
            case 0:
               RefreshFloorCreatePage();
               break;
            case 1:
               RefreshFloorEditPage(floorSelectionComboBox.SelectedIndex);
               break;
            case 2:
               floorRemovePageButton.Focus();
               RefreshFloorRemovePage(floorSelectionComboBox.SelectedIndex);
               break;
         }
      }
      
      private void CreateFloorButton_Click(object sender, EventArgs e)
      {
         int carCount = (int) floorCreatePageCarsNumericUpDown.Value;
         int bikeCount = (int) floorCreatePageBikesNumericUpDown.Value;
         
         Floor newFloor = parkhouse.AddFloor(carCount, bikeCount);
         
         FloorPanel newFloorPanel = new FloorPanel(newFloor);
         floorPanels.Add(newFloorPanel);
         floorDisplayPanel.Controls.Add(newFloorPanel);
         HideAllFloorPanelsExceptFor(floorPanels.Count - 1);

         RefreshFloorCreatePage();
         UpdateFloorComboBox(floorSelectionComboBox);
         floorSelectionComboBox.SelectedIndex = parkhouse.Floors - 1;
         
         RefreshDriveInPage();
         RefreshParkhouseStats();
      }

      private int floorEditPageComboBoxIndex;
      
      private void FloorEditPageComboBox_DropDownClosed(object sender, EventArgs e)
      {
         if (floorEditPageComboBoxIndex == floorEditPageComboBox.SelectedIndex) return;
         int selectedIndex = floorEditPageComboBox.SelectedIndex;
         floorEditPageComboBoxIndex = selectedIndex;
         RefreshFloorEditPage(selectedIndex);
         UpdateFloorComboBox(selectedIndex, floorSelectionComboBox);
      }
      
      private void FloorSelectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
      {
         int selectedIndex = floorSelectionComboBox.SelectedIndex;
         RefreshFloorDisplay(selectedIndex);
         RefreshFloorEditPage(selectedIndex);
         RefreshFloorRemovePage(selectedIndex);
      }
      
      private void FloorEditPageButton_Click(object sender, EventArgs e)
      {
         Floor floor = parkhouse.GetFloor(floorEditPageComboBox.SelectedIndex);
         if(floor.FreeParkingSlotCount() < floor.SlotCount)
         {
            DialogResult result = MessageBox.Show(
                        "When you edit this floor all parked cars will exit this parkhouse.",
                        "Are you sure?",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
            );

            if(result != DialogResult.Yes) return;
         }
         
         int selectedIndex = floorEditPageComboBox.SelectedIndex;
         int carCount = (int)floorEditPageCarsNumericUpDown.Value;
         int bikeCount = (int)floorEditPageBikesNumericUpDown.Value;
         
         Vehicle[] vehicles = parkhouse.RemoveVehicle(selectedIndex);
         if(vehicles != null) VehiclesRemoved(vehicles);
         
         Floor newFloor = new Floor(carCount, bikeCount, GetAlphabeticalCharacterAt(selectedIndex));
         parkhouse.ReplaceFloor(selectedIndex, newFloor);
         FloorPanel newPanel = new FloorPanel(newFloor);
         floorDisplayPanel.Controls.Add(newPanel);
         floorPanels[selectedIndex].Dispose();
         floorPanels[selectedIndex] = newPanel;
         
         RefreshFloorDisplay(selectedIndex);
         RefreshParkhouseStats();
      }

      private int floorRemoveComboBoxIndex;

      private void FloorRemovePageComboBox_DropDownClosed(object sender, EventArgs e)
      {
         if (floorRemoveComboBoxIndex == floorRemovePageComboBox.SelectedIndex) return;
         int selectedIndex = floorRemovePageComboBox.SelectedIndex;
         floorRemoveComboBoxIndex = selectedIndex;
         UpdateFloorComboBox(selectedIndex, floorSelectionComboBox);
      }
      
      private void FloorRemovePageButton_Click(object sender, EventArgs e)
      {
         Floor removingFloor = parkhouse.GetFloor(floorRemovePageComboBox.SelectedIndex);
         if(removingFloor.FreeParkingSlotCount() < removingFloor.SlotCount)
         {
            DialogResult result = MessageBox.Show(
                        "When you remove this floor all parked cars will exit this parkhouse.",
                        "Are you sure?",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
            );

            if(result != DialogResult.Yes) return;
         }
         
         int removeIndex = floorRemovePageComboBox.SelectedIndex;

         Vehicle[] vehicles = parkhouse.RemoveVehicle(removeIndex);
         VehiclesRemoved(vehicles);
         
         floorPanels[removeIndex].Dispose();
         floorPanels.RemoveAt(removeIndex);
         parkhouse.RemoveFloor(removeIndex);
         
         int floorsToRename = parkhouse.Floors - removeIndex;

         if(floorsToRename > 0)
         {
            for(int i = 0; i < floorsToRename; i++)
            {
               Floor floor = parkhouse.GetFloor(removeIndex + i);
               floor.Rename(GetAlphabeticalCharacterAt(removeIndex + i));
            }
         }

         int temp = 0;
         if(floorsToRename == 0) temp = -1;
         
         UpdateFloorComboBox(removeIndex + temp, floorSelectionComboBox);
         RefreshFloorRemovePage(removeIndex + temp);
         RefreshParkhouseStats();
      }
      
      private void FloorCreatePageCarsNumericUpDown_KeyDown(object sender, KeyEventArgs e)
      {
         if(e.KeyCode == Keys.Enter)
         {
            CreateFloorButton_Click(sender, e);
         }
      }

      private void FloorCreatePageBikesNumericUpDown_KeyDown(object sender, KeyEventArgs e)
      {
         if(e.KeyCode == Keys.Enter)
         {
            CreateFloorButton_Click(sender, e);
         }
      }
      
      private void FloorEditPageCarsNumericUpDown_KeyDown(object sender, KeyEventArgs e)
      {
         if(e.KeyCode == Keys.Enter)
         {
            FloorEditPageButton_Click(sender, e);
         }
      }

      private void FloorEditPageBikesNumericUpDown_KeyDown(object sender, KeyEventArgs e)
      {
         if(e.KeyCode == Keys.Enter)
         {
            FloorEditPageButton_Click(sender, e);
         }
      }

      private void FloorCreatePageCarsNumericUpDown_Enter(object sender, EventArgs e)
      {
         if(floorCreatePageCarsNumericUpDown.Value == 0)
         {
            floorCreatePageCarsNumericUpDown.Text = "";
         }
      }

      private void FloorCreatePageBikesNumericUpDown_Enter(object sender, EventArgs e)
      {
         if(floorCreatePageBikesNumericUpDown.Value == 0)
         {
            floorCreatePageBikesNumericUpDown.Text = "";
         }
      }
      
      private void FloorEditPageCarsNumericUpDown_Enter(object sender, EventArgs e)
      {
         if(floorEditPageCarsNumericUpDown.Value == 0)
         {
            floorEditPageCarsNumericUpDown.Text = "";
         }
      }

      private void FloorEditPageBikesNumericUpDown_Enter(object sender, EventArgs e)
      {
         if(floorEditPageBikesNumericUpDown.Value == 0)
         {
            floorEditPageBikesNumericUpDown.Text = "";
         }
      }
      
      private void FloorCreatePageCarsNumericUpDown_Leave(object sender, EventArgs e)
      {
         if(floorCreatePageCarsNumericUpDown.Text == "")
         {
            floorCreatePageCarsNumericUpDown.Text = "0";
         }
      }

      private void FloorCreatePageBikesNumericUpDown_Leave(object sender, EventArgs e)
      {
         if(floorCreatePageBikesNumericUpDown.Text == "")
         {
            floorCreatePageBikesNumericUpDown.Text = "0";
         }
      }

      private void FloorEditPageCarsNumericUpDown_Leave(object sender, EventArgs e)
      {
         if(floorEditPageCarsNumericUpDown.Text == "")
         {
            floorEditPageCarsNumericUpDown.Text = "0";
         }
      }

      private void FloorEditPageBikesNumericUpDown_Leave(object sender, EventArgs e)
      {
         if(floorEditPageBikesNumericUpDown.Text == "")
         {
            floorEditPageBikesNumericUpDown.Text = "0";
         }
      }
      
      //----------------------------------------------------------------------------------------------------------------
      
      private void RefreshFloorCreatePage()
      {
         floorCreatePageNameTextBox.Text = $"Floor {GetAlphabeticalCharacterAt(parkhouse.Floors)}";
         floorCreatePageCarsNumericUpDown.Value = 0;
         floorCreatePageBikesNumericUpDown.Value = 0;
      }

      private void RefreshFloorEditPage(int floorIndex)
      {
         UpdateFloorComboBox(floorIndex, floorEditPageComboBox);
         floorEditPageButton.Enabled = parkhouse.Floors > 0;
         if (parkhouse.Floors == 0) return;
         
         Floor currentFloor = parkhouse.GetFloor(floorIndex);
         floorEditPageCarsNumericUpDown.Value = parkhouse.GetCarSlotCount(currentFloor);
         floorEditPageBikesNumericUpDown.Value = parkhouse.GetBikeSlotCount(currentFloor);
      }

      private void RefreshFloorRemovePage(int index)
      {
         UpdateFloorComboBox(index, floorRemovePageComboBox);
         floorRemovePageButton.Enabled = parkhouse.Floors > 1;
      }
      
      private void RefreshFloorDisplay(int index)
      {
         HideAllFloorPanelsExceptFor(index);
      }
      
      //----------------------------------------------------------------------------------------------------------------
      
      private void HideAllFloorPanelsExceptFor(int excludingIndex)
      {
         foreach(FloorPanel floorPanel in floorPanels) floorPanel.Visible = false;
         floorPanels[excludingIndex].Visible = true;
      }

      private void UpdateFloorComboBox(ComboBox comboBox)
      {
         string[] data = new string[parkhouse.Floors];
         for(int i = 0; i < data.Length; i++)
            data[i] = $"Floor {GetAlphabeticalCharacterAt(i)}";
         comboBox.DataSource = data;
      }

      private void UpdateFloorComboBox(int newIndex, ComboBox comboBox)
      {
         UpdateFloorComboBox(comboBox);
         comboBox.SelectedIndex = newIndex;
      }
      
      #endregion

      #region Drive (In/Out)

      private void DriveInOutTabControl_SelectedIndexChanged(object sender, EventArgs e)
      {
         switch(driveInOutTabControl.SelectedIndex)
         {
            case 0:
               RefreshDriveInPage();
               break;
         }
      }
      
      private void DriveInButton_Click(object sender, EventArgs e)
      {
         int carCount = (int) driveInCarsNumericUpDown.Value;
         int bikeCount = (int) driveInBikesNumericUpDown.Value;

         Vehicle[] cars = new Vehicle[carCount];
         for(int i = 0; i < carCount; i++)
         {
            cars[i] = parkhouse.AddVehicle(VehicleType.Car);
         }
         CarsAdded(cars);
         
         Vehicle[] bikes = new Vehicle[bikeCount];
         for(int i = 0; i < bikeCount; i++)
         {
            bikes[i] = parkhouse.AddVehicle(VehicleType.Bike);
         }
         BikesAdded(bikes);
         
         RefreshDriveInPage();
         RefreshParkhouseStats();
      }
      
      private void DriveOutButton_Click(object sender, EventArgs e)
      {
         int carCount = (int) driveOutCarsNumericUpDown.Value;
         int bikeCount = (int) driveOutBikesNumericUpDown.Value;

         Vehicle[] cars = new Vehicle[carCount];
         for(int i = 0; i < carCount; i++)
         {
            cars[i] = parkhouse.RemoveVehicle(VehicleType.Car);
         }
         CarsRemoved(cars);

         Vehicle[] bikes = new Vehicle[bikeCount];
         for(int i = 0; i < bikeCount; i++)
         {
            bikes[i] = parkhouse.RemoveVehicle(VehicleType.Bike);
         }
         BikesRemoved(bikes);
         
         RefreshDriveOutPage();
         RefreshParkhouseStats();
      }
      
      private void DriveInCarsNumericUpDown_Leave(object sender, EventArgs e)
      {
         RefreshDriveInPage();
         if(driveInCarsNumericUpDown.Text == "")
         {
            driveInCarsNumericUpDown.Text = "0";
         }
      }
      
      private void DriveInBikesNumericUpDown_Leave(object sender, EventArgs e)
      {
         RefreshDriveInPage();
         if(driveInBikesNumericUpDown.Text == "")
         {
            driveInBikesNumericUpDown.Text = "0";
         }
      }
      
      private void DriveOutCarsNumericUpDown_Leave(object sender, EventArgs e)
      {
         RefreshDriveOutPage();
         if(driveOutCarsNumericUpDown.Text == "")
         {
            driveOutCarsNumericUpDown.Text = "0";
         }
      }
      
      private void DriveOutBikesNumericUpDown_Leave(object sender, EventArgs e)
      {
         RefreshDriveOutPage();
         if(driveOutBikesNumericUpDown.Text == "")
         {
            driveOutBikesNumericUpDown.Text = "0";
         }
      }
      
      private void DriveInCarsNumericUpDown_KeyDown(object sender, KeyEventArgs e)
      {
         if(e.KeyCode == Keys.Enter)
         {
            RefreshDriveInPage();
            DriveInButton_Click(sender, e);
         }
      }

      private void DriveInBikesNumericUpDown_KeyDown(object sender, KeyEventArgs e)
      {
         if(e.KeyCode == Keys.Enter)
         {
            RefreshDriveInPage();
            DriveInButton_Click(sender, e);
         }
      }

      private void DriveOutCarsNumericUpDown_KeyDown(object sender, KeyEventArgs e)
      {
         if(e.KeyCode == Keys.Enter)
         {
            RefreshDriveOutPage();
            DriveOutButton_Click(sender, e);
         }
      }

      private void DriveOutBikesNumericUpDown_KeyDown(object sender, KeyEventArgs e)
      {
         if(e.KeyCode == Keys.Enter)
         {
            RefreshDriveOutPage();
            DriveOutButton_Click(sender, e);
         }
      }
      
      private void DriveInCarsNumericUpDown_Enter(object sender, EventArgs e)
      {
         if(driveInCarsNumericUpDown.Value == 0)
         {
            driveInCarsNumericUpDown.Text = "";
         }
      }

      private void DriveInBikesNumericUpDown_Enter(object sender, EventArgs e)
      {
         if(driveInBikesNumericUpDown.Value == 0)
         {
            driveInBikesNumericUpDown.Text = "";
         }
      }

      private void DriveOutCarsNumericUpDown_Enter(object sender, EventArgs e)
      {
         if(driveOutCarsNumericUpDown.Value == 0)
         {
            driveOutCarsNumericUpDown.Text = "";
         }
      }

      private void DriveOutBikesNumericUpDown_Enter(object sender, EventArgs e)
      {
         if(driveOutBikesNumericUpDown.Value == 0)
         {
            driveOutBikesNumericUpDown.Text = "";
         }
      }

      //----------------------------------------------------------------------------------------------------------------

      private void RefreshDriveInPage()
      {
         int maxPossibleCars = parkhouse.FreeParkingSlotCountForCars();
         int inputNumberCars = (int) driveInCarsNumericUpDown.Value;

         if(inputNumberCars > maxPossibleCars)
         {
            driveInCarsNumericUpDown.Value = maxPossibleCars;
         }
         
         int maxPossibleBikes = parkhouse.FreeParkingSlotCountForBikes();
         int inputNumberBikes = (int) driveInBikesNumericUpDown.Value;

         if(inputNumberBikes > maxPossibleBikes)
         {
            driveInBikesNumericUpDown.Value = maxPossibleBikes;
         }

         driveInButton.Enabled = parkhouse.Floors > 0;
      }

      private void RefreshDriveOutPage()
      {
         int maxPossibleCars = parkhouse.OccupiedParkingSlotCountForCars();
         int inputNumberCars = (int) driveOutCarsNumericUpDown.Value;

         if(inputNumberCars > maxPossibleCars)
         {
            driveOutCarsNumericUpDown.Value = maxPossibleCars;
         }
         
         int maxPossibleBikes = parkhouse.OccupiedParkingSlotCountForBikes();
         int inputNumberBikes = (int) driveOutBikesNumericUpDown.Value;

         if(inputNumberBikes > maxPossibleBikes)
         {
            driveOutBikesNumericUpDown.Value = maxPossibleBikes;
         }

         driveOutButton.Enabled = parkhouse.Floors > 0;
      }

      #endregion

      #region Parkhouse stats

      private void RefreshParkhouseStats()
      {
         int totalFloors = parkhouse.Floors;
         int totalCars = parkhouse.Cars;
         int totalBikes = parkhouse.Bikes;
         int totalCarSlots = parkhouse.CarSlots;
         int totalBikeSlots = parkhouse.BikeSlots;
         int totalSlots = parkhouse.Slots;

         int freeCarSlots = parkhouse.FreeParkingSlotCountForCars();
         int freeBikeSlots = parkhouse.FreeParkingSlotCountForBikes();

         int occupiedCarSlots = parkhouse.OccupiedParkingSlotCountForCars();
         int occupiedBikeSlots = parkhouse.OccupiedParkingSlotCountForBikes();

         statsTotalFloorsTextbox.Text = totalFloors.ToString();
         statsTotalCarsTextbox.Text = totalCars.ToString();
         statsTotalBikesTextbox.Text = totalBikes.ToString();
         statsTotalCarSlotsTextbox.Text = totalCarSlots.ToString();
         statsTotalBikeSlotsTextbox.Text = totalBikeSlots.ToString();
         statsTotalSlotsTextbox.Text = totalSlots.ToString();

         statsFreeCarSlotsTextbox.Text = freeCarSlots.ToString();
         statsFreeBikeSlotsTextbox.Text = freeBikeSlots.ToString();

         statsOccupiedCarSlotsTextbox.Text = occupiedCarSlots.ToString();
         statsOccupiedBikeSlotsTextbox.Text = occupiedBikeSlots.ToString();
      }

      #endregion

      #region Vehicle Display

      private List<VehicleGroupBox> carGroupBoxes = new List<VehicleGroupBox>();
      private List<VehicleGroupBox> bikeGroupBoxes = new List<VehicleGroupBox>();
      private VehicleShowType showType = VehicleShowType.All;

      private void VehicleSearchComboBox_SelectedIndexChanged(object sender, EventArgs e)
      {
         showType = (VehicleShowType) vehicleSearchComboBox.SelectedIndex;
         RefreshVehicleDisplay();
      }
      
      //----------------------------------------------------------------------------------------------------------------
      
      private void CarsAdded(Vehicle[] cars)
      {
         foreach(Vehicle car in cars)
         {
            VehicleGroupBox newBox = new VehicleGroupBox(car);
            carGroupBoxes.Add(newBox);
         }
         RefreshVehicleDisplay();
      }

      private void BikesAdded(Vehicle[] bikes)
      {
         foreach(Vehicle bike in bikes)
         {
            VehicleGroupBox newBox = new VehicleGroupBox(bike);
            bikeGroupBoxes.Add(newBox);
         }
         RefreshVehicleDisplay();
      }

      private void VehiclesRemoved(Vehicle[] vehicles)
      {
         for(int i = 0; i < vehicles.Length; i++)
         {
            if(vehicles[i].Type == VehicleType.Car)
            {
               for(int j = 0; j < carGroupBoxes.Count; j++)
               {
                  if(vehicles[i].ID == carGroupBoxes[j].VehicleID)
                  {
                     carGroupBoxes[j].Dispose();
                     carGroupBoxes.RemoveAt(j);
                     break;
                  }
               }
            }
            else if(vehicles[i].Type == VehicleType.Bike)
            {
               for(int j = 0; j < bikeGroupBoxes.Count; j++)
               {
                  if(vehicles[i].ID == bikeGroupBoxes[j].VehicleID)
                  {
                     bikeGroupBoxes[j].Dispose();
                     bikeGroupBoxes.RemoveAt(j);
                     break;
                  }
               }
            }
         }
         RefreshVehicleDisplay();
      }

      private void CarsRemoved(Vehicle[] cars)
      {
         foreach(Vehicle car in cars)
         {
            for(int i = 0; i < carGroupBoxes.Count; i++)
            {
               if(car.ID == carGroupBoxes[i].VehicleID)
               {
                  carGroupBoxes[i].Dispose();
                  carGroupBoxes.RemoveAt(i);
                  break;
               }
            }
         }
         RefreshVehicleDisplay();
      }

      private void BikesRemoved(Vehicle[] bikes)
      {
         foreach(Vehicle bike in bikes)
         {
            for(int i = 0; i < bikeGroupBoxes.Count; i++)
            {
               if(bike.ID == bikeGroupBoxes[i].VehicleID)
               {
                  bikeGroupBoxes[i].Dispose();
                  bikeGroupBoxes.RemoveAt(i);
                  break;
               }
            }
         }
         RefreshVehicleDisplay();
      }
      
      //----------------------------------------------------------------------------------------------------------------
      
      private void RefreshVehicleDisplay()
      {
         vehicleDisplayPanel.Controls.Clear();
         
         switch(showType)
         {
            case VehicleShowType.All:
               foreach(VehicleGroupBox carGroupBox in carGroupBoxes)
                  vehicleDisplayPanel.Controls.Add(carGroupBox);
               
               foreach(VehicleGroupBox bikeGroupBox in bikeGroupBoxes)
                  vehicleDisplayPanel.Controls.Add(bikeGroupBox);
               break;
            case VehicleShowType.Car:
               foreach(VehicleGroupBox carGroupBox in carGroupBoxes)
                  vehicleDisplayPanel.Controls.Add(carGroupBox);
               
               foreach(VehicleGroupBox bikeGroupBox in bikeGroupBoxes)
                  vehicleDisplayPanel.Controls.Remove(bikeGroupBox);
               break;
            case VehicleShowType.Bike:
               foreach(VehicleGroupBox carGroupBox in carGroupBoxes)
                  vehicleDisplayPanel.Controls.Remove(carGroupBox);
               
               foreach(VehicleGroupBox bikeGroupBox in bikeGroupBoxes)
                  vehicleDisplayPanel.Controls.Add(bikeGroupBox);
               break;
         }
      }

      private void InitVehicleSearchComboBox()
      {
         string[] data = new string[3];
         data[0] = "All";
         data[1] = "Car";
         data[2] = "Bike";
         vehicleSearchComboBox.DataSource = data;
      }
      
      private enum VehicleShowType
      {
         All,
         Car,
         Bike
      }
      
      #endregion

      #region Vehicle Search
      
      private void SearchVehicleButton_Click(object sender, EventArgs e)
      {
         try
         {
            string vehicleID = searchVehicleEnterIDTextbox.Text;
            Vehicle vehicle = parkhouse.FindVehicle(vehicleID);
            MessageBox.Show(
               $"This vehicle stays at position: [{vehicle.Position}].",
               $"{vehicle.Type}: {vehicle.ID}",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information
            );
         }
         catch(Exception exception)
         {
            MessageBox.Show(
               $"There is no vehicle with the id: {searchVehicleEnterIDTextbox.Text}.",
               "Input not correct!",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error
            );
         }
         searchVehicleEnterIDTextbox.Text = "";
      }
      
      private void SearchVehicleEnterIDTextbox_KeyDown(object sender, KeyEventArgs e)
      {
         if(e.KeyCode == Keys.Enter)
         {
            SearchVehicleButton_Click(sender, e);
         }
      }
      
      #endregion
      
      #region Extra Utilty

      public static string GetAlphabeticalCharacterAt(int index)
      {
         return ((char) ('A' + index)).ToString();
      }

      #endregion
   }
}