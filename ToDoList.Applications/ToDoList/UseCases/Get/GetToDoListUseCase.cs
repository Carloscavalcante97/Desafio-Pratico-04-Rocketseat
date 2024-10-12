
using ToDoList.Communications.Response;

namespace ToDoList.Applications.ToDoList.UseCases.Get;

public class GetToDoListUseCase
{
    public List<ResponseCreatedItem> Execute()
    {
        return new List<ResponseCreatedItem>
        {
            new ResponseCreatedItem
            {
                Name = "Item 1",
                Description = "Description 1",
                Priority = Communications.Enum.PriorityType.Media,
                Status = Communications.Enum.StatusType.EmAndamento
            },
            new ResponseCreatedItem
            {
                
                Name = "Item 2",
                Description = "Description 2",
                Priority = Communications.Enum.PriorityType.Baixa,
                Status = Communications.Enum.StatusType.EmAndamento
            }
        };
    }
}