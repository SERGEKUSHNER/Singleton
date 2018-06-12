using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    class MessageFactory
    {

    public static CommonPoint Send(int id)
        {
            switch (id)
            {
                case 0:
                    return new EMAIL("seraph1023@gmail.com");
                case 1:
                    return new SMS("Hello Me, how are you :) ?");
                default:
                    return new EMAIL("default email");
            }
        }
    }



}

