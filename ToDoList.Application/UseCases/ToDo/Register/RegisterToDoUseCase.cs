using ToDoList.Communication.Requests;
using ToDoList.Communication.Responses;

namespace ToDoList.Application.UseCases.ToDo.Register;
public class RegisterToDoUseCase
{
  public ResponseRegisterToDoJson Execute(RequestToDoListJson request)
  {
    return new ResponseRegisterToDoJson
    {
      Id = request.Id,
      Name = request.Name
    };
  }
}
