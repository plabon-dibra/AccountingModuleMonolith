using ShareSubsystem.Handlers.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareSubsystem.Handlers.Handlers
{
    public interface ICommandHandler<TCommand>where TCommand : ICommand
    {
        Task<IEnumerable<Event>> HandleAsync(TCommand command);
    }
}
