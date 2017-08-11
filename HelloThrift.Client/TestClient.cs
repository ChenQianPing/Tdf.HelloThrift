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
    public class TestClient
    {
        public void TestMethod1()
        {
            try
            {
                // 设置服务端端口号和地址
                TTransport transport = new TSocket("localhost", 7911);

                /* 
                 * 设置传输协议为二进制传输协议；
                 * 
                 * Thrift可以让用户选择客户端与服务端之间传输通信协议的类别，
                 * 在传输协议上总体划分为文本(text)和二进制(binary)传输协议，
                 * 为节约带宽，提高传输效率，
                 * 一般情况下使用二进制类型的传输协议为多数，
                 * 有时还会使用基于文本类型的协议，
                 * 这需要根据项目/产品中的实际需求。
                 * 
                 * 常用协议有以下几种：
                 * BinaryProtocol——二进制编码格式进行数据传输使，
                 * TCompactProtocol——高效率的、密集的二进制编码格式进行数据传输，
                 * TJSONProtocol——使用JSON 的数据编码协议进行数据传输。
                 * 
                 */
                TProtocol protocol = new TBinaryProtocol(transport);
                // 创建客户端对象
                HelloService.Client client = new HelloService.Client(protocol);
                transport.Open();
                Console.WriteLine("Client calls .....");

                if (transport.IsOpen)
                {
                    // I am seeing this message
                    Console.WriteLine("server is open for business");
                }

                // 调用服务端的方法
                Console.WriteLine(client.HelloString("HelloThrift"));
                Console.WriteLine(client.HelloInt(11));
                Console.WriteLine(client.HelloBoolean(false));

                transport.Close();

                Console.ReadKey();
            }
            catch (TTransportException e)
            {
                Console.WriteLine(e.Message);
            }
        }


        public void TestMethod2()
        {
            try
            {
                // 设置服务端端口号和地址
                TTransport transport = new TSocket("localhost", 7911);

                /* 
                 * 设置传输协议为二进制传输协议；
                 * 
                 * Thrift可以让用户选择客户端与服务端之间传输通信协议的类别，
                 * 在传输协议上总体划分为文本(text)和二进制(binary)传输协议，
                 * 为节约带宽，提高传输效率，
                 * 一般情况下使用二进制类型的传输协议为多数，
                 * 有时还会使用基于文本类型的协议，
                 * 这需要根据项目/产品中的实际需求。
                 * 
                 * 常用协议有以下几种：
                 * BinaryProtocol——二进制编码格式进行数据传输使，
                 * TCompactProtocol——高效率的、密集的二进制编码格式进行数据传输，
                 * TJSONProtocol——使用JSON 的数据编码协议进行数据传输。
                 * 
                 */
                TProtocol protocol = new TBinaryProtocol(transport);
                // 创建客户端对象
                UserService.Client client = new UserService.Client(protocol);
                transport.Open();
                Console.WriteLine("Client calls .....");

                if (transport.IsOpen)
                {
                    // I am seeing this message
                    Console.WriteLine("server is open for business");
                }

                // 调用服务端的方法
                var result1 = client.GetAllUser();

                foreach (var user in result1)
                {
                    Console.WriteLine($"{user.Id},{user.UserName},{user.UserPass}");
                }


                transport.Close();

                Console.ReadKey();
            }
            catch (TTransportException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
