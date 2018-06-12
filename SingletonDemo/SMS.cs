using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    class SMS : CommonPoint
    {
        string PhoneNumber;

       public SMS(string PhoneNumber)
        {
            this.PhoneNumber = PhoneNumber;
        }

        public string Send()
        {
            return PhoneNumber;

        }
    }
}
