using Accounting.CustomerSubsystem.DTOs.Command;
using Accounting.CustomerSubsystem.DTOs.ResponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Accounting.CustomerSubsystem.Aggregators
{
    public class ContactPersonAggregateRoot
    {
        public int Id { get; set; }

        public int Cid { get; set; }

        public string Name { get; set; } = null!;

        public string? Designation { get; set; }

        public string Ptype { get; set; } = null!;

        public string? Email { get; set; }

        public string? Phone { get; set; }

        public void MapAddContactPersonCommand(AddContactPersonCommand data)
        {
            Cid = data.Cid;
            Name = data.Name;
            Designation = data.Designation;
            Ptype = data.Ptype;
            Email = data.Email;
            Phone = data.Phone;
        }
        public AddContactPersonResponseDTO GetContactPersonResponseDTO()
        {
            return new AddContactPersonResponseDTO
            {
                Id = Id,
                Cid = Cid,
                Name = Name,
                Designation = Designation,
                Ptype = Ptype,
                Email = Email,
                Phone = Phone
            };
        }
    }
}
