using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtmBuilder.Core.ValueObjects
{
    public class Url : ValueObject
    {
        /// <summary>
        /// Create a new URL
        /// </summary>
        /// <param name="address">Address of URL (Website link)</param>

        public Url(string address)
        {
            Address = address;
        }

        /// <summary>
        /// Address of URL (Website link)
        /// </summary>

        public string Address { get; }
    }
}
