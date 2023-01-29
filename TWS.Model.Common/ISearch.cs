using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWS.Model.Common
{
    public interface ISearch
    {
        string Property { get; set; }
        string SearchPhrase { get; set; }
    }
}
