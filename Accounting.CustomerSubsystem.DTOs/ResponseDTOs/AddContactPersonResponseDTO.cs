using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.CustomerSubsystem.DTOs.ResponseDTOs
{
    public class AddContactPersonResponseDTO
    {
        public int Id { get; set; }
        public int Cid { get; set; }

        public string Name { get; set; } = null!;

        public string? Designation { get; set; }

        public string Ptype { get; set; } = null!;

        public string? Email { get; set; }

        public string? Phone { get; set; }
    }
}
