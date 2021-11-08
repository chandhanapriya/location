using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace demo_Ioc
{
    class DL:IProduct
    {
        string IProduct.InsertData()
        {
            String val = "dependecy variable injected";
            Console.WriteLine(val);
            return val;
            throw new NotImplementedException();
        }

    }
}
