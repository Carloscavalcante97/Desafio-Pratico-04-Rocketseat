
using ToDoList.Communications.Response;

namespace ToDoList.Applications.ToDoList.UseCases.GetById;

public class GetByIdToDoListUseCase
{
    public ResponseCreatedItem Execute(Guid id)
    {
        return new ResponseCreatedItem
        {
            Name = "Correr",
            Description = "Correr 5km",
            Priority = Communications.Enum.PriorityType.Alta,
            Status = Communications.Enum.StatusType.EmAndamento
        };
    }
}
