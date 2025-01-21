namespace MyBike
{
    partial class FormBike
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBike));
            buttonAdd = new Button();
            labelSerialNumber = new Label();
            textBoxSerialNumber = new TextBox();
            listBoxBike = new ListBox();
            groupBox1 = new GroupBox();
            comboBoxColor = new ComboBox();
            labelColor = new Label();
            textBoxSpeed = new TextBox();
            textBoxBrand = new TextBox();
            textBoxModel = new TextBox();
            comboBoxType = new ComboBox();
            labelBikeType = new Label();
            labelSpeed = new Label();
            labelModel = new Label();
            labelBrand = new Label();
            groupBoxMadeDate = new GroupBox();
            textBoxMonth = new TextBox();
            textBoxYear = new TextBox();
            labelYear = new Label();
            labelMonth = new Label();
            labelDay = new Label();
            textBoxDay = new TextBox();
            groupBoxRoadBike = new GroupBox();
            labelSeatHeight = new Label();
            textBoxSeatHeight = new TextBox();
            groupBoxMountainBike = new GroupBox();
            comboBoxSuspension = new ComboBox();
            labelSuspension = new Label();
            labelHeighFromGround = new Label();
            textBoxHeightFromGround = new TextBox();
            buttonPrintBikes = new Button();
            buttonReset = new Button();
            buttonMountainBikes = new Button();
            buttonPrintRoadBikes = new Button();
            groupBoxSerializeDeserialize = new GroupBox();
            buttonReadFromXmlFile = new Button();
            buttonWriteToXmlFile = new Button();
            groupBoxModification = new GroupBox();
            buttonRemove = new Button();
            buttonUpdate = new Button();
            buttonSearch = new Button();
            labelRemove = new Label();
            labelUpdate = new Label();
            labelSearch = new Label();
            buttonExit = new Button();
            groupBoxElectricBike = new GroupBox();
            label1 = new Label();
            textBoxBattreyLife = new TextBox();
            buttonElectricBike = new Button();
            groupBoxSpeedUp = new GroupBox();
            buttonSpeedUp = new Button();
            numericUpDownSpeedIncrement = new NumericUpDown();
            label2MaxSpeed = new Label();
            pictureBox1 = new PictureBox();
            groupBoxPrintBikes = new GroupBox();
            buttonPrintFoldingBike = new Button();
            groupBoxFoldingBike = new GroupBox();
            comboBoxFrameMaterial = new ComboBox();
            labelFrameMaterial = new Label();
            labelWeight = new Label();
            textBoxWeight = new TextBox();
            groupBox1.SuspendLayout();
            groupBoxMadeDate.SuspendLayout();
            groupBoxRoadBike.SuspendLayout();
            groupBoxMountainBike.SuspendLayout();
            groupBoxSerializeDeserialize.SuspendLayout();
            groupBoxModification.SuspendLayout();
            groupBoxElectricBike.SuspendLayout();
            groupBoxSpeedUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSpeedIncrement).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxPrintBikes.SuspendLayout();
            groupBoxFoldingBike.SuspendLayout();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAdd.Location = new Point(31, 510);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(104, 41);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // labelSerialNumber
            // 
            labelSerialNumber.BorderStyle = BorderStyle.FixedSingle;
            labelSerialNumber.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSerialNumber.Location = new Point(19, 75);
            labelSerialNumber.Name = "labelSerialNumber";
            labelSerialNumber.Size = new Size(150, 23);
            labelSerialNumber.TabIndex = 1;
            labelSerialNumber.Text = "Serial Number";
            labelSerialNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxSerialNumber
            // 
            textBoxSerialNumber.Location = new Point(202, 75);
            textBoxSerialNumber.Name = "textBoxSerialNumber";
            textBoxSerialNumber.Size = new Size(121, 23);
            textBoxSerialNumber.TabIndex = 2;
            // 
            // listBoxBike
            // 
            listBoxBike.FormattingEnabled = true;
            listBoxBike.ItemHeight = 15;
            listBoxBike.Location = new Point(28, 557);
            listBoxBike.Name = "listBoxBike";
            listBoxBike.Size = new Size(468, 139);
            listBoxBike.TabIndex = 3;
            listBoxBike.SelectedIndexChanged += listBoxBike_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox1.Controls.Add(comboBoxColor);
            groupBox1.Controls.Add(labelColor);
            groupBox1.Controls.Add(textBoxSpeed);
            groupBox1.Controls.Add(textBoxBrand);
            groupBox1.Controls.Add(textBoxModel);
            groupBox1.Controls.Add(comboBoxType);
            groupBox1.Controls.Add(labelBikeType);
            groupBox1.Controls.Add(labelSpeed);
            groupBox1.Controls.Add(labelModel);
            groupBox1.Controls.Add(labelBrand);
            groupBox1.Controls.Add(labelSerialNumber);
            groupBox1.Controls.Add(textBoxSerialNumber);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(403, 305);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bike Information";
            // 
            // comboBoxColor
            // 
            comboBoxColor.FormattingEnabled = true;
            comboBoxColor.Location = new Point(202, 265);
            comboBoxColor.Name = "comboBoxColor";
            comboBoxColor.Size = new Size(121, 23);
            comboBoxColor.TabIndex = 8;
            // 
            // labelColor
            // 
            labelColor.BorderStyle = BorderStyle.FixedSingle;
            labelColor.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelColor.Location = new Point(19, 265);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(150, 23);
            labelColor.TabIndex = 11;
            labelColor.Text = "Color";
            labelColor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxSpeed
            // 
            textBoxSpeed.Location = new Point(202, 221);
            textBoxSpeed.Name = "textBoxSpeed";
            textBoxSpeed.Size = new Size(121, 23);
            textBoxSpeed.TabIndex = 10;
            // 
            // textBoxBrand
            // 
            textBoxBrand.Location = new Point(202, 126);
            textBoxBrand.Name = "textBoxBrand";
            textBoxBrand.Size = new Size(121, 23);
            textBoxBrand.TabIndex = 9;
            // 
            // textBoxModel
            // 
            textBoxModel.Location = new Point(202, 173);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(121, 23);
            textBoxModel.TabIndex = 8;
            // 
            // comboBoxType
            // 
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(202, 34);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(121, 23);
            comboBoxType.TabIndex = 7;
            comboBoxType.SelectedIndexChanged += comboBoxType_SelectedIndexChanged;
            // 
            // labelBikeType
            // 
            labelBikeType.BorderStyle = BorderStyle.FixedSingle;
            labelBikeType.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBikeType.Location = new Point(19, 34);
            labelBikeType.Name = "labelBikeType";
            labelBikeType.Size = new Size(150, 23);
            labelBikeType.TabIndex = 6;
            labelBikeType.Text = "Bike Type";
            labelBikeType.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSpeed
            // 
            labelSpeed.BorderStyle = BorderStyle.FixedSingle;
            labelSpeed.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSpeed.Location = new Point(19, 221);
            labelSpeed.Name = "labelSpeed";
            labelSpeed.Size = new Size(150, 23);
            labelSpeed.TabIndex = 5;
            labelSpeed.Text = "Speed";
            labelSpeed.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelModel
            // 
            labelModel.BorderStyle = BorderStyle.FixedSingle;
            labelModel.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelModel.Location = new Point(19, 171);
            labelModel.Name = "labelModel";
            labelModel.Size = new Size(150, 23);
            labelModel.TabIndex = 4;
            labelModel.Text = "Model";
            labelModel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelBrand
            // 
            labelBrand.BorderStyle = BorderStyle.FixedSingle;
            labelBrand.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBrand.Location = new Point(19, 126);
            labelBrand.Name = "labelBrand";
            labelBrand.Size = new Size(150, 23);
            labelBrand.TabIndex = 3;
            labelBrand.Text = "Brand";
            labelBrand.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBoxMadeDate
            // 
            groupBoxMadeDate.Controls.Add(textBoxMonth);
            groupBoxMadeDate.Controls.Add(textBoxYear);
            groupBoxMadeDate.Controls.Add(labelYear);
            groupBoxMadeDate.Controls.Add(labelMonth);
            groupBoxMadeDate.Controls.Add(labelDay);
            groupBoxMadeDate.Controls.Add(textBoxDay);
            groupBoxMadeDate.Location = new Point(421, 12);
            groupBoxMadeDate.Name = "groupBoxMadeDate";
            groupBoxMadeDate.Size = new Size(300, 211);
            groupBoxMadeDate.TabIndex = 5;
            groupBoxMadeDate.TabStop = false;
            groupBoxMadeDate.Text = "Bike Made Date";
            // 
            // textBoxMonth
            // 
            textBoxMonth.Location = new Point(172, 90);
            textBoxMonth.Name = "textBoxMonth";
            textBoxMonth.Size = new Size(121, 23);
            textBoxMonth.TabIndex = 9;
            // 
            // textBoxYear
            // 
            textBoxYear.Location = new Point(172, 141);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(121, 23);
            textBoxYear.TabIndex = 8;
            // 
            // labelYear
            // 
            labelYear.BorderStyle = BorderStyle.FixedSingle;
            labelYear.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelYear.Location = new Point(19, 141);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(122, 23);
            labelYear.TabIndex = 4;
            labelYear.Text = "Year";
            labelYear.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelMonth
            // 
            labelMonth.BorderStyle = BorderStyle.FixedSingle;
            labelMonth.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMonth.Location = new Point(19, 90);
            labelMonth.Name = "labelMonth";
            labelMonth.Size = new Size(122, 23);
            labelMonth.TabIndex = 3;
            labelMonth.Text = "Month";
            labelMonth.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelDay
            // 
            labelDay.BorderStyle = BorderStyle.FixedSingle;
            labelDay.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDay.Location = new Point(19, 46);
            labelDay.Name = "labelDay";
            labelDay.Size = new Size(122, 23);
            labelDay.TabIndex = 1;
            labelDay.Text = "Day";
            labelDay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxDay
            // 
            textBoxDay.Location = new Point(172, 48);
            textBoxDay.Name = "textBoxDay";
            textBoxDay.Size = new Size(121, 23);
            textBoxDay.TabIndex = 2;
            // 
            // groupBoxRoadBike
            // 
            groupBoxRoadBike.Controls.Add(labelSeatHeight);
            groupBoxRoadBike.Controls.Add(textBoxSeatHeight);
            groupBoxRoadBike.Location = new Point(421, 233);
            groupBoxRoadBike.Name = "groupBoxRoadBike";
            groupBoxRoadBike.Size = new Size(297, 84);
            groupBoxRoadBike.TabIndex = 6;
            groupBoxRoadBike.TabStop = false;
            groupBoxRoadBike.Text = "Road Bike Specification";
            // 
            // labelSeatHeight
            // 
            labelSeatHeight.BorderStyle = BorderStyle.FixedSingle;
            labelSeatHeight.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSeatHeight.Location = new Point(16, 36);
            labelSeatHeight.Name = "labelSeatHeight";
            labelSeatHeight.Size = new Size(137, 23);
            labelSeatHeight.TabIndex = 1;
            labelSeatHeight.Text = "Seat Height";
            labelSeatHeight.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxSeatHeight
            // 
            textBoxSeatHeight.Location = new Point(175, 36);
            textBoxSeatHeight.Name = "textBoxSeatHeight";
            textBoxSeatHeight.Size = new Size(109, 23);
            textBoxSeatHeight.TabIndex = 2;
            // 
            // groupBoxMountainBike
            // 
            groupBoxMountainBike.Controls.Add(comboBoxSuspension);
            groupBoxMountainBike.Controls.Add(labelSuspension);
            groupBoxMountainBike.Controls.Add(labelHeighFromGround);
            groupBoxMountainBike.Controls.Add(textBoxHeightFromGround);
            groupBoxMountainBike.Location = new Point(12, 323);
            groupBoxMountainBike.Name = "groupBoxMountainBike";
            groupBoxMountainBike.Size = new Size(403, 128);
            groupBoxMountainBike.TabIndex = 7;
            groupBoxMountainBike.TabStop = false;
            groupBoxMountainBike.Text = "Mountain Bike Specification";
            // 
            // comboBoxSuspension
            // 
            comboBoxSuspension.FormattingEnabled = true;
            comboBoxSuspension.Location = new Point(219, 80);
            comboBoxSuspension.Name = "comboBoxSuspension";
            comboBoxSuspension.Size = new Size(132, 23);
            comboBoxSuspension.TabIndex = 9;
            // 
            // labelSuspension
            // 
            labelSuspension.BorderStyle = BorderStyle.FixedSingle;
            labelSuspension.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSuspension.Location = new Point(16, 80);
            labelSuspension.Name = "labelSuspension";
            labelSuspension.Size = new Size(178, 27);
            labelSuspension.TabIndex = 3;
            labelSuspension.Text = "Suspension";
            labelSuspension.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelHeighFromGround
            // 
            labelHeighFromGround.BorderStyle = BorderStyle.FixedSingle;
            labelHeighFromGround.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHeighFromGround.Location = new Point(16, 36);
            labelHeighFromGround.Name = "labelHeighFromGround";
            labelHeighFromGround.Size = new Size(178, 23);
            labelHeighFromGround.TabIndex = 1;
            labelHeighFromGround.Text = "Height From Ground";
            labelHeighFromGround.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxHeightFromGround
            // 
            textBoxHeightFromGround.Location = new Point(219, 36);
            textBoxHeightFromGround.Name = "textBoxHeightFromGround";
            textBoxHeightFromGround.Size = new Size(132, 23);
            textBoxHeightFromGround.TabIndex = 2;
            // 
            // buttonPrintBikes
            // 
            buttonPrintBikes.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPrintBikes.Location = new Point(141, 510);
            buttonPrintBikes.Name = "buttonPrintBikes";
            buttonPrintBikes.Size = new Size(104, 41);
            buttonPrintBikes.TabIndex = 8;
            buttonPrintBikes.Text = "Print Bikes";
            buttonPrintBikes.UseVisualStyleBackColor = true;
            buttonPrintBikes.Click += buttonPrintBikes_Click;
            // 
            // buttonReset
            // 
            buttonReset.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonReset.Location = new Point(259, 510);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(104, 41);
            buttonReset.TabIndex = 10;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonMountainBikes
            // 
            buttonMountainBikes.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMountainBikes.Location = new Point(6, 67);
            buttonMountainBikes.Name = "buttonMountainBikes";
            buttonMountainBikes.Size = new Size(166, 41);
            buttonMountainBikes.TabIndex = 11;
            buttonMountainBikes.Text = "Print Mountain Bikes";
            buttonMountainBikes.UseVisualStyleBackColor = true;
            buttonMountainBikes.Click += buttonMountainBikes_Click;
            // 
            // buttonPrintRoadBikes
            // 
            buttonPrintRoadBikes.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPrintRoadBikes.Location = new Point(6, 22);
            buttonPrintRoadBikes.Name = "buttonPrintRoadBikes";
            buttonPrintRoadBikes.Size = new Size(166, 39);
            buttonPrintRoadBikes.TabIndex = 12;
            buttonPrintRoadBikes.Text = "Print Road Bikes";
            buttonPrintRoadBikes.UseVisualStyleBackColor = true;
            buttonPrintRoadBikes.Click += buttonPrintRoadBikes_Click;
            // 
            // groupBoxSerializeDeserialize
            // 
            groupBoxSerializeDeserialize.Controls.Add(buttonReadFromXmlFile);
            groupBoxSerializeDeserialize.Controls.Add(buttonWriteToXmlFile);
            groupBoxSerializeDeserialize.Location = new Point(31, 702);
            groupBoxSerializeDeserialize.Name = "groupBoxSerializeDeserialize";
            groupBoxSerializeDeserialize.Size = new Size(389, 71);
            groupBoxSerializeDeserialize.TabIndex = 13;
            groupBoxSerializeDeserialize.TabStop = false;
            groupBoxSerializeDeserialize.Text = "Serialize/Deserialize XML File";
            // 
            // buttonReadFromXmlFile
            // 
            buttonReadFromXmlFile.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonReadFromXmlFile.Location = new Point(202, 22);
            buttonReadFromXmlFile.Name = "buttonReadFromXmlFile";
            buttonReadFromXmlFile.Size = new Size(169, 39);
            buttonReadFromXmlFile.TabIndex = 14;
            buttonReadFromXmlFile.Text = "Read XML File";
            buttonReadFromXmlFile.UseVisualStyleBackColor = true;
            buttonReadFromXmlFile.Click += buttonReadFromXmlFile_Click;
            // 
            // buttonWriteToXmlFile
            // 
            buttonWriteToXmlFile.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonWriteToXmlFile.Location = new Point(15, 22);
            buttonWriteToXmlFile.Name = "buttonWriteToXmlFile";
            buttonWriteToXmlFile.Size = new Size(164, 39);
            buttonWriteToXmlFile.TabIndex = 13;
            buttonWriteToXmlFile.Text = "Write XML File";
            buttonWriteToXmlFile.UseVisualStyleBackColor = true;
            buttonWriteToXmlFile.Click += buttonWriteToXmlFile_Click;
            // 
            // groupBoxModification
            // 
            groupBoxModification.Controls.Add(buttonRemove);
            groupBoxModification.Controls.Add(buttonUpdate);
            groupBoxModification.Controls.Add(buttonSearch);
            groupBoxModification.Controls.Add(labelRemove);
            groupBoxModification.Controls.Add(labelUpdate);
            groupBoxModification.Controls.Add(labelSearch);
            groupBoxModification.Location = new Point(766, 20);
            groupBoxModification.Name = "groupBoxModification";
            groupBoxModification.Size = new Size(349, 236);
            groupBoxModification.TabIndex = 15;
            groupBoxModification.TabStop = false;
            groupBoxModification.Text = "Modification";
            // 
            // buttonRemove
            // 
            buttonRemove.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRemove.Location = new Point(122, 203);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(87, 27);
            buttonRemove.TabIndex = 17;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonUpdate.Location = new Point(122, 138);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(87, 27);
            buttonUpdate.TabIndex = 18;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSearch.Location = new Point(122, 78);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(87, 27);
            buttonSearch.TabIndex = 16;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // labelRemove
            // 
            labelRemove.BorderStyle = BorderStyle.FixedSingle;
            labelRemove.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRemove.Location = new Point(19, 172);
            labelRemove.Name = "labelRemove";
            labelRemove.Size = new Size(306, 23);
            labelRemove.TabIndex = 4;
            labelRemove.Text = "Choose a Bike to Remove from the listBox";
            labelRemove.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelUpdate
            // 
            labelUpdate.BorderStyle = BorderStyle.FixedSingle;
            labelUpdate.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUpdate.Location = new Point(19, 112);
            labelUpdate.Name = "labelUpdate";
            labelUpdate.Size = new Size(306, 23);
            labelUpdate.TabIndex = 3;
            labelUpdate.Text = "Choose a Bike to Update from the listBox";
            labelUpdate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSearch
            // 
            labelSearch.BorderStyle = BorderStyle.FixedSingle;
            labelSearch.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSearch.Location = new Point(19, 46);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(306, 29);
            labelSearch.TabIndex = 1;
            labelSearch.Text = "Search for Bike by Serial Number";
            labelSearch.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonExit.Location = new Point(994, 718);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(121, 50);
            buttonExit.TabIndex = 16;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // groupBoxElectricBike
            // 
            groupBoxElectricBike.Controls.Add(label1);
            groupBoxElectricBike.Controls.Add(textBoxBattreyLife);
            groupBoxElectricBike.Location = new Point(428, 323);
            groupBoxElectricBike.Name = "groupBoxElectricBike";
            groupBoxElectricBike.Size = new Size(297, 84);
            groupBoxElectricBike.TabIndex = 17;
            groupBoxElectricBike.TabStop = false;
            groupBoxElectricBike.Text = "Electric Bike Specification";
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 36);
            label1.Name = "label1";
            label1.Size = new Size(137, 23);
            label1.TabIndex = 1;
            label1.Text = "Battrey Life";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxBattreyLife
            // 
            textBoxBattreyLife.Location = new Point(165, 38);
            textBoxBattreyLife.Name = "textBoxBattreyLife";
            textBoxBattreyLife.Size = new Size(109, 23);
            textBoxBattreyLife.TabIndex = 2;
            // 
            // buttonElectricBike
            // 
            buttonElectricBike.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonElectricBike.Location = new Point(6, 114);
            buttonElectricBike.Name = "buttonElectricBike";
            buttonElectricBike.Size = new Size(166, 41);
            buttonElectricBike.TabIndex = 18;
            buttonElectricBike.Text = "Print Electric Bikes";
            buttonElectricBike.UseVisualStyleBackColor = true;
            buttonElectricBike.Click += buttonElectricBike_Click;
            // 
            // groupBoxSpeedUp
            // 
            groupBoxSpeedUp.Controls.Add(buttonSpeedUp);
            groupBoxSpeedUp.Controls.Add(numericUpDownSpeedIncrement);
            groupBoxSpeedUp.Controls.Add(label2MaxSpeed);
            groupBoxSpeedUp.Location = new Point(766, 277);
            groupBoxSpeedUp.Name = "groupBoxSpeedUp";
            groupBoxSpeedUp.Size = new Size(300, 84);
            groupBoxSpeedUp.TabIndex = 19;
            groupBoxSpeedUp.TabStop = false;
            groupBoxSpeedUp.Text = "Speed Up Bikes";
            // 
            // buttonSpeedUp
            // 
            buttonSpeedUp.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSpeedUp.Location = new Point(99, 51);
            buttonSpeedUp.Name = "buttonSpeedUp";
            buttonSpeedUp.Size = new Size(97, 30);
            buttonSpeedUp.TabIndex = 22;
            buttonSpeedUp.Text = "Speed Up";
            buttonSpeedUp.UseVisualStyleBackColor = true;
            buttonSpeedUp.Click += buttonSpeedUp_Click;
            // 
            // numericUpDownSpeedIncrement
            // 
            numericUpDownSpeedIncrement.Location = new Point(164, 22);
            numericUpDownSpeedIncrement.Name = "numericUpDownSpeedIncrement";
            numericUpDownSpeedIncrement.Size = new Size(120, 23);
            numericUpDownSpeedIncrement.TabIndex = 2;
            // 
            // label2MaxSpeed
            // 
            label2MaxSpeed.BorderStyle = BorderStyle.FixedSingle;
            label2MaxSpeed.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2MaxSpeed.Location = new Point(16, 22);
            label2MaxSpeed.Name = "label2MaxSpeed";
            label2MaxSpeed.Size = new Size(137, 23);
            label2MaxSpeed.TabIndex = 1;
            label2MaxSpeed.Text = "Speed Up";
            label2MaxSpeed.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(776, 403);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(339, 284);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // groupBoxPrintBikes
            // 
            groupBoxPrintBikes.Controls.Add(buttonPrintFoldingBike);
            groupBoxPrintBikes.Controls.Add(buttonPrintRoadBikes);
            groupBoxPrintBikes.Controls.Add(buttonMountainBikes);
            groupBoxPrintBikes.Controls.Add(buttonElectricBike);
            groupBoxPrintBikes.Location = new Point(515, 557);
            groupBoxPrintBikes.Name = "groupBoxPrintBikes";
            groupBoxPrintBikes.Size = new Size(193, 211);
            groupBoxPrintBikes.TabIndex = 21;
            groupBoxPrintBikes.TabStop = false;
            groupBoxPrintBikes.Text = "Print Bikes";
            // 
            // buttonPrintFoldingBike
            // 
            buttonPrintFoldingBike.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPrintFoldingBike.Location = new Point(8, 161);
            buttonPrintFoldingBike.Name = "buttonPrintFoldingBike";
            buttonPrintFoldingBike.Size = new Size(166, 41);
            buttonPrintFoldingBike.TabIndex = 19;
            buttonPrintFoldingBike.Text = "Print Folding Bikes";
            buttonPrintFoldingBike.UseVisualStyleBackColor = true;
            buttonPrintFoldingBike.Click += buttonPrintFoldingBike_Click;
            // 
            // groupBoxFoldingBike
            // 
            groupBoxFoldingBike.Controls.Add(comboBoxFrameMaterial);
            groupBoxFoldingBike.Controls.Add(labelFrameMaterial);
            groupBoxFoldingBike.Controls.Add(labelWeight);
            groupBoxFoldingBike.Controls.Add(textBoxWeight);
            groupBoxFoldingBike.Location = new Point(428, 424);
            groupBoxFoldingBike.Name = "groupBoxFoldingBike";
            groupBoxFoldingBike.Size = new Size(297, 104);
            groupBoxFoldingBike.TabIndex = 22;
            groupBoxFoldingBike.TabStop = false;
            groupBoxFoldingBike.Text = "Folding Bike Specification";
            // 
            // comboBoxFrameMaterial
            // 
            comboBoxFrameMaterial.FormattingEnabled = true;
            comboBoxFrameMaterial.Location = new Point(161, 73);
            comboBoxFrameMaterial.Name = "comboBoxFrameMaterial";
            comboBoxFrameMaterial.Size = new Size(132, 23);
            comboBoxFrameMaterial.TabIndex = 10;
            // 
            // labelFrameMaterial
            // 
            labelFrameMaterial.BorderStyle = BorderStyle.FixedSingle;
            labelFrameMaterial.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFrameMaterial.Location = new Point(9, 73);
            labelFrameMaterial.Name = "labelFrameMaterial";
            labelFrameMaterial.Size = new Size(137, 23);
            labelFrameMaterial.TabIndex = 3;
            labelFrameMaterial.Text = "Frame Material";
            labelFrameMaterial.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelWeight
            // 
            labelWeight.BorderStyle = BorderStyle.FixedSingle;
            labelWeight.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelWeight.Location = new Point(9, 36);
            labelWeight.Name = "labelWeight";
            labelWeight.Size = new Size(137, 23);
            labelWeight.TabIndex = 1;
            labelWeight.Text = "Weight";
            labelWeight.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxWeight
            // 
            textBoxWeight.Location = new Point(161, 38);
            textBoxWeight.Name = "textBoxWeight";
            textBoxWeight.Size = new Size(132, 23);
            textBoxWeight.TabIndex = 2;
            // 
            // FormBike
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1215, 804);
            Controls.Add(groupBoxFoldingBike);
            Controls.Add(groupBoxPrintBikes);
            Controls.Add(pictureBox1);
            Controls.Add(groupBoxSpeedUp);
            Controls.Add(groupBoxElectricBike);
            Controls.Add(buttonExit);
            Controls.Add(groupBoxModification);
            Controls.Add(groupBoxSerializeDeserialize);
            Controls.Add(buttonReset);
            Controls.Add(buttonPrintBikes);
            Controls.Add(groupBoxMountainBike);
            Controls.Add(groupBoxRoadBike);
            Controls.Add(groupBoxMadeDate);
            Controls.Add(groupBox1);
            Controls.Add(listBoxBike);
            Controls.Add(buttonAdd);
            DoubleBuffered = true;
            Margin = new Padding(2);
            Name = "FormBike";
            Text = "Negar Pirasteh";
            Load += FormBike_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxMadeDate.ResumeLayout(false);
            groupBoxMadeDate.PerformLayout();
            groupBoxRoadBike.ResumeLayout(false);
            groupBoxRoadBike.PerformLayout();
            groupBoxMountainBike.ResumeLayout(false);
            groupBoxMountainBike.PerformLayout();
            groupBoxSerializeDeserialize.ResumeLayout(false);
            groupBoxModification.ResumeLayout(false);
            groupBoxElectricBike.ResumeLayout(false);
            groupBoxElectricBike.PerformLayout();
            groupBoxSpeedUp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownSpeedIncrement).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxPrintBikes.ResumeLayout(false);
            groupBoxFoldingBike.ResumeLayout(false);
            groupBoxFoldingBike.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAdd;
        private Label labelSerialNumber;
        private TextBox textBoxSerialNumber;
        private ListBox listBoxBike;
        private GroupBox groupBox1;
        private Label labelSpeed;
        private Label labelModel;
        private Label labelBrand;
        private Label labelBikeType;
        private TextBox textBoxSpeed;
        private TextBox textBoxBrand;
        private TextBox textBoxModel;
        private ComboBox comboBoxType;
        private ComboBox comboBoxColor;
        private Label labelColor;
        private GroupBox groupBoxMadeDate;
        private TextBox textBoxMonth;
        private TextBox textBoxYear;
        private Label labelYear;
        private Label labelMonth;
        private Label labelDay;
        private TextBox textBoxDay;
        private GroupBox groupBoxRoadBike;
        private Label labelSeatHeight;
        private TextBox textBoxSeatHeight;
        private GroupBox groupBoxMountainBike;
        private Label labelSuspension;
        private Label labelHeighFromGround;
        private TextBox textBoxHeightFromGround;
        private ComboBox comboBoxSuspension;
        private Button buttonPrintBikes;
        private Button buttonReset;
        private Button buttonMountainBikes;
        private Button buttonPrintRoadBikes;
        private GroupBox groupBoxSerializeDeserialize;
        private Button buttonReadFromXmlFile;
        private Button buttonWriteToXmlFile;
        private GroupBox groupBoxModification;
        private Label labelRemove;
        private Label labelUpdate;
        private Label labelSearch;
        private Button buttonRemove;
        private Button buttonUpdate;
        private Button buttonSearch;
        private Button buttonExit;
        private GroupBox groupBoxElectricBike;
        private Label label1;
        private TextBox textBoxBattreyLife;
        private Button buttonElectricBike;
        private GroupBox groupBoxSpeedUp;
        private Label label2MaxSpeed;
        private PictureBox pictureBox1;
        private GroupBox groupBoxPrintBikes;
        private Button buttonSpeedUp;
        private NumericUpDown numericUpDownSpeedIncrement;
        private GroupBox groupBoxFoldingBike;
        private ComboBox comboBoxFrameMaterial;
        private Label labelFrameMaterial;
        private Label labelWeight;
        private TextBox textBoxWeight;
        private Button buttonPrintFoldingBike;
    }
}
