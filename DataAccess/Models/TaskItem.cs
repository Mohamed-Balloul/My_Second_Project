namespace NTierTodoApp.Models 
{
    /// <summary>
    /// يمثل نموذج المهمة.
    /// </summary>
    public class TaskItem
    {
        public int Id { get; set; }
        //ملاحظة:قمت بهذا التعديل لاني أستخدم .NET 6
        public string Title { get; set; } = string.Empty;
        public bool IsComplete { get; set; }
    }
} 