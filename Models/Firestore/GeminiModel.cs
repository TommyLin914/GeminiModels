using Google.Cloud.Firestore;

namespace GeminiModels.Models.Firestore
{
    /// <summary>
    /// 紀錄聊天訊息
    /// </summary>
    [FirestoreData]
    public class GeminiModel : BaseModel
    {
        /// <summary>
        /// 頻道ID
        /// </summary>
        [FirestoreProperty]
        public ulong ChannelId { get; set; }

        /// <summary>
        /// 問答訊息內容
        /// </summary>
        [FirestoreProperty]
        public List<FirestoreContent> Contents { get; set; } = [];

        /// <summary>
        /// 聊天紀錄狀態
        /// </summary>
        [FirestoreProperty]
        public bool IsActive { get; set; }
    }

    [FirestoreData]
    public class FirestoreContent
    {
        /// <summary>
        /// 文本內容
        /// </summary>
        [FirestoreProperty]
        public string? Text { get; set; }

        /// <summary>
        /// 圖片資訊
        /// </summary>
        [FirestoreProperty]
        public List<FirestoreInlineData>? InlineData { get; set; }

        [FirestoreProperty]
        public Timestamp Timestamp { get; set; }

        [FirestoreProperty]
        public string Role { get; set; } = null!;
    }

    [FirestoreData]
    public class FirestoreInlineData
    {
        /// <summary>
        /// 數據的MIME類型
        /// </summary>
        [FirestoreProperty]
        public string? MimeType { get; set; }

        /// <summary>
        /// Base64編碼的數據
        /// </summary>
        [FirestoreProperty]
        public string? Data { get; set; }
    }


}
