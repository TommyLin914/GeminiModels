namespace GeminiModels.Models.API
{
    /// <summary>
    /// 表示 Gemini API 的回應結構
    /// </summary>
    public class GeminiResponse
    {
        /// <summary>
        /// 候選回應列表
        /// </summary>
        public List<Candidate> Candidates { get; set; } = [];

        /// <summary>
        /// 表示提示詞的反饋信息
        /// </summary>
        public PromptFeedback? PromptFeedback { get; set; }

        /// <summary>
        /// 使用統計資訊
        /// </summary>
        public UsageMetadata? UsageMetadata { get; set; }
    }
}