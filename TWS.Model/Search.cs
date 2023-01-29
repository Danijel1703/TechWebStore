using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWS.Model.Common;

namespace TWS.Model
{
    public class Search : ISearch
    {
        public string Property { get; set; }
        public string SearchPhrase { get; set; }
    }
}
