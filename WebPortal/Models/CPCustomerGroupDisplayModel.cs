using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLibrary.Models;

namespace WebPortal.Models
{
    public class CPCustomerGroupDisplayModel : ICPCustomerGroupModel
    {
        [Required]
        [MaxLength(15)]
        public string GroupId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
