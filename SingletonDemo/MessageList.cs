using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    class MessageList
    {
        static MessageList obj = null;
        private MessageList() { }
        public static object getInstance()
        {
            if (obj == null)
            {
                obj = new MessageList();
                return obj;
            }
            return obj;
        }
        static List<string> myList = new List<string>();

        public static void putMessage(string Message)
        {
            myList.Add(Message);
        }

        public static void getMessage()
        {
            int CountMessage = myList.Count - 1;
            if ((CountMessage) > 0)
            {
                int index = 0;
                foreach (var item in myList)
                {
                    ++index;
                    Console.WriteLine(index + ") Message: " + item);
                    Console.WriteLine("");
                }
            }
            else
            {
                Console.WriteLine("List is empty!");
            }
        }
    }
}
