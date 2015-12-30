using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryFactoryExample.Business.Attributes
{
    public class EnumTypeAttribute : Attribute
    {
        private readonly Type _type;

        /// <summary>
        /// Get the type
        /// </summary>
        public Type Type
        {
            get
            {
                return this._type;
            }
        }

        /// <summary>
        /// Constructor, set the type
        /// </summary>
        /// <param name="type">The type to set.</param>
        public EnumTypeAttribute(Type type)
        {
            this._type = type;
        }
    }
}
