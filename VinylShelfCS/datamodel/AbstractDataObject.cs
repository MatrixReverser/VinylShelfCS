using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinylShelfCS.datamodel
{
    /*
     * Base class for all data objects of the application
     */
    internal abstract class AbstractDataObject
    {
        // Class variables
        private static int id_generator = 0;

        // Member variables
        private int _id;

        // Properties
        public int Id
        {
            get { return _id; }
            set
            {
                _id = value;
                if (id_generator <= _id)
                {
                    id_generator++;
                }
            }
        }

        protected AbstractDataObject()
        {
            Id = id_generator;
        }
    }
}
