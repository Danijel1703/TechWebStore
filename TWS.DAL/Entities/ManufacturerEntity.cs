using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWS.DAL.Entities
{
    public class ManufacturerEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Abrv { get; set; }

        public ICollection<ProductEntity> Products { get; set; }
    }
}
