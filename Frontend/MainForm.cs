using System;
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
         RefreshFloorEditPage();
      }

      #region Events

      private void CreateFloorButton_Click(object sender, EventArgs e)
      {
         int carCount = (int) floorCreatePageCarsNumericUpDown.Value;
         int bikeCount = (int) floorCreatePageBikesNumericUpDown.Value;
         Floor newFloor = parkhouse.AddFloor(carCount, bikeCount);
         
         HideFloorPanels();
         FloorPanel newFloorPanel = new FloorPanel(newFloor);
         floorPanels.Add(newFloorPanel);
         floorDisplayPanel.Controls.Add(newFloorPanel);

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
               RefreshFloorEditPage();
               break;
         }
      }

      private void FloorSelectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
      {
         int floorIndex = floorSelectionComboBox.SelectedIndex;
         HideFloorPanels();
         floorPanels[floorIndex].Visible = true;
      }

      private void FloorEditPageButton_Click(object sender, EventArgs e)
      {
         int floor = floorEditPageComboBox.SelectedIndex;
         int carCount = (int) floorEditPageCarsNumericUpDown.Value;
         int bikeCount = (int) floorEditPageBikesNumericUpDown.Value;
         parkhouse.EditFloor(floor, carCount, bikeCount);
      }
      
      #endregion

      private void RefreshFloorCreatePage()
      {
         floorCreatePageNameTextBox.Text = $"Floor {GetAlphabeticalCharacterAt(parkhouse.Floors)}";
         floorCreatePageCarsNumericUpDown.Value = 0;
         floorCreatePageBikesNumericUpDown.Value = 0;
      }

      private void RefreshFloorEditPage()
      {
         UpdateComboBox(floorEditPageComboBox);
         floorEditPageComboBox.SelectedIndex = floorSelectionComboBox.SelectedIndex;
         
         floorCreatePageCarsNumericUpDown.Value = 0;
         floorCreatePageBikesNumericUpDown.Value = 0;
      }

      #region Utilty

      public static string GetAlphabeticalCharacterAt(int index)
      {
         return ((char) ('A' + index)).ToString();
      }

      private void HideFloorPanels()
      {
         foreach(FloorPanel floorPanel in floorPanels) floorPanel.Visible = false;
      }

      private void UpdateComboBox(ComboBox comboBox)
      {
         string[] data = new string[parkhouse.Floors];
         for(int i = 0; i < data.Length; i++)
            data[i] = $"Floor {GetAlphabeticalCharacterAt(i)}";
         comboBox.DataSource = data;
      }
      
      #endregion
   }
}