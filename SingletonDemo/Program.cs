using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            

            for (int i = 0; i <= 2; i++)
            {
                var position = MessageFactory.Send(i);
                Console.WriteLine("Where id = {0}, position = {1} ", i, position.Send());
                Console.ReadLine();
            }

            Console.WriteLine("-----------------");

            var messageList = MessageList.getInstance();
            for (int i = 0; i <= 2; i++)
            {
                var position = MessageFactory.Send(i);
                MessageList.putMessage(position.Send());
                
            }
            MessageList.getMessage();
            Console.ReadKey();
        }
    }
}
