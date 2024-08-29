namespace GeminiModels.Enums
{
    public enum HarmBlockThreshold
    {
        /// <summary>
        /// 未指定門檻
        /// </summary>
        HARM_BLOCK_THRESHOLD_UNSPECIFIED,
        /// <summary>
        /// 我們允許發布含有 NEGLIGIBLE 的內容
        /// </summary>
        BLOCK_LOW_AND_ABOVE,
        /// <summary>
        /// 系統允許放送內容為 NEGLIGIBLE 和 LOW 的內容
        /// </summary>
        BLOCK_MEDIUM_AND_ABOVE,
        /// <summary>
        /// 系統允許發布「NEGLIGIBLE」、「LOW」和「MEDIUM」內容
        /// </summary>
        BLOCK_ONLY_HIGH,
        /// <summary>
        /// 允許所有內容
        /// </summary>
        BLOCK_NONE
    }

}
