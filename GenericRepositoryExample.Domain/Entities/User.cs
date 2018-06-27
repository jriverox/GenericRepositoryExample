using GenericRepositoryExample.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GenericRepositoryExample.Domain.Entities
{
    public class User: EntityBase
    {
        [StringLength(255)]
        public string Email { get; set; }

        public Department Department { get; set; }

        [Required]
        public int DepartmentId { get; set; }

        public DateTime BirthDate { get; set; }

        public bool Active { get; set; }
    }
}
