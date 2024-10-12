
using ToDoList.Communications.Request;
using ToDoList.Applications.ToDoList;

namespace ToDoList.Applications.ToDoList.UseCases.DeleteById;

public class DeleteByIdUseCase
{
    public string Execute(Guid id)
    {
        return "Item deletado";
    }
}
