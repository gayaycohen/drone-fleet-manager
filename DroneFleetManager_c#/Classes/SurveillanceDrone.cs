using System.Drawing;

namespace DroneFleetManager_c_.Classes
{
    [Serializable]
    public class SurveillanceDrone : Drone        
    {
        public string CameraQuality { get; set; }  
        public SurveillanceDrone (int id,string name,int battery,double speed,string cameraQuality,int x,int y)
            :base (id,name,"Available",battery,speed,x,y)
        {
            CameraQuality = cameraQuality;
        }
        public override void AssignMission(string mission)
        {
            if (Battery < 20)
            {
                Status = "Battery Too Low";
                return;
            }
            CurrentMission = mission;
            Status = "On Surveillance Mission";
            Battery = Battery - 15;
        }
        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 2);
            Brush bodyBrush = Brushes.Black;
            g.FillRectangle(bodyBrush, X + 20, Y + 20, 30, 20);
            g.DrawRectangle(pen, X + 20, Y + 20, 30, 20);
            g.DrawLine(pen, X + 20, Y + 20, X, Y);
            g.DrawLine(pen, X + 50, Y + 20, X + 70, Y);
            g.DrawLine(pen, X + 20, Y + 40, X, Y + 60);
            g.DrawLine(pen, X + 50, Y + 40, X + 70, Y + 60);
            g.DrawEllipse(pen, X - 8, Y - 8, 16, 16);
            g.DrawEllipse(pen, X + 62, Y - 8, 16, 16);
            g.DrawEllipse(pen, X - 8, Y + 52, 16, 16);
            g.DrawEllipse(pen, X + 62, Y + 52, 16, 16);
            g.DrawString("S", new Font("Segoe UI", 8, FontStyle.Bold), Brushes.White, X + 28, Y + 20);
        }
        public override string GetInfo()
        {
            return $"Surveillance Drone  | ID:{Id},Name:{Name},Battery:{Battery}%,Status:{Status},Mission:{CurrentMission},Camera:{CameraQuality}";
        }
    }
}
