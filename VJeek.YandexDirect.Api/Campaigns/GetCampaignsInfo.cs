using System.Collections.Generic;

namespace VJeek.YandexDirect.Api.Campaigns
{
    public class GetCampaignsInfo
    {
        public IEnumerable<string> Logins { get; set; }
        public CampaignsFilterInfo Filter { get; set; }

        public int? Limit { get; set; }

        public int? Offset { get; set; }
    }
}
