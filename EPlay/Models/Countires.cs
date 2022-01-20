using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EPlay.Models
{
    public class Countires
    {
        public IEnumerable<string> countries
        {
            get
            {
                yield return "Slovenia";
                yield return "USA";
                yield return "UK";
                yield return "Germany";
                yield return "Italy";
                yield return "Netherland";
                yield return "Poland";
            }

        }
    }
}
