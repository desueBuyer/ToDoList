namespace ToDoList
{
    public class ToDoItem
    {
        public string Title {  get; set; }
        public string? Description {  get; set; }
        public string Status { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? CompletionDate { get; set; }

    }
}
