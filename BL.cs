using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_Ioc
{
    class BL
    {
        IProduct Iproduct_obj;
        public BL(IProduct _obj) // Injecting DL
        {
            Iproduct_obj = _obj;
        }
        public void Write()
        {
            Iproduct_obj.InsertData(); //Calling Method OF DL
        }

    }
}


