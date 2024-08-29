using Newtonsoft.Json;

namespace GeminiModels.Models.API
{
    /// <summary>
    /// 表示回應的內容
    /// </summary>
    public class Content
    {
        /// <summary>
        /// 內容部分列表
        /// </summary>
        [JsonProperty("parts")]
        public List<Part> Parts { get; set; } = [];

        /// <summary>
        /// 內容的角色
        /// </summary>
        [JsonProperty("role")]
        public string Role { get; set; } = string.Empty;
    }

}