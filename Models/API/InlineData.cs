using Newtonsoft.Json;

namespace GeminiModels.Models.API
{
    /// <summary>
    /// 表示內聯數據,用於圖片等二進制數據
    /// </summary>
    public class InlineData
    {
        /// <summary>
        /// 數據的MIME類型
        /// </summary>
        [JsonProperty("mime_type")]
        public string? MimeType { get; set; }

        /// <summary>
        /// Base64編碼的數據
        /// </summary>
        [JsonProperty("data")]
        public string? Data { get; set; }
    }
}