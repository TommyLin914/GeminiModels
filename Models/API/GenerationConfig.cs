using Newtonsoft.Json;

namespace GeminiModels.Models.API
{
    public class GenerationConfig
    {
        [JsonProperty("stopSequences")]
        public List<string>? StopSequences { get; set; }

        [JsonProperty("responseMimeType")]
        public string? ResponseMimeType { get; set; }

        /// <summary> 回應上限 </summary>
        [JsonProperty("maxOutputTokens")]
        public int? MaxOutputTokens { get; set; }

        /// <summary> 
        /// 控管輸出內容的隨機程度
        /// (精確 ~ 創造力)
        /// 0 ~ 2
        /// </summary>
        [JsonProperty("temperature")]
        public int? Temperature { get; set; }

    }
}