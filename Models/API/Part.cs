using Newtonsoft.Json;

namespace GeminiModels.Models.API
{
    /// <summary>
    /// 表示內容的一個部分
    /// </summary>
    public class Part
    {
        /// <summary>
        /// 文本內容
        /// </summary>
        [JsonProperty("text")]
        public string? Text { get; set; }

        [JsonProperty("inline_data")]
        public InlineData? InlineData { get; set; }
    }

}