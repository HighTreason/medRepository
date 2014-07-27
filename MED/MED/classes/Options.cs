using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MED.classes
{
    protected class Options
    {
        protected enum LocationUnit : int
        {
            [Description("None")]
            None = -1,
            [Description("Random")]
            Random = 0,
            [Description("Street")]
            Street = 1,
            [Description("City")]
            City = 2,
            [Description("Country")]
            Country = 3
        }
    }
}
