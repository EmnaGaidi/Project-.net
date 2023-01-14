using project.Models;

namespace project.Data
{
    public interface ICommandRepository : IRepository<Command>
    {
        IEnumerable<Command> GetAllCommands();

    }
}
