using ToDoList.Communication.Responses;

namespace ToDoList.Application.UseCases.ToDo.GetAll;
public class GetAllToDoUseCase
{
  public ResponseAllToDoJson Execute()
  {
    return new ResponseAllToDoJson
    {
      ToDoList = new List<ResponseShortToDoJson>
      {
        new ResponseShortToDoJson
        {
          Name = "Jogar Bola",
          Deadline = "10/02/2025",
          Priority = Communication.Enums.Priority.low.ToString(),
          Status = Communication.Enums.Status.waiting.ToString()
        },
        new ResponseShortToDoJson
        {
          Name = "Malhar",
          Deadline = "06/02/2025",
          Priority = Communication.Enums.Priority.high.ToString(),
          Status = Communication.Enums.Status.in_progress.ToString()
        }
      }
    };
  }
}