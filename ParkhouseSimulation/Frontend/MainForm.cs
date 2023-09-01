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

      #region Events

      private void CreateFloorButton_Click(object sender, EventArgs e)
      {
         int carCount = (int) floorCreatePageCarsNumericUpDown.Value;
         int bikeCount = (int) floorCreatePageBikesNumericUpDown.Value;
         Floor newFloor = parkhouse.AddFloor(carCount, bikeCount);
         
         FloorPanel newFloorPanel = new FloorPanel(newFloor);
         floorPanels.Add(newFloorPanel);
         floorDisplayPanel.Controls.Add(newFloorPanel);
         HideFloorPanels(floorPanels.Count - 1);

         RefreshFloorCreatePage();
         UpdateComboBox(floorSelectionComboBox);
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
               UpdateComboBox(floorSelectionComboBox.SelectedIndex, floorRemovePageComboBox);
               break;
         }
      }
      
      private void FloorEditPageComboBox_DropDownClosed(object sender, EventArgs e)
      {
         int selectedIndex = floorEditPageComboBox.SelectedIndex;
         RefreshFloorEditPage(selectedIndex);
         UpdateComboBox(selectedIndex, floorSelectionComboBox);
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
         UpdateComboBox(selectedIndex, floorSelectionComboBox);
      }
      
      private void FloorRemovePageButton_Click(object sender, EventArgs e)
      {
         if(parkhouse.Floors == 1) return;
         
         int removeIndex = floorRemovePageComboBox.SelectedIndex;

         floorPanels[removeIndex].Dispose();
         floorPanels.RemoveAt(removeIndex);
         parkhouse.RemoveFloor(removeIndex);
         
         int floorsToRename = parkhouse.Floors - removeIndex;

         if(floorsToRename > 0)
         {
            for(int i = 0; i < floorsToRename; i++)
            {
               Floor renamedFloor = parkhouse.GetFloor(removeIndex + i);
               renamedFloor.Rename(GetAlphabeticalCharacterAt(removeIndex + i));
               floorPanels[removeIndex + i].Rename(renamedFloor);
            }
         }

         int temp = 0;
         if(floorsToRename == 0) temp = -1;
         
         UpdateComboBox(removeIndex + temp, floorSelectionComboBox);
         RefreshFloorRemovePage(removeIndex + temp);
      }
      
      #endregion

      private void RefreshFloorCreatePage()
      {
         floorCreatePageNameTextBox.Text = $"Floor {GetAlphabeticalCharacterAt(parkhouse.Floors)}";
         floorCreatePageCarsNumericUpDown.Value = 0;
         floorCreatePageBikesNumericUpDown.Value = 0;
      }

      private void RefreshFloorEditPage(int floorIndex)
      {
         UpdateComboBox(floorIndex, floorEditPageComboBox);
         
         if (parkhouse.Floors == 0) return;
         
         Floor currentFloor = parkhouse.GetFloor(floorIndex);
         floorEditPageCarsNumericUpDown.Value = parkhouse.GetCarSlotCount(currentFloor);
         floorEditPageBikesNumericUpDown.Value = parkhouse.GetBikeSlotCount(currentFloor);
      }

      private void RefreshFloorRemovePage(int index)
      {
         UpdateComboBox(index, floorRemovePageComboBox);
      }
      
      private void RefreshFloorDisplay(int index)
      {
         HideFloorPanels(index);
      }
      
      #region Utilty

      public static string GetAlphabeticalCharacterAt(int index)
      {
         return ((char) ('A' + index)).ToString();
      }

      private void HideFloorPanels(int excludingIndex)
      {
         foreach(FloorPanel floorPanel in floorPanels) floorPanel.Visible = false;
         floorPanels[excludingIndex].Visible = true;
      }

      private void UpdateComboBox(ComboBox comboBox)
      {
         string[] data = new string[parkhouse.Floors];
         for(int i = 0; i < data.Length; i++)
            data[i] = $"Floor {GetAlphabeticalCharacterAt(i)}";
         comboBox.DataSource = data;
      }

      private void UpdateComboBox(int newIndex, ComboBox comboBox)
      {
         UpdateComboBox(comboBox);
         comboBox.SelectedIndex = newIndex;
      }

      #endregion
   }
}