using MeetingApp.Models;
using MeetingMVC.IServices;
using Newtonsoft.Json;
using RestSharp;

namespace MeetingMVC.Services
{
    public class MeetingService : IMeetingService
    {
        public async Task<bool> SaveMeeting(Meeting meet)
        {
            try
            {
                var client = new RestClient("https://localhost:7021/api/Meetings/postMeeting");
                var request = new RestRequest();

                request.Method = Method.Post;
                request.AddHeader("Content-Type", "application/json");
                request.RequestFormat = DataFormat.Json;
                request.AddJsonBody(meet);

                var res = await client.ExecuteAsync(request);

                if (res.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    if (JsonConvert.DeserializeObject<bool>(res.Content))
                        return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
