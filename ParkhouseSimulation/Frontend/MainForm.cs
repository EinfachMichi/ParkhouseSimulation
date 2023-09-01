﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ParkhouseSimulation.Backend;

namespace ParkhouseSimulation.Frontend
{
   public partial class MainForm : Form
   {
      private Parkhouse parkhouse = new Parkhouse();
      private List<FloorPanel> floorPanels = new List<FloorPanel>();

      public MainForm()
      {
         InitializeComponent();
         RefreshFloorCreatePage();
      }

      #region Floor (Create/Edit/Remove)

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
      }

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
               RefreshFloorRemovePage(floorSelectionComboBox.SelectedIndex);
               break;
         }
      }
      
      private void FloorEditPageComboBox_DropDownClosed(object sender, EventArgs e)
      {
         int selectedIndex = floorEditPageComboBox.SelectedIndex;
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
         int selectedIndex = floorEditPageComboBox.SelectedIndex;
         int carCount = (int)floorEditPageCarsNumericUpDown.Value;
         int bikeCount = (int)floorEditPageBikesNumericUpDown.Value;
         
         Floor newFloor = new Floor(carCount, bikeCount, GetAlphabeticalCharacterAt(selectedIndex));
         parkhouse.ReplaceFloor(selectedIndex, newFloor);
         FloorPanel newPanel = new FloorPanel(newFloor);
         floorDisplayPanel.Controls.Add(newPanel);
         floorPanels[selectedIndex].Dispose();
         floorPanels[selectedIndex] = newPanel;
         
         RefreshFloorDisplay(selectedIndex);
      }

      private void FloorRemovePageComboBox_DropDownClosed(object sender, EventArgs e)
      {
         int selectedIndex = floorRemovePageComboBox.SelectedIndex;
         UpdateFloorComboBox(selectedIndex, floorSelectionComboBox);
      }
      
      private void FloorRemovePageButton_Click(object sender, EventArgs e)
      {
         int removeIndex = floorRemovePageComboBox.SelectedIndex;

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

      private void DriveInButton_Click(object sender, EventArgs e)
      {
         int carCount = (int) driveInCarsNumericUpDown.Value;
         int bikeCount = (int) driveInBikesNumericUpDown.Value;

         for(int i = 0; i < carCount; i++)
         {
            if(!parkhouse.AddVehicle(VehicleType.Car))
            {
               //TODO: ERROR MESSAGE
            }
         }
         
         for(int i = 0; i < bikeCount; i++)
         {
            if(!parkhouse.AddVehicle(VehicleType.Bike))
            {
               //TODO: ERROR MESSAGE
            }
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