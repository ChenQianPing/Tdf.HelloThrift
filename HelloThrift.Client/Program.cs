using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloThrift.Interface;
using Thrift.Protocol;
using Thrift.Transport;

namespace HelloThrift.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            // new TestClient().TestMethod1();

            new TestClient().TestMethod2();

        }
    }
}
