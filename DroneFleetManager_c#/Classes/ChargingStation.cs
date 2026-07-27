using System.Drawing;

namespace DroneFleetManager_c_.Classes
{
    [Serializable]
    public class ChargingStation : FleetEntity  
    {
        public int Capacity { get; set; }  
        public int AvailableSlots { get; set; }    
        public ChargingStation (int id,string name,int capacity,int x,int y)
            :base (id,name,"Active",x,y)
        {
            Capacity = capacity;
            AvailableSlots = capacity;
        }
        public void ChargeDrone(Drone drone)
        {
            if(AvailableSlots>0)
            {
                AvailableSlots--;
                drone.Charge();
                AvailableSlots++;
            }
        }
        public override string GetInfo()
        {
            return $"Charging Station  | ID: {Id},Name: {Name},Status: {Status},Capacity: {Capacity},Available Slots: {AvailableSlots}";
        }
        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 2);
            Brush stationBrush = Brushes.Gray;
            Brush screenBrush = Brushes.Black;
            Brush lightBrush = Brushes.White;
            g.FillRectangle(stationBrush, X, Y, 45, 70);
            g.DrawRectangle(pen, X, Y, 45, 70);
            g.FillRectangle(screenBrush, X + 10, Y + 10, 25, 35);
            g.DrawRectangle(Pens.White, X + 10, Y + 10, 25, 35);
            g.DrawString("⚡", new Font("Segoe UI", 18, FontStyle.Bold), lightBrush, X + 8, Y + 4);
            g.FillRectangle(Brushes.Gray, X - 5, Y + 70, 55, 10);
            g.DrawRectangle(pen, X - 5, Y + 70, 55, 10);
        }
    }
}
