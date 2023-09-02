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
         this.SuspendLayout();
         // 
         // floorSelectionComboBox
         // 
         this.floorSelectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.floorSelectionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.floorSelectionComboBox.FormattingEnabled = true;
         this.floorSelectionComboBox.Location = new System.Drawing.Point(215, 19);
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
         this.floorDisplayPanel.Location = new System.Drawing.Point(215, 51);
         this.floorDisplayPanel.Name = "floorDisplayPanel";
         this.floorDisplayPanel.Size = new System.Drawing.Size(547, 498);
         this.floorDisplayPanel.TabIndex = 4;
         // 
         // driveInOutTabControl
         // 
         this.driveInOutTabControl.Controls.Add(this.driveInPage);
         this.driveInOutTabControl.Controls.Add(this.driveOutPage);
         this.driveInOutTabControl.Location = new System.Drawing.Point(12, 161);
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
         // MainForm
         // 
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
         this.BackColor = System.Drawing.Color.Gray;
         this.ClientSize = new System.Drawing.Size(774, 561);
         this.Controls.Add(this.driveInOutTabControl);
         this.Controls.Add(this.floorDisplayPanel);
         this.Controls.Add(this.floorCreationTabControl);
         this.Controls.Add(this.floorSelectionComboBox);
         this.Location = new System.Drawing.Point(15, 15);
         this.MaximumSize = new System.Drawing.Size(790, 600);
         this.MinimumSize = new System.Drawing.Size(790, 600);
         this.Name = "MainForm";
         this.RightToLeftLayout = true;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
         this.ResumeLayout(false);
      }

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