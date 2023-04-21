using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinylShelfCS.datamodel
{
    internal class GenreDO : AbstractDataObject
    {
        // Constants
        private const string DEFAULT_NAME = "<Genre>";

        // Properties
        public string Name { get; set; }

        public GenreDO()
        {
            Name = DEFAULT_NAME;
        }
    }
}
