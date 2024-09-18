using System.Runtime.Serialization;

namespace PracticeSignalR.Models
{
    public class ChartPoint
    {
        public string Label { get; set; }
        public int Y { get; set; }

        public ChartPoint(string label, int y)
        {
            Label = label;
            Y = y;
        }
    }
}
