using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryFactoryExample.Business.Extensions
{

    /// <summary>
    /// Extension methods for enums
    /// </summary>
    public static class EnumExtensions
    {

        /// <summary>
        /// Get the Enum attribute
        /// </summary>
        /// <typeparam name="T">The attribute</typeparam>
        /// <param name="enumValue">The enum</param>
        /// <returns>The type to create</returns>
        public static T GetAttribute<T>(this System.Enum enumValue)
            where T : Attribute
        {
            FieldInfo field = enumValue.GetType().GetField(enumValue.ToString());
            object[] attribs = field.GetCustomAttributes(typeof(T), false);
            T result = default(T);

            if (attribs.Length > 0)
            {
                result = attribs[0] as T;
            }

            return result;
        }

    }

}
