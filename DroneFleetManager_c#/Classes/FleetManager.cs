using System;
using System.Collections.Generic;

namespace DroneFleetManager_c_.Classes
{
    [Serializable]
    public class FleetManager  
    {
        public List<Drone> Drones { get; set; }  
        public List<ChargingStation> Stations { get; set; } 
        public List<FleetEntity> Entities { get; set; }
        [field: NonSerialized]
        public event Action<string> BatteryLow; 
        public FleetManager()
        {
            Drones = new List<Drone>();
            Stations = new List<ChargingStation>();
            Entities = new List<FleetEntity>();
        }
        public void AddDrone(Drone drone)            
        {
            Drones.Add(drone);
            Entities.Add(drone);
        }
        public void RemoveDrone(Drone drone)       
        {
            Drones.Remove(drone);
            Entities.Remove(drone);
        }
        public void AddStation(ChargingStation station)    
        {
            Stations.Add(station);
            Entities.Add(station);
        }
        public void AssignMissionToDrone(Drone drone,string mission)  
        {
            if (drone.Battery<20)
            {
                drone.Status = "Battery Too Low";
                BatteryLow?.Invoke($"{drone.Name} battery is too low");
                return;
            }
            drone.AssignMission(mission);
            if (drone.Battery < 20)
            { 
            BatteryLow?.Invoke($"{drone.Name} battery is too low");
            }
        }
        public Drone GetBestAvailableDrone()
        {
            Drone bestDrone = null;
            foreach(Drone drone in Drones)
            {
                if(drone.Status=="Available"&&drone.Battery>=20)
                {
                    if (bestDrone==null||drone.Battery>bestDrone.Battery)
                    {
                        bestDrone = drone;
                    }
                }
            }
            return bestDrone;
        }
    }
}
