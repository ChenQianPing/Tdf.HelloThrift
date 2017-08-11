using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloThrift.Interface;

namespace HelloThrift.Server
{
    public class MyHelloService : HelloService.Iface
    {
        public bool HelloBoolean(bool para)
        {
            Console.WriteLine("客户端调用了HelloBoolean方法");

            return para;
        }

        public int HelloInt(int para)
        {
            Console.WriteLine("客户端调用了HelloInt方法");

            return para;
        }

        public string HelloNull()
        {
            Console.WriteLine("客户端调用了HelloNull方法");

            return null;
        }

        /// <summary>
        /// 只有一个参数返回值为字符串类型的方法
        /// </summary>
        /// <param name="para">string类型参数</param>
        /// <returns>返回值为string类型</returns>
        public string HelloString(string para)
        {
            Console.WriteLine("客户端调用了HelloString方法");

            return para;
        }

        public void HelloVoid()
        {
            Console.WriteLine("客户端调用了HelloVoid方法");
        }
    }
}
