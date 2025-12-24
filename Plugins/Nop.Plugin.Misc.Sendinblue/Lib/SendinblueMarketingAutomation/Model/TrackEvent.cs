namespace SendinblueMarketingAutomation.Model
{
    public class TrackEvent
    {
        public TrackEvent(string email, string eventName, object eventData = null)
        {
            Email = email;
            EventName = eventName;
            EventData = eventData;
        }

        public string Email { get; set; }
        public string EventName { get; set; }
        public object EventData { get; set; }
    }
}
