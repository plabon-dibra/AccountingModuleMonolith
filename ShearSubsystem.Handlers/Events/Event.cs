using ShareSubsystem.Handlers.Enums;
using ShareSubsystem.Handlers.Handlers;

namespace ShareSubsystem.Handlers.Events
{
    public class Event : IEvent
    {
        public EventType EventType { get; set; }
        public List<KeyValuePair<string, object>>? EventData { get; set; }
        public EventId EventId { get; set; }
    }
}
