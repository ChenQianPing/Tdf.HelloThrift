using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloThrift.Interface;
using Thrift;
using Thrift.Protocol;
using Thrift.Server;
using Thrift.Transport;

namespace HelloThrift.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            // new Server().Start1();
            new Server().Start2();
        }
    }
}
