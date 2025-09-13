using ShareSubsystem.Handlers.Handlers;

namespace Accounting.CustomerSubsystem.DTOs.Command
{
    public class AddContactPersonCommand : ICommand
    {
        public int Cid { get; set; }

        public string Name { get; set; } = null!;

        public string? Designation { get; set; }

        public string Ptype { get; set; } = null!;

        public string? Email { get; set; }

        public string? Phone { get; set; }
    }
}
