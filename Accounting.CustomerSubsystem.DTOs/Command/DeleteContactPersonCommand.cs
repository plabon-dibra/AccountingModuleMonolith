using ShareSubsystem.Handlers.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.CustomerSubsystem.DTOs.Command
{
    public class DeleteContactPersonCommand : ICommand
    {
        public int Cid { get; set; }

        public string Name { get; set; } = null!;

        public string? Designation { get; set; }

        public string Ptype { get; set; } = null!;

        public string? Email { get; set; }

        public string? Phone { get; set; }
    }
}
