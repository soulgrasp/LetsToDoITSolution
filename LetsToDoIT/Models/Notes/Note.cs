namespace LetsToDoIT.Models.Notes
{
    public class Note
    {
        public int Id { get; set; }

        // Title
        public string Title { get; set; }

        // IsCompleted
        public bool IsCompleted { get; set; }

        // Timestamp
        public DateTime Created { get; set; }

        // Author
        public string AuthorName {  get; set; }
        

    }
}
