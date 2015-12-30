using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryFactoryExample.Business.Attributes;
using RepositoryFactoryExample.Business.Enum;
using RepositoryFactoryExample.Business.Extensions;
using RepositoryFactoryExample.Business.Interface;

namespace RepositoryFactoryExample.Business.Factory
{
    public class RepositoryFactory
    {
        public IRepository GetRepository(FormTypes formType)
        {
            try
            {
                // Represents the IRepository that should be created, based on the form type passed
                var typeToCreate = formType.GetAttribute<EnumTypeAttribute>().Type;

                // return an instance of the form type repository
                return Activator.CreateInstance(typeToCreate) as IRepository;
            }
            catch
            {
                // No instance of IRepository could be found for the form type, provide a default repository
                return new UnknownRepository();
            }
        }
    }

    public class UnknownRepository : IRepository
    {
        public void SayYourName()
        {
            Console.WriteLine("A repository does not exist for this type.  Add the appropriate repository and enum to FormTypes.");
        }
    }
}
