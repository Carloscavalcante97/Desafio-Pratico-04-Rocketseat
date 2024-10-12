
using ToDoList.Communications.Enum;

namespace ToDoList.Communications.Response;

public class ResponseCreatedItem
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public PriorityType Priority { get; set; }
    public StatusType Status { get; set; }
}
