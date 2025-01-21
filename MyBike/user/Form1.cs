using MyBike.bus;
using System;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Xml;
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Date = MyBike.bus.Date;



namespace MyBike
{
    public partial class FormBike : Form
    {

        List<Bike>? listOfBikes = new List<Bike>();

        List<RoadBike>? listOfRoadBikes = new List<RoadBike>();

        List<MountainBike>? listOfMountainBike = new List<MountainBike>();

        List<ElectricBike>? listOfElectricBike = new List<ElectricBike>();

        List<FoldingBike>? listOfFoldingBike = new List<FoldingBike>();

        Bike currentBike;
        RoadBike currentRoadBike;
        MountainBike currentMountainBike;
        ElectricBike currentElectricBike;
        FoldingBike currentFoldingBike;
        Date currentMadeDate;



        public FormBike()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int serialNumber;
            string? brand;
            string? model;
            double speed;
            int currentMonth, currentDay, currentYear;

            try
            {

                currentMadeDate = new Date();


                EnumType currentType;
                Enum.TryParse(this.comboBoxType.Text, out currentType);


                EnumColor currentColor;
                Enum.TryParse(this.comboBoxColor.Text, out currentColor);

                EnumSuspension currentSuspension;
                Enum.TryParse(this.comboBoxSuspension.Text, out currentSuspension);

                EnumFrameMaterial currentFrameMaterial;
                Enum.TryParse(this.comboBoxSuspension.Text, out currentFrameMaterial);


                serialNumber = Convert.ToInt32(this.textBoxSerialNumber.Text);
                brand = this.textBoxBrand.Text;
                model = this.textBoxModel.Text;
                speed = Convert.ToInt64(this.textBoxSpeed.Text);

                currentMonth = Convert.ToInt32(this.textBoxMonth.Text);
                currentDay = Convert.ToInt32(this.textBoxDay.Text);
                currentYear = Convert.ToInt32(this.textBoxYear.Text);
                currentMadeDate.Month = currentMonth;
                currentMadeDate.Day = currentDay;
                currentMadeDate.Year = currentYear;

                // Validate month
                if (currentMonth < 1 || currentMonth > 12)
                {
                    MessageBox.Show("The month is wrong. Please enter a value between 1 and 12.", "Invalid Date");
                    return; 
                }

                // Validate day
                if (currentDay < 1 || currentDay > 31)
                {
                    MessageBox.Show("The day is wrong. Please enter a value between 1 and 31.", "Invalid Date");
                    return;
                }

                // Validate year
                if (currentYear < 1900 || currentYear > 2024)
                {
                    MessageBox.Show("The year is wrong. Please enter a year between 1900 to 2024.", "Invalid Date");
                    return; 
                }


                if (currentType == EnumType.RoadBike)
                {

                    currentRoadBike = new RoadBike();

                    currentRoadBike.Type = currentType;
                    currentRoadBike.SerialNumber = serialNumber;
                    currentRoadBike.Brand = brand;
                    currentRoadBike.Model = model;
                    currentRoadBike.Speed = speed;
                    currentRoadBike.Color = currentColor;
                    currentRoadBike.MadeDate = currentMadeDate;

                    if (speed < 1 || speed > 40)
                    {
                        MessageBox.Show("The speed is wrong. Please enter a value between 1 and 40 for Road Bike.", "Invalid Speed");
                        return;
                    }

                    try
                    {
                        currentRoadBike.SeatHeight = Convert.ToInt64(this.textBoxSeatHeight.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                    if (DataCollection.GetBikeList() != null)
                    {
                        DataCollection.Add(currentRoadBike);
                    }

                }

                else if (currentType == EnumType.MountainBike)
                {

                    currentMountainBike = new MountainBike();


                    currentMountainBike.Type = currentType;
                    currentMountainBike.SerialNumber = serialNumber;
                    currentMountainBike.Brand = brand;
                    currentMountainBike.Model = model;
                    currentMountainBike.Speed = speed;
                    currentMountainBike.Color = currentColor;
                    currentMountainBike.MadeDate = currentMadeDate;
                    currentMountainBike.Suspension = currentSuspension;

                    if (speed < 1 || speed > 20)
                    {
                        MessageBox.Show("The speed is wrong. Please enter a value between 1 and 20 for Mountain Bike.", "Invalid Speed");
                        return;
                    }

                    try
                    {
                        currentMountainBike.HeightFromGround = Convert.ToInt32(this.textBoxHeightFromGround.Text);
                        // currentMountainBike.Suspension = this.comboBoxSuspension.Text;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                    if (DataCollection.GetBikeList() != null)
                    {
                        DataCollection.Add(currentMountainBike);
                    }

                }

                else if (currentType == EnumType.ElectricBike)
                {

                    currentElectricBike = new ElectricBike();


                    currentElectricBike.Type = currentType;
                    currentElectricBike.SerialNumber = serialNumber;
                    currentElectricBike.Brand = brand;
                    currentElectricBike.Model = model;
                    currentElectricBike.Speed = speed;
                    currentElectricBike.Color = currentColor;
                    currentElectricBike.MadeDate = currentMadeDate;

                    if (speed < 1 || speed > 20)
                    {
                        MessageBox.Show("The speed is wrong. Please enter a value between 1 and 20 for Electric Bike.", "Invalid Speed");
                        return;
                    }

                    try
                    {
                        currentElectricBike.BatteryLifeHours = Convert.ToInt32(this.textBoxBattreyLife.Text);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                    if (DataCollection.GetBikeList() != null)
                    {
                        DataCollection.Add(currentElectricBike);
                    }

                }


                else if (currentType == EnumType.FoldingBike)
                {

                    currentFoldingBike = new FoldingBike();


                    currentFoldingBike.Type = currentType;
                    currentFoldingBike.SerialNumber = serialNumber;
                    currentFoldingBike.Brand = brand;
                    currentFoldingBike.Model = model;
                    currentFoldingBike.Speed = speed;
                    currentFoldingBike.Color = currentColor;
                    currentFoldingBike.MadeDate = currentMadeDate;
                    currentFoldingBike.FrameMaterial = currentFrameMaterial;

                    if (speed < 1 || speed > 30)
                    {
                        MessageBox.Show("The speed is wrong. Please enter a value between 1 and 30 for Folding Bike.", "Invalid Speed");
                        return;
                    }


                    try
                    {
                        currentFoldingBike.Weight = Convert.ToInt32(this.textBoxWeight.Text);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                    if (DataCollection.GetBikeList() != null)
                    {
                        DataCollection.Add(currentFoldingBike);
                    }

                }
            }



            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n \t You must input a valid data");
                this.textBoxSerialNumber.Focus();
            }

            this.buttonAdd.Enabled = false;


        }

        private void buttonPrintBikes_Click(object sender, EventArgs e)
        {
            this.listBoxBike.Items.Clear();

            if (DataCollection.GetBikeList() != null && DataCollection.GetBikeList().Count > 0 && this.listBoxBike.Items.Count == 0)
            {
                foreach (Bike currentBike in DataCollection.GetBikeList())
                {
                    if (currentBike is RoadBike)
                    {
                        currentRoadBike = (RoadBike)currentBike;

                        this.listBoxBike.Items.Add(currentRoadBike.GetState());
                    }
                    else if (currentBike is MountainBike)
                    {
                        currentMountainBike = (MountainBike)currentBike;

                        this.listBoxBike.Items.Add(currentMountainBike.GetState());

                        // this.listBoxBike.Items.Add(currentMountainBike.ToString());


                    }
                    else if (currentBike is ElectricBike)
                    {
                        currentElectricBike = (ElectricBike)currentBike;

                        this.listBoxBike.Items.Add(currentElectricBike.GetState());

                        // this.listBoxBike.Items.Add(currentMountainBike.ToString());

                    }
                    else if (currentBike is FoldingBike)
                    {
                        currentFoldingBike = (FoldingBike)currentBike;

                        this.listBoxBike.Items.Add(currentFoldingBike.GetState());

                        // this.listBoxBike.Items.Add(currentMountainBike.ToString());

                    }
                }
            }
            else
            {
                MessageBox.Show("The list of items already printed in the listBox or the list of Counters in memory is empty....");
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {

            this.comboBoxType.Text = EnumType.Undefined.ToString();

            this.comboBoxSuspension.Text = EnumSuspension.Undefined.ToString();

            this.comboBoxColor.Text = Convert.ToString(EnumColor.Undefined);

            this.comboBoxFrameMaterial.Text = Convert.ToString(EnumFrameMaterial.Undefined);

            this.textBoxSerialNumber.Text = string.Empty;
            this.textBoxBrand.Text = string.Empty;
            this.textBoxModel.Text = string.Empty;
            this.textBoxSpeed.Text = string.Empty;

            this.textBoxMonth.Text = string.Empty;
            this.textBoxDay.Text = string.Empty;
            this.textBoxYear.Text = string.Empty;

            this.textBoxSeatHeight.Text = string.Empty;
            this.textBoxHeightFromGround.Text = string.Empty;
            this.textBoxBattreyLife.Text = string.Empty;
            this.textBoxWeight.Text = string.Empty;
            this.numericUpDownSpeedIncrement.Value = 0;


            this.textBoxSeatHeight.Enabled = true;
            this.textBoxHeightFromGround.Enabled = true;
            this.comboBoxSuspension.Enabled = true;
            this.textBoxBattreyLife.Enabled = true;
            this.comboBoxFrameMaterial.Enabled = true;


            this.textBoxSerialNumber.Focus();

            this.listBoxBike.Items.Clear();

            this.buttonAdd.Enabled = true;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Application written by Negar Pirasteh and Teammate Betty Dang", "Event Programming with C#",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            bool found = false;
            Bike BikeToSearch = null;

            RoadBike currentRoadBike;
            MountainBike currentMountainBike;


            if (DataCollection.GetBikeList != null)
            {
                foreach (Bike currentBike in DataCollection.GetBikeList())
                {
                    if (currentBike.SerialNumber == Convert.ToInt32(this.textBoxSerialNumber.Text))
                    {
                        found = true;
                        BikeToSearch = currentBike;
                        break;
                    }
                }
            }

            if (found)
            {
                if (BikeToSearch.Type == EnumType.RoadBike)
                {
                    currentRoadBike = (RoadBike)BikeToSearch;

                    MessageBox.Show("Bike found ..." + currentRoadBike.GetState(),
                       "Event Programming with C#", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.listBoxBike.Items.Add(currentRoadBike.GetState());

                }

                else if (BikeToSearch.Type == EnumType.MountainBike)
                {
                    currentMountainBike = (MountainBike)BikeToSearch;

                    MessageBox.Show("Bike found ..." + currentMountainBike.GetState(),
                       "Event Programming with C#", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.listBoxBike.Items.Add(currentMountainBike.GetState());

                }


                else if (BikeToSearch.Type == EnumType.ElectricBike)
                {
                    currentElectricBike = (ElectricBike)BikeToSearch;

                    MessageBox.Show("Bike found ..." + currentElectricBike.GetState(),
                       "Event Programming with C#", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.listBoxBike.Items.Add(currentElectricBike.GetState());

                }

                else if (BikeToSearch.Type == EnumType.FoldingBike)
                {
                    currentFoldingBike = (FoldingBike)BikeToSearch;

                    MessageBox.Show("Bike found ..." + currentFoldingBike.GetState(),
                       "Event Programming with C#", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.listBoxBike.Items.Add(currentFoldingBike.GetState());

                }

            }
            else
            {
                MessageBox.Show("Bike Not found ...",
                    "Event Programming with C#", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormBike_Load(object sender, EventArgs e)
        {
            foreach (EnumColor counter in Enum.GetValues(typeof(EnumColor)))
            {
                this.comboBoxColor.Items.Add(counter);
            }

            this.comboBoxColor.Text = Convert.ToString(EnumColor.Undefined);


            foreach (EnumType counter in Enum.GetValues(typeof(EnumType)))
            {
                this.comboBoxType.Items.Add(counter);
            }

            this.comboBoxType.Text = Convert.ToString(EnumType.Undefined);

            foreach (EnumSuspension counter in Enum.GetValues(typeof(EnumSuspension)))
            {
                this.comboBoxSuspension.Items.Add(counter);
            }

            this.comboBoxSuspension.Text = Convert.ToString(EnumSuspension.Undefined);

            foreach (EnumFrameMaterial counter in Enum.GetValues(typeof(EnumFrameMaterial)))
            {
                this.comboBoxFrameMaterial.Items.Add(counter);
            }

            this.comboBoxFrameMaterial.Text = Convert.ToString(EnumFrameMaterial.Undefined);
        }


        int currentIndex = -1;
        private void listBoxBike_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentIndex = this.listBoxBike.SelectedIndex;

            EnumType currentBikeType;

            this.listOfBikes = DataCollection.GetBikeList();

            if (this.listOfBikes != null)
            {
                currentBikeType = this.listOfBikes[currentIndex].Type;

                this.comboBoxType.Text = Convert.ToString(currentBikeType);


                if (currentIndex >= 0 && currentBikeType == EnumType.RoadBike)
                {
                    RoadBike currentRoadBike = new RoadBike();

                    currentRoadBike = (RoadBike)this.listOfBikes[currentIndex];

                    this.textBoxSerialNumber.Text = currentRoadBike.SerialNumber.ToString();
                    this.textBoxBrand.Text = currentRoadBike.Brand.ToString();
                    this.textBoxModel.Text = currentRoadBike.Model.ToString();
                    this.textBoxSpeed.Text = currentRoadBike.Speed.ToString();

                    this.comboBoxColor.Text = currentRoadBike.Color.ToString();


                    this.textBoxMonth.Text = currentRoadBike.MadeDate.Month.ToString();
                    this.textBoxDay.Text = currentRoadBike.MadeDate.Day.ToString();
                    this.textBoxYear.Text = currentRoadBike.MadeDate.Year.ToString();

                    this.textBoxSeatHeight.Text = currentRoadBike.SeatHeight.ToString();

                }

                else
                if (currentIndex >= 0 && currentBikeType == EnumType.MountainBike)
                {
                    MountainBike currentMountainBike = new MountainBike();

                    currentMountainBike = (MountainBike)this.listOfBikes[currentIndex];

                    this.textBoxSerialNumber.Text = currentMountainBike.SerialNumber.ToString();
                    this.textBoxBrand.Text = currentMountainBike.Brand.ToString();
                    this.textBoxModel.Text = currentMountainBike.Model.ToString();
                    this.textBoxSpeed.Text = currentMountainBike.Speed.ToString();


                    this.comboBoxColor.Text = currentMountainBike.Color.ToString();

                    this.textBoxMonth.Text = currentMountainBike.MadeDate.Month.ToString();
                    this.textBoxDay.Text = currentMountainBike.MadeDate.Day.ToString();
                    this.textBoxYear.Text = currentMountainBike.MadeDate.Year.ToString();

                    this.textBoxHeightFromGround.Text = currentMountainBike.HeightFromGround.ToString();

                    this.comboBoxSuspension.Text = currentMountainBike.Suspension.ToString();

                }

                else
                if (currentIndex >= 0 && currentBikeType == EnumType.ElectricBike)
                {
                    ElectricBike currentElectricBike = new ElectricBike();

                    currentElectricBike = (ElectricBike)this.listOfBikes[currentIndex];

                    this.textBoxSerialNumber.Text = currentElectricBike.SerialNumber.ToString();
                    this.textBoxBrand.Text = currentElectricBike.Brand.ToString();
                    this.textBoxModel.Text = currentElectricBike.Model.ToString();
                    this.textBoxSpeed.Text = currentElectricBike.Speed.ToString();


                    this.comboBoxColor.Text = currentElectricBike.Color.ToString();

                    this.textBoxMonth.Text = currentElectricBike.MadeDate.Month.ToString();
                    this.textBoxDay.Text = currentElectricBike.MadeDate.Day.ToString();
                    this.textBoxYear.Text = currentElectricBike.MadeDate.Year.ToString();

                    this.textBoxBattreyLife.Text = currentElectricBike.BatteryLifeHours.ToString();

                }
                else
                if (currentIndex >= 0 && currentBikeType == EnumType.FoldingBike)
                {
                    FoldingBike currentFoldingBike = new FoldingBike();

                    currentFoldingBike = (FoldingBike)this.listOfBikes[currentIndex];

                    this.textBoxSerialNumber.Text = currentFoldingBike.SerialNumber.ToString();
                    this.textBoxBrand.Text = currentFoldingBike.Brand.ToString();
                    this.textBoxModel.Text = currentFoldingBike.Model.ToString();
                    this.textBoxSpeed.Text = currentFoldingBike.Speed.ToString();


                    this.comboBoxColor.Text = currentFoldingBike.Color.ToString();

                    this.textBoxMonth.Text = currentFoldingBike.MadeDate.Month.ToString();
                    this.textBoxDay.Text = currentFoldingBike.MadeDate.Day.ToString();
                    this.textBoxYear.Text = currentFoldingBike.MadeDate.Year.ToString();

                    this.textBoxWeight.Text = currentFoldingBike.Weight.ToString();

                    this.comboBoxFrameMaterial.Text = currentFoldingBike.FrameMaterial.ToString();

                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            EnumType currentType;
            Enum.TryParse(this.comboBoxType.Text, out currentType);



            if (DataCollection.ListOfBikes != null)
            {
                currentType = DataCollection.ListOfBikes[currentIndex].Type;
            }

            if (currentIndex >= 0 && listOfBikes != null)
            {
                if (currentType == EnumType.RoadBike)
                {
                    RoadBike currentRoadBike = new RoadBike();

                    currentRoadBike.Type = currentType;
                    currentRoadBike.SerialNumber = Convert.ToInt32(this.textBoxSerialNumber.Text);
                    currentRoadBike.Brand = this.textBoxBrand.Text;
                    currentRoadBike.Model = this.textBoxModel.Text;
                    currentRoadBike.Speed = Convert.ToInt64(this.textBoxSpeed.Text);



                    EnumColor currentColor;
                    Enum.TryParse(this.comboBoxColor.Text, out currentColor);
                    currentRoadBike.Color = currentColor;


                    Date currentDate = new Date();
                    currentDate.Month = Convert.ToInt32(this.textBoxMonth.Text);
                    currentDate.Day = Convert.ToInt32(this.textBoxDay.Text);
                    currentDate.Year = Convert.ToInt32(this.textBoxYear.Text);
                    currentRoadBike.MadeDate = currentDate;

                    currentRoadBike.SeatHeight = Convert.ToInt64(this.textBoxSeatHeight.Text);

                    DataCollection.RemoveAt(currentIndex);

                    DataCollection.InsertAt(currentIndex, currentRoadBike);

                }

                else if (currentType == EnumType.MountainBike)
                {
                    MountainBike currentMountainBike = new MountainBike();

                    currentMountainBike.Type = currentType;
                    currentMountainBike.SerialNumber = Convert.ToInt32(this.textBoxSerialNumber.Text);
                    currentMountainBike.Brand = this.textBoxBrand.Text;
                    currentMountainBike.Model = this.textBoxModel.Text;
                    currentMountainBike.Speed = Convert.ToInt64(this.textBoxSpeed.Text);

                    EnumColor currentColor;
                    Enum.TryParse(this.comboBoxColor.Text, out currentColor);
                    currentMountainBike.Color = currentColor;


                    Date currentDate = new Date();
                    currentDate.Month = Convert.ToInt32(this.textBoxMonth.Text);
                    currentDate.Day = Convert.ToInt32(this.textBoxDay.Text);
                    currentDate.Year = Convert.ToInt32(this.textBoxYear.Text);
                    currentMountainBike.MadeDate = currentDate;

                    currentMountainBike.HeightFromGround = Convert.ToInt32(this.textBoxHeightFromGround.Text);

                    EnumSuspension currentSuspension;
                    Enum.TryParse(this.comboBoxSuspension.Text, out currentSuspension);
                    currentMountainBike.Suspension = currentSuspension;


                    DataCollection.RemoveAt(currentIndex);
                    DataCollection.InsertAt(currentIndex, currentMountainBike);

                }

                else if (currentType == EnumType.ElectricBike)
                {
                    ElectricBike currentElectricBike = new ElectricBike();

                    currentElectricBike.Type = currentType;
                    currentElectricBike.SerialNumber = Convert.ToInt32(this.textBoxSerialNumber.Text);
                    currentElectricBike.Brand = this.textBoxBrand.Text;
                    currentElectricBike.Model = this.textBoxModel.Text;
                    currentElectricBike.Speed = Convert.ToInt64(this.textBoxSpeed.Text);

                    EnumColor currentColor;
                    Enum.TryParse(this.comboBoxColor.Text, out currentColor);
                    currentElectricBike.Color = currentColor;


                    Date currentDate = new Date();
                    currentDate.Month = Convert.ToInt32(this.textBoxMonth.Text);
                    currentDate.Day = Convert.ToInt32(this.textBoxDay.Text);
                    currentDate.Year = Convert.ToInt32(this.textBoxYear.Text);
                    currentElectricBike.MadeDate = currentDate;

                    currentElectricBike.BatteryLifeHours = Convert.ToInt32(this.textBoxBattreyLife.Text);

                    DataCollection.RemoveAt(currentIndex);
                    DataCollection.InsertAt(currentIndex, currentElectricBike);


                }


                else if (currentType == EnumType.FoldingBike)
                {
                    FoldingBike currentFoldingBike = new FoldingBike();

                    currentFoldingBike.Type = currentType;
                    currentFoldingBike.SerialNumber = Convert.ToInt32(this.textBoxSerialNumber.Text);
                    currentFoldingBike.Brand = this.textBoxBrand.Text;
                    currentFoldingBike.Model = this.textBoxModel.Text;
                    currentFoldingBike.Speed = Convert.ToInt64(this.textBoxSpeed.Text);

                    EnumColor currentColor;
                    Enum.TryParse(this.comboBoxColor.Text, out currentColor);
                    currentFoldingBike.Color = currentColor;


                    Date currentDate = new Date();
                    currentDate.Month = Convert.ToInt32(this.textBoxMonth.Text);
                    currentDate.Day = Convert.ToInt32(this.textBoxDay.Text);
                    currentDate.Year = Convert.ToInt32(this.textBoxYear.Text);
                    currentFoldingBike.MadeDate = currentDate;

                    currentFoldingBike.Weight = Convert.ToInt32(this.textBoxWeight.Text);

                    EnumFrameMaterial currentFrameMaterial;
                    Enum.TryParse(this.comboBoxSuspension.Text, out currentFrameMaterial);
                    currentFoldingBike.FrameMaterial = currentFrameMaterial;

                    DataCollection.RemoveAt(currentIndex);
                    DataCollection.InsertAt(currentIndex, currentElectricBike);


                }

            }
            else
            {
                MessageBox.Show("Choose from the listBox the item to UPDATE");
            }

            this.listBoxBike.Items.Clear();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (currentIndex >= 0 && this.listOfBikes != null)
            {
                DataCollection.ListOfBikes.RemoveAt(currentIndex);
            }
            else
            {
                MessageBox.Show("Choose from the listBox the item to REMOVE");
            }

            this.listBoxBike.Items.Clear();
        }

        private void buttonWriteToXmlFile_Click(object sender, EventArgs e)
        {
            if (DataCollection.ListOfBikes != null)
            {
                FileManager.WriteToXmlFile(DataCollection.ListOfBikes);
            }
        }

        private void buttonReadFromXmlFile_Click(object sender, EventArgs e)
        {
            this.listOfBikes.Clear();

            DataCollection.ListOfBikes = FileManager.ReadFromXmlFile();

            if ((DataCollection.ListOfBikes = FileManager.ReadFromXmlFile()) != null)
            {
                foreach (Bike currentBike in DataCollection.ListOfBikes)
                {
                    if (currentBike is RoadBike)
                    {
                        currentRoadBike = (RoadBike)currentBike;

                        this.listBoxBike.Items.Add(currentRoadBike.GetState());

                    }

                    else if (currentBike is MountainBike)
                    {
                        currentMountainBike = (MountainBike)currentBike;

                        this.listBoxBike.Items.Add(currentMountainBike.GetState());

                    }

                    else if (currentBike is ElectricBike)
                    {
                        currentElectricBike = (ElectricBike)currentBike;

                        this.listBoxBike.Items.Add(currentElectricBike.GetState());

                    }

                    else if (currentBike is FoldingBike)
                    {
                        currentFoldingBike = (FoldingBike)currentBike;

                        this.listBoxBike.Items.Add(currentFoldingBike.GetState());

                    }
                }

            }
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnumType currentType;

            Enum.TryParse(this.comboBoxType.Text, out currentType);

            if (currentType == EnumType.RoadBike)
            {
                this.textBoxSeatHeight.Enabled = true;
                this.textBoxHeightFromGround.Enabled = false;
                this.comboBoxSuspension.Enabled = false;
                this.textBoxBattreyLife.Enabled = false;
                this.textBoxWeight.Enabled = false;
                this.comboBoxFrameMaterial.Enabled = false;
            }

            else if (currentType == EnumType.MountainBike)
            {
                this.textBoxSeatHeight.Enabled = false;
                this.textBoxHeightFromGround.Enabled = true;
                this.comboBoxSuspension.Enabled = true;
                this.textBoxBattreyLife.Enabled = false;
                this.textBoxWeight.Enabled = false;
                this.comboBoxFrameMaterial.Enabled = false;
            }

            else if (currentType == EnumType.ElectricBike)
            {
                this.textBoxSeatHeight.Enabled = false;
                this.textBoxHeightFromGround.Enabled = false;
                this.comboBoxSuspension.Enabled = false;
                this.textBoxBattreyLife.Enabled = true;
                this.textBoxWeight.Enabled = false;
                this.comboBoxFrameMaterial.Enabled = false;
            }


            else if (currentType == EnumType.FoldingBike)
            {
                this.textBoxSeatHeight.Enabled = false;
                this.textBoxHeightFromGround.Enabled = false;
                this.comboBoxSuspension.Enabled = false;
                this.textBoxBattreyLife.Enabled = false;
                this.textBoxWeight.Enabled = true;
                this.comboBoxFrameMaterial.Enabled = true;
            }
        }

        private void buttonMountainBikes_Click(object sender, EventArgs e)
        {
            this.listBoxBike.Items.Clear();

            if (DataCollection.GetBikeList() != null && DataCollection.GetBikeList().Count > 0 && this.listBoxBike.Items.Count == 0)
            {
                foreach (Bike currentBike in DataCollection.GetBikeList())
                {
                    if (currentBike is MountainBike)
                    {
                        currentMountainBike = (MountainBike)currentBike;

                        this.listBoxBike.Items.Add(currentMountainBike.GetState());
                    }
                }
            }
            else
            {
                MessageBox.Show("The list of items already printed in the listBox or the list of Bikes in memory is empty....");
            }
        }



        private void buttonElectricBike_Click(object sender, EventArgs e)
        {
            this.listBoxBike.Items.Clear();

            if (DataCollection.GetBikeList() != null && DataCollection.GetBikeList().Count > 0 && this.listBoxBike.Items.Count == 0)
            {
                foreach (Bike currentBike in DataCollection.GetBikeList())
                {
                    if (currentBike is ElectricBike)
                    {
                        currentElectricBike = (ElectricBike)currentBike;

                        this.listBoxBike.Items.Add(currentElectricBike.GetState());
                    }
                }
            }
            else
            {
                MessageBox.Show("The list of items already printed in the listBox or the list of Bikes in memory is empty....");
            }
        }

        private void buttonSpeedUp_Click(object sender, EventArgs e)
        {
            if (currentIndex != -1 && listOfBikes != null && listOfBikes.Count > currentIndex)
            {
                Bike selectedBike = listOfBikes[currentIndex];
                double increment = (double)numericUpDownSpeedIncrement.Value;
                double newPotentialSpeed = selectedBike.Speed + increment;

                if (newPotentialSpeed <= selectedBike.GetMaxSpeed())
                {
                    selectedBike.Speed = newPotentialSpeed;
                    MessageBox.Show($"Speed increased to {selectedBike.Speed}.", "Speed Adjustment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateBikeListDisplay();  // Refresh the list display
                }
                else
                {
                    MessageBox.Show($"Cannot exceed maximum speed of {selectedBike.GetMaxSpeed()}!", "Speed Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select a bike first.", "No Bike Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateBikeListDisplay()
        {
            listBoxBike.Items.Clear();
            foreach (Bike bike in listOfBikes)
            {
                listBoxBike.Items.Add(bike.GetState());
            }
        }


        private void buttonPrintRoadBikes_Click(object sender, EventArgs e)
        {
            this.listBoxBike.Items.Clear();

            if (DataCollection.GetBikeList() != null && DataCollection.GetBikeList().Count > 0 && this.listBoxBike.Items.Count == 0)
            {
                foreach (Bike currentBike in DataCollection.GetBikeList())
                {
                    if (currentBike is RoadBike)
                    {
                        currentRoadBike = (RoadBike)currentBike;

                        this.listBoxBike.Items.Add(currentRoadBike.GetState());
                    }
                }
            }
            else
            {
                MessageBox.Show("The list of items already printed in the listBox or the list of Bikes in memory is empty....");
            }
        }

        private void buttonPrintFoldingBike_Click(object sender, EventArgs e)
        {
            this.listBoxBike.Items.Clear();

            if (DataCollection.GetBikeList() != null && DataCollection.GetBikeList().Count > 0 && this.listBoxBike.Items.Count == 0)
            {
                foreach (Bike currentBike in DataCollection.GetBikeList())
                {
                    if (currentBike is FoldingBike)
                    {
                        currentFoldingBike = (FoldingBike)currentBike;

                        this.listBoxBike.Items.Add(currentFoldingBike.GetState());
                    }
                }
            }
            else
            {
                MessageBox.Show("The list of items already printed in the listBox or the list of Bikes in memory is empty....");
            }
        }
    }
}