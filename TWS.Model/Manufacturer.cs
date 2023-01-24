using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWS.Model.Common;

namespace TWS.Model
{
    public class Manufacturer : IManufacturer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Abrv { get; set; }
    }
}
