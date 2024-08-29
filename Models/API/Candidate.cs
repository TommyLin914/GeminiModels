namespace GeminiModels.Models.API
{
    /// <summary>
    /// 表示一個候選回應
    /// </summary>
    public class Candidate
    {
        /// <summary>
        /// 回應內容
        /// </summary>
        public Content Content { get; set; } = new Content();

        /// <summary>
        /// 回應結束原因
        /// </summary>
        public string FinishReason { get; set; } = string.Empty;

        /// <summary>
        /// 候選回應的索引
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// 安全評級列表
        /// </summary>
        public List<SafetyRating> SafetyRatings { get; set; } = [];
    }

}