using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Tracking;
using Unity;
namespace demo_Ioc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implementing IOC using unity container");
            UnityContainer IU = new UnityContainer();
            IU.RegisterType<BL>();
            IU.RegisterType<DL>();
            IU.RegisterType<IProduct,DL>();

            BL objDL = IU.Resolve<BL>();
            objDL.Write();

            Console.ReadLine();

        }
    }
}
