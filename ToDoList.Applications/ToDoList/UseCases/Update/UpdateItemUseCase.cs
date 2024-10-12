
using ToDoList.Communications.Request;

namespace ToDoList.Applications.ToDoList.UseCases.Update;

public class UpdateItemUseCase
{
    public void Execute(Guid id, RequestToDoListItem updatedItem)
    {
        new RequestToDoListItem
        {
            Name = updatedItem.Name,
            Description = updatedItem.Description,
            Priority = updatedItem.Priority,
            Status = updatedItem.Status
        };
    }
}
