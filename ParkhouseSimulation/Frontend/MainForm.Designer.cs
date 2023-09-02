namespace ParkhouseSimulation.Frontend
{
   partial class MainForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if(disposing && (components != null))
         {
            components.Dispose();
         }

         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.floorSelectionComboBox = new System.Windows.Forms.ComboBox();
         this.floorCreationTabControl = new System.Windows.Forms.TabControl();
         this.createParkhousePage = new System.Windows.Forms.TabPage();
         this.floorCreatePageNameLabel = new System.Windows.Forms.Label();
         this.floorCreatePageNameTextBox = new System.Windows.Forms.TextBox();
         this.floorCreatePageButton = new System.Windows.Forms.Button();
         this.floorCreatePageBikesNumericUpDown = new System.Windows.Forms.NumericUpDown();
         this.floorCreatePageCarsNumericUpDown = new System.Windows.Forms.NumericUpDown();
         this.floorCreatePageBikeLabel = new System.Windows.Forms.Label();
         this.floorCreatePageCarsLabel = new System.Windows.Forms.Label();
         this.floorEditPage = new System.Windows.Forms.TabPage();
         this.floorEditPageButton = new System.Windows.Forms.Button();
         this.floorEditPageBikesNumericUpDown = new System.Windows.Forms.NumericUpDown();
         this.floorEditPageCarsNumericUpDown = new System.Windows.Forms.NumericUpDown();
         this.floorEditPageBikesLabel = new System.Windows.Forms.Label();
         this.floorEditPageCarsLabel = new System.Windows.Forms.Label();
         this.floorEditPageComboBox = new System.Windows.Forms.ComboBox();
         this.floorRemovePage = new System.Windows.Forms.TabPage();
         this.floorRemovePageButton = new System.Windows.Forms.Button();
         this.floorRemovePageComboBox = new System.Windows.Forms.ComboBox();
         this.floorDisplayPanel = new System.Windows.Forms.Panel();
         this.driveInOutTabControl = new System.Windows.Forms.TabControl();
         this.driveInPage = new System.Windows.Forms.TabPage();
         this.driveInButton = new System.Windows.Forms.Button();
         this.driveInBikesNumericUpDown = new System.Windows.Forms.NumericUpDown();
         this.driveInCarsNumericUpDown = new System.Windows.Forms.NumericUpDown();
         this.driveInBikesLabel = new System.Windows.Forms.Label();
         this.driveInCarsLabel = new System.Windows.Forms.Label();
         this.driveOutPage = new System.Windows.Forms.TabPage();
         this.driveOutButton = new System.Windows.Forms.Button();
         this.driveOutBikesNumericUpDown = new System.Windows.Forms.NumericUpDown();
         this.driveOutCarsNumericUpDown = new System.Windows.Forms.NumericUpDown();
         this.driveOutBikesLabel = new System.Windows.Forms.Label();
         this.driveOutCarsLabel = new System.Windows.Forms.Label();
         this.statsGroupBox = new System.Windows.Forms.GroupBox();
         this.statsOccupiedGroupBox = new System.Windows.Forms.GroupBox();
         this.statsOccupiedBikeSlotsTextbox = new System.Windows.Forms.TextBox();
         this.statsOccupiedCarSlotsLabel = new System.Windows.Forms.Label();
         this.statsOccupiedCarSlotsTextbox = new System.Windows.Forms.TextBox();
         this.statsOccupiedBikeSlotsLabel = new System.Windows.Forms.Label();
         this.statsFreeGroupBox = new System.Windows.Forms.GroupBox();
         this.statsFreeBikeSlotsTextbox = new System.Windows.Forms.TextBox();
         this.statsFreeCarSlotsTextbox = new System.Windows.Forms.TextBox();
         this.statsFreeCarSlotsLabel = new System.Windows.Forms.Label();
         this.statsFreeBikeSlotsLabel = new System.Windows.Forms.Label();
         this.statsTotalGroupBox = new System.Windows.Forms.GroupBox();
         this.statsTotalBikeSlotsTextbox = new System.Windows.Forms.TextBox();
         this.statsTotalCarSlotsTextbox = new System.Windows.Forms.TextBox();
         this.statsTotalBikesTextbox = new System.Windows.Forms.TextBox();
         this.statsTotalCarsTextbox = new System.Windows.Forms.TextBox();
         this.statsTotalFloorsTextbox = new System.Windows.Forms.TextBox();
         this.statsTotalFloorsLabel = new System.Windows.Forms.Label();
         this.statsTotalBikeSlotsLabel = new System.Windows.Forms.Label();
         this.statsTotalCarsLabel = new System.Windows.Forms.Label();
         this.statsTotalCarSlotsLabel = new System.Windows.Forms.Label();
         this.statsTotalBikesLabel = new System.Windows.Forms.Label();
         this.floorCreationTabControl.SuspendLayout();
         this.createParkhousePage.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.floorCreatePageBikesNumericUpDown)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.floorCreatePageCarsNumericUpDown)).BeginInit();
         this.floorEditPage.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.floorEditPageBikesNumericUpDown)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.floorEditPageCarsNumericUpDown)).BeginInit();
         this.floorRemovePage.SuspendLayout();
         this.driveInOutTabControl.SuspendLayout();
         this.driveInPage.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.driveInBikesNumericUpDown)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.driveInCarsNumericUpDown)).BeginInit();
         this.driveOutPage.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.driveOutBikesNumericUpDown)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.driveOutCarsNumericUpDown)).BeginInit();
         this.statsGroupBox.SuspendLayout();
         this.statsOccupiedGroupBox.SuspendLayout();
         this.statsFreeGroupBox.SuspendLayout();
         this.statsTotalGroupBox.SuspendLayout();
         this.SuspendLayout();
         // 
         // floorSelectionComboBox
         // 
         this.floorSelectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.floorSelectionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.floorSelectionComboBox.FormattingEnabled = true;
         this.floorSelectionComboBox.Location = new System.Drawing.Point(231, 21);
         this.floorSelectionComboBox.Name = "floorSelectionComboBox";
         this.floorSelectionComboBox.Size = new System.Drawing.Size(172, 24);
         this.floorSelectionComboBox.TabIndex = 2;
         this.floorSelectionComboBox.SelectedIndexChanged += new System.EventHandler(this.FloorSelectionComboBox_SelectedIndexChanged);
         // 
         // floorCreationTabControl
         // 
         this.floorCreationTabControl.Controls.Add(this.createParkhousePage);
         this.floorCreationTabControl.Controls.Add(this.floorEditPage);
         this.floorCreationTabControl.Controls.Add(this.floorRemovePage);
         this.floorCreationTabControl.Location = new System.Drawing.Point(12, 12);
         this.floorCreationTabControl.Name = "floorCreationTabControl";
         this.floorCreationTabControl.SelectedIndex = 0;
         this.floorCreationTabControl.Size = new System.Drawing.Size(197, 143);
         this.floorCreationTabControl.TabIndex = 3;
         this.floorCreationTabControl.SelectedIndexChanged += new System.EventHandler(this.FloorCreationTabControl_SelectedIndexChanged);
         // 
         // createParkhousePage
         // 
         this.createParkhousePage.BackColor = System.Drawing.Color.PaleGreen;
         this.createParkhousePage.Controls.Add(this.floorCreatePageNameLabel);
         this.createParkhousePage.Controls.Add(this.floorCreatePageNameTextBox);
         this.createParkhousePage.Controls.Add(this.floorCreatePageButton);
         this.createParkhousePage.Controls.Add(this.floorCreatePageBikesNumericUpDown);
         this.createParkhousePage.Controls.Add(this.floorCreatePageCarsNumericUpDown);
         this.createParkhousePage.Controls.Add(this.floorCreatePageBikeLabel);
         this.createParkhousePage.Controls.Add(this.floorCreatePageCarsLabel);
         this.createParkhousePage.Location = new System.Drawing.Point(4, 22);
         this.createParkhousePage.Name = "createParkhousePage";
         this.createParkhousePage.Padding = new System.Windows.Forms.Padding(3);
         this.createParkhousePage.Size = new System.Drawing.Size(189, 117);
         this.createParkhousePage.TabIndex = 0;
         this.createParkhousePage.Text = "Create floor";
         // 
         // floorCreatePageNameLabel
         // 
         this.floorCreatePageNameLabel.AutoSize = true;
         this.floorCreatePageNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.floorCreatePageNameLabel.Location = new System.Drawing.Point(10, 13);
         this.floorCreatePageNameLabel.Name = "floorCreatePageNameLabel";
         this.floorCreatePageNameLabel.Size = new System.Drawing.Size(48, 16);
         this.floorCreatePageNameLabel.TabIndex = 7;
         this.floorCreatePageNameLabel.Text = "Name:";
         // 
         // floorCreatePageNameTextBox
         // 
         this.floorCreatePageNameTextBox.Enabled = false;
         this.floorCreatePageNameTextBox.Location = new System.Drawing.Point(61, 10);
         this.floorCreatePageNameTextBox.Name = "floorCreatePageNameTextBox";
         this.floorCreatePageNameTextBox.Size = new System.Drawing.Size(122, 20);
         this.floorCreatePageNameTextBox.TabIndex = 6;
         // 
         // floorCreatePageButton
         // 
         this.floorCreatePageButton.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.floorCreatePageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.floorCreatePageButton.Location = new System.Drawing.Point(3, 91);
         this.floorCreatePageButton.Name = "floorCreatePageButton";
         this.floorCreatePageButton.Size = new System.Drawing.Size(183, 23);
         this.floorCreatePageButton.TabIndex = 4;
         this.floorCreatePageButton.Text = "Create floor";
         this.floorCreatePageButton.UseVisualStyleBackColor = true;
         this.floorCreatePageButton.Click += new System.EventHandler(this.CreateFloorButton_Click);
         // 
         // floorCreatePageBikesNumericUpDown
         // 
         this.floorCreatePageBikesNumericUpDown.Location = new System.Drawing.Point(61, 64);
         this.floorCreatePageBikesNumericUpDown.Name = "floorCreatePageBikesNumericUpDown";
         this.floorCreatePageBikesNumericUpDown.Size = new System.Drawing.Size(122, 20);
         this.floorCreatePageBikesNumericUpDown.TabIndex = 3;
         // 
         // floorCreatePageCarsNumericUpDown
         // 
         this.floorCreatePageCarsNumericUpDown.Location = new System.Drawing.Point(61, 37);
         this.floorCreatePageCarsNumericUpDown.Maximum = new decimal(new int[] {200, 0, 0, 0});
         this.floorCreatePageCarsNumericUpDown.Name = "floorCreatePageCarsNumericUpDown";
         this.floorCreatePageCarsNumericUpDown.Size = new System.Drawing.Size(122, 20);
         this.floorCreatePageCarsNumericUpDown.TabIndex = 2;
         // 
         // floorCreatePageBikeLabel
         // 
         this.floorCreatePageBikeLabel.AutoSize = true;
         this.floorCreatePageBikeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.floorCreatePageBikeLabel.Location = new System.Drawing.Point(10, 67);
         this.floorCreatePageBikeLabel.Name = "floorCreatePageBikeLabel";
         this.floorCreatePageBikeLabel.Size = new System.Drawing.Size(45, 16);
         this.floorCreatePageBikeLabel.TabIndex = 1;
         this.floorCreatePageBikeLabel.Text = "Bikes:";
         // 
         // floorCreatePageCarsLabel
         // 
         this.floorCreatePageCarsLabel.AutoSize = true;
         this.floorCreatePageCarsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.floorCreatePageCarsLabel.Location = new System.Drawing.Point(10, 40);
         this.floorCreatePageCarsLabel.Name = "floorCreatePageCarsLabel";
         this.floorCreatePageCarsLabel.Size = new System.Drawing.Size(39, 16);
         this.floorCreatePageCarsLabel.TabIndex = 0;
         this.floorCreatePageCarsLabel.Text = "Cars:";
         // 
         // floorEditPage
         // 
         this.floorEditPage.BackColor = System.Drawing.Color.LemonChiffon;
         this.floorEditPage.Controls.Add(this.floorEditPageButton);
         this.floorEditPage.Controls.Add(this.floorEditPageBikesNumericUpDown);
         this.floorEditPage.Controls.Add(this.floorEditPageCarsNumericUpDown);
         this.floorEditPage.Controls.Add(this.floorEditPageBikesLabel);
         this.floorEditPage.Controls.Add(this.floorEditPageCarsLabel);
         this.floorEditPage.Controls.Add(this.floorEditPageComboBox);
         this.floorEditPage.Location = new System.Drawing.Point(4, 22);
         this.floorEditPage.Name = "floorEditPage";
         this.floorEditPage.Padding = new System.Windows.Forms.Padding(3);
         this.floorEditPage.Size = new System.Drawing.Size(189, 117);
         this.floorEditPage.TabIndex = 1;
         this.floorEditPage.Text = "Edit floor";
         // 
         // floorEditPageButton
         // 
         this.floorEditPageButton.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.floorEditPageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.floorEditPageButton.Location = new System.Drawing.Point(3, 91);
         this.floorEditPageButton.Name = "floorEditPageButton";
         this.floorEditPageButton.Size = new System.Drawing.Size(183, 23);
         this.floorEditPageButton.TabIndex = 8;
         this.floorEditPageButton.Text = "Edit floor";
         this.floorEditPageButton.UseVisualStyleBackColor = true;
         this.floorEditPageButton.Click += new System.EventHandler(this.FloorEditPageButton_Click);
         // 
         // floorEditPageBikesNumericUpDown
         // 
         this.floorEditPageBikesNumericUpDown.Location = new System.Drawing.Point(61, 64);
         this.floorEditPageBikesNumericUpDown.Name = "floorEditPageBikesNumericUpDown";
         this.floorEditPageBikesNumericUpDown.Size = new System.Drawing.Size(122, 20);
         this.floorEditPageBikesNumericUpDown.TabIndex = 7;
         // 
         // floorEditPageCarsNumericUpDown
         // 
         this.floorEditPageCarsNumericUpDown.Location = new System.Drawing.Point(61, 37);
         this.floorEditPageCarsNumericUpDown.Maximum = new decimal(new int[] {200, 0, 0, 0});
         this.floorEditPageCarsNumericUpDown.Name = "floorEditPageCarsNumericUpDown";
         this.floorEditPageCarsNumericUpDown.Size = new System.Drawing.Size(122, 20);
         this.floorEditPageCarsNumericUpDown.TabIndex = 6;
         // 
         // floorEditPageBikesLabel
         // 
         this.floorEditPageBikesLabel.AutoSize = true;
         this.floorEditPageBikesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.floorEditPageBikesLabel.Location = new System.Drawing.Point(10, 67);
         this.floorEditPageBikesLabel.Name = "floorEditPageBikesLabel";
         this.floorEditPageBikesLabel.Size = new System.Drawing.Size(45, 16);
         this.floorEditPageBikesLabel.TabIndex = 5;
         this.floorEditPageBikesLabel.Text = "Bikes:";
         // 
         // floorEditPageCarsLabel
         // 
         this.floorEditPageCarsLabel.AutoSize = true;
         this.floorEditPageCarsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.floorEditPageCarsLabel.Location = new System.Drawing.Point(10, 40);
         this.floorEditPageCarsLabel.Name = "floorEditPageCarsLabel";
         this.floorEditPageCarsLabel.Size = new System.Drawing.Size(39, 16);
         this.floorEditPageCarsLabel.TabIndex = 4;
         this.floorEditPageCarsLabel.Text = "Cars:";
         // 
         // floorEditPageComboBox
         // 
         this.floorEditPageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.floorEditPageComboBox.FormattingEnabled = true;
         this.floorEditPageComboBox.Location = new System.Drawing.Point(6, 6);
         this.floorEditPageComboBox.MaxDropDownItems = 100;
         this.floorEditPageComboBox.Name = "floorEditPageComboBox";
         this.floorEditPageComboBox.Size = new System.Drawing.Size(118, 21);
         this.floorEditPageComboBox.TabIndex = 0;
         this.floorEditPageComboBox.DropDownClosed += new System.EventHandler(this.FloorEditPageComboBox_DropDownClosed);
         // 
         // floorRemovePage
         // 
         this.floorRemovePage.BackColor = System.Drawing.Color.LightPink;
         this.floorRemovePage.Controls.Add(this.floorRemovePageButton);
         this.floorRemovePage.Controls.Add(this.floorRemovePageComboBox);
         this.floorRemovePage.Location = new System.Drawing.Point(4, 22);
         this.floorRemovePage.Name = "floorRemovePage";
         this.floorRemovePage.Padding = new System.Windows.Forms.Padding(3);
         this.floorRemovePage.Size = new System.Drawing.Size(189, 117);
         this.floorRemovePage.TabIndex = 2;
         this.floorRemovePage.Text = "Remove floor";
         // 
         // floorRemovePageButton
         // 
         this.floorRemovePageButton.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.floorRemovePageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.floorRemovePageButton.Location = new System.Drawing.Point(3, 91);
         this.floorRemovePageButton.Name = "floorRemovePageButton";
         this.floorRemovePageButton.Size = new System.Drawing.Size(183, 23);
         this.floorRemovePageButton.TabIndex = 14;
         this.floorRemovePageButton.Text = "Remove floor";
         this.floorRemovePageButton.UseVisualStyleBackColor = true;
         this.floorRemovePageButton.Click += new System.EventHandler(this.FloorRemovePageButton_Click);
         // 
         // floorRemovePageComboBox
         // 
         this.floorRemovePageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.floorRemovePageComboBox.FormattingEnabled = true;
         this.floorRemovePageComboBox.Location = new System.Drawing.Point(6, 6);
         this.floorRemovePageComboBox.MaxDropDownItems = 100;
         this.floorRemovePageComboBox.Name = "floorRemovePageComboBox";
         this.floorRemovePageComboBox.Size = new System.Drawing.Size(118, 21);
         this.floorRemovePageComboBox.TabIndex = 9;
         this.floorRemovePageComboBox.DropDownClosed += new System.EventHandler(this.FloorRemovePageComboBox_DropDownClosed);
         // 
         // floorDisplayPanel
         // 
         this.floorDisplayPanel.BackColor = System.Drawing.Color.DimGray;
         this.floorDisplayPanel.Location = new System.Drawing.Point(231, 51);
         this.floorDisplayPanel.Name = "floorDisplayPanel";
         this.floorDisplayPanel.Size = new System.Drawing.Size(547, 567);
         this.floorDisplayPanel.TabIndex = 4;
         // 
         // driveInOutTabControl
         // 
         this.driveInOutTabControl.Controls.Add(this.driveInPage);
         this.driveInOutTabControl.Controls.Add(this.driveOutPage);
         this.driveInOutTabControl.Location = new System.Drawing.Point(12, 175);
         this.driveInOutTabControl.Name = "driveInOutTabControl";
         this.driveInOutTabControl.SelectedIndex = 0;
         this.driveInOutTabControl.Size = new System.Drawing.Size(197, 116);
         this.driveInOutTabControl.TabIndex = 5;
         this.driveInOutTabControl.SelectedIndexChanged += new System.EventHandler(this.DriveInOutTabControl_SelectedIndexChanged);
         // 
         // driveInPage
         // 
         this.driveInPage.BackColor = System.Drawing.Color.PaleGreen;
         this.driveInPage.Controls.Add(this.driveInButton);
         this.driveInPage.Controls.Add(this.driveInBikesNumericUpDown);
         this.driveInPage.Controls.Add(this.driveInCarsNumericUpDown);
         this.driveInPage.Controls.Add(this.driveInBikesLabel);
         this.driveInPage.Controls.Add(this.driveInCarsLabel);
         this.driveInPage.Location = new System.Drawing.Point(4, 22);
         this.driveInPage.Name = "driveInPage";
         this.driveInPage.Padding = new System.Windows.Forms.Padding(3);
         this.driveInPage.Size = new System.Drawing.Size(189, 90);
         this.driveInPage.TabIndex = 0;
         this.driveInPage.Text = "Drive in";
         // 
         // driveInButton
         // 
         this.driveInButton.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.driveInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.driveInButton.Location = new System.Drawing.Point(3, 64);
         this.driveInButton.Name = "driveInButton";
         this.driveInButton.Size = new System.Drawing.Size(183, 23);
         this.driveInButton.TabIndex = 9;
         this.driveInButton.Text = "Enter parkhouse";
         this.driveInButton.UseVisualStyleBackColor = true;
         this.driveInButton.Click += new System.EventHandler(this.DriveInButton_Click);
         // 
         // driveInBikesNumericUpDown
         // 
         this.driveInBikesNumericUpDown.Location = new System.Drawing.Point(59, 36);
         this.driveInBikesNumericUpDown.Name = "driveInBikesNumericUpDown";
         this.driveInBikesNumericUpDown.Size = new System.Drawing.Size(122, 20);
         this.driveInBikesNumericUpDown.TabIndex = 8;
         this.driveInBikesNumericUpDown.Leave += new System.EventHandler(this.DriveInBikesNumericUpDown_Leave);
         // 
         // driveInCarsNumericUpDown
         // 
         this.driveInCarsNumericUpDown.Location = new System.Drawing.Point(59, 9);
         this.driveInCarsNumericUpDown.Maximum = new decimal(new int[] {200, 0, 0, 0});
         this.driveInCarsNumericUpDown.Name = "driveInCarsNumericUpDown";
         this.driveInCarsNumericUpDown.Size = new System.Drawing.Size(122, 20);
         this.driveInCarsNumericUpDown.TabIndex = 7;
         this.driveInCarsNumericUpDown.Leave += new System.EventHandler(this.DriveInCarsNumericUpDown_Leave);
         // 
         // driveInBikesLabel
         // 
         this.driveInBikesLabel.AutoSize = true;
         this.driveInBikesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.driveInBikesLabel.Location = new System.Drawing.Point(8, 39);
         this.driveInBikesLabel.Name = "driveInBikesLabel";
         this.driveInBikesLabel.Size = new System.Drawing.Size(45, 16);
         this.driveInBikesLabel.TabIndex = 6;
         this.driveInBikesLabel.Text = "Bikes:";
         // 
         // driveInCarsLabel
         // 
         this.driveInCarsLabel.AutoSize = true;
         this.driveInCarsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.driveInCarsLabel.Location = new System.Drawing.Point(8, 12);
         this.driveInCarsLabel.Name = "driveInCarsLabel";
         this.driveInCarsLabel.Size = new System.Drawing.Size(39, 16);
         this.driveInCarsLabel.TabIndex = 5;
         this.driveInCarsLabel.Text = "Cars:";
         // 
         // driveOutPage
         // 
         this.driveOutPage.BackColor = System.Drawing.Color.LightPink;
         this.driveOutPage.Controls.Add(this.driveOutButton);
         this.driveOutPage.Controls.Add(this.driveOutBikesNumericUpDown);
         this.driveOutPage.Controls.Add(this.driveOutCarsNumericUpDown);
         this.driveOutPage.Controls.Add(this.driveOutBikesLabel);
         this.driveOutPage.Controls.Add(this.driveOutCarsLabel);
         this.driveOutPage.Location = new System.Drawing.Point(4, 22);
         this.driveOutPage.Name = "driveOutPage";
         this.driveOutPage.Padding = new System.Windows.Forms.Padding(3);
         this.driveOutPage.Size = new System.Drawing.Size(189, 90);
         this.driveOutPage.TabIndex = 1;
         this.driveOutPage.Text = "Drive out";
         // 
         // driveOutButton
         // 
         this.driveOutButton.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.driveOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.driveOutButton.Location = new System.Drawing.Point(3, 64);
         this.driveOutButton.Name = "driveOutButton";
         this.driveOutButton.Size = new System.Drawing.Size(183, 23);
         this.driveOutButton.TabIndex = 14;
         this.driveOutButton.Text = "Exit parkhouse";
         this.driveOutButton.UseVisualStyleBackColor = true;
         this.driveOutButton.Click += new System.EventHandler(this.DriveOutButton_Click);
         // 
         // driveOutBikesNumericUpDown
         // 
         this.driveOutBikesNumericUpDown.Location = new System.Drawing.Point(59, 36);
         this.driveOutBikesNumericUpDown.Name = "driveOutBikesNumericUpDown";
         this.driveOutBikesNumericUpDown.Size = new System.Drawing.Size(122, 20);
         this.driveOutBikesNumericUpDown.TabIndex = 13;
         this.driveOutBikesNumericUpDown.Leave += new System.EventHandler(this.DriveOutBikesNumericUpDown_Leave);
         // 
         // driveOutCarsNumericUpDown
         // 
         this.driveOutCarsNumericUpDown.Location = new System.Drawing.Point(59, 9);
         this.driveOutCarsNumericUpDown.Maximum = new decimal(new int[] {200, 0, 0, 0});
         this.driveOutCarsNumericUpDown.Name = "driveOutCarsNumericUpDown";
         this.driveOutCarsNumericUpDown.Size = new System.Drawing.Size(122, 20);
         this.driveOutCarsNumericUpDown.TabIndex = 12;
         this.driveOutCarsNumericUpDown.Leave += new System.EventHandler(this.DriveOutCarsNumericUpDown_Leave);
         // 
         // driveOutBikesLabel
         // 
         this.driveOutBikesLabel.AutoSize = true;
         this.driveOutBikesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.driveOutBikesLabel.Location = new System.Drawing.Point(8, 39);
         this.driveOutBikesLabel.Name = "driveOutBikesLabel";
         this.driveOutBikesLabel.Size = new System.Drawing.Size(45, 16);
         this.driveOutBikesLabel.TabIndex = 11;
         this.driveOutBikesLabel.Text = "Bikes:";
         // 
         // driveOutCarsLabel
         // 
         this.driveOutCarsLabel.AutoSize = true;
         this.driveOutCarsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.driveOutCarsLabel.Location = new System.Drawing.Point(8, 12);
         this.driveOutCarsLabel.Name = "driveOutCarsLabel";
         this.driveOutCarsLabel.Size = new System.Drawing.Size(39, 16);
         this.driveOutCarsLabel.TabIndex = 10;
         this.driveOutCarsLabel.Text = "Cars:";
         // 
         // statsGroupBox
         // 
         this.statsGroupBox.Controls.Add(this.statsOccupiedGroupBox);
         this.statsGroupBox.Controls.Add(this.statsFreeGroupBox);
         this.statsGroupBox.Controls.Add(this.statsTotalGroupBox);
         this.statsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.statsGroupBox.Location = new System.Drawing.Point(12, 308);
         this.statsGroupBox.Name = "statsGroupBox";
         this.statsGroupBox.Size = new System.Drawing.Size(197, 310);
         this.statsGroupBox.TabIndex = 6;
         this.statsGroupBox.TabStop = false;
         this.statsGroupBox.Text = "Parkhouse stats";
         // 
         // statsOccupiedGroupBox
         // 
         this.statsOccupiedGroupBox.Controls.Add(this.statsOccupiedBikeSlotsTextbox);
         this.statsOccupiedGroupBox.Controls.Add(this.statsOccupiedCarSlotsLabel);
         this.statsOccupiedGroupBox.Controls.Add(this.statsOccupiedCarSlotsTextbox);
         this.statsOccupiedGroupBox.Controls.Add(this.statsOccupiedBikeSlotsLabel);
         this.statsOccupiedGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.statsOccupiedGroupBox.Location = new System.Drawing.Point(6, 235);
         this.statsOccupiedGroupBox.Name = "statsOccupiedGroupBox";
         this.statsOccupiedGroupBox.Size = new System.Drawing.Size(185, 68);
         this.statsOccupiedGroupBox.TabIndex = 11;
         this.statsOccupiedGroupBox.TabStop = false;
         this.statsOccupiedGroupBox.Text = "Occupied";
         // 
         // statsOccupiedBikeSlotsTextbox
         // 
         this.statsOccupiedBikeSlotsTextbox.BackColor = System.Drawing.SystemColors.ScrollBar;
         this.statsOccupiedBikeSlotsTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.statsOccupiedBikeSlotsTextbox.Location = new System.Drawing.Point(92, 41);
         this.statsOccupiedBikeSlotsTextbox.Name = "statsOccupiedBikeSlotsTextbox";
         this.statsOccupiedBikeSlotsTextbox.ReadOnly = true;
         this.statsOccupiedBikeSlotsTextbox.Size = new System.Drawing.Size(87, 22);
         this.statsOccupiedBikeSlotsTextbox.TabIndex = 13;
         // 
         // statsOccupiedCarSlotsLabel
         // 
         this.statsOccupiedCarSlotsLabel.AutoSize = true;
         this.statsOccupiedCarSlotsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.statsOccupiedCarSlotsLabel.Location = new System.Drawing.Point(5, 22);
         this.statsOccupiedCarSlotsLabel.Name = "statsOccupiedCarSlotsLabel";
         this.statsOccupiedCarSlotsLabel.Size = new System.Drawing.Size(80, 18);
         this.statsOccupiedCarSlotsLabel.TabIndex = 3;
         this.statsOccupiedCarSlotsLabel.Text = "Cars slots:";
         // 
         // statsOccupiedCarSlotsTextbox
         // 
         this.statsOccupiedCarSlotsTextbox.BackColor = System.Drawing.SystemColors.ScrollBar;
         this.statsOccupiedCarSlotsTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.statsOccupiedCarSlotsTextbox.Location = new System.Drawing.Point(92, 21);
         this.statsOccupiedCarSlotsTextbox.Name = "statsOccupiedCarSlotsTextbox";
         this.statsOccupiedCarSlotsTextbox.ReadOnly = true;
         this.statsOccupiedCarSlotsTextbox.Size = new System.Drawing.Size(87, 22);
         this.statsOccupiedCarSlotsTextbox.TabIndex = 14;
         // 
         // statsOccupiedBikeSlotsLabel
         // 
         this.statsOccupiedBikeSlotsLabel.AutoSize = true;
         this.statsOccupiedBikeSlotsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.statsOccupiedBikeSlotsLabel.Location = new System.Drawing.Point(5, 42);
         this.statsOccupiedBikeSlotsLabel.Name = "statsOccupiedBikeSlotsLabel";
         this.statsOccupiedBikeSlotsLabel.Size = new System.Drawing.Size(77, 18);
         this.statsOccupiedBikeSlotsLabel.TabIndex = 4;
         this.statsOccupiedBikeSlotsLabel.Text = "Bike slots:";
         // 
         // statsFreeGroupBox
         // 
         this.statsFreeGroupBox.Controls.Add(this.statsFreeBikeSlotsTextbox);
         this.statsFreeGroupBox.Controls.Add(this.statsFreeCarSlotsTextbox);
         this.statsFreeGroupBox.Controls.Add(this.statsFreeCarSlotsLabel);
         this.statsFreeGroupBox.Controls.Add(this.statsFreeBikeSlotsLabel);
         this.statsFreeGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.statsFreeGroupBox.Location = new System.Drawing.Point(6, 161);
         this.statsFreeGroupBox.Name = "statsFreeGroupBox";
         this.statsFreeGroupBox.Size = new System.Drawing.Size(185, 68);
         this.statsFreeGroupBox.TabIndex = 10;
         this.statsFreeGroupBox.TabStop = false;
         this.statsFreeGroupBox.Text = "Free";
         // 
         // statsFreeBikeSlotsTextbox
         // 
         this.statsFreeBikeSlotsTextbox.BackColor = System.Drawing.SystemColors.ScrollBar;
         this.statsFreeBikeSlotsTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.statsFreeBikeSlotsTextbox.Location = new System.Drawing.Point(92, 41);
         this.statsFreeBikeSlotsTextbox.Name = "statsFreeBikeSlotsTextbox";
         this.statsFreeBikeSlotsTextbox.ReadOnly = true;
         this.statsFreeBikeSlotsTextbox.Size = new System.Drawing.Size(87, 22);
         this.statsFreeBikeSlotsTextbox.TabIndex = 13;
         // 
         // statsFreeCarSlotsTextbox
         // 
         this.statsFreeCarSlotsTextbox.BackColor = System.Drawing.SystemColors.ScrollBar;
         this.statsFreeCarSlotsTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.statsFreeCarSlotsTextbox.Location = new System.Drawing.Point(92, 21);
         this.statsFreeCarSlotsTextbox.Name = "statsFreeCarSlotsTextbox";
         this.statsFreeCarSlotsTextbox.ReadOnly = true;
         this.statsFreeCarSlotsTextbox.Size = new System.Drawing.Size(87, 22);
         this.statsFreeCarSlotsTextbox.TabIndex = 14;
         // 
         // statsFreeCarSlotsLabel
         // 
         this.statsFreeCarSlotsLabel.AutoSize = true;
         this.statsFreeCarSlotsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.statsFreeCarSlotsLabel.Location = new System.Drawing.Point(5, 22);
         this.statsFreeCarSlotsLabel.Name = "statsFreeCarSlotsLabel";
         this.statsFreeCarSlotsLabel.Size = new System.Drawing.Size(80, 18);
         this.statsFreeCarSlotsLabel.TabIndex = 3;
         this.statsFreeCarSlotsLabel.Text = "Cars slots:";
         // 
         // statsFreeBikeSlotsLabel
         // 
         this.statsFreeBikeSlotsLabel.AutoSize = true;
         this.statsFreeBikeSlotsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.statsFreeBikeSlotsLabel.Location = new System.Drawing.Point(5, 42);
         this.statsFreeBikeSlotsLabel.Name = "statsFreeBikeSlotsLabel";
         this.statsFreeBikeSlotsLabel.Size = new System.Drawing.Size(77, 18);
         this.statsFreeBikeSlotsLabel.TabIndex = 4;
         this.statsFreeBikeSlotsLabel.Text = "Bike slots:";
         // 
         // statsTotalGroupBox
         // 
         this.statsTotalGroupBox.Controls.Add(this.statsTotalBikeSlotsTextbox);
         this.statsTotalGroupBox.Controls.Add(this.statsTotalCarSlotsTextbox);
         this.statsTotalGroupBox.Controls.Add(this.statsTotalBikesTextbox);
         this.statsTotalGroupBox.Controls.Add(this.statsTotalCarsTextbox);
         this.statsTotalGroupBox.Controls.Add(this.statsTotalFloorsTextbox);
         this.statsTotalGroupBox.Controls.Add(this.statsTotalFloorsLabel);
         this.statsTotalGroupBox.Controls.Add(this.statsTotalBikeSlotsLabel);
         this.statsTotalGroupBox.Controls.Add(this.statsTotalCarsLabel);
         this.statsTotalGroupBox.Controls.Add(this.statsTotalCarSlotsLabel);
         this.statsTotalGroupBox.Controls.Add(this.statsTotalBikesLabel);
         this.statsTotalGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.statsTotalGroupBox.Location = new System.Drawing.Point(6, 28);
         this.statsTotalGroupBox.Name = "statsTotalGroupBox";
         this.statsTotalGroupBox.Size = new System.Drawing.Size(185, 127);
         this.statsTotalGroupBox.TabIndex = 9;
         this.statsTotalGroupBox.TabStop = false;
         this.statsTotalGroupBox.Text = "Total";
         // 
         // statsTotalBikeSlotsTextbox
         // 
         this.statsTotalBikeSlotsTextbox.BackColor = System.Drawing.SystemColors.ScrollBar;
         this.statsTotalBikeSlotsTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.statsTotalBikeSlotsTextbox.Location = new System.Drawing.Point(92, 101);
         this.statsTotalBikeSlotsTextbox.Name = "statsTotalBikeSlotsTextbox";
         this.statsTotalBikeSlotsTextbox.ReadOnly = true;
         this.statsTotalBikeSlotsTextbox.Size = new System.Drawing.Size(87, 22);
         this.statsTotalBikeSlotsTextbox.TabIndex = 11;
         // 
         // statsTotalCarSlotsTextbox
         // 
         this.statsTotalCarSlotsTextbox.BackColor = System.Drawing.SystemColors.ScrollBar;
         this.statsTotalCarSlotsTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.statsTotalCarSlotsTextbox.Location = new System.Drawing.Point(92, 81);
         this.statsTotalCarSlotsTextbox.Name = "statsTotalCarSlotsTextbox";
         this.statsTotalCarSlotsTextbox.ReadOnly = true;
         this.statsTotalCarSlotsTextbox.Size = new System.Drawing.Size(87, 22);
         this.statsTotalCarSlotsTextbox.TabIndex = 12;
         // 
         // statsTotalBikesTextbox
         // 
         this.statsTotalBikesTextbox.BackColor = System.Drawing.SystemColors.ScrollBar;
         this.statsTotalBikesTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.statsTotalBikesTextbox.Location = new System.Drawing.Point(92, 61);
         this.statsTotalBikesTextbox.Name = "statsTotalBikesTextbox";
         this.statsTotalBikesTextbox.ReadOnly = true;
         this.statsTotalBikesTextbox.Size = new System.Drawing.Size(87, 22);
         this.statsTotalBikesTextbox.TabIndex = 11;
         // 
         // statsTotalCarsTextbox
         // 
         this.statsTotalCarsTextbox.BackColor = System.Drawing.SystemColors.ScrollBar;
         this.statsTotalCarsTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.statsTotalCarsTextbox.Location = new System.Drawing.Point(92, 41);
         this.statsTotalCarsTextbox.Name = "statsTotalCarsTextbox";
         this.statsTotalCarsTextbox.ReadOnly = true;
         this.statsTotalCarsTextbox.Size = new System.Drawing.Size(87, 22);
         this.statsTotalCarsTextbox.TabIndex = 10;
         // 
         // statsTotalFloorsTextbox
         // 
         this.statsTotalFloorsTextbox.BackColor = System.Drawing.SystemColors.ScrollBar;
         this.statsTotalFloorsTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.statsTotalFloorsTextbox.Location = new System.Drawing.Point(92, 21);
         this.statsTotalFloorsTextbox.Name = "statsTotalFloorsTextbox";
         this.statsTotalFloorsTextbox.ReadOnly = true;
         this.statsTotalFloorsTextbox.Size = new System.Drawing.Size(87, 22);
         this.statsTotalFloorsTextbox.TabIndex = 9;
         // 
         // statsTotalFloorsLabel
         // 
         this.statsTotalFloorsLabel.AutoSize = true;
         this.statsTotalFloorsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.statsTotalFloorsLabel.Location = new System.Drawing.Point(5, 22);
         this.statsTotalFloorsLabel.Name = "statsTotalFloorsLabel";
         this.statsTotalFloorsLabel.Size = new System.Drawing.Size(55, 18);
         this.statsTotalFloorsLabel.TabIndex = 0;
         this.statsTotalFloorsLabel.Text = "Floors:";
         // 
         // statsTotalBikeSlotsLabel
         // 
         this.statsTotalBikeSlotsLabel.AutoSize = true;
         this.statsTotalBikeSlotsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.statsTotalBikeSlotsLabel.Location = new System.Drawing.Point(7, 102);
         this.statsTotalBikeSlotsLabel.Name = "statsTotalBikeSlotsLabel";
         this.statsTotalBikeSlotsLabel.Size = new System.Drawing.Size(77, 18);
         this.statsTotalBikeSlotsLabel.TabIndex = 8;
         this.statsTotalBikeSlotsLabel.Text = "Bike slots:";
         // 
         // statsTotalCarsLabel
         // 
         this.statsTotalCarsLabel.AutoSize = true;
         this.statsTotalCarsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.statsTotalCarsLabel.Location = new System.Drawing.Point(5, 42);
         this.statsTotalCarsLabel.Name = "statsTotalCarsLabel";
         this.statsTotalCarsLabel.Size = new System.Drawing.Size(44, 18);
         this.statsTotalCarsLabel.TabIndex = 1;
         this.statsTotalCarsLabel.Text = "Cars:";
         // 
         // statsTotalCarSlotsLabel
         // 
         this.statsTotalCarSlotsLabel.AutoSize = true;
         this.statsTotalCarSlotsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.statsTotalCarSlotsLabel.Location = new System.Drawing.Point(7, 82);
         this.statsTotalCarSlotsLabel.Name = "statsTotalCarSlotsLabel";
         this.statsTotalCarSlotsLabel.Size = new System.Drawing.Size(72, 18);
         this.statsTotalCarSlotsLabel.TabIndex = 7;
         this.statsTotalCarSlotsLabel.Text = "Car slots:";
         // 
         // statsTotalBikesLabel
         // 
         this.statsTotalBikesLabel.AutoSize = true;
         this.statsTotalBikesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.statsTotalBikesLabel.Location = new System.Drawing.Point(7, 62);
         this.statsTotalBikesLabel.Name = "statsTotalBikesLabel";
         this.statsTotalBikesLabel.Size = new System.Drawing.Size(49, 18);
         this.statsTotalBikesLabel.TabIndex = 2;
         this.statsTotalBikesLabel.Text = "Bikes:";
         // 
         // MainForm
         // 
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
         this.BackColor = System.Drawing.Color.Gray;
         this.ClientSize = new System.Drawing.Size(1034, 629);
         this.Controls.Add(this.statsGroupBox);
         this.Controls.Add(this.driveInOutTabControl);
         this.Controls.Add(this.floorDisplayPanel);
         this.Controls.Add(this.floorCreationTabControl);
         this.Controls.Add(this.floorSelectionComboBox);
         this.Location = new System.Drawing.Point(15, 15);
         this.MaximumSize = new System.Drawing.Size(1050, 668);
         this.MinimumSize = new System.Drawing.Size(1050, 668);
         this.Name = "MainForm";
         this.RightToLeftLayout = true;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Parkhouse Simulation";
         this.floorCreationTabControl.ResumeLayout(false);
         this.createParkhousePage.ResumeLayout(false);
         this.createParkhousePage.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.floorCreatePageBikesNumericUpDown)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.floorCreatePageCarsNumericUpDown)).EndInit();
         this.floorEditPage.ResumeLayout(false);
         this.floorEditPage.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.floorEditPageBikesNumericUpDown)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.floorEditPageCarsNumericUpDown)).EndInit();
         this.floorRemovePage.ResumeLayout(false);
         this.driveInOutTabControl.ResumeLayout(false);
         this.driveInPage.ResumeLayout(false);
         this.driveInPage.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.driveInBikesNumericUpDown)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.driveInCarsNumericUpDown)).EndInit();
         this.driveOutPage.ResumeLayout(false);
         this.driveOutPage.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.driveOutBikesNumericUpDown)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.driveOutCarsNumericUpDown)).EndInit();
         this.statsGroupBox.ResumeLayout(false);
         this.statsOccupiedGroupBox.ResumeLayout(false);
         this.statsOccupiedGroupBox.PerformLayout();
         this.statsFreeGroupBox.ResumeLayout(false);
         this.statsFreeGroupBox.PerformLayout();
         this.statsTotalGroupBox.ResumeLayout(false);
         this.statsTotalGroupBox.PerformLayout();
         this.ResumeLayout(false);
      }

      private System.Windows.Forms.TextBox statsTotalCarsTextbox;
      private System.Windows.Forms.TextBox statsTotalBikesTextbox;
      private System.Windows.Forms.TextBox statsTotalCarSlotsTextbox;
      private System.Windows.Forms.TextBox statsTotalBikeSlotsTextbox;
      private System.Windows.Forms.TextBox statsFreeBikeSlotsTextbox;
      private System.Windows.Forms.TextBox statsFreeCarSlotsTextbox;
      private System.Windows.Forms.TextBox statsOccupiedBikeSlotsTextbox;
      private System.Windows.Forms.TextBox statsOccupiedCarSlotsTextbox;

      private System.Windows.Forms.GroupBox statsTotalGroupBox;
      private System.Windows.Forms.GroupBox statsFreeGroupBox;
      private System.Windows.Forms.TextBox statsTotalFloorsTextbox;
      private System.Windows.Forms.Label statsOccupiedCarSlotsLabel;
      private System.Windows.Forms.Label statsOccupiedBikeSlotsLabel;

      private System.Windows.Forms.Label statsTotalCarSlotsLabel;
      private System.Windows.Forms.Label statsTotalBikeSlotsLabel;
      private System.Windows.Forms.GroupBox statsOccupiedGroupBox;

      private System.Windows.Forms.Label statsTotalFloorsLabel;
      private System.Windows.Forms.Label statsTotalCarsLabel;
      private System.Windows.Forms.Label statsTotalBikesLabel;
      private System.Windows.Forms.Label statsFreeCarSlotsLabel;
      private System.Windows.Forms.Label statsFreeBikeSlotsLabel;
      
      private System.Windows.Forms.GroupBox statsGroupBox;

      private System.Windows.Forms.Button driveInButton;
      private System.Windows.Forms.NumericUpDown driveInBikesNumericUpDown;
      private System.Windows.Forms.NumericUpDown driveInCarsNumericUpDown;
      private System.Windows.Forms.Label driveInBikesLabel;
      private System.Windows.Forms.Label driveInCarsLabel;
      private System.Windows.Forms.Button driveOutButton;
      private System.Windows.Forms.NumericUpDown driveOutBikesNumericUpDown;
      private System.Windows.Forms.NumericUpDown driveOutCarsNumericUpDown;
      private System.Windows.Forms.Label driveOutBikesLabel;
      private System.Windows.Forms.Label driveOutCarsLabel;

      private System.Windows.Forms.TabControl driveInOutTabControl;
      private System.Windows.Forms.TabPage driveInPage;
      private System.Windows.Forms.TabPage driveOutPage;

      private System.Windows.Forms.Panel floorDisplayPanel;

      private System.Windows.Forms.Label floorCreatePageNameLabel;

      private System.Windows.Forms.Button floorRemovePageButton;
      private System.Windows.Forms.ComboBox floorRemovePageComboBox;

      private System.Windows.Forms.TabPage floorRemovePage;

      private System.Windows.Forms.TextBox floorCreatePageNameTextBox;

      private System.Windows.Forms.Button floorEditPageButton;

      private System.Windows.Forms.NumericUpDown floorEditPageBikesNumericUpDown;
      private System.Windows.Forms.NumericUpDown floorEditPageCarsNumericUpDown;
      private System.Windows.Forms.Label floorEditPageBikesLabel;
      private System.Windows.Forms.Label floorEditPageCarsLabel;

      private System.Windows.Forms.ComboBox floorEditPageComboBox;

      private System.Windows.Forms.Label floorCreatePageCarsLabel;
      private System.Windows.Forms.NumericUpDown floorCreatePageCarsNumericUpDown;
      private System.Windows.Forms.NumericUpDown floorCreatePageBikesNumericUpDown;
      private System.Windows.Forms.Button floorCreatePageButton;

      private System.Windows.Forms.Label floorCreatePageBikeLabel;

      private System.Windows.Forms.TabControl floorCreationTabControl;
      private System.Windows.Forms.TabPage createParkhousePage;
      private System.Windows.Forms.TabPage floorEditPage;

      private System.Windows.Forms.ComboBox floorSelectionComboBox;

      #endregion
   }
}