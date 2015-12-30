using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryFactoryExample.Business.Interface;

namespace RepositoryFactoryExample.Business.Repository
{
    public class Form64_9C2Repository : IRepository
    {
        public void SayYourName()
        {
            Console.WriteLine("I'm a {0}", this.GetType().Name);
        }
    }
}
