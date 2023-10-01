 

namespace LuvFinder_ViewModels
{
    public class Message
    {
        public int ID { get; set; }
        public int FromID { get; set; }
        public int ToID { get; set; }
        public string? Text { get; set; }
        public DateTime? Date { get; set; }
        public bool? MessageRead { get; set; }
        public DateTime? MessageReadDate { get; set; }
        public bool? DisplayOnLeft { get; set; }
    }
}
