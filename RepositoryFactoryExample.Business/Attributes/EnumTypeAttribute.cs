﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryFactoryExample.Business.Attributes
{

    /// <summary>
    /// Attribute is used to describe the concrete type that should be associated to an enum value
    /// </summary>
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
