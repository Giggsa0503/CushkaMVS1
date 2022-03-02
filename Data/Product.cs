using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CushkaMVS1.Data
{
    
public class Product
{
        public int Id { get; set; }
        public string Name { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Prise { get; set; }
        public string Description { get; set; }
        public TypeFood Type { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

    }
}
