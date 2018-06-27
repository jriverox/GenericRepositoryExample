using GenericRepositoryExample.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GenericRepositoryExample.Domain.Entities
{
    public class Department: EntityBase
    {
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

    }
}
