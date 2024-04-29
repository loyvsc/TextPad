namespace TextPad.Models
{
    public class Note
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public DateTime ChangedDate { get; set; }

        public Note()
        {
            Name = "Новая заметка";
            Text = string.Empty;
            ChangedDate = DateTime.Now;
        }

        public Note(string name, string text, DateTime changedDate)
        {
            Name = name;
            Text = text;
            ChangedDate = changedDate;
        }
    }
}
