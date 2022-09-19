using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Test_DotNETCore
{
    internal class RootObject
    {
        public string timezone { get; set; }
        public long serverTime { get; set; }
        public Ratelimit[] rateLimits { get; set; }
        public object[] exchangeFilters { get; set; }
        public Symbol[] symbols { get; set; }
    }
}
