namespace GeminiModels.Models.API
{
    /// <summary>
    /// 表示提示詞的反饋信息
    /// </summary>
    public class PromptFeedback
    {
        /// <summary>
        /// 安全評級列表，包含對提示詞的各種安全性評估
        /// </summary>
        public List<SafetyRating> SafetyRatings { get; set; } = [];
    }
}