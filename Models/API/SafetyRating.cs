using GeminiModels.Enums;

namespace GeminiModels.Models.API
{
    /// <summary>
    /// 表示單個安全評級
    /// </summary>
    public class SafetyRating
    {
        /// <summary>
        /// 安全評級的類別，例如 "HARM_CATEGORY_SEXUALLY_EXPLICIT", "HARM_CATEGORY_HATE_SPEECH" 等
        /// </summary>
        public HarmCategory Category { get; set; }

        /// <summary>
        /// 該類別的概率評估，例如 "NEGLIGIBLE", "LOW", "MEDIUM", "HIGH" 等
        /// </summary>
        public HarmProbability Probability { get; set; }

        public bool? Blocked { get; set; }
    }
}