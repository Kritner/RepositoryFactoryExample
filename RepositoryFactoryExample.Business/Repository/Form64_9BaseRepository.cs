using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryFactoryExample.Business.Interface;

namespace RepositoryFactoryExample.Business.Repository
{

    /// <summary>
    /// Form 64 9 base repository
    /// </summary>
    public class Form64_9BaseRepository : IRepository
    {

        /// <summary>
        /// Say your name
        /// </summary>
        public void SayYourName()
        {
            Console.WriteLine("I'm a {0}", this.GetType().Name);
        }
    }
}
