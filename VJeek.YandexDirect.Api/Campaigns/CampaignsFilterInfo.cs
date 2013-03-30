using System.Collections.Generic;

namespace VJeek.YandexDirect.Api.Campaigns
{
    public class CampaignsFilterInfo
    {
        public IEnumerable<StatusModerate> StatusModerate { get; set; }

        public IEnumerable<IsActive> IsActive { get; set; }

        public IEnumerable<StatusArchive> StatusArchive { get; set; }

        public IEnumerable<StatusActivating> StatusActivating { get; set; }

        public IEnumerable<StatusShow> StatusShow { get; set; }


    }
}
