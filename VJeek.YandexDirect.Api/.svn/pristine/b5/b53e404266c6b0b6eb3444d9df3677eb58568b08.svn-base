using System.Collections.Generic;

namespace VJeek.YandexDirect.Api.Banners
{
    public class BannerPhraseInfo
    {
        public int CampaignID { get; set; }
        public int BannerId { get; set; }
        public int PhraseID { get; set; }
        public string Phrase { get; set; }
        public IsRubric IsRubric { get; set; }
        
        public int Clicks { get; set; }
        public int FirstPageClicks { get; set; }
        public int PremiumClicks { get; set; }
        public int Shows { get; set; }

        public double Price { get; set; }
        public double MinPrice { get; set; }
        public double Min { get; set; }
        public double Max { get; set; }
        public double PremiumMin { get; set; }
        public double PremiumMax { get; set; }
        public double? ContextPrice { get; set; }
        public IEnumerable<double> Prices { get; set; }

        public LowCTRWarning LowCTRWarning { get; set; }
        public LowCTR LowCTR { get; set; }
        public ContextLowCTR ContextLowCTR { get; set; }
        
        public IEnumerable<CoverageInfo> Coverage { get; set; }
        public IEnumerable<CoverageInfo> ContextCoverage { get; set; }
        
        public IEnumerable<PhraseUserParam> UserParams { get; set; }

        /*autobroker*/
        public AutoBroker AutoBroker { get; set; }
        public double? CurrentOnSearch { get; set; }

        public AutoBudgetPriority AutoBudgetPriority { get; set; }


    }
}
