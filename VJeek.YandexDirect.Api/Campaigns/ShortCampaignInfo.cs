﻿using System;

namespace VJeek.YandexDirect.Api.Campaigns
{
    public class ShortCampaignInfo
    {
        public int CampaignID { get; set; }
        public string Login { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public string StrategyName { get; set; }
        public string ContextStrategyName { get; set; }
        public double Sum { get; set; }
        public double Rest { get; set; }
        public double SumAvailableForTransfer { get; set; }
        public int Shows { get; set; }
        public int Clicks { get; set; }
        public string Status { get; set; }
        public StatusShow StatusShow { get; set; }
        public StatusArchive StatusArchive { get; set; }
        public StatusActivating StatusActivating { get; set; }
        public StatusModerate StatusModerate { get; set; }
        public IsActive IsActive { get; set; }
        public string ManagerName { get; set; }
        public string AgencyName { get; set; }
    }
}
