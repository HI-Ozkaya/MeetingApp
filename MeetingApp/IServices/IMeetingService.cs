using MeetingApp.Models;

namespace MeetingMVC.IServices
{
    public interface IMeetingService
    {
        Task<bool>  SaveMeeting(Meeting meet);
    }
}
