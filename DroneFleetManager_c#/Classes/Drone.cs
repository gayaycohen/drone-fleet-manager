//using System.Runtime.Versioning;

namespace DroneFleetManager_c_.Classes
{
    [Serializable]
    public abstract class Drone : FleetEntity   
    {
        public int Battery { get; set; } 
        public double Speed { get; set; }   
        public string CurrentMission { get; set; } 
        public Drone (int id,string name ,string status,int battery,double speed,int x,int y)   
            :base (id,name,status,x,y)
        {
            Battery = battery;
            Speed = speed;
            CurrentMission = "None";
        }
        public void Charge()    
        {
            Battery = 100;
            Status = "Available";
        }
        public abstract void AssignMission(string mission);      
        public void CompleteMission()
        {
            CurrentMission = "None";
            Status = "Available";
        }
    }
}
