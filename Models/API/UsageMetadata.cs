namespace GeminiModels.Models.API
{
    /// <summary>
    /// 表示使用統計資訊
    /// </summary>
    public class UsageMetadata
    {
        /// <summary>
        /// 提示詞的 token 數量
        /// </summary>
        public int PromptTokenCount { get; set; }

        /// <summary>
        /// 候選回應的 token 總數
        /// </summary>
        public int CandidatesTokenCount { get; set; }

        /// <summary>
        /// 總 token 數量
        /// </summary>
        public int TotalTokenCount { get; set; }
    }
}
