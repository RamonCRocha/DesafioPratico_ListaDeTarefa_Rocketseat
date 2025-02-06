namespace ToDoList.Communication.Responses;
public class ResponseToDoJson
{
  public int Id { get; set; }
  public string Name { get; set; } = string.Empty;
  public string Description { get; set; } = string.Empty;
  public string Priority { get; set; } = string.Empty;
  public string Status { get; set; } = string.Empty;
  public string Deadline { get; set; } = string.Empty;
}
