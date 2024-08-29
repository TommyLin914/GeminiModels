using GeminiModels.Enums;
using Newtonsoft.Json;

namespace GeminiModels.Models.API
{
    public class SafetySettings
    {
        /// <summary> 這項設定的類別 </summary>
        [JsonProperty("category")]
        public HarmCategory Category { get; set; } = HarmCategory.HARM_CATEGORY_UNSPECIFIED;

        /// <summary> 控管造成損害的機率門檻 </summary>
        [JsonProperty("threshold")]
        public HarmBlockThreshold Threshold { get; set; } = HarmBlockThreshold.BLOCK_ONLY_HIGH;
    }
}