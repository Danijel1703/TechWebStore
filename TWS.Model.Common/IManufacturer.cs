using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWS.Model.Common
{
    public interface IManufacturer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Abrv { get; set; }
    }
}
