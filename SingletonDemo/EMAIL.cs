using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    class EMAIL : CommonPoint
    {
        string email_address;

      public  EMAIL(string email_address)
        {
            this.email_address = email_address;
        }
        public string Send()
        {
            return email_address;
                       
        }

    }
}
