using System.Threading.Tasks;
using SendinblueMarketingAutomation.Client;
using SendinblueMarketingAutomation.Model;

namespace SendinblueMarketingAutomation.Api
{
    public class MarketingAutomationApi
    {
        public MarketingAutomationApi(Configuration config)
        {
        }

        public Task IdentifyAsync(Identify identify)
        {
            return Task.CompletedTask;
        }

        public Task TrackEventAsync(TrackEvent trackEvent)
        {
            return Task.CompletedTask;
        }

        public void TrackEvent(TrackEvent trackEvent)
        {
        }
    }
}
