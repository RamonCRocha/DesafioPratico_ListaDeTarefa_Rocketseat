using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Application.UseCases.ToDo.Delete;
using ToDoList.Application.UseCases.ToDo.GetAll;
using ToDoList.Application.UseCases.ToDo.GetById;
using ToDoList.Application.UseCases.ToDo.Register;
using ToDoList.Application.UseCases.ToDo.Update;
using ToDoList.Communication.Requests;
using ToDoList.Communication.Responses;

namespace ToDoList.Api.Controllers;
[Route("[controller]")]
[ApiController]
public class ToDoController : ControllerBase
{

  [HttpPost]
  [ProducesResponseType(typeof(ResponseRegisterToDoJson), StatusCodes.Status201Created)]
  [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
  public IActionResult Register([FromBody] RequestToDoListJson request)
  {
    var response = new RegisterToDoUseCase().Execute(request);

    return Created(string.Empty, response);
  }

  [HttpPut]
  [Route("{id}")]
  [ProducesResponseType(StatusCodes.Status204NoContent)]
  [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
  public IActionResult Update([FromRoute] int id, [FromBody] RequestToDoListJson request)
  {
    var useCase = new UpdateToDoByIdUseCase();

    useCase.Execute(id, request);

    return NoContent();
  }

  [HttpGet]
  [ProducesResponseType(typeof(ResponseAllToDoJson), StatusCodes.Status200OK)]
  [ProducesResponseType(StatusCodes.Status204NoContent)]
  public IActionResult GetAll()
  {
    var response = new GetAllToDoUseCase().Execute();

    if(!response.ToDoList.Any())
      return NoContent();

    return Ok(response);
  }

  [HttpGet]
  [Route("{id}")]
  [ProducesResponseType(typeof(ResponseToDoJson), StatusCodes.Status200OK)]
  [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
  public IActionResult Get(int id)
  {
    var response = new GetToDoByIdUseCase().Execute(id);

    //Retorno provisório. 
    //Posteriormente ficará pela responsabilidade da regra de negócio
    if (response == null) 
      return NotFound();

    return Ok(response);
  }

  [HttpDelete]
  [Route("{id}")]
  [ProducesResponseType(StatusCodes.Status204NoContent)]
  [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
  public IActionResult Delete(int id)
  {
    var useCase = new DeleteToDoByIdUseCase();

    //Retorno provisório. 
    //Posteriormente ficará pela responsabilidade da regra de negócio.
    if (useCase == null)
      return NotFound();

    useCase.Execute(id);

    return NoContent();
  }
}
