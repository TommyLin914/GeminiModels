namespace GeminiModels.Models.Firestore
{
    public abstract class BaseModel
    {
        /// <summary>
        /// Firestore 文件 ID
        /// </summary>
        public string Id { get; set; } = null!;
    }
}
