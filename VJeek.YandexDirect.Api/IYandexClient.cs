using System.Collections.Generic;
using VJeek.YandexDirect.Api.Banners;
using VJeek.YandexDirect.Api.Campaigns;
using VJeek.YandexDirect.Api.Clients;
using VJeek.YandexDirect.Api.OAuth;

namespace VJeek.YandexDirect.Api
{
    public interface IYandexClient
    {
        string AuthToken { get; set; }
        string Login { get; set; }
        IEnumerable<ClientInfo> GetClientInfo(IEnumerable<string> logins);
        IEnumerable<ShortCampaignInfo> GetCampaignList(IEnumerable<string> logins);
        IEnumerable<ShortCampaignInfo> GetCampaignsListFilter(GetCampaignsInfo filter);
        IEnumerable<BannerInfo> GetBanners(GetBannersInfo filter);
        void GetBanners();

        IEnumerable<int> CreateOrUpdateBanners(IEnumerable<BannerInfo> banners);
        int StopBanners(CampaignBidsInfo info);
        int ArchiveBanners(CampaignBidsInfo info);

        AccessTokenResponse GetAuthToken(string confirmationCode);
    }
}
