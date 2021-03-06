﻿using System.Collections.Generic;

namespace VJeek.YandexDirect.Api.Banners
{
    public class BannerInfo
    {
        public int BannerID { get; set; }
        public int CampaignID { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Href { get; set; }
        public string Domain { get; set; }
        public string Geo { get; set; }
        public ContactInfo ContactInfo { get; set; }
        public List<BannerPhraseInfo> Phrases { get; set; }
        public StatusActivating StatusActivating { get; set; }
        public StatusArchive StatusArchive { get; set; }
        public StatusBannerModerate StatusBannerModerate { get; set; }
        public StatusPhrasesModerate StatusPhrasesModerate { get; set; }
        public StatusPhoneModerate StatusPhoneModerate { get; set; }
        public StatusShow StatusShow { get; set; }
        public IsActive IsActive { get; set; }
        public StatusSitelinksModerate StatusSitelinksModerate { get; set; }
        public IEnumerable<SiteLink> SiteLinks { get; set; }
        public IEnumerable<string> AdWarnings { get; set; }
        public FixedOnModeration FixedOnModeration { get; set; }
        public IEnumerable<RejectReason> ModerateRejectionReasons { get; set; }
        public IEnumerable<string> MinusKeywords { get; set; }
        public string AutoMinusWords { get; set; }
    }
}
