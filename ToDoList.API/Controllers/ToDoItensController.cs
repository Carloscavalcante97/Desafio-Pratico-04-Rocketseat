using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Applications.ToDoList.UseCases.Create;
using ToDoList.Applications.ToDoList.UseCases.DeleteById;
using ToDoList.Applications.ToDoList.UseCases.Get;
using ToDoList.Applications.ToDoList.UseCases.GetById;
using ToDoList.Applications.ToDoList.UseCases.Update;
using ToDoList.Communications.Errors;
using ToDoList.Communications.Request;
using ToDoList.Communications.Response;

namespace ToDoList.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ToDoItensController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseCreatedItem), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(Errors), StatusCodes.Status400BadRequest)]
    public IActionResult Post([FromBody] RequestToDoListItem request)
    {
        try
        {
            if (request.Name == string.Empty || request.Description == string.Empty) throw new Exception("Name and Description is required");
            var useCase = new CreateItemUseCase();
            var response = useCase.Execute(request);
            return Created(string.Empty, response);
        }
        catch (Exception ex)
        {
            return BadRequest(new Errors { ListErrors = new List<string> { ex.Message } });
        }
    }
    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(Errors), StatusCodes.Status400BadRequest)]
    public IActionResult Update([FromRoute] Guid id, [FromBody] RequestToDoListItem request)
    {
        try
        {
            var useCase = new UpdateItemUseCase();
            useCase.Execute(id, request);
            return NoContent();
        }
        catch (Exception)
        {
            return BadRequest(new Errors { ListErrors = new List<string> { "Item not exists" } });
        }
    }
    [HttpGet]
    [ProducesResponseType(typeof(List<ResponseCreatedItem>), StatusCodes.Status200OK)]
    public IActionResult Get()
    {
        var useCase = new GetToDoListUseCase();
        var response = useCase.Execute();
        return Ok(response);
    }
    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseCreatedItem), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(Errors), StatusCodes.Status400BadRequest)]
    public IActionResult GetById([FromRoute] Guid id)
    {
        try
        {
            var useCase = new GetByIdToDoListUseCase();
            var response = useCase.Execute(id);
            return Ok(response);
        }
        catch (Exception)
        {
            return BadRequest(new Errors { ListErrors = new List<string> { "Item not exists" } });
        }
    }
    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseCreatedItem), StatusCodes.Status204NoContent)]
    public IActionResult Delete([FromRoute] Guid id)
    {
        try
        {
            var useCase = new DeleteByIdUseCase();
            var response = useCase.Execute(id);
            return Ok(response);
        }
        catch (Exception)
        {
            return BadRequest(new Errors { ListErrors = new List<string> { "Item not exists" } });
        }
    }
}
