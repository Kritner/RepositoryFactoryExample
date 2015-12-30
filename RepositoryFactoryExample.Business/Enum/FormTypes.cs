using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryFactoryExample.Business.Attributes;
using RepositoryFactoryExample.Business.Repository;

namespace RepositoryFactoryExample.Business.Enum
{
    public enum FormTypes
    {
        [EnumTypeAttribute(typeof(Form64_9C2Repository))]
        Form64_9C2,

        [EnumTypeAttribute(typeof(Form64_9BaseRepository))]
        Form64_9Base
    }
}
