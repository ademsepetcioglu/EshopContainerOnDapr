using System.Text.Json.Serialization;

namespace EshopContainerOnDapr.Abstractions.Model
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ResultType
    {
        Ok,
        BadRequest,
        Unexpected,
        NotFound,
        Unauthorized,
        Invalid,
        NoContent,
        InvalidModel
    }
}
