﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryFactoryExample.Business.Enum;
using RepositoryFactoryExample.Business.Factory;

namespace RepositoryFactoryExample.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Repository Factory Example \n\n");

            RepositoryFactory factory = new RepositoryFactory();

            var repo9c2 = factory.GetRepository(FormTypes.Form64_9C2);
            repo9c2.SayYourName();

            var repo9base = factory.GetRepository(FormTypes.Form64_9Base);
            repo9base.SayYourName();
        }
    }
}
