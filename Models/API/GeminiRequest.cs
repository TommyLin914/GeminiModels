using Newtonsoft.Json;

namespace GeminiModels.Models.API
{
    public class GeminiRequest
    {
        /// <summary>
        /// 目前與模型對話的內容。
        /// 如果是單輪查詢，這只是單一例項。 
        /// 若是多輪查詢(例如 chat)，這個重複欄位會包含對話記錄和最新的要求。
        /// </summary>
        [JsonProperty("contents")]
        public List<Content> Contents { get; set; } = [];

        /// <summary>
        /// 模型產生和輸出的設定選項
        /// </summary>
        [JsonProperty("generationConfig")]
        public GenerationConfig? GenerationConfig { get; set; }

        /// <summary>
        /// 用於封鎖不安全內容的不重複 SafetySetting 執行個體清單。
        /// </summary>
        [JsonProperty("safetySettings")]
        public SafetySettings[]? SafetySettings { get; set; }
    }
}