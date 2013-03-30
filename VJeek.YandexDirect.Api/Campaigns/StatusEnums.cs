using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace VJeek.YandexDirect.Api.Campaigns
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StatusShow : int
    {
        Yes,
        No
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StatusArchive:int
    {
        Yes,
        No, 
        Pending
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StatusActivating:int
    {
        Yes,
        No,
        Pending
    }
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StatusModerate:int
    {
        Yes,
        No,
        New,
        Pending
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum IsActive:int
    {
        Yes,
        No
    }
}
