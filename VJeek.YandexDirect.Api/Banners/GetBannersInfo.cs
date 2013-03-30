using System.Collections.Generic;

namespace VJeek.YandexDirect.Api.Banners
{
    public class GetBannersInfo
    {
        public IEnumerable<int> CampaignIDS { get; set; }

        public BannersFilterInfo Filter { get; set; }

        public GetPhrases GetPhrases { get; set; }

        public int? Limit { get; set; }

        public int? Offset { get; set; }
    }
}
