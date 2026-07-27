using DroneFleetManager_c_.Classes;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
#pragma warning disable SYSLIB0011

namespace DroneFleetManager_c_
{
    public partial class Form1 : Form
    {
        private FleetManager fleetManager = new FleetManager();
        Drone currentMissionDrone = null;
        private int indexid = 1;
        private int Dcount = 1;
        private int Scount = 1;
        private int batterycount = 1;
        private FleetEntity selectEntity = null;


        public Form1()
        {
            InitializeComponent();
            panelMap.Paint += panelMap_Paint;
            SetupTables();
            dvgDeliveryDrones.CellClick += dvgDeliveryDrones_CellContentClick;
            dgvSurveillanceDrones.CellClick += dgvSurveillanceDrones_CellContentClick;
            dvgStation.CellClick += dvgStation_CellContentClick;
            fleetManager.BatteryLow += (message) =>
            {
                MessageBox.Show(message, "Fleet Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            };

        }

        private void SetupTables()
        {
            dvgDeliveryDrones.Columns.Add("Id", "ID");
            dvgDeliveryDrones.Columns.Add("Name", "Name");
            dvgDeliveryDrones.Columns.Add("Battery", "Battery");
            dvgDeliveryDrones.Columns.Add("Speed", "Speed");
            dvgDeliveryDrones.Columns.Add("Status", "Status");
            dvgDeliveryDrones.Columns.Add("Mission", "Mission");
            dvgDeliveryDrones.Columns.Add("MaxWeight", "Max Weight");

            dgvSurveillanceDrones.Columns.Add("Id", "ID");
            dgvSurveillanceDrones.Columns.Add("Name", "Name");
            dgvSurveillanceDrones.Columns.Add("Battery", "Battery");
            dgvSurveillanceDrones.Columns.Add("Speed", "Speed");
            dgvSurveillanceDrones.Columns.Add("Status", "Status");
            dgvSurveillanceDrones.Columns.Add("Mission", "Mission");
            dgvSurveillanceDrones.Columns.Add("CameraQuality", "Camera Quality");

            dvgStation.Columns.Add("Id", "ID");
            dvgStation.Columns.Add("Name", "Name");
            dvgStation.Columns.Add("Status", "Status");
            dvgStation.Columns.Add("Capacity", "Capacity");
            dvgStation.Columns.Add("AvailableSlots", "Available Slots");
            dvgDeliveryDrones.ReadOnly = true;
            dgvSurveillanceDrones.ReadOnly = true;
            dvgStation.ReadOnly = true;

            dvgDeliveryDrones.AllowUserToAddRows = false;
            dgvSurveillanceDrones.AllowUserToAddRows = false;
            dvgStation.AllowUserToAddRows = false;

            dvgDeliveryDrones.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvSurveillanceDrones.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dvgStation.SelectionMode = DataGridViewSelectionMode.CellSelect;

            dvgDeliveryDrones.MultiSelect = false;
            dgvSurveillanceDrones.MultiSelect = false;
            dvgStation.MultiSelect = false;

            dvgDeliveryDrones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSurveillanceDrones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgStation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgDeliveryDrones.ClearSelection();
            dgvSurveillanceDrones.ClearSelection();
            dvgStation.ClearSelection();
        }
        private void RefreshTables()
        {
            dvgDeliveryDrones.Rows.Clear();
            dgvSurveillanceDrones.Rows.Clear();
            dvgStation.Rows.Clear();

            foreach (Drone drone in fleetManager.Drones)
            {
                if (drone is DeliveryDrone delivery)
                {
                    dvgDeliveryDrones.Rows.Add(
                        delivery.Id,
                        delivery.Name,
                        delivery.Battery,
                        delivery.Speed,
                        delivery.Status,
                        delivery.CurrentMission,
                        delivery.MaxPackageWeight
                    );
                }
                else if (drone is SurveillanceDrone surveillance)
                {
                    dgvSurveillanceDrones.Rows.Add(
                        surveillance.Id,
                        surveillance.Name,
                        surveillance.Battery,
                        surveillance.Speed,
                        surveillance.Status,
                        surveillance.CurrentMission,
                        surveillance.CameraQuality
                    );
                }
            }

            foreach (ChargingStation station in fleetManager.Stations)
            {
                dvgStation.Rows.Add(
                    station.Id,
                    station.Name,
                    station.Status,
                    station.Capacity,
                    station.AvailableSlots
                );
            }
            dvgDeliveryDrones.ClearSelection();
            dgvSurveillanceDrones.ClearSelection();
            dvgStation.ClearSelection();
        }
        private void btnAddDeliivery_Click(object sender, EventArgs e)
        {
            int id = indexid++;
            int x = 220 - (Dcount * 20);
            int y = 120 + (Dcount * 90);
            DeliveryDrone drone = new DeliveryDrone(id, "Delivery-" + Dcount++, 100, 40, 5.0, x, y);
            fleetManager.AddDrone(drone);
            RefreshTables();
            panelMap.Invalidate();
            MessageBox.Show("Delivery drone added successfully");
        }

        private void dvgDrones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddSurveillance_Click(object sender, EventArgs e)
        {
            int id = indexid++;
            int x = 1280 + (Scount * 20);
            int y = 120 + (Scount * 90);
            SurveillanceDrone drone = new SurveillanceDrone(id, "Surveillance-" + Scount++, 100, 35, "HD", x, y);
            fleetManager.AddDrone(drone);
            RefreshTables();
            panelMap.Invalidate();
            MessageBox.Show("Surveillance drone added successfully");
        }

        private void btnAddStation_Click(object sender, EventArgs e)
        {

        }
        private void btnAssignMission_Click(object sender, EventArgs e)
        {

        }

        private void panelMap_Paint(object sender, PaintEventArgs e)
        {
            foreach (FleetEntity entity in fleetManager.Entities)
            {
                entity.Draw(e.Graphics);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            FleetEntity selected = selectEntity;
            if (selected == null)
            {
                MessageBox.Show("Please select an object to delete");
                return;
            }
            fleetManager.Entities.Remove(selected);
            if (selected is Drone drone)
            {
                fleetManager.Drones.Remove(drone);
            }
            if (selected is ChargingStation station)
            {
                fleetManager.Stations.Remove(station);
            }
            selectEntity = null;
            RefreshTables();
            panelMap.Invalidate();
            MessageBox.Show("Object deleted successfully");
        }

        private void btnMoveSelected_Click(object sender, EventArgs e)
        {
            FleetEntity selected = selectEntity;
            if (selected == null)
            {
                MessageBox.Show("Please select an object to move");
                return;
            }

            selected.X += 20;
            selected.Y += 20;
            RefreshTables();
            panelMap.Invalidate();

        }

        private void btnAssignMission_Click_1(object sender, EventArgs e)
        {
            if (currentMissionDrone != null)
            {
                MessageBox.Show("Another mission is already in progress");
                return;
            }
            FleetEntity selected = selectEntity;
            if (selected == null)
            {
                MessageBox.Show("Please select a drone");
                return;
            }
            if (selected is Drone drone)
            {
                if(drone.Status!="Available")
                {
                    MessageBox.Show("Drone is not available for mission");
                    return;
                }
                
                fleetManager.AssignMissionToDrone(drone, "New Mission");

                RefreshTables();
                panelMap.Invalidate();

                if (drone.Status == "Battery Too Low" )
                {
                    currentMissionDrone = null;
                    return;
                }
                else
                {
                    currentMissionDrone = drone;
                    missionTimer.Start();
                    MessageBox.Show("Mission in progress......");
                }
            }
            else
            {
                MessageBox.Show("Only drones can receive missions");
            }
        }


        private void dvgStation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int id = Convert.ToInt32(dvgStation.Rows[e.RowIndex].Cells["Id"].Value);

            selectEntity = fleetManager.Entities.FirstOrDefault(entity => entity.Id == id);
        }

        private void dgvSurveillanceDrones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;



            int id = Convert.ToInt32(dgvSurveillanceDrones.Rows[e.RowIndex].Cells["Id"].Value);

            selectEntity = fleetManager.Entities.FirstOrDefault(entity => entity.Id == id);
        }

        private void dvgDeliveryDrones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;



            int id = Convert.ToInt32(dvgDeliveryDrones.Rows[e.RowIndex].Cells["Id"].Value);

            selectEntity = fleetManager.Entities.FirstOrDefault(entity => entity.Id == id);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Drone Fleet File|*.dat";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create);

                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fileStream, fleetManager);

                fileStream.Close();

                MessageBox.Show("System saved successfully");
            }

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Drone Fleet File|*.dat";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open);

#pragma warning disable SYSLIB0011
                BinaryFormatter formatter = new BinaryFormatter();
                fleetManager = (FleetManager)formatter.Deserialize(fileStream);
                if (fleetManager.Entities.Count==0)
                {
                    indexid = 1;
                }
                else
                {
                    indexid = fleetManager.Entities.Max(entity => entity.Id) + 1;
                }

#pragma warning restore SYSLIB0011
                    selectEntity = null;

                fileStream.Close();
                fleetManager.BatteryLow += (message) =>
                {
                    MessageBox.Show(message, "Fleet Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                };
                RefreshTables();
                panelMap.Invalidate();

                MessageBox.Show("System loaded successfully");
            }

        }

        private void btnChargeDrone_Click(object sender, EventArgs e)
        {
            FleetEntity selected = selectEntity;
            if (selected == null)
            {
                MessageBox.Show("Please select a drone to charge");
                return;
            }

            if (selected is Drone drone)
            {
                if (drone.CurrentMission != "None")
                {
                    MessageBox.Show(" A drone cannot be charged while a mission is in progress");
                    return;
                }

                if (fleetManager.Stations.Count == 0)
                {
                    MessageBox.Show("No charging stations available");
                    return;
                }


                ChargingStation availableStation = fleetManager.Stations.FirstOrDefault(s => s.AvailableSlots > 0);

                if (availableStation == null)
                {
                    MessageBox.Show("All charging stations are currently full!");
                    return;
                }


                availableStation.ChargeDrone(drone);

                RefreshTables();
                panelMap.Invalidate();
                MessageBox.Show($"Drone charged successfully at {availableStation.Name}");
            }
            else
            {
                MessageBox.Show("Only drones can be charged");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnstation_Click(object sender, EventArgs e)
        {
            int id = indexid++;
            int x = 1135 - (batterycount * 70);
            int y = 300;
            ChargingStation station = new ChargingStation(id, "station-" + batterycount++, 4, x, y);
            fleetManager.AddStation(station);
            RefreshTables();
            panelMap.Invalidate();
            MessageBox.Show("Charging station added successfully");
        }

        private void btnAutoAssign_Click(object sender, EventArgs e)
        {
            if (currentMissionDrone != null)
            {
                MessageBox.Show("Another mission is already in progress");
                return;
            }
            Drone bestDrone = fleetManager.GetBestAvailableDrone();
            if (bestDrone == null)
            {
                MessageBox.Show("No available drone with enough battery");
                return;
            }
            fleetManager.AssignMissionToDrone(bestDrone, "Auto Mission");
            RefreshTables();
            panelMap.Invalidate();
            currentMissionDrone = bestDrone;
            missionTimer.Start();
            MessageBox.Show("Mission in progress......");
            
        }

        private void missionTimer_Tick(object sender, EventArgs e)
        {
           
            missionTimer.Stop();
            if (currentMissionDrone!=null)
            {
                currentMissionDrone.CompleteMission();
                currentMissionDrone = null;
                RefreshTables();
                MessageBox.Show("Mission Completed Successfully");
            }
        }
    }
}
