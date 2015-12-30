using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryFactoryExample.Business.Attributes;
using RepositoryFactoryExample.Business.Repository;

namespace RepositoryFactoryExample.Business.Enum
{

    /// <summary>
    /// The different form types that have repositories for them, as well as their repository mapping
    /// </summary>
    public enum FormTypes
    {

        /// <summary>
        /// Form 64 9C2
        /// </summary>
        [EnumTypeAttribute(typeof(Form64_9C2Repository))]
        Form64_9C2,

        /// <summary>
        /// Form 64 9Base
        /// </summary>
        [EnumTypeAttribute(typeof(Form64_9BaseRepository))]
        Form64_9Base
    }
}
