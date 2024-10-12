using ToDoList.Communications.Request;
using ToDoList.Communications.Response;

namespace ToDoList.Applications.ToDoList.UseCases.Create;

public class CreateItemUseCase
{
    public RequestToDoListItem Execute(RequestToDoListItem NewItem)
    {
        var item = new RequestToDoListItem 
        {
            Id = Guid.NewGuid(),
            Name = NewItem.Name,
            Description = NewItem.Description,
            Priority = NewItem.Priority,
            Status = NewItem.Status
        };
        return item;
    }
}

