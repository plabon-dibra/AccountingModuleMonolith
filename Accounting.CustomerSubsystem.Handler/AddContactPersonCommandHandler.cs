using Accounting.CustomerSubsystem.Aggregators;
using Accounting.CustomerSubsystem.DTOs.Command;
using Accounting.CustomerSubsystem.Handler.Abstractions;
using Accounting.CustomerSubsystem.Repositories;
using Accounting.CustomerSubsystem.Repositories.Abstractions;
using ShareSubsystem.Handlers.Enums;
using ShareSubsystem.Handlers.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.CustomerSubsystem.Handler
{
    public class AddContactPersonCommandHandler : IAddContactPersonCommandHandler
    {
        private readonly IAddContactPersonCommandRepository _repository;
        public AddContactPersonCommandHandler(IAddContactPersonCommandRepository repository) {
            _repository = repository;
        }
        public async Task<IEnumerable<Event>> HandleAsync(AddContactPersonCommand command)
        {
            ContactPersonAggregateRoot contactPersonAggregateRoot  = new ContactPersonAggregateRoot();
            contactPersonAggregateRoot.MapAddContactPersonCommand(command);
            var response = await _repository.AddContactPersonAsync(contactPersonAggregateRoot);
            if (response != null)
            {
                //return Success Event
                return new List<Event>
                {   new Event
                    {
                        EventId = EventId.ResourceCreated,
                        EventType = EventType.Success,
                        EventData = new List<KeyValuePair<string, object>>
                        {
                            new KeyValuePair<string, object>("message","Contact Person Added Successfully" )
                            // ,new KeyValuePair<string, object>("data",response.GetContactPersonResponseDTO())
                        }
                    }
                };
            }
            else
            {
                //return Failure Event
                return new List<Event>
                {   new Event
                    {
                        EventId = EventId.DatabaseOperationFailed,
                        EventType = EventType.Fail,
                        EventData = new List<KeyValuePair<string, object>>
                        {
                            new KeyValuePair<string, object>("message","Failed to Add Contact Person" )
                        }
                    }
                };
            }
           
        }
    }
}
