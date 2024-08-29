namespace GeminiModels.Enums
{
    public enum HarmCategory
    {
        /// <summary>
        /// 未指定類別
        /// </summary>
        HARM_CATEGORY_UNSPECIFIED,

        /// <summary>
        /// 針對特定身分和/或受保護屬性發表負面或有害言論
        /// </summary>
        HARM_CATEGORY_DEROGATORY,

        /// <summary>
        /// 粗魯無禮、不尊重或不雅的內容
        /// </summary>
        HARM_CATEGORY_TOXICITY,

        /// <summary>
        /// 描述對個人或群體施暴的情境，或描述血腥的血腥描述
        /// </summary>
        HARM_CATEGORY_VIOLENCE,

        /// <summary>
        /// 提及性行為或其他猥褻情事的內容
        /// </summary>
        HARM_CATEGORY_SEXUAL,

        /// <summary>
        /// 宣傳未經證實的醫療建議
        /// </summary>
        HARM_CATEGORY_MEDICAL,

        /// <summary>
        /// 宣傳、鼓吹或助長有害舉動的「危險內容」
        /// </summary>
        HARM_CATEGORY_DANGEROUS,

        /// <summary>
        /// 騷擾內容
        /// </summary>
        HARM_CATEGORY_HARASSMENT,

        /// <summary>
        /// 仇恨言論和內容
        /// </summary>
        HARM_CATEGORY_HATE_SPEECH,

        /// <summary>
        /// 情色露骨內容
        /// </summary>
        HARM_CATEGORY_SEXUALLY_EXPLICIT,

        /// <summary>
        /// 危險內容
        /// </summary>
        HARM_CATEGORY_DANGEROUS_CONTENT

    }

}
