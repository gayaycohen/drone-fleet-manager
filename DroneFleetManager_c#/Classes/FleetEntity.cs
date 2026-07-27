using System.Drawing;
namespace DroneFleetManager_c_.Classes
{
    [Serializable]
    public abstract class FleetEntity     //מחלקת בסיס אבסטרקטית לכל האובייקטים במערכת
    {
        public int X { get; set; }
        public int Y { get; set; }
        public abstract void Draw(Graphics g);
        public int Id { get; set; }      
        public string Name { get; set; }  
        public string Status { get; set; } 
        public FleetEntity(int id,string name,string status,int x,int y) 
        {
            Id = id;
            Name = name;
            Status = status;
            Y = y;
            X = x;
        }
        public abstract string GetInfo();        
        public override string ToString()
        {
            return GetInfo();
        }
    }
}
