using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contactista.DataAccess.DTO
{
    public class ContactDto
    {
        public int ContactId { get; set; }

        [Required]
        
        public string FullName { get; set; } = default!;

        [Required]
        
        public string Address { get; set; } = default!;

        [Required]
        [Phone]
        public string PhoneNumber { get; set; } = default!;
        public string Notes { get; set; } = default!;
    }
}
