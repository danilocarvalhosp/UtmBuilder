using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtmBuilder.Core.ValueObjects
{
    public class Url : ValueObject
    {
        public Url(string address)
        {
            Address = address;
        }

        public string Address { get; }
    }
}
