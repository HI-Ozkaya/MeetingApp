namespace MeetingApp.Models
{
    public class Meeting
    {
        public int Id { get; set; }
        public string Topic { get; set; }
        public DateTime MeetingDate { get; set; }
        public short StartTime { get; set; }
        public short EndTime { get; set; }
        public List<Participant> Participants { get; set; }
    }
}
