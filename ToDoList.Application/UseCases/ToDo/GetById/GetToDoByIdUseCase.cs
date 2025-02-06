using ToDoList.Communication.Responses;

namespace ToDoList.Application.UseCases.ToDo.GetById;
public class GetToDoByIdUseCase
{
  public ResponseToDoJson Execute(int id)
  {
    return new ResponseToDoJson
    {
      Id = id,
      Name = "Jogar Bola",
      Description = "Campo da vila do sapo",
      Deadline = "07/02/2025",
      Status = Communication.Enums.Status.completed.ToString(),
      Priority = Communication.Enums.Priority.medium.ToString()
    };
  }
}
